using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ShameTheThronesV2.Models;

namespace ShameTheThronesV2.DB
{
    public partial class ShameTheThronesContext : DbContext
    {
        public DbSet<Restroom> Restrooms { get; set; }
        public DbSet<Rating> Ratings { get; set; }

        public ShameTheThronesContext(DbContextOptions<ShameTheThronesContext> options) : base(options)
        { }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)   
                optionsBuilder.UseSqlServer(@"Server=(localdb)\ProjectsV12;Integrated Security=true;");
            
        }

     
    }
}
