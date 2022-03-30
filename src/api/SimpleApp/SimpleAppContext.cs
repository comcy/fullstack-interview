using Microsoft.EntityFrameworkCore;

namespace SimpleApp
{
    public class SimpleAppContext : DbContext
    {
        public DbSet<Protocol>? Protocols { get; set; }
        public DbSet<Comment>? Comments { get; set; }

        public string DbPath { get; }

        public SimpleAppContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            // Will be stored in AppData local folder
            DbPath = System.IO.Path.Join(path, "simpleapp.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Protocol>().HasData(
                new Protocol
                {
                    ProtocolId = 1,
                    Name = "First Protocol",
                    DrawingNumber = "Test",
                });
        }
    }
}
