using Lab3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab3.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //get
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(FormModel model)
        {
            if (ModelState.IsValid && validateIterations(model.Iterations))
            {
                return View("Created", model);
            }
            return View(model);
        }
        private bool validateIterations(int iterations) => iterations <= 5 && iterations >= 1;
    }
}
