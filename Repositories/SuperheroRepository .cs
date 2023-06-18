using GraphQLSampleAPI.Data;
using GraphQLSampleAPI.Interfaces;
using GraphQLSampleAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace GraphQLSampleAPI.Repositories
{
    public class SuperheroRepository : ISuperheroRepository
    {
        private readonly ApplicationDbContext _appDbContext;

        public SuperheroRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }
}
