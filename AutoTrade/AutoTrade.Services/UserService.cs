
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

            if (search.IsAdmin.HasValue)
            {
                query = query.Where(x => x.IsAdmin == search.IsAdmin.Value);
            }



            return base.AddFilter(search, query);

        }

        public override IQueryable<Database.User> AddInclude(IQueryable<Database.User> query, UserSearchObject? search = null, bool includeDetails = false, bool includeDoneAds = false)
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


        public Model.User LoginAdmin(LoginRequest request)
        {
            var entity = Context.Users
            .Include(u => u.City)
            .ThenInclude(c => c.Canton).Where(x => x.IsAdmin)
            .FirstOrDefault(x => x.UserName == request.Username);

            if (entity == null)
            {
                throw new UnauthorizedAccessException("Admin not found.");
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


        public Model.User InsertAdmin(UserInsertRequest request)
        {

            if (request.Password != request.PasswordConfirmation)
            {
                throw new Exception("Passwords do not match.");
            }


            var entity = new Services.Database.User
            {
                UserName = request.UserName,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                PhoneNumber = request.PhoneNumber,
                Adress = request.Adress,
                Gender = request.Gender,
                IsAdmin = true,
                DateOfBirth = request.DateOfBirth,
                CityId = request.CityId
            };

            PasswordHelper.SetPassword(entity, request.Password);

            if (request.ProfilePicture != null && request.ProfilePicture.Length > 0)
            {
                entity.ProfilePicture = FileUploadHelper.UploadProfilePicture(request.ProfilePicture);
            }

            if (request.CityId > 0)
            {
                var city = Context.Cities.FirstOrDefault(c => c.Id == request.CityId);
                if (city == null)
                {
                    throw new Exception("City not found.");
                }
                entity.City = city;
            }


            Context.Users.Add(entity);
            Context.SaveChanges();

            return Mapper.Map<Model.User>(entity);
        }

        public Model.User Update(int id, Model.User user)
        {

            var entity = Context.Users.FirstOrDefault(u => u.Id == id);
            if (entity == null)
            {
                throw new KeyNotFoundException("User not found.");
            }

            entity.FirstName = user.FirstName;
            entity.LastName = user.LastName;
            entity.PhoneNumber = user.PhoneNumber;
            entity.Adress = user.Adress;
            entity.Gender = user.Gender;
            entity.DateOfBirth = user.DateOfBirth;
            entity.CityId = user.CityId;
            entity.ProfilePicture = user.ProfilePicture;

            Context.Users.Update(entity);
            Context.SaveChanges();

            return Mapper.Map<Model.User>(entity);
        }

    }
}
