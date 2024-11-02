using AutoTrade.Services.Database;
using Database;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;
using Request;
using SearchObject;

namespace AutoTrade.Services
{
    public class ReservationService : BaseCRUDService<Model.Reservation, BaseSerachObject, Reservation, ReservationUpsertRequest, ReservationUpsertRequest>, IReservationService
    {
        public ReservationService(AutoTradeContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IQueryable<Reservation> AddInclude(IQueryable<Reservation> query, BaseSerachObject? search = null)
        {
            return query.Include(x => x.User).ThenInclude(u => u.AutomobileAds);
        }
    }
}