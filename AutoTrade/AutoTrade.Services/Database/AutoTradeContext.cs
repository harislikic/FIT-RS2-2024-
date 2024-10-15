using AutoTrade.Model;
using Microsoft.EntityFrameworkCore;

namespace AutoTrade.Services.Database
{
    public partial class AutoTradeContext : DbContext
    {

        public AutoTradeContext() : base() { }

        public AutoTradeContext(DbContextOptions<AutoTradeContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
         optionsBuilder.UseSqlServer("Data Source=127.0.0.1;Initial Catalog=AutoTrade; user=SA; Password=MyPass@word; TrustServerCertificate=True;");
        }
    }
}