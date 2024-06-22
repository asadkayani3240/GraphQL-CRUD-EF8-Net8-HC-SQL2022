using Microsoft.EntityFrameworkCore;
using GraphQL_CRUD_with_EF.Data.Entities;

namespace GraphQL_CRUD_with_EF.Data
{
    public class MyWorldDbContext : DbContext
    {
        public MyWorldDbContext(DbContextOptions<MyWorldDbContext> options) : base(options)
        {
        }

        public DbSet<Cake> Cake { get; set; }
    }

}
