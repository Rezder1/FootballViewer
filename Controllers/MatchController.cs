using Microsoft.AspNetCore.Mvc;
using FootballViewer.Core.Repositories;
using FootballViewer.Core.Entities;

namespace FootballViewer.Core.Controllers
{
    public class MatchController : Controller
    {
        private readonly SportContext _Context;

        public MatchController(SportContext context)
        {
            _Context = context;
        }

        public IActionResult Index()
        {
            var matchs = _Context.Matches.ToList();
            return View(matchs);
        }
    }
}
