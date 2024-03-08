using WebApplication_Movie.Data.Base;
using WebApplication_Movie.Models;

namespace WebApplication_Movie.Data.Services
{
    public class ProducersService: EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context) : base(context)
        {
                
        }
    }
}
