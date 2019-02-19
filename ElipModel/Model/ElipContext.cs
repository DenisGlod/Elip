using ElipAdmin.Model.Entity;
using System.Data.Entity;

namespace ElipAdmin.Model
{
    public class ElipContext : DbContext
    {
        public ElipContext() : base("DbConnection") { }

        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<DataInGroup> DataInGroups { get; set; }

        public void DeleteDataBase()
        {
            Database.Delete();
        }

    }
}
