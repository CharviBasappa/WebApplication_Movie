using WebApplication_Movie.Data.Base;
using WebApplication_Movie.Models;

namespace WebApplication_Movie.Data.Services
{
    public interface IActorsService: IEntityBaseRepository<Actor>
    {
        /*Task<IEnumerable<Actor>> GetAllAsync();
        Task<Actor> GetByIdAsync(int id);
        Task AddAsync(Actor actor);
        Task<Actor> UpdateAsync(int id, Actor newActor);
        Task DeleteAsync(int id);*/
    }
}
