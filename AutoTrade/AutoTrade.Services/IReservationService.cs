using Database;
using Request;
using SearchObject;

namespace AutoTrade.Services
{
    public interface IReservationService : ICRUDService<Model.Reservation,BaseSerachObject,ReservationUpsertRequest,ReservationUpsertRequest> 
    {
    }
}