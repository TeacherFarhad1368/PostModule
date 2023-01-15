using Microsoft.EntityFrameworkCore;
using PostModule.Domain.StateEntity;
using PostModule.Domain.CityEntity;
using PostModule.Infrastracture.EF.Mapping;

namespace PostModule.Infrastracture.EF
{
    public class Post_Context : DbContext
    {
        public Post_Context(DbContextOptions<Post_Context> options) : base(options)
        {

        }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StateMapping());
            modelBuilder.ApplyConfiguration(new CityMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}
