using AutoTrade.Services.Database;
using Database;
using EasyNetQ;
using Helpers;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.ML;
using Microsoft.ML.Data;
using Request;
using SearchObject;
using System.Linq.Dynamic.Core;
using Microsoft.ML.Trainers;
using Microsoft.Extensions.Options;

namespace AutoTrade.Services
{
    public class AutomobileAdService : BaseCRUDService<Model.AutomobileAd, AutomobileAdSearchObject, AutomobileAd, AutomobileAdInsertRequst, AutomobileUpdateRequest>, IAutomobileAdService
    {
        private readonly AutoTradeContext _context;

        public AutomobileAdService(AutoTradeContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
        }


        public override IQueryable<AutomobileAd> AddInclude(IQueryable<AutomobileAd> query, AutomobileAdSearchObject? search = null, bool includeDetails = false, bool includeDoneAds = false)
        {

            if (!includeDoneAds)
            {
                query = query.Where(ad => ad.Status != "Done");
            }
            if (!string.IsNullOrEmpty(search?.Status))
            {
                query = query.Where(ad => ad.Status == search.Status);
            }

            query = query
         .Include(ad => ad.User).ThenInclude(x => x.City).ThenInclude(x => x.Canton)
         .Include(ad => ad.CarBrand)
         .Include(ad => ad.CarCategory)
         .Include(ad => ad.CarModel)
         .Include(x => x.Images)
         .Include(x => x.FuelType)
         .Include(x => x.VehicleCondition)
         .Include(x => x.TransmissionType)
         .Include(x => x.AutomobileAdEquipments)
         .ThenInclude(x => x.Equipment);

            if (includeDetails)
            {
                query = query
             .Include(ad => ad.Comments)
             .Include(ad => ad.Reservations);
            }

            return query;
        }

        public override void BeforeInsert(AutomobileAdInsertRequst request, AutomobileAd entity)
        {
            entity.DateOFadd = DateTime.Now;
            entity.Status = "Pending";
            //
            entity.Images = null;

            try
            {
                var bus = RabbitHutch.CreateBus("host=localhost");
                bus.PubSub.Publish(entity);
            }
            catch (Exception ex)
            {
                Console.WriteLine("RabbitMQ is not available. Error: " + ex.Message);
            }

            base.BeforeInsert(request, entity);
        }


        public override void AfterInsert(AutomobileAdInsertRequst request, AutomobileAd entity)
        {
            if (request.Images != null && request.Images.Count > 0)
            {
                foreach (var file in request.Images)
                {
                    if (file.Length > 0)
                    {
                        var imageUrl = FileUploadHelper.UploadProfilePicture(file);

                        if (string.IsNullOrEmpty(imageUrl))
                        {
                            imageUrl = "default_image_url";
                        }

                        var imageEntity = new AutomobileAdImage
                        {
                            AutomobileAdId = entity.Id,
                            ImageUrl = imageUrl
                        };

                        Context.AutomobileAdImages.Add(imageEntity);
                    }
                }


                Context.SaveChanges();
            }


            base.AfterInsert(request, entity);
        }


