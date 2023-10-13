using Dot6.HotChoc12.CRUD.Demo.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dot6.HotChoc12.CRUD.Demo.Data
{
    public class myWorldDbContext :DbContext
    {
        public myWorldDbContext(DbContextOptions<myWorldDbContext> options): base(options)
        {
            
        }

        public DbSet<Cake> Cake { get; set; }   
        
    }
}
