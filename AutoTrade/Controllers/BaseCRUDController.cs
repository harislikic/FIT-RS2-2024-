using AutoTrade.Services;
using AutoTrader.Controllers;
using Database;
using Microsoft.AspNetCore.Mvc;
using SearchObject;

namespace Controllers
{
    public class BaseCRUDController<TModel, TSearch, TInsert, TUpdate> : BaseController<TModel, TSearch> where TSearch : BaseSerachObject where TModel : class
    {
        public BaseCRUDController(ICRUDService<TModel, TSearch, TInsert, TUpdate> service) : base(service)
        {

        }

        [HttpPost]
        public virtual TModel Insert(TInsert request)
        {
            if (_service == null)
            {
                throw new NullReferenceException("User service is not initialized.");
            }

            return (_service as ICRUDService<TModel, TSearch, TInsert, TUpdate>).Insert(request);
        }

        [HttpPut("{id}")]
        public TModel Update(int id, TUpdate request)
        {
            return (_service as ICRUDService<TModel, TSearch, TInsert, TUpdate>).Update(id, request);
        }
    }
}