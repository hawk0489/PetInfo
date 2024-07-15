using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace PetInfo.Models
{
    public class PetDbContext : DbContext
    {
        public PetDbContext(DbContextOptions<PetDbContext> options) : base(options)
        {

        }
        public DbSet<Pet> Pets { get; set; }
    }
}
