using AutoTrade.Services.Database;
using Database;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;
using Request;
using SearchObject;

namespace AutoTrade.Services
{
    public class CommentService : BaseCRUDService<Model.Comment, BaseSerachObject, Comment, CommentInsertRequst, CommentUpdateRequest>, ICommentService
    {
        public CommentService(AutoTradeContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IQueryable<Comment> AddInclude(IQueryable<Comment> query, BaseSerachObject? search = null, bool includeDetails = false)
        {

            return query.Include(x => x.User).ThenInclude(c => c.AutomobileAds);
        }


        public override void BeforeInsert(CommentInsertRequst request, Comment entity)
        {
            entity.CreatedAt = DateTime.Now;

            base.BeforeInsert(request, entity);
        }

        public override void BeforeUpdate(CommentUpdateRequest request, Comment entity)
        {
            entity.UpdatedAt = DateTime.Now;

            base.BeforeUpdate(request, entity);
        }
    }
}