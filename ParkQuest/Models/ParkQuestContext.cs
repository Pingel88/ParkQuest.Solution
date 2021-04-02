using Microsoft.EntityFrameworkCore;

namespace ParkQuest.Models
{
  public class ParkQuestContext : DbContext
  {
    public ParkQuestContext(DbContextOptions<ParkQuestContext> options)
      : base(options)
    {

    }

    public DbSet<Park> Parks { get; set; }

  }
}