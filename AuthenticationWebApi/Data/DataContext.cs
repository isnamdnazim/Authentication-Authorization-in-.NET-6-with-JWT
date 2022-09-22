using Microsoft.EntityFrameworkCore;

namespace AuthenticationWebApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {

        }
        public DbSet<User> Users { get; set; }  
       // public DbSet<UserDto> UserDtos { get; set; }  

    }
}