        public override IQueryable<AutomobileAd> AddFilter(AutomobileAdSearchObject search, IQueryable<AutomobileAd> query)
        {

            // using (var context = new AutoTradeContext())
            // {
            //     context.Database.ExecuteSqlRaw("EXEC UpdateExpiredHighlights");
            // }

            query = query.OrderByDescending(ad => ad.HighlightExpiryDate.HasValue && ad.HighlightExpiryDate > DateTime.Now);

            if (!string.IsNullOrWhiteSpace(search?.Title))
            {
                query = query.Where(ad =>
                    ad.Title.Contains(search.Title) ||
                    ad.User.FirstName.Contains(search.Title) ||
                    ad.User.LastName.Contains(search.Title) ||
                    ad.User.UserName.Contains(search.Title));
            }

            if (search.MinPrice.HasValue && search.MaxPrice.HasValue)
            {
                query = query.Where(ad => ad.Price >= search.MinPrice.Value && ad.Price <= search.MaxPrice.Value);
            }
            else if (search.MinPrice.HasValue)
            {
                query = query.Where(ad => ad.Price >= search.MinPrice.Value);
            }
            else if (search.MaxPrice.HasValue)
            {
                query = query.Where(ad => ad.Price <= search.MaxPrice.Value);
            }


            if (search.MinMilage.HasValue)
            {
                query = query.Where(ad => ad.Milage >= search.MinMilage.Value);
            }

            if (search.MaxMilage.HasValue)
            {
                query = query.Where(ad => ad.Milage <= search.MaxMilage.Value);
            }


            if (search.YearOfManufacture.HasValue)
            {
                query = query.Where(ad => ad.YearOfManufacture == search.YearOfManufacture.Value);
            }


            if (search.Registered.HasValue)
            {
                query = query.Where(ad => ad.Registered == search.Registered.Value);
            }


            if (search.CarBrandId.HasValue)
            {
                query = query.Where(ad => ad.CarBrandId == search.CarBrandId.Value);
            }


            if (search.CarCategoryId.HasValue)
            {
                query = query.Where(ad => ad.CarCategoryId == search.CarCategoryId.Value);
            }


            if (search.CarModelId.HasValue)
            {
                query = query.Where(ad => ad.CarModelId == search.CarModelId.Value);
            }


            if (search.FuelTypeId.HasValue)
            {
                query = query.Where(ad => ad.FuelTypeId == search.FuelTypeId.Value);
            }


            if (search.TransmissionTypeId.HasValue)
            {
                query = query.Where(ad => ad.TransmissionTypeId == search.TransmissionTypeId.Value);
            }

            if (search.CityId.HasValue)
            {
                query = query.Where(ad => ad.User.CityId == search.CityId.Value);
            }


            if (!string.IsNullOrWhiteSpace(search.OrderBy))
            {
                query = query.OrderBy(search.OrderBy);
            }


            // Sorting logic
            if (!string.IsNullOrWhiteSpace(search.OrderBy))
            {
                bool isAscending = search.OrderDirection?.ToLower() == "asc";

                query = search.OrderBy.ToLower() switch
                {
                    "title" => isAscending ? query.OrderBy(ad => ad.Title) : query.OrderByDescending(ad => ad.Title),
                    "price" => isAscending ? query.OrderBy(ad => ad.Price) : query.OrderByDescending(ad => ad.Price),
                    _ => query
                };
            }

            return base.AddFilter(search, query);
        }


        public Model.AutomobileAd MarkAsDone(int id)
        {
            var ad = _context.AutomobileAds.Find(id);
            if (ad == null)
            {
                throw new Exception("Automobile ad not found");
            }

            ad.Status = "Done";
            _context.SaveChanges();

            return Mapper.Map<Model.AutomobileAd>(ad);
        }

        public Model.AutomobileAd MarkAsActive(int id)
        {
            var ad = _context.AutomobileAds.Find(id);
            if (ad == null)
            {
                throw new Exception("Automobile ad not found");
            }

            ad.Status = "Active";
            _context.SaveChanges();

            return Mapper.Map<Model.AutomobileAd>(ad);
        }

        public override void MapEquipment(AutomobileAdInsertRequst request, AutomobileAd entity)
        {
            if (request.EquipmentIds.Any())
            {
                foreach (var equipmentId in request.EquipmentIds)
                {
                    var automobileAdEquipment = new AutomobileAdEquipment
                    {
                        AutomobileAdId = entity.Id,
                        EquipmentId = equipmentId
                    };
                    Context.Add(automobileAdEquipment);
                }
                Context.SaveChanges();
            }
            base.MapEquipment(request, entity);
        }

