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
                characters = context.Characters.Include(c => c.OgType).OrderBy(c => c.OgType.Name).ToList();
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

        public IActionResult Anime(int id)
        {
            var characters = context.Characters.Include(c => c.OgType).Where(c => c.OgType.OgTypeId == "A").ToList();

            if (id == 1)
            {
                characters = context.Characters.Include(c => c.OgType).OrderBy(c => c.Name).Where(c => c.OgType.OgTypeId == "A").ToList();
            }
            else if (id == 2)
            {
                characters = context.Characters.Include(c => c.OgType).OrderBy(c => c.Origin).Where(c => c.OgType.OgTypeId == "A").ToList();
            }
            else if (id == 3)
            {
                characters = context.Characters.Include(c => c.OgType).OrderBy(c => c.Year).Where(c => c.OgType.OgTypeId == "A").ToList();
            }
            else
            {
                characters = context.Characters.Include(c => c.OgType).OrderBy(c => c.CharacterId).Where(c => c.OgType.OgTypeId == "A").ToList();
            }

            return View(characters);
        }

        public IActionResult Comic(int id)
        {
            var characters = context.Characters.Include(c => c.OgType).Where(c => c.OgType.OgTypeId == "C").ToList();

            if (id == 1)
            {
                characters = context.Characters.Include(c => c.OgType).OrderBy(c => c.Name).Where(c => c.OgType.OgTypeId == "C").ToList();
            }
            else if (id == 2)
            {
                characters = context.Characters.Include(c => c.OgType).OrderBy(c => c.Origin).Where(c => c.OgType.OgTypeId == "C").ToList();
            }
            else if (id == 3)
            {
                characters = context.Characters.Include(c => c.OgType).OrderBy(c => c.Year).Where(c => c.OgType.OgTypeId == "C").ToList();
            }
            else
            {
                characters = context.Characters.Include(c => c.OgType).OrderBy(c => c.CharacterId).Where(c => c.OgType.OgTypeId == "C").ToList();
            }

            return View(characters);
        }

        public IActionResult Movie(int id)
        {
            var characters = context.Characters.Include(c => c.OgType).Where(c => c.OgType.OgTypeId == "F").ToList();

            if (id == 1)
            {
                characters = context.Characters.Include(c => c.OgType).OrderBy(c => c.Name).Where(c => c.OgType.OgTypeId == "F").ToList();
            }
            else if (id == 2)
            {
                characters = context.Characters.Include(c => c.OgType).OrderBy(c => c.Origin).Where(c => c.OgType.OgTypeId == "F").ToList();
            }
            else if (id == 3)
            {
                characters = context.Characters.Include(c => c.OgType).OrderBy(c => c.Year).Where(c => c.OgType.OgTypeId == "F").ToList();
            }
            else
            {
                characters = context.Characters.Include(c => c.OgType).OrderBy(c => c.CharacterId).Where(c => c.OgType.OgTypeId == "F").ToList();
            }

            return View(characters);
        }

        public IActionResult Game(int id)
        {
            var characters = context.Characters.Include(c => c.OgType).Where(c => c.OgType.OgTypeId == "G").ToList();

            if (id == 1)
            {
                characters = context.Characters.Include(c => c.OgType).OrderBy(c => c.Name).Where(c => c.OgType.OgTypeId == "G").ToList();
            }
            else if (id == 2)
            {
                characters = context.Characters.Include(c => c.OgType).OrderBy(c => c.Origin).Where(c => c.OgType.OgTypeId == "G").ToList();
            }
            else if (id == 3)
            {
                characters = context.Characters.Include(c => c.OgType).OrderBy(c => c.Year).Where(c => c.OgType.OgTypeId == "G").ToList();
            }
            else
            {
                characters = context.Characters.Include(c => c.OgType).OrderBy(c => c.CharacterId).Where(c => c.OgType.OgTypeId == "G").ToList();
            }

            return View(characters);
        }

        public IActionResult Manga(int id)
        {
            var characters = context.Characters.Include(c => c.OgType).Where(c => c.OgType.OgTypeId == "M").ToList();

            if (id == 1)
            {
                characters = context.Characters.Include(c => c.OgType).OrderBy(c => c.Name).Where(c => c.OgType.OgTypeId == "M").ToList();
            }
            else if (id == 2)
            {
                characters = context.Characters.Include(c => c.OgType).OrderBy(c => c.Origin).Where(c => c.OgType.OgTypeId == "M").ToList();
            }
            else if (id == 3)
            {
                characters = context.Characters.Include(c => c.OgType).OrderBy(c => c.Year).Where(c => c.OgType.OgTypeId == "M").ToList();
            }
            else
            {
                characters = context.Characters.Include(c => c.OgType).OrderBy(c => c.CharacterId).Where(c => c.OgType.OgTypeId == "M").ToList();
            }

            return View(characters);
        }

        public IActionResult Cartoon(int id)
        {
            var characters = context.Characters.Include(c => c.OgType).Where(c => c.OgType.OgTypeId == "S").ToList();

            if (id == 1)
            {
                characters = context.Characters.Include(c => c.OgType).OrderBy(c => c.Name).Where(c => c.OgType.OgTypeId == "S").ToList();
            }
            else if (id == 2)
            {
                characters = context.Characters.Include(c => c.OgType).OrderBy(c => c.Origin).Where(c => c.OgType.OgTypeId == "S").ToList();
            }
            else if (id == 3)
            {
                characters = context.Characters.Include(c => c.OgType).OrderBy(c => c.Year).Where(c => c.OgType.OgTypeId == "S").ToList();
            }
            else
            {
                characters = context.Characters.Include(c => c.OgType).OrderBy(c => c.CharacterId).Where(c => c.OgType.OgTypeId == "S").ToList();
            }

            return View(characters);
        }
    }
}
