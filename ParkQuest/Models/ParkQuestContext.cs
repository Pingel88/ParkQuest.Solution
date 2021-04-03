using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ParkQuest.Models
{
  public class ParkQuestContext : IdentityDbContext
  {
    public ParkQuestContext(DbContextOptions<ParkQuestContext> options)
      : base(options)
    {

    }

    public DbSet<Park> Parks { get; set; }

  }
}