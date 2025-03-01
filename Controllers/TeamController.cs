using Microsoft.AspNetCore.Mvc;
using FootballViewer.Core.Repositories;
using FootballViewer.Core.Entities;

namespace FootballViewer.Core.Controllers
{
    public class TeamController : Controller
    {
        private readonly SportContext _Context;

        public TeamController(SportContext context)
        {
            _Context = context;
        }

        public IActionResult Index()
        {
            var teams = _Context.Matches.ToList();
            return View(teams);
        }
    }
}
