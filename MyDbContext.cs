using System.Data.Entity;



namespace MVC1.Models
{
    public class MyDbContext
    {
        public MyDbContext(string v)
            : base(v)
        {

        }

        public DbSet<User> Users { get; set; }

    }
}