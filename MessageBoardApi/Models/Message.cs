namespace MessageBoardApi.Models
{
  public class Message
  {
    public int MessageId {get; set; }
    public DateTime MessageTime { get; set; }
    public string MessageName { get; set; }

    public string MessageBody { get; set; }
    
    // Foreign Key #1
    public int GroupId { get; set; }
    public Group Group { get; set; }

    // Foreign Key #2
    public string UserName { get; set; }
    public ApplicationUser User { get; set; }

  }
}