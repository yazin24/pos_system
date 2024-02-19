using Microsoft.EntityFrameworkCore;

namespace SCS_POS_SYSTEM.Database
{
    public class DatabaseContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public DatabaseContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        //Entites here




        //Relationship here





        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string ConnectionString = _configuration.GetConnectionString("SqlConnection");

            if(ConnectionString != null)
            {
                optionsBuilder.UseSqlServer(ConnectionString);
            }else
            {
                Console.WriteLine("Cant connect to the Sql Server! Please try again later.");
            }
        }
    }
}
