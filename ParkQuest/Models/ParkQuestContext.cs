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

    protected override void OnModelCreating(ModelBuilder builder)
    {
      base.OnModelCreating(builder);
      
      builder.Entity<Park>()
        .HasData(
          new Park { ParkId = 1, Name = "Ainsworth", ParkType = "State", HasRestrooms = "No" },
          new Park { ParkId = 2, Name = "Crater Lake", ParkType = "National", HasRestrooms = "Yes" },
          new Park { ParkId = 3, Name = "Gates of the Arctic", ParkType = "National", HasRestrooms = "No" },
          new Park { ParkId = 4, Name = "Bob Straub", ParkType = "State", HasRestrooms = "Yes" },
          new Park { ParkId = 5, Name = "William M. Tugman", ParkType = "State", HasRestrooms = "Yes" },
          new Park { ParkId = 6, Name = "Brian Booth - Beaver Creek", ParkType = "State", HasRestrooms = "Yes" },
          new Park { ParkId = 7, Name = "Lake Clark", ParkType = "National", HasRestrooms = "No" },
          new Park { ParkId = 8, Name = "Cascadia", ParkType = "State", HasRestrooms = "No" },
          new Park { ParkId = 9, Name = "Isle Royale", ParkType = "National", HasRestrooms = "Yes" },
          new Park { ParkId = 10, Name = "Kobuk Valley", ParkType = "National", HasRestrooms = "No" },
          new Park { ParkId = 11, Name = "Dry Tortugas", ParkType = "National", HasRestrooms = "Yes" },
          new Park { ParkId = 12, Name = "Ecola", ParkType = "State", HasRestrooms = "No" },
          new Park { ParkId = 13, Name = "Cottonwood Canyon", ParkType = "State", HasRestrooms = "No" },
          new Park { ParkId = 14, Name = "Harris Beach", ParkType = "State", HasRestrooms = "No" },
          new Park { ParkId = 15, Name = "LaPine", ParkType = "State", HasRestrooms = "Yes" },
          new Park { ParkId = 16, Name = "North Cascades", ParkType = "National", HasRestrooms = "No" },
          new Park { ParkId = 17, Name = "Great Basin", ParkType = "National", HasRestrooms = "Yes" },
          new Park { ParkId = 18, Name = "Mayer", ParkType = "State", HasRestrooms = "Yes" },
          new Park { ParkId = 19, Name = "Prineville Reservoir", ParkType = "State", HasRestrooms = "No" },
          new Park { ParkId = 20, Name = "Nehalem Bay", ParkType = "State", HasRestrooms = "No" },
          new Park { ParkId = 21, Name = "Congaree", ParkType = "National", HasRestrooms = "Yes" },
          new Park { ParkId = 22, Name = "Port Orford Heads", ParkType = "State", HasRestrooms = "Yes" },
          new Park { ParkId = 23, Name = "Black Canyon of the Gunnison", ParkType = "National", HasRestrooms = "Yes" },
          new Park { ParkId = 24, Name = "Umpqua Lighthouse", ParkType = "State", HasRestrooms = "Yes" },
          new Park { ParkId = 25, Name = "Guadalupe Mountains", ParkType = "National", HasRestrooms = "No" }
        );
    }
  }
}