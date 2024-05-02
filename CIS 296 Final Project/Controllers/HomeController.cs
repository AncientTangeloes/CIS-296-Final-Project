using CIS_296_Final_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq;

namespace CharacterList.Controllers
{
    public class HomeController : Controller
    {
        private CharacterContext context { get; set; }

        public HomeController(CharacterContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index(int id)
        {
            var characters = context.Characters.Include(c => c.OgType).ToList();

            if (id == 1)
            {
                characters = context.Characters.Include(c => c.OgType).OrderBy(c => c.Name).ToList();
            }
            else if (id == 2) 
            {
                characters = context.Characters.Include(c => c.OgType).OrderBy(c => c.Origin).ToList();
            }
            else if (id == 3)
            {
                characters = context.Characters.Include(c => c.OgType).OrderBy(c => c.OgType).ToList();
            }
            else if (id == 4)
            {
                characters = context.Characters.Include(c => c.OgType).OrderBy(c => c.Year).ToList();
            }
            else
            {
                characters = context.Characters.Include(c => c.OgType).OrderBy(c => c.CharacterId).ToList();
            }

            return View(characters);
        }
    }
}
