
using AutoTrade.Model;
using AutoTrade.Services.Database;
using AutoTrader.Services.Helpers;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;
using Request;
using SerachObject;
using System.Linq.Dynamic.Core;

namespace AutoTrade.Services
{
    public class UserService : BaseCRUDService<Model.User, UserSearchObject, Database.User, UserInsertRequest, UserUpdateRequest>, IUserService
    {

        public UserService(AutoTradeContext context, IMapper mapper) : base(context, mapper)
        {

        }


        public override IQueryable<Database.User> AddFilter(UserSearchObject search, IQueryable<Database.User> query)
        {

            if (!string.IsNullOrWhiteSpace(search?.FirstNameGTE))
            {
                query = query.Where(x => x.FirstName.Contains(search.FirstNameGTE));
            }

            if (!string.IsNullOrWhiteSpace(search?.LastNameeGTE))
            {
                query = query.Where(x => x.LastName.StartsWith(search.LastNameeGTE));
            }

            if (!string.IsNullOrWhiteSpace(search?.UserName))
            {
                query = query.Where(x => x.UserName.StartsWith(search.UserName));
            }

            if (!string.IsNullOrWhiteSpace(search.OrderBy))
            {
                query = query.OrderBy(search.OrderBy);
            }

            return base.AddFilter(search, query);

        }

        public override IQueryable<Database.User> AddInclude(IQueryable<Database.User> query, UserSearchObject? search = null)
        {
            return query.Include(u => u.City).ThenInclude(c => c.Canton);
        }

        public override void BeforeInsert(UserInsertRequest request, Database.User entity)
        {
            if (request.Password != request.PasswordConfirmation)
            {
                throw new ArgumentException("Password and Password confirmation must be equal");
            }

            entity.PasswordSalt = PasswordHelper.GenerateSalt();
            entity.PasswordHash = PasswordHelper.GenerateHash(entity.PasswordSalt, request.Password);

            entity.ProfilePicture = FileUploadHelper.UploadProfilePicture(request.ProfilePicture);

            base.BeforeInsert(request, entity);
        }

        public override void BeforeUpdate(UserUpdateRequest request, Database.User entity)
        {

            if (request.Password != null)
            {
                if (request.Password != request.PasswordConfirmation)
                {
                    throw new ArgumentException("Password and Password confirmation must be same");
                }
                entity.PasswordSalt = PasswordHelper.GenerateSalt();
                entity.PasswordHash = PasswordHelper.GenerateHash(entity.PasswordSalt, request.Password);
            }

            if (request.ProfilePicture != null)
            {
                entity.ProfilePicture = FileUploadHelper.UploadProfilePicture(request.ProfilePicture);
            }


            base.BeforeUpdate(request, entity);
        }

        public Model.User Login(string username, string password)
        {
            var entity = Context.Users.FirstOrDefault(x => x.UserName == username);
            if (entity == null)
            {
                return null;
            }

            var hash = PasswordHelper.GenerateHash(entity.PasswordSalt, password);

            if (hash != entity.PasswordHash)
            {
                return null;
            }

            return this.Mapper.Map<Model.User>(entity);
        }

    }
}