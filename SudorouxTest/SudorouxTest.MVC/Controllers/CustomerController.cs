using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SudorouxTest.BL.IServices;
using SudorouxTest.MVC.Models;
using System.Threading.Tasks;

namespace SudorouxTest.MVC.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomHelpers _helper;
        private readonly IConfiguration _Configuration;


        public CustomerController(ICustomHelpers helper, IConfiguration configuration)
        {
            _helper = helper;
            _Configuration = configuration;
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(CustomerViewModel model)
        {
            if (ModelState.IsValid)
            {

                var stream = await  _helper.PostExternalApi(model, _Configuration["apiUrl"]);
                var fileName = "Customer.json";
                return File(stream, "application/json", fileName);
            }

            else
            {
                return View(model);
            }
        }
    }
}

    

