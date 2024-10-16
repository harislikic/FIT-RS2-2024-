using AutoTrade.Model;
using AutoTrade.Services.Database;
using AutoTrader.Services.Helpers;
using MapsterMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using Request;
using SerachObject;

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

        public virtual List<Model.User> Get(UserSearchObject serachObject)
        {
            List<Model.User> result = new List<Model.User>();

            var query = Context.Users.AsQueryable();
            if (!string.IsNullOrWhiteSpace(serachObject?.FirstNameGTE))
            {
                query = query.Where(x => x.FirstName.StartsWith(serachObject.FirstNameGTE));
            }

            if (!string.IsNullOrWhiteSpace(serachObject?.LastNameeGTE))
            {
                query = query.Where(x => x.LastName.StartsWith(serachObject.LastNameeGTE));
            }

            if (!string.IsNullOrWhiteSpace(serachObject?.Email))
            {
                query = query.Where(x => x.Email == serachObject.Email);
            }

            if (!string.IsNullOrWhiteSpace(serachObject?.UserName))
            {
                query = query.Where(x => x.UserName == serachObject.UserName);
            }

            query.Include(x => x.City).ThenInclude(c => c.Canton).ToList();

            var list = query.ToList();

            result = Mapper.Map(list, result);
            return result;
        }

        public Model.User Insert(UserInsertRequest request)
        {
            if (request.Password != request.PasswordConfirmation)
            {
                throw new ArgumentException("Password and Password confirmation must be same");
            }

            Database.User entity = new Database.User();
            Mapper.Map(request, entity);

            entity.PasswordSalt = PasswordHelper.GenerateSalt();
            entity.PasswordHash = PasswordHelper.GenerateHash(entity.PasswordSalt, request.Password);

            entity.ProfilePicture = FileUploadHelper.UploadProfilePicture(request.ProfilePicture);

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