        public override void MapUpdatedEquipment(AutomobileUpdateRequest request, AutomobileAd entity)
        {

            var existingEquipment = Context.Set<AutomobileAdEquipment>()
                                  .Where(e => e.AutomobileAdId == entity.Id)
                                  .ToList();

            foreach (var equipment in existingEquipment)
            {
                Context.Remove(equipment);
            }


            if (request.EquipmentIds.Any())
            {
                foreach (var equipmentId in request.EquipmentIds)
                {
                    var automobileAdEquipment = new AutomobileAdEquipment
                    {
                        AutomobileAdId = entity.Id,
                        EquipmentId = equipmentId
                    };
                    Context.Add(automobileAdEquipment);
                }
            }
            Context.SaveChanges();

            base.MapUpdatedEquipment(request, entity);
        }


        static MLContext mlContext = new MLContext();
        static object isLocked = new object();

        static ITransformer model = null;

        public List<Model.AutomobileAd> Recommend(int userId)
        {
            const string modelPath = "recommendation_model.zip";

            lock (isLocked)
            {
                if (model == null)
                {
                    if (File.Exists(modelPath))
                    {

                        using var fileStream = File.OpenRead(modelPath);
                        model = mlContext.Model.Load(fileStream, out _);
                    }
                    else
                    {

                        var favoriteData = Context.Favorites.ToList();
                        var reservationData = Context.Reservations.ToList();
                        var automobilesData = Context.AutomobileAds.Include(x => x.FuelType).Where(x => x.Status != "Done" && x.Status != "Pending").ToList();

                        var data = new List<ProductEntry>();

                        foreach (var favorite in favoriteData)
                        {
                            data.Add(new ProductEntry
                            {
                                UserId = (uint)favorite.UserId,
                                AutomobileAdId = (uint)favorite.AutomobileAdId,
                                Label = 1
                            });
                        }

                        foreach (var reservation in reservationData)
                        {
                            data.Add(new ProductEntry
                            {
                                UserId = (uint)reservation.UserId,
                                AutomobileAdId = (uint)reservation.AutomobileAdId,
                                Label = 2

                            });
                        }


                        foreach (var automobile in automobilesData)
                        {
                            data.Add(new ProductEntry
                            {
                                UserId = (uint)userId,
                                AutomobileAdId = (uint)automobile.Id,
                                Label = 0,
                                Price = (float)automobile.Price,
                                YearOfManufacture = automobile.YearOfManufacture,
                                Milage = (float)automobile.Milage,
                                FuelType = automobile.FuelType?.Name ?? "Unknown",
                                ViewsCount = automobile.ViewsCount,
                                IsHighlighted = automobile.IsHighlighted ?? false
                            });
                        }

                        if (!data.Any())
                        {
                            throw new Exception("No data for favorites or reservations to train the model.");
                        }

                        var trainData = mlContext.Data.LoadFromEnumerable(data);

                        var options = new MatrixFactorizationTrainer.Options
                        {
                            MatrixColumnIndexColumnName = nameof(ProductEntry.UserId),
                            MatrixRowIndexColumnName = nameof(ProductEntry.AutomobileAdId),
                            LabelColumnName = nameof(ProductEntry.Label),
                            NumberOfIterations = 100,
                            Alpha = 0.01,
                            Lambda = 0.025
                        };

                        var est = mlContext.Recommendation().Trainers.MatrixFactorization(options);

                        model = est.Fit(trainData);

                        using var fileStream = File.Create(modelPath);
                        mlContext.Model.Save(model, trainData.Schema, fileStream);
                    }
                }
            }

            var userFavorites = Context.Favorites
                .Where(f => f.UserId == userId)
                .Select(f => f.AutomobileAdId)
                .ToList();

            var userReservations = Context.Reservations
                .Where(r => r.UserId == userId)
                .Select(r => r.AutomobileAdId)
                .ToList();

            var excludedIds = userFavorites.Concat(userReservations).Distinct();

            var automobiles = Context.AutomobileAds
                .Where(ad => !excludedIds.Contains(ad.Id))
                  .AsNoTracking()
                .Include(x => x.Images)
                .ToList();

            var predictionResult = new List<(AutomobileAd, float)>();

            foreach (var automobile in automobiles)
            {
                var predictionEngine = mlContext.Model.CreatePredictionEngine<ProductEntry, Copurchase_prediction>(model);
                var prediction = predictionEngine.Predict(
                    new ProductEntry
                    {
                        UserId = (uint)userId,
                        AutomobileAdId = (uint)automobile.Id,
                        Price = (float)automobile.Price,
                        YearOfManufacture = automobile.YearOfManufacture,
                        Milage = (float)automobile.Milage,
                        FuelType = automobile.FuelType?.Name ?? "Unknown",
                        ViewsCount = automobile.ViewsCount,
                        IsHighlighted = automobile.IsHighlighted ?? false
                    });

                predictionResult.Add((automobile, prediction.Score));
            }

            var finalResult = predictionResult
              .OrderByDescending(x => x.Item2)
              .Select(x => x.Item1)
              .Take(8)
              .ToList();

            return Mapper.Map<List<Model.AutomobileAd>>(finalResult);

        }

