using AutoTrade.Model;
using AutoTrade.Services;
using Microsoft.AspNetCore.Mvc;
using Request;
using SearchObject;

namespace Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CommentController : BaseCRUDController<Comment, BaseSerachObject, CommentInsertRequst, CommentUpdateRequest>
    {
        public CommentController(ICommentService service) : base(service)
        {
        }
    }
}