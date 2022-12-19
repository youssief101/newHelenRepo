using helenProject.Models.userModel;
using Microsoft.EntityFrameworkCore;

namespace helenProject.Data
{
    // the DbContext class help us to speak to the database
    public class helenDbContext : DbContext
    {
        // a constructer that use the DbContext options and passes the arguments to the base class
        public helenDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<userCredentials> userCredential { get; set; }
        public DbSet<tag> tags{ get; set; }
    }
}
