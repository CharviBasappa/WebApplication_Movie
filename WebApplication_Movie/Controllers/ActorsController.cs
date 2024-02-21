using Microsoft.AspNetCore.Mvc;
using WebApplication_Movie.Data;

namespace WebApplication_Movie.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDbContext _context;
        public ActorsController(AppDbContext context)
        {
                _context = context;
        }
        public IActionResult Index()
        {
            var data =_context.Actors.ToList();
            return View();
        }
    }
}
