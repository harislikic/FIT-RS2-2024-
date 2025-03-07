using AutoTrade.Model;
using AutoTrade.Services;
using AutoTrade.Services.Database;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Request;
using SearchObject;

namespace Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CommentController : BaseCRUDController<Comment, BaseSerachObject, CommentInsertRequst, CommentUpdateRequest>
    {

        private readonly AutoTradeContext _context;
        public CommentController(ICommentService service, AutoTradeContext context) : base(service)
        {
            _context = context;
        }

        [HttpGet("automobile/{automobileId}")]
        public async Task<ActionResult<IEnumerable<Comment>>> GetCommentsByAutomobileId(int automobileId)
        {
            var comments = await _context.Comments
                .Where(c => c.AutomobileAdId == automobileId)
                .Include(c => c.User)
                .Select(c => new
                {
                    CommentId = c.Id,
                    Content = c.Content,
                    CreatedAt = c.CreatedAt,
                    UpdateAt = c.UpdatedAt,
                    User = new
                    {
                        Id = c.User.Id,
                        ProfilePicture = c.User.ProfilePicture,
                        Username = c.User.UserName
                    }
                })
                .ToListAsync();
            return Ok(comments);
        }

        [HttpPut("edit/{commentId}")]
        [Authorize]
        public async Task<ActionResult> UpdateComment(int commentId, int userId, [FromBody] CommentUpdateRequest request)
        {

            var comment = await _context.Comments
           .Include(c => c.User)
           .FirstOrDefaultAsync(c => c.Id == commentId && c.UserId == userId);


            if (comment == null)
            {
                return NotFound("Comment not found or you are not authorized to edit it.");
            }

            comment.Content = request.Content;
            comment.UpdatedAt = DateTime.UtcNow;

            await _context.SaveChangesAsync();

            return Ok(new
            {
                message = "Comment updated successfully.",
                updatedComment = new
                {
                    CommentId = comment.Id,
                    Content = comment.Content,
                    UpdatedAt = comment.UpdatedAt,
                    User = new
                    {
                        Id = comment.User.Id,
                        Username = comment.User.UserName,
                        ProfilePicture = comment.User.ProfilePicture
                    }
                }
            });
        }

        [HttpGet("search")]
        public async Task<ActionResult> GetFilteredComments([FromQuery] CommentSearchObject searchObject)
        {
            var query = _context.Comments
                .Include(c => c.User)
                .AsQueryable();

            if (searchObject.AutomobileId.HasValue)
            {
                query = query.Where(c => c.AutomobileAdId == searchObject.AutomobileId);
            }

            if (searchObject.UserId.HasValue)
            {
                query = query.Where(c => c.UserId == searchObject.UserId);
            }


            var totalCount = await query.CountAsync();

            var page = searchObject.Page ?? 0;
            var pageSize = searchObject.PageSize ?? 25;

            var comments = await query
                .Skip(page * pageSize)
                .Take(pageSize)
                .Select(c => new
                {
                    CommentId = c.Id,
                    Content = c.Content,
                    CreatedAt = c.CreatedAt,
                    UpdatedAt = c.UpdatedAt,
                    User = new
                    {
                        Id = c.User.Id,
                        ProfilePicture = c.User.ProfilePicture,
                        Username = c.User.UserName
                    }
                })
                .ToListAsync();

            var response = new
            {
                TotalCount = totalCount,
                Page = page,
                PageSize = pageSize,
                Comments = comments
            };

            return Ok(response);

        }

    }
}