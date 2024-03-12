using WebApplication_Movie.Data.Base;
using WebApplication_Movie.Models;

namespace WebApplication_Movie.Data.Services
{
    public interface ICinemasService : IEntityBaseRepository<Cinema>
    {

    }
    /*public interface ICinemasService
    {
        Task<IEnumerable<Cinema>> GetAllAsync();
        Task<Cinema> GetByIdAsync(int id);
        Task AddAsync(Cinema cinema);
        Task<Cinema> UpdateAsync(int id, Cinema newCinema);
        Task DeleteAsync(int id);
    }*/
}
