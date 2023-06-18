using GraphQLSampleAPI.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GraphQLSampleAPI.Data.ContextConfigurations
{
    public class SampleContextConfiguration : IEntityTypeConfiguration<Sample>
    {
        private Guid[] _ids;

        public SampleContextConfiguration(Guid[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Sample> builder)
        {
            builder
                .HasData(
                new Sample
                {
                    Id = Guid.NewGuid(),
                    Title = "Batman Begins",
                    Description = "Batman Begins is a 2005 superhero film directed by Christopher Nolan and written by Nolan and David S. Goyer. Based on the DC Comics character Batman, it stars Christian Bale as Bruce Wayne / Batman, with Michael Caine, Liam Neeson, Katie Holmes, Gary Oldman,",
                    Instructor = "Christopher Nolan",
                    ReleaseDate = new DateTime(2005, 06, 25),
                });
                
        }
    }
}


