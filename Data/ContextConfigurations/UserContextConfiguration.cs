using GraphQLSampleAPI.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQLSampleAPI.Data.ContextConfigurations
{
    public class UserContextConfiguration : IEntityTypeConfiguration<User>
    {
        private Guid[] _ids;

        public UserContextConfiguration(Guid[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<User> builder)
        {
            throw new NotImplementedException();
        }
    }
}
