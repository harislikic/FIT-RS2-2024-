using System.Linq.Dynamic.Core;
using AutoTrade.Model;
using AutoTrade.Services.Database;
using AutoTrader.Services.Helpers;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;
using Request;
using SerachObject;

namespace AutoTrade.Services
{
    public class UserService : BaseService<Model.User, UserSearchObject, Database.User>, IUserService
    {

        // public AutoTradeContext Context { get; set; }

        // public IMapper Mapper { get; set; }

        public UserService(AutoTradeContext context, IMapper mapper) : base(context, mapper)
        {

        }


        public override IQueryable<Database.User> AddFilter(UserSearchObject serach, IQueryable<Database.User> query)
        {
            var filteredQuery = base.AddFilter(serach, query);

            if (!string.IsNullOrWhiteSpace(serach?.UserName))
            {
                filteredQuery = filteredQuery.Where(x => x.FirstName.Contains(serach.FirstNameGTE));
            }

            if (!string.IsNullOrWhiteSpace(serach?.LastNameeGTE))
            {
                query = query.Where(x => x.LastName.StartsWith(serach.LastNameeGTE));
            }

            return filteredQuery;

        }

        public override IQueryable<Database.User> AddInclude(IQueryable<Database.User> query, UserSearchObject search = null)
        {
            return query.Include(u => u.City).ThenInclude(c => c.Canton);
        }

        // public virtual Model.PagedResult<Model.User> Get(UserSearchObject serachObject)
        // {
        //     List<Model.User> result = new List<Model.User>();

        //     var query = Context.Users.AsQueryable();
        //     if (!string.IsNullOrWhiteSpace(serachObject?.FirstNameGTE))
        //     {
        //         query = query.Where(x => x.FirstName.StartsWith(serachObject.FirstNameGTE));
        //     }

        //     if (!string.IsNullOrWhiteSpace(serachObject?.LastNameeGTE))
        //     {
        //         query = query.Where(x => x.LastName.StartsWith(serachObject.LastNameeGTE));
        //     }

        //     if (!string.IsNullOrWhiteSpace(serachObject?.Email))
        //     {
        //         query = query.Where(x => x.Email == serachObject.Email);
        //     }

        //     if (!string.IsNullOrWhiteSpace(serachObject?.UserName))
        //     {
        //         query = query.Where(x => x.UserName == serachObject.UserName);
        //     }

        //     int count = query.Count();

        //     if (!string.IsNullOrWhiteSpace(serachObject.OrderBy))
        //     {
        //         query = query.OrderBy(serachObject.OrderBy);
        //     }

        //     if (serachObject?.Page.HasValue == true && serachObject?.PageSize.HasValue == true)
        //     {
        //         query = query.Skip(serachObject.Page.Value * serachObject.PageSize.Value)
        //         .Take(serachObject.PageSize.Value);
        //     }
        //     query = query.Include(x => x.City).ThenInclude(c => c.Canton);

        //     var list = query.ToList();

        //     var resultList = Mapper.Map(list, result);

        //     Model.PagedResult<Model.User> response = new Model.PagedResult<Model.User>();
        //     response.ResultList = resultList;
        //     response.Count = count;

        //     return response;
        // }

        // public Model.User Insert(UserInsertRequest request)
        // {
        //     if (request.Password != request.PasswordConfirmation)
        //     {
        //         throw new ArgumentException("Password and Password confirmation must be equal");
        //     }

        //     Database.User entity = new Database.User();
        //     Mapper.Map(request, entity);

        //     entity.PasswordSalt = PasswordHelper.GenerateSalt();
        //     entity.PasswordHash = PasswordHelper.GenerateHash(entity.PasswordSalt, request.Password);

        //     entity.CityId = request.CityId;
        //     entity.ProfilePicture = FileUploadHelper.UploadProfilePicture(request.ProfilePicture);

        //     Context.Add(entity);
        //     Context.SaveChanges();



        //     return Mapper.Map<Model.User>(entity);
        // }

        // public Model.User Update(int id, UserUpdateRequest request)
        // {
        //     var entity = Context.Users.Find(id);

        //     Mapper.Map(request, entity);

        //     if (request.Password != null)
        //     {
        //         if (request.Password != request.PasswordConfirmation)
        //         {
        //             throw new ArgumentException("Password and Password confirmation must be same");
        //         }
        //         entity.PasswordSalt = PasswordHelper.GenerateSalt();
        //         entity.PasswordHash = PasswordHelper.GenerateHash(entity.PasswordSalt, request.Password);
        //     }

        //     Context.SaveChanges();
        //     return Mapper.Map<Model.User>(entity);
        // }
    }
}