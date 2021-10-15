using Microsoft.AspNetCore.Mvc;
using SudorouxTest.MVC.Models;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SudorouxTest.MVC.Controllers
{
    public class CustomerController : Controller
    {
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
                string apiUrl = "https://localhost:44328/api/customers";

                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Clear();
                    var json = Newtonsoft.Json.JsonConvert.SerializeObject(model);
                    var content = new StringContent(json, Encoding.UTF8, "application/json"); ;

                    HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        var data = await response.Content.ReadAsStringAsync();
                        var fileName = "customer.json";

                        var bytes= Encoding.UTF8.GetBytes(data);

                        var stream = new System.IO.MemoryStream(bytes);
                        return File(stream, "application/json", fileName);
                    }

                }
                return View(ModelState);
            }
            else
            {
                return View(model);
            }
        }

    }
}
