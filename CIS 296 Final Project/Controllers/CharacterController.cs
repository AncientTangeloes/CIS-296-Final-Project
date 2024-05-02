using Microsoft.AspNetCore.Mvc;
using CIS_296_Final_Project.Models;

namespace CIS_296_Final_Project.Controllers
{
    public class CharacterController : Controller
    {
        private CharacterContext context { get; set; }

        public CharacterController(CharacterContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.OgTypes = context.OgTypes.OrderBy(g => g.Name).ToList();
            return View("Edit", new Character());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.OgTypes = context.OgTypes.OrderBy(g => g.Name).ToList();
            var character = context.Characters.Find(id);
            return View("Edit", character);
        }

        [HttpPost]
        public IActionResult Edit(Character character)
        {
            if (ModelState.IsValid)
            {
                if (character.CharacterId == 0)
                {
                    context.Characters.Add(character);
                }
                else
                {
                    context.Characters.Update(character);
                }
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (character.CharacterId == 0) ? "Add" : "Edit";
                ViewBag.OgTypes = context.OgTypes.OrderBy(g => g.Name).ToList();
                return View(character);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var character = context.Characters.Find(id);
            return View(character);
        }

        [HttpPost]
        public IActionResult Delete(Character character)
        {
            context.Characters.Remove(character);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
