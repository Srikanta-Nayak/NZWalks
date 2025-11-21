using Microsoft.EntityFrameworkCore;
using NZWalksAPI.Models.Domain;

namespace NZWalksAPI.Data
{
    public class NZWalksDbContext:DbContext
    {
        public NZWalksDbContext(DbContextOptions<NZWalksDbContext> dbContextOptions): base(dbContextOptions) 
        {
                
        }

        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }

        public DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var difficulties = new List<Difficulty>()
            {
                new Difficulty()
                {
                    Id=Guid.Parse("32897835-90c5-43de-b078-938eee1c4a99"),
                    Name ="Easy"
                },
                new Difficulty()
                {
                    Id=Guid.Parse("375c2b1e-7370-4057-a8dd-0a70365f0d96"),
                    Name ="Medium"
                },
                new Difficulty()
                {
                    Id=Guid.Parse("14928567-2694-4d9a-9f1f-cdb70651d7d2"),
                    Name ="Hard"
                }
            };
            modelBuilder.Entity<Difficulty>().HasData(difficulties);

            var regions = new List<Region>()
            {
                new Region()
                {
                    Id= Guid.Parse("06719c97-b4e4-403e-9a86-7a30a5f29fc1"),
                    Name ="Auckland",
                    Code ="AKL",
                    RegionImageUrl = "Auckland-image.jpg"
                },
                new Region()
                {
                    Id= Guid.Parse("9c192bc5-7aaa-41e5-80c5-fa203d8f4c58"),
                    Name ="Northland",
                    Code ="NTL",
                    RegionImageUrl = null
                },
                new Region()
                {
                    Id= Guid.Parse("c328f00f-7ebd-44e5-80b0-90dd5349dccb"),
                    Name ="Bay Of Plenty",
                    Code ="BOP",
                    RegionImageUrl = null
                },
                new Region()
                {
                    Id= Guid.Parse("241de1cb-7924-4b1e-9ca5-a85735497b0d"),
                    Name ="Wellington",
                    Code ="WGN",
                    RegionImageUrl = "Wellington-image.jpg"
                },
                 new Region()
                {
                    Id= Guid.Parse("2b40c899-6edf-4a33-a213-a3fb124cf22b"),
                    Name ="Nelson",
                    Code ="NSN",
                    RegionImageUrl = "Nelson-image.jpg"
                },
                 new Region()
                {
                    Id= Guid.Parse("ae526b88-8e09-4b15-9231-3ea9fde3688a"),
                    Name ="Southland",
                    Code ="STL",
                    RegionImageUrl = null
                },
            };
            modelBuilder.Entity<Region>().HasData(regions);

        }
    }
}
