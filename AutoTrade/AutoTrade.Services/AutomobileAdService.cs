using AutoTrade.Services.Database;
using Database;
using EasyNetQ;
using Helpers;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;
using Request;
using SearchObject;
using System.Linq.Dynamic.Core;

namespace AutoTrade.Services
{
    public class AutomobileAdService : BaseCRUDService<Model.AutomobileAd, AutomobileAdSearchObject, AutomobileAd, AutomobileAdInsertRequst, AutomobileUpdateRequest>, IAutomobileAdService
    {
        private readonly AutoTradeContext _context;

        public AutomobileAdService(AutoTradeContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
        }


        public override IQueryable<AutomobileAd> AddInclude(IQueryable<AutomobileAd> query, AutomobileAdSearchObject? search = null, bool includeDetails = false)
        {
            query = query
         .Include(ad => ad.User)
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
            entity.Status = "Active";
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

            using (var context = new AutoTradeContext())
            {
                context.Database.ExecuteSqlRaw("EXEC UpdateExpiredHighlights");
            }

            query = query.OrderByDescending(ad => ad.HighlightExpiryDate.HasValue && ad.HighlightExpiryDate > DateTime.Now);

            if (!string.IsNullOrWhiteSpace(search?.Title))
            {
                query = query.Where(ad => ad.Title.Contains(search.Title));
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

    }
}