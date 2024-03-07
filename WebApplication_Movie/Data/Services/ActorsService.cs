using Microsoft.EntityFrameworkCore;
using WebApplication_Movie.Data.Base;
using WebApplication_Movie.Models;

namespace WebApplication_Movie.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        /*private readonly AppDbContext _context;*/
        public ActorsService(AppDbContext context) : base(context) { }
        /*{
            _context = context;
        }*/

        /*public async Task AddAsync (Actor actor)
        {
            await _context.Actors.AddAsync(actor);
            await _context.SaveChangesAsync();
            *//*throw new NotImplementedException();*//*
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(n => n.Id == id);
            _context.Actors.Remove(result);
            await _context.SaveChangesAsync();
            *//*throw new NotImplementedException();*//*
        }

        //Moved to EntityBaseRepository.cs

        *//*public async Task<IEnumerable<Actor>> GetAllAsync()
        {
            var result = await _context.Actors.ToListAsync();
            return result;
        }

        public async Task<Actor> GetByIdAsync(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(n => n.Id == id);
            return result;
            *//*throw new NotImplementedException();*//*
        }*//*

        public async Task<Actor> UpdateAsync(int id, Actor newActor)
        {
            _context.Update(newActor);
            await _context.SaveChangesAsync();
            return newActor;
            *//*throw new NotImplementedException();*//*
        }*/
    }
}
