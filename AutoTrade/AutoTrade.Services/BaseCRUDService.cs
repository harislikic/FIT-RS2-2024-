using AutoTrade.Services.Database;
using Database;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;
using Request;
using SearchObject;

namespace AutoTrade.Services
{
    public abstract class BaseCRUDService<TModel, TSearch, TDbEntity, TInsert, TUpdate> : BaseService<TModel, TSearch, TDbEntity> where TModel : class where TSearch : BaseSerachObject where TDbEntity : class
    {
        public BaseCRUDService(AutoTradeContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public TModel Insert(TInsert request)
        {
            TDbEntity entity = Mapper.Map<TDbEntity>(request);

            BeforeInsert(request, entity);
            Context.Add(entity);
            Context.SaveChanges();

            AfterInsert(request, entity);

            if (request is AutomobileAdInsertRequst)
            {
                MapEquipment(request, entity);
            }


            return Mapper.Map<TModel>(entity);
        }

        public virtual void MapEquipment(TInsert request, TDbEntity entity)
        {

        }




        public virtual void BeforeInsert(TInsert request, TDbEntity entity)
        {

        }


        public virtual void AfterInsert(TInsert request, TDbEntity entity)
        {

        }

        public TModel Update(int id, TUpdate request)
        {
            var set = Context.Set<TDbEntity>();
            var entity = set.Find(id);

            Mapper.Map(request, entity);
            BeforeUpdate(request, entity);

            Context.SaveChanges();

            if (request is AutomobileUpdateRequest)
            {
                MapUpdatedEquipment(request, entity);
            }

            return Mapper.Map<TModel>(entity);
        }

        public virtual void MapUpdatedEquipment(TUpdate request, TDbEntity entity)
        {

        }


        public virtual void BeforeUpdate(TUpdate request, TDbEntity entity)
        {

        }

        public TModel Delete(int id)
        {
            var set = Context.Set<TDbEntity>();
            var entity = set.Find(id);

            if (entity == null)
            {
                throw new Exception("Entity not found with provided id");
            }

            if (typeof(TDbEntity) == typeof(Services.Database.User))
            {
                var userEntity = entity as Services.Database.User;
                if (userEntity != null)
                {
                    // Učitavanje povezanog `City` entiteta
                    Context.Entry(userEntity).Reference(u => u.City).Load();
                }
            }

            Context.Remove(entity);
            Context.SaveChanges();

            return Mapper.Map<TModel>(entity);

        }

    }
}
