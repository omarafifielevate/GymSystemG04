using GymSystemG04.AppDbContexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace GymSystemG04.Controllers
{
    public class PlansController : Controller
    {
        private readonly GymDbContext _dbContext;

        public PlansController()
        {
            _dbContext = new GymDbContext();
        }

        public async Task<IActionResult> Index()
        {
            var plans = await _dbContext.Plans.ToListAsync();

            return View(plans);
        }

        public async Task<IActionResult> Details(int id)
        {
            var plan = await _dbContext.Plans.FindAsync(id);

            if(plan == null)
                return RedirectToAction(nameof(Index));

            return View(plan);
        }
    }
}
