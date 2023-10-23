using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MessageBoardApi.Models
{
  public class MessageBoardApiContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Message> Messages { get; set; }
    public DbSet<Group> Groups { get; set; }

    public MessageBoardApiContext(DbContextOptions<MessageBoardApiContext> options) : base(options)
    {
      
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      base.OnModelCreating(builder);
      // var user = new ApplicationUser
      // {
      //   Id= "1",
      //   UserName = "ScarySpice"
      // };
      
      builder.Entity<Group>()
        .HasData(
          new Group { GroupId = 1, GroupName = "SpiceGirls"}
        );
      builder.Entity<ApplicationUser>()
        .HasData(
          new ApplicationUser {UserName = "ScarySpice"}
        );
     
      DateTime messageTime = DateTime.Parse("2023-10-05 12:01:42");

      builder.Entity<Message>()
        .HasData(
          new Message { MessageId = 1, MessageTime = messageTime, MessageName = "beMyLova", MessageBody = "gotta get wit my friends", GroupId = 1, UserName = "ScarySpice"}
        );
    }
  }
}