using GraphQLSampleAPI.Data;
using GraphQLSampleAPI.GraphQLInput;
using GraphQLSampleAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace GraphQLSampleAPI.Mutations
{
    public class Mutation
    {
        public async Task<Superhero> CreateHeroAsync([Service] ApplicationDbContext context, SuperheroInput newSuperHero)
        {
            Superhero superhero = new Superhero();
            superhero.Name = newSuperHero.Name;
            superhero.Description = newSuperHero.Description;
            superhero.Id = Guid.NewGuid();

            context.Superheroes.Add(superhero);
            await context.SaveChangesAsync();
            return superhero;
        }

        public async Task<Superhero> CreateHeroWithPowerAsync([Service] ApplicationDbContext context, SuperheroWithPowerInput newSuperHero)
        {
            Superhero superhero = new Superhero();
            superhero.Name = newSuperHero.Name;
            superhero.Description = newSuperHero.Description;
            superhero.Id = Guid.NewGuid();

            context.Superheroes.Add(superhero);
            Superpower superpower = new Superpower();
            superpower.Superhero = superhero;
            superpower.Id = Guid.NewGuid();
            superpower.SuperPower = newSuperHero.SuperpowerInput.SuperPower;
            superpower.Description = newSuperHero.SuperpowerInput.Description;
            context.Superpowers.Add(superpower);    
            await context.SaveChangesAsync();
            return superhero;
        }

        public async Task<Superhero?> UpdateHeroAsync([Service] ApplicationDbContext context, SuperheroUpdateInput newSuperHero)
        {
            if (Guid.TryParse(newSuperHero.Id, out Guid heroId))
            {
                var hero = await context.Superheroes.Where(x => x.Id == heroId).FirstOrDefaultAsync();
                hero.Name = newSuperHero.Name;
                hero.Description = newSuperHero.Description;    
                context.Update(hero);
                context.SaveChanges();
                return hero;
            }
            return null;
        }

        public async Task<bool> DeleteHeroAsync([Service] ApplicationDbContext context, string Id)
        {
            if (Guid.TryParse(Id, out Guid heroId))
            {
                var hero = await context.Superheroes.Where(x => x.Id == heroId).FirstOrDefaultAsync();
                context.Remove(hero);
                context.SaveChanges();
                return true;
            }
            return false;
        }
    }

   



}
