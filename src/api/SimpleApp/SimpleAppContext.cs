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
            DbPath = Path.Join(path, "simpleapp.db");
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
                    Name = "mein_block_testv1",
                    FileName = "28022022114012_IV05N002R0.pdf",
                    DrawingNumber = "11",
                    MeasuredOn = DateTime.Now,
                    PartNumber = "11",
                    OrderNumber = "",
                    WorkpieceName ="",
                    SoftwareVersion =  "",
                    OperatorName = "",
                    CmmNumber = "112233",

                }, new Protocol
                {
                    ProtocolId = 2,
                    Name = "mein_block_testv2",
                    FileName = "24022022112318_IV05N002R0.pdf",
                    DrawingNumber = "8",
                    MeasuredOn = DateTime.Now,
                    PartNumber = "8",
                    OrderNumber = "",
                    WorkpieceName = "",
                    SoftwareVersion = "",
                    OperatorName = "",
                    CmmNumber = "112233",
                }, new Protocol
                {
                    ProtocolId = 3,
                    Name = "mein_block_testv3",
                    FileName = "24022022112244_IV05N002R0.pdf",
                    DrawingNumber = "9",
                    MeasuredOn = DateTime.Now,
                    PartNumber = "9",
                    OrderNumber = "",
                    WorkpieceName = "",
                    SoftwareVersion = "",
                    OperatorName = "",
                    CmmNumber = "112233",
                }, new Protocol
                {
                    ProtocolId = 4,
                    Name = "mein_block_testv4",
                    FileName = "24022022112301_IV05N002R0.pdf",
                    DrawingNumber = "11",
                    MeasuredOn = DateTime.Now,
                    PartNumber = "11",
                    OrderNumber = "",
                    WorkpieceName = "",
                    SoftwareVersion = "",
                    OperatorName = "",
                    CmmNumber = "112233",
                }, new Protocol
                {
                    ProtocolId = 5,
                    Name = "mein_block_testv5",
                    FileName = "20122021070353_IV05N002R0.pdf",
                    DrawingNumber = "11",
                    MeasuredOn = DateTime.Now,
                    PartNumber = "11",
                    OrderNumber = "",
                    WorkpieceName = "",
                    SoftwareVersion = "",
                    OperatorName = "",
                    CmmNumber = "112233",
                }
                );
        }
    }
}
