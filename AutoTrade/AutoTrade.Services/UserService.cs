
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

        public override IQueryable<Database.User> AddInclude(IQueryable<Database.User> query, UserSearchObject? search = null, bool includeDetails = false)
        {
            return query.Include(u => u.City).ThenInclude(c => c.Canton);
        }

        public override void BeforeInsert(UserInsertRequest request, Database.User entity)
        {

            entity.City = Context.Cities
                .Include(c => c.Canton)
                .FirstOrDefault(c => c.Id == entity.CityId);

            if (entity.City == null)
            {
                throw new Exception("City not found for the given CityId.");
            }



            bool userExists = Context.Users.Any(u => u.UserName == request.UserName || u.Email == request.Email);
            if (userExists)
            {
                throw new ArgumentException("A user with the same username or email already exists.");
            }

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


            entity.City = Context.Cities
                          .Include(c => c.Canton)
                          .FirstOrDefault(c => c.Id == entity.CityId);


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

        public Model.User Login(LoginRequest request)
        {
            var entity = Context.Users
            .Include(u => u.City)
            .ThenInclude(c => c.Canton)
            .FirstOrDefault(x => x.UserName == request.Username);

            if (entity == null)
            {
                throw new UnauthorizedAccessException("User not found.");
            }

            var hash = PasswordHelper.GenerateHash(entity.PasswordSalt, request.Password);

            if (hash != entity.PasswordHash)
            {
                throw new UnauthorizedAccessException("Invalid password.");
            }

            var basicAuth = "Basic " + Convert.ToBase64String(
                System.Text.Encoding.UTF8.GetBytes($"{request.Username}:{request.Password}")
            );

            return this.Mapper.Map<Model.User>(entity);
        }

    }
}
