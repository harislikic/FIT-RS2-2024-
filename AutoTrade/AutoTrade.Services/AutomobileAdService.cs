using AutoTrade.Services.Database;
using Database;
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


        public override IQueryable<AutomobileAd> AddInclude(IQueryable<AutomobileAd> query, AutomobileAdSearchObject? search = null)
        {
            return query
     .Include(ad => ad.User)
     .Include(ad => ad.CarBrand)
     .Include(ad => ad.CarCategory)
     .Include(ad => ad.CarModel)
     .Include(ad => ad.Comments);
        }

        public override void BeforeInsert(AutomobileAdInsertRequst request, AutomobileAd entity)
        {
            entity.DateOFadd = DateTime.Now;

            base.BeforeInsert(request, entity);
        }


        public override IQueryable<AutomobileAd> AddFilter(AutomobileAdSearchObject search, IQueryable<AutomobileAd> query)
        {

            if (!string.IsNullOrWhiteSpace(search?.Title))
            {
                query = query.Where(ad => ad.Title.Contains(search.Title));
            }


            if (search.MinPrice.HasValue)
            {
                query = query.Where(ad => ad.Price >= search.MinPrice.Value);
            }

            if (search.MaxPrice.HasValue)
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

            return base.AddFilter(search, query);
        }

    }
}