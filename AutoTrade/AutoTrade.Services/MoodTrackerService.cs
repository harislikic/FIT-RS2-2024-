using System.Globalization;
using AutoTrade.Services.Database;
using Database;
using MapsterMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Request;
using SearchObject;

namespace AutoTrade.Services
{
    public class MoodTrackerService : BaseCRUDService<Model.MoodTracker, MoodTrackerSerachObject, MoodTracker, MoodTrackerUpsertRequest, MoodTrackerUpsertRequest>, IMoodTrackerService
    {
        public MoodTrackerService(AutoTradeContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IQueryable<MoodTracker> AddInclude(IQueryable<MoodTracker> query, MoodTrackerSerachObject? search = null, bool includeDetails = false, bool includeDoneAds = false)
        {
            return query.Include(x => x.User);
        }

        public override IQueryable<MoodTracker> AddFilter(MoodTrackerSerachObject search, IQueryable<MoodTracker> query)
        {

            if (!string.IsNullOrWhiteSpace(search.FullNameQuery))
            {
                string filter = search.FullNameQuery.Trim();
                query = query.Where(x =>
                    x.User.FirstName.Contains(filter) ||
                    x.User.LastName.Contains(filter));
            }

            if (search.userId.HasValue)
            {
                query = query.Where(x => x.User.Id == search.userId.Value);
            }

            if (!string.IsNullOrWhiteSpace(search.Mood))
            {
                query = query.Where(x => x.Mood.StartsWith(search.Mood));
            }


            var format = "dd-MM-yyyy";
            var culture = CultureInfo.InvariantCulture;

            if (!string.IsNullOrWhiteSpace(search.MoodStartDate))
            {
                var parsed = DateTime.ParseExact(search.MoodStartDate, format, culture);
                query = query.Where(x => x.MoodDate.Date >= parsed.Date);
            }

            if (!string.IsNullOrWhiteSpace(search.MoodEndDate))
            {
                var parsed = DateTime.ParseExact(search.MoodEndDate, format, culture);
                query = query.Where(x => x.MoodDate.Date <= parsed.Date);
            }



            return base.AddFilter(search, query);
        }

        public override void BeforeInsert(MoodTrackerUpsertRequest request, MoodTracker entity)
        {
            var userMoodCountDate = Context.MoodTrackers.Where(x => x.User.Id == request.UserId && x.MoodDate.Date == request.MoodDate.Date).Count();

            var canAdd = userMoodCountDate < 2;

            if (!canAdd)
            {
                throw new Exception("Korisnik je već unio 2 raspoloženja za taj dan.");
            }

            base.BeforeInsert(request, entity);
        }

    }
}