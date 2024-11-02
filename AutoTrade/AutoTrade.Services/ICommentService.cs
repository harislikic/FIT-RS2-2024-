using Database;
using Request;
using SearchObject;

namespace AutoTrade.Services
{
    public interface ICommentService : ICRUDService<Model.Comment, BaseSerachObject, CommentInsertRequst, CommentUpdateRequest>
    {
    }
}