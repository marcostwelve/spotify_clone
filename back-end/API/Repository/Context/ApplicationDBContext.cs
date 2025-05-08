using Microsoft.EntityFrameworkCore;
using Modelos.Models;

namespace Repository.Context
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }
        
        public DbSet<Media> Medias { get; set; }
        
    }
}
