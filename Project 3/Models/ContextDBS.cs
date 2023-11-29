using Microsoft.EntityFrameworkCore;
using Project_2.Models;


namespace Project_3.Models
{
    public class ContextDBS:DbContext
    {
        public ContextDBS(DbContextOptions<ContextDBS> options):base(options)
        {
            
        }
        public DbSet<products> productss { get; set; }
        public DbSet<users> userss { get; set; }
        public DbSet<bascket> basckets { get; set; }
    }
}