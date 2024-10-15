using AutoTrade.Model;
using AutoTrade.Services.Database;
using AutoTrader.Services.Helpers;
using MapsterMapper;
using Request;

namespace AutoTrade.Services
{
    public class UserService : IUserService
    {

        public AutoTradeContext Context { get; set; }

        public IMapper Mapper { get; set; }

        public UserService(AutoTradeContext context, IMapper mapper)
        {
            Context = context;
            Mapper = mapper;
        }

        public virtual List<Model.User> Get()
        {
            List<Model.User> result = new List<Model.User>();
            var list = Context.Users.ToList();

            result = Mapper.Map(list, result);
            return result;
        }

        public Model.User Insert(UserInsertRequest request)
        {
            if (request.Password != request.PasswordConfirmation)
            {
                throw new ArgumentException("Password and Password confirmation must be same");
            }

            User entity = new User();
            Mapper.Map(request, entity);

            entity.PasswordSalt = PasswordHelper.GenerateSalt();
            entity.PasswordHash = PasswordHelper.GenerateHash(entity.PasswordSalt, request.Password);

            Context.Add(entity);
            Context.SaveChanges();

            return Mapper.Map<Model.User>(entity);
        }

        public Model.User Update(int id, UserUpdateRequest request)
        {
            var entity = Context.Users.Find(id);

            Mapper.Map(request, entity);

            if (request.Password != null)
            {
                if (request.Password != request.PasswordConfirmation)
                {
                    throw new ArgumentException("Password and Password confirmation must be same");
                }
                entity.PasswordSalt = PasswordHelper.GenerateSalt();
                entity.PasswordHash = PasswordHelper.GenerateHash(entity.PasswordSalt, request.Password);
            }

            Context.SaveChanges();
            return Mapper.Map<Model.User>(entity);
        }
    }
}