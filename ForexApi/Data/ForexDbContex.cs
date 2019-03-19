using System;
using Microsoft.EntityFrameworkCore;

namespace ForexApi.Data
{
    public class ForexDbContex : DbContext
    {

        //private const string connectionString = "Data Source=127.0.0.1,1433;Initial Catalog=KontenaAspnetCore;User ID=sa;Password=1qaz2wsx@V;";


        private const string connectionString = "Server=tcp:hudayanga.database.windows.net,1433;Initial Catalog=Forex;Persist Security Info=False;User ID=hudayanga;Password=1qaz2wsx@V;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<RateData> Rates { get; set; }
    }
}