        public class Copurchase_prediction
        {
            public float Score { get; set; }
        }

        public class ProductEntry
        {
            [KeyType(count: 262111)]
            public uint UserId { get; set; }
            [KeyType(count: 262111)]
            public uint AutomobileAdId { get; set; }
            public float Label { get; set; }
            public float Price { get; set; }
            public int YearOfManufacture { get; set; }
            public float Milage { get; set; }
            public string FuelType { get; set; }
            public int ViewsCount { get; set; }
            public bool IsHighlighted { get; set; }
        }



        public Model.AutomobileAd Update(int id, Model.AutomobileAd automobile)
        {
            var entity = Context.AutomobileAds.FirstOrDefault(a => a.Id == id);
            if (entity == null)
            {
                throw new KeyNotFoundException("Automobile not found.");
            }
            entity.Title = automobile.Title;
            entity.Description = automobile.Description;
            entity.Price = automobile.Price;
            entity.Milage = automobile.Milage;
            entity.YearOfManufacture = automobile.YearOfManufacture;
            entity.Registered = automobile.Registered;
            entity.RegistrationExpirationDate = automobile.RegistrationExpirationDate;
            entity.Last_Small_Service = automobile.Last_Small_Service;
            entity.Last_Big_Service = automobile.Last_Big_Service;
            entity.CarBrandId = automobile.CarBrandId.GetValueOrDefault();
            entity.CarCategoryId = automobile.CarCategoryId.GetValueOrDefault();
            entity.CarModelId = automobile.CarModelId.GetValueOrDefault();
            entity.FuelTypeId = automobile.FuelTypeId.GetValueOrDefault();
            entity.TransmissionTypeId = automobile.TransmissionTypeId.GetValueOrDefault();
            entity.EnginePower = automobile.EnginePower.GetValueOrDefault();
            entity.NumberOfDoors = automobile.NumberOfDoors.GetValueOrDefault();
            entity.CubicCapacity = automobile.CubicCapacity.GetValueOrDefault();
            entity.HorsePower = automobile.HorsePower.GetValueOrDefault();
            entity.Color = automobile.Color ?? "-";
            entity.VehicleConditionId = automobile.VehicleCondtionId.GetValueOrDefault();


            if (automobile.Images != null && automobile.Images.Any())
            {
                // Očistite slike koje nisu prisutne u trenutnoj kolekciji
                entity.Images.Clear();

                foreach (var image in automobile.Images)
                {
                    // Proverite da li slika već postoji pre dodavanja
                    if (!entity.Images.Any(img => img.ImageUrl == image.ImageUrl))
                    {
                        var databaseImage = new AutomobileAdImage
                        {
                            ImageUrl = image.ImageUrl,
                            AutomobileAdId = entity.Id
                        };

                        entity.Images.Add(databaseImage);
                    }
                }
            }


            Context.AutomobileAds.Update(entity);
            Context.SaveChanges();

            return Mapper.Map<Model.AutomobileAd>(entity);
        }


    }
}