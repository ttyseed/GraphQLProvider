using GraphQLSampleAPI.Data;
using GraphQLSampleAPI.Interfaces;

namespace GraphQLSampleAPI.Repositories
{
    public class SuperpowerRepository : ISuperpowerRepository
    {
        private readonly ApplicationDbContext _appDbContext;

        public SuperpowerRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }
}
