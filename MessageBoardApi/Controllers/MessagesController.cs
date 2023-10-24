using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MessageBoardApi.Models;

namespace MessageBoardApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class MessagesController : ControllerBase
  {
    private readonly MessageBoardApiContext _db;

    public MessagesController(MessageBoardApiContext db)
    {
      _db = db;
    }

    // return a list of all messages
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Message>>> Get()
    {
      return await _db.Messages.ToListAsync();
    }



    // GET: api/Messages/1
    [HttpGet("{id}")]
    public async Task<ActionResult<Message>> GetMessage(int id)
    {

      Message message = await _db.Messages.FindAsync(id);

      if (message == null)
      {
        return NotFound();
      }

      return message;
    }

    // POST api/animals
    [HttpPost]
    public async Task<ActionResult<Message>> Post(Message message)
    {
      _db.Messages.Add(message);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetMessage), new { id = message.MessageId }, message);
    }

    //PUT: ..api/Messages/2
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Message message, string putUserName)
    {
      if (id != message.MessageId || putUserName != message.UserName)
      {
        return BadRequest();
      }

      // if (user.UserName )

      _db.Messages.Update(message);

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!MessageExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }

    private bool MessageExists(int id)
    {
      return _db.Messages.Any(e => e.MessageId == id);
    }

    // DELETE: api/Messages/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteMessage(int id, string deleteUserName)
    {
      Message message = await _db.Messages.FindAsync(id);
      if (message == null)
      {
        return NotFound();
      }
      else if (deleteUserName != message.UserName)
      {
        return Unauthorized();
      }

      _db.Messages.Remove(message);
      await _db.SaveChangesAsync();

      return NoContent();
    }

    [HttpGet("/messages")]
    public async Task<ActionResult<IEnumerable<Message>>> GetMessagesByDate(string fromDate, string toDate)
    {
      if (!DateTime.TryParse(fromDate, out DateTime startDate) || !DateTime.TryParse(toDate, out DateTime endDate)) 
      {
        return BadRequest("Invalid date format. Use yyyy-MM-dd.");
      }

      var messages = await _db.Messages
                .Where(m => m.MessageTime >= startDate && m.MessageTime <= endDate )
                .ToListAsync();

      if (messages == null)
      {
        return NotFound();
      }

      return messages;
    }
//     public async Task<List<Product>> GetByDateBetweenAsync(string fromDate, string toDate)
// {
//     var startAt=DateTime.Parse(fromDate);
//     var endAt=DateTime.Parse(toDate);

//     var sql = $"SELECT * FROM Products WHERE CreatedDate BETWEEN {startAt} AND {endAt}";

//     using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
//     {
//         connection.Open();
//         var result = await connection.QuerySingleOrDefaultAsync<Product>(sql);
//         return result;
//     }
// }
  }
}



//comment made on paul branch