using Microsoft.AspNetCore.Mvc;
using FootballViewer.Core.Repositories;
using FootballViewer.Core.Entities;

namespace FootballViewer.Core.Controllers
{
    public class CountryController : Controller
    {
        private readonly SportContext _Context;

        public CountryController(SportContext context)
        {  
            _Context = context; 
        }

        public IActionResult Index()
        {
            var namecountry = _Context.Countries.ToList();
            return View(namecountry);
        }
    }
}
