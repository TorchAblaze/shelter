using Microsoft.EntityFrameworkCore;

namespace RestServer.Models
{
  public class RestServerContext : DbContext
  {
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
        .HasData(
          new Animal { Id = 1, Name = "John", Age = 15, Type="cat", Sex = "Male", Available= true, PicHeight=100, PicWidth=100},
          new Animal { Id = 2, Name = "Robb", Age = 15, Type="cat", Sex = "Male", Available= false, PicHeight=200, PicWidth=200},
          new Animal { Id = 3, Name = "Sansa", Age = 11, Type="cat", Sex = "Female", Available= true, PicHeight=210, PicWidth=210},
          new Animal { Id = 4, Name = "Bran", Age = 7, Type="cat", Sex = "Male", Available= true, PicHeight=300, PicWidth=300},
          new Animal { Id = 5, Name = "Arya", Age = 9, Type="cat", Sex = "Female", Available= true, PicHeight=500, PicWidth=500},
          new Animal { Id = 6, Name = "Rickon", Age = 3, Type="cat", Sex = "Male", Available= false, PicHeight=600, PicWidth=600},
          new Animal { Id = 7, Name = "Ghost", Age = 1, Type="dog", Sex = "Male", Available= true, PicHeight=700, PicWidth=700},
          new Animal { Id = 8, Name = "Grey Wind", Age = 1, Type="dog", Sex = "Male", Available= false, PicHeight=800, PicWidth=800},
          new Animal { Id = 9, Name = "Lady", Age = 1, Type="dog", Sex = "Female", Available= false, PicHeight=900, PicWidth=900},
          new Animal { Id = 10, Name = "Nymeria", Age = 1, Type="dog", Sex = "Female", Available= true, PicHeight=1010, PicWidth=1010},
          new Animal { Id = 11, Name = "Summer", Age = 1, Type="dog", Sex = "Male", Available= false, PicHeight=1200, PicWidth=1200},
          new Animal { Id = 12, Name = "Shaggy Dog", Age = 1, Type="dog", Sex = "Male", Available= false, PicHeight=1300, PicWidth=1300}
        );
    }
    public DbSet<Animal> Animals { get; set; }

    public RestServerContext(DbContextOptions options) : base(options) { }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}

// using Microsoft.EntityFrameworkCore;

// namespace Shelter.Models
// {
//   public class ShelterContext : DbContext
//   {
//     protected override void OnModelCreating(ModelBuilder builder)
//     {
//       builder.Entity<Animal>()
//           .HasData(
//               new Animal { AnimalId = 1, Name = "John", Age = 15, Type="cat", Sex = "Male", Available= true},
//               new Animal { AnimalId = 2, Name = "Robb", Age = 15, Type="cat", Sex = "Male", Available= false},
//               new Animal { AnimalId = 3, Name = "Sansa", Age = 11, Type="cat", Sex = "Female", Available= true},
//               new Animal { AnimalId = 4, Name = "Bran", Age = 7, Type="cat", Sex = "Male", Available= true},
//               new Animal { AnimalId = 5, Name = "Arya", Age = 9, Type="cat", Sex = "Female", Available= true},
//               new Animal { AnimalId = 6, Name = "Rickon", Age = 3, Type="cat", Sex = "Male", Available= false},
//               new Animal { AnimalId = 7, Name = "Ghost", Age = 1, Type="dog", Sex = "Male", Available= true},
//               new Animal { AnimalId = 8, Name = "Grey Wind", Age = 1, Type="dog", Sex = "Male", Available= false},
//               new Animal { AnimalId = 9, Name = "Lady", Age = 1, Type="dog", Sex = "Female", Available= false},
//               new Animal { AnimalId = 10, Name = "Nymeria", Age = 1, Type="dog", Sex = "Female", Available= true},
//               new Animal { AnimalId = 11, Name = "Summer", Age = 1, Type="dog", Sex = "Male", Available= false},
//               new Animal { AnimalId = 12, Name = "Shaggy Dog", Age = 1, Type="dog", Sex = "Male", Available= false}
              
//           );
//     }
//     public ShelterContext(DbContextOptions<ShelterContext> options)
//       : base(options)
//     {
//     }