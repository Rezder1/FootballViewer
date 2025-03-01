using Microsoft.AspNetCore.Mvc;
using FootballViewer.Core.Repositories;
using FootballViewer.Core.Entities;

namespace FootballViewer.Core.Controllers
{
    public class PlayerController : Controller
    {
        private readonly SportContext _Context;

        public PlayerController(SportContext context)
        {
            _Context = context;
        }

        public IActionResult Index()
        {
            var players = _Context.Matches.ToList();
            return View(players);
        }
    }
}
