using Microsoft.EntityFrameworkCore;
using RattoWeb.Models.Domain;

namespace RattoWeb.Data
{
    public class RattoWebDBContext: DbContext
    {
        public RattoWebDBContext(DbContextOptions<RattoWebDBContext> options) : base(options)
        {

        }

        public DbSet<Region> Regions { get; set; }

        public DbSet<Walk> Walks { get; set; }


        public DbSet<WalkDifficulty> WalkDifficulty { get; set; }


    }
}
