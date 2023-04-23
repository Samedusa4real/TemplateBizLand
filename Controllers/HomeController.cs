using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TemplateBizLand.DataAccess;
using TemplateBizLand.ViewModel;

namespace TemplateBizLand.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _context;

        public HomeController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeViewModel model = new HomeViewModel();
            model.features = _context.Features.ToList();
            model.teamMembers = _context.TeamMembers.ToList();
            model.pricing = _context.Pricing.ToList();
            return View(model);
        }
    }
}
