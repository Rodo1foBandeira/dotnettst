using Microsoft.EntityFrameworkCore;

namespace dotnettst.Models
{
    public class Context : DbContext    
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
            
        }
        //"MySqlConnectionString":"server=18.212.145.93;port=3306;database=dotnettst;uid=root;pwd=!Q@W3e4r"
        public DbSet<Produto> Produtos { get; set; }
    }
}