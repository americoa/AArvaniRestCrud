using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

public class AArvaniContext : DbContext
{
    public DbSet<User> Users { get; set; }

   
protected override void OnConfiguring(DbContextOptionsBuilder options)
  => options.UseSqlServer("Server=localhost;Initial Catalog=AArvani;MultipleActiveResultSets=true;User ID=sa;Password=Q!)CWg(tT^rDc5I$;TrustServerCertificate=true");

}

public class User
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int UserId { get; set; }
    public string UserName { get; set; }
}

