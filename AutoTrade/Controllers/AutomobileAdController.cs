using AutoTrade.Model;
using AutoTrade.Services;
using AutoTrade.Services.Database;
using Database;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Request;
using SearchObject;

namespace Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AutomobileAdController : BaseCRUDController<AutoTrade.Model.AutomobileAd, AutomobileAdSearchObject, AutomobileAdInsertRequst, AutomobileUpdateRequest>
    {
        private readonly IAutomobileAdService _automobileAdService;

        private AutoTradeContext _context;

        public AutomobileAdController(IAutomobileAdService service, AutoTradeContext context) : base(service)
        {
            _automobileAdService = service;
            _context = context;
        }

        [HttpPut("mark-as-done/{id}")]
        [Authorize]
        public IActionResult MarkAsDone(int id)
        {
            try
            {
                var updatedAd = _automobileAdService.MarkAsDone(id);
                return Ok(updatedAd);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }


        [HttpPut("mar-as-active/{id}")]
        [Authorize]
        public IActionResult MarkAsActive(int id)
        {
            try
            {
                var updatedAd = _automobileAdService.MarkAsActive(id);
                return Ok(updatedAd);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }



        [HttpPost("api/highlight-ad")]
        [Authorize]
        public async Task<IActionResult> HighlightOglas(int id, [FromBody] HighlightAdRequest request)
        {
            var entity = await _context.AutomobileAds.FindAsync(id);
            if (entity == null) return NotFound();



            if (entity.HighlightExpiryDate.HasValue && entity.HighlightExpiryDate.Value > DateTime.Now)
            {
                entity.HighlightExpiryDate = entity.HighlightExpiryDate.Value.AddDays(request.HighlightDays);
            }
            else
            {
                entity.HighlightExpiryDate = DateTime.Now.AddDays(request.HighlightDays);
            }
            entity.IsHighlighted = true;

            var transaction = new PaymentTransaction
            {
                PaymentId = request.PaymentId,
                Amount = request.Amount.Value,
                Currency = request.Currency,
                Status = request.Status,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                AutomobileAdId = id
            };
            _context.PaymentTransactions.Add(transaction);
            await _context.SaveChangesAsync();


            return Ok(new
            {
                success = true,

                transactionId = transaction.Id
            });
        }

        [HttpGet("user-ads/{userId}")]
        public async Task<IActionResult> GetAdsByUser(
      int userId,
      [FromQuery] MyAutomobilesRequest request,
      int page = 0,
      int pageSize = 25
   )
        {
            try
            {

                if (page < 0) page = 0;
                if (pageSize <= 0 || pageSize > 100) pageSize = 25;


                var query = _context.AutomobileAds
                    .Where(ad => ad.UserId == userId).Include(x => x.Images)
                    .AsQueryable();


                if (!string.IsNullOrWhiteSpace(request.status))
                {
                    if (request.status == "Active")
                    {
                        query = query.Where(ad => ad.Status == "Active" || (ad.IsHighlighted ?? false));
                    }

                    else
                    {
                        query = query.Where(ad => ad.Status.Contains(request.status));
                    }
                }



                if (request.IsHighlighted.HasValue)
                {
                    query = query.Where(ad => ad.IsHighlighted == request.IsHighlighted.Value && ad.Status != "Done");
                }



                var totalCount = await query.CountAsync();


                var paginatedAds = await query
                    .Skip((page) * pageSize)
                    .Take(pageSize)
                    .ToListAsync();

            
                if (!paginatedAds.Any())
                {
                    return Ok(new
                    {
                        count = totalCount,
                        data = Array.Empty<object>()
                    });
                }

 
                return Ok(new
                {
                    count = totalCount,
                    data = paginatedAds
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }



        [AllowAnonymous]
        [HttpGet("{id}/recommend")]
        public List<AutoTrade.Model.AutomobileAd> Recommend(int id)
        {
            return (_service as IAutomobileAdService).Recommend(id);
        }



        [HttpPatch("{id}")]
        [Authorize]
        public IActionResult Patch(int id, [FromForm] AutomobileUpdateRequest request)
        {
           
            var automobile = _service.GetById(id);
            if (automobile == null)
            {
                return NotFound("Automobile not found.");
            }

        
            if (!string.IsNullOrWhiteSpace(request.Title))
                automobile.Title = request.Title;

            if (!string.IsNullOrWhiteSpace(request.Description))
                automobile.Description = request.Description;

            if (request.Price.HasValue)
                automobile.Price = (double)request.Price;

            if (request.Milage > 0)
                automobile.Milage = (double)request.Milage;

            if (request.YearOfManufacture.HasValue)
                automobile.YearOfManufacture = (int)request.YearOfManufacture;

            if (request.Registered != null)
                automobile.Registered = (bool)request.Registered;

            if (request.RegistrationExpirationDate.HasValue)
                automobile.RegistrationExpirationDate = request.RegistrationExpirationDate.Value;

            if (request.Last_Small_Service.HasValue)
                automobile.Last_Small_Service = request.Last_Small_Service.Value;

            if (request.Last_Big_Service.HasValue)
                automobile.Last_Big_Service = request.Last_Big_Service.Value;


            if (request.CarBrandId.HasValue)
                automobile.CarBrandId = request.CarBrandId.Value;

            if (request.CarCategoryId.HasValue)
                automobile.CarCategoryId = request.CarCategoryId.Value;

            if (request.CarModelId.HasValue)
                automobile.CarModelId = request.CarModelId.Value;

            if (request.FuelTypeId.HasValue)
                automobile.FuelTypeId = request.FuelTypeId.Value;

            if (request.TransmissionTypeId.HasValue)
                automobile.TransmissionTypeId = request.TransmissionTypeId.Value;

            if (request.EnginePower.HasValue)
                automobile.EnginePower = request.EnginePower.Value;

            if (request.NumberOfDoors.HasValue)
                automobile.NumberOfDoors = request.NumberOfDoors.Value;

            if (request.CubicCapacity.HasValue)
                automobile.CubicCapacity = request.CubicCapacity.Value;

            if (request.HorsePower.HasValue)
                automobile.HorsePower = request.HorsePower.Value;

            if (!string.IsNullOrWhiteSpace(request.Color))
                automobile.Color = request.Color;

            if (request.VehicleConditionId.HasValue)
                automobile.VehicleCondtionId = request.VehicleConditionId.Value;





            if (request.Images != null && request.Images.Any())
            {
                foreach (var image in request.Images)
                {
                   
                    var imagePath = FileUploadHelper.UploadProfilePicture(image);

                   
                    if (!automobile.Images.Any(img => img.ImageUrl == imagePath))
                    {
                        var automobileAdImage = new AutoTrade.Model.AutomobileAdImage
                        {
                            ImageUrl = imagePath,
                            AutomobileAdId = automobile.Id
                        };

                        automobile.Images.Add(automobileAdImage);
                    }
                }
            }

            _automobileAdService.Update(id, automobile);

            return Ok(automobile);
        }

    }
}
