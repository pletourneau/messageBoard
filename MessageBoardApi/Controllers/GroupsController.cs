using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MessageBoardApi.Models;

namespace MessageBoardApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class GroupsController : ControllerBase
  {
    private readonly MessageBoardApiContext _db;

    public GroupsController(MessageBoardApiContext db)
    {
      _db = db;
    }

    // [HttpGet("{groupId}/messages")]
    // public async Task<ActionResult<IEnumerable<Message>>> GetMessagesByGroup(int groupId)
    // {
    //   var messages = await _db.Messages
    //             .Where(m => m.GroupId == groupId)
    //             .ToListAsync();

    //   if (messages == null)
    //   {
    //     return NotFound();
    //   }
    //   return messages;
    // }
    [HttpGet("{groupId}/messages")]
    public async Task<ActionResult<PaginatedList<Message>>> GetMessagesByGroup(int groupId, int pageIndex = 1, int pageSize = 10)
    {
    
      var messages = _db.Messages.Where(m => m.GroupId == groupId);

      var paginatedMessages = await PaginatedList<Message>.CreateAsync(messages, pageIndex, pageSize);

      if (paginatedMessages.Count == 0)
      {
        return NotFound();
      }

      return paginatedMessages;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Group>>> Get()
    {
      return await _db.Groups.ToListAsync();
    }
  }
}