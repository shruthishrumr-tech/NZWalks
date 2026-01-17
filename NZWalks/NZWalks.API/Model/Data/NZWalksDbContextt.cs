using Microsoft.EntityFrameworkCore;
using NZWalks.API.Model.DomainModel;


namespace NZWalks.API.Model.Data
{
    public class NZWalksDbContextt:DbContext
    {
        public NZWalksDbContextt(DbContextOptions<NZWalksDbContextt> options):base(options)
        {

        }
        
       public DbSet<Region> Regions { get; set; }   
        public DbSet<WalkDifficulty> WalkDifficulties { get; set; }
        public DbSet<Walk> Walks { get; set; }

    }
}
