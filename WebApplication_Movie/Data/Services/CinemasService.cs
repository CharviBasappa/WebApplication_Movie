using Microsoft.EntityFrameworkCore;
using WebApplication_Movie.Data.Base;
using WebApplication_Movie.Models;

namespace WebApplication_Movie.Data.Services
{
    public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasService(AppDbContext context) : base(context)
        {

        }
    }

    /*public class CinemasService : ICinemasService
    {
        private readonly AppDbContext _context;
        public CinemasService(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Cinema cinema)
        {
            await _context.Cinemas.AddAsync(cinema);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Cinemas.FirstOrDefaultAsync(c => c.Id == id);
             _context.Cinemas.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Cinema>> GetAllAsync()
        {
            var result = await _context.Cinemas.ToListAsync();
            return result;
        }

        public async Task<Cinema> GetByIdAsync(int id)
        {
            var result = await _context.Cinemas.FirstOrDefaultAsync(c => c.Id == id);
            return result;
        }

        public async Task<Cinema> UpdateAsync(int id, Cinema newCinema)
        {
            _context.Update(newCinema);
            await _context.SaveChangesAsync(); 
            return newCinema;
        }*/
}
