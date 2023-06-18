using GraphQLSampleAPI.Model;

namespace GraphQLSampleAPI.Data
{
    public class Query
    {
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Superhero> GetSuperheroes([Service] ApplicationDbContext context) =>
             context.Superheroes;
        public IQueryable<Superhero> GetSuperheroesName([Service] ApplicationDbContext context, string name) =>
            context.Superheroes.Where(x=>x.Name ==name);
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Superpower> GetSuperpowers([Service] ApplicationDbContext context) =>
           context.Superpowers;
    }
}
