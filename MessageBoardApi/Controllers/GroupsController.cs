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

    [HttpGet("{groupId}/messages")]
    public async Task<ActionResult<IEnumerable<Message>>> GetMessagesByGroup(int groupId)
    {
      // List<Group> messages = await _db.Groups
      //     .Where(m => m.GroupId == groupId)
      //     .ToListAsync();
      var messages = await _db.Messages
                .Where(m => m.GroupId == groupId)
                .ToListAsync();

      if (messages == null)
      {
        return NotFound();
      }

      return messages;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Group>>> Get()
    {
      return await _db.Groups.ToListAsync();
    }
  }
}