using API.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace paidLeave_WebApp.Controllers
{
    public class CutiPanelController : Controller
    {
        HttpClient httpClient;
        string address;

        public CutiPanelController()
        {
            this.address = "https://localhost:44325/api/Account/";
            httpClient = new HttpClient
            {
                BaseAddress = new Uri(address)
            };

        }

        public IActionResult CutiPanel()
        {
            return View();
        }

        public async Task<IActionResult> CutiPanel(CutiPanel cutiPanel)
        {
            StringContent content = new StringContent(JsonConvert.SerializeObject(cutiPanel), Encoding.UTF8, "application/json");
            var resultCuti = httpClient.PostAsync(address, content).Result;
            if (resultCuti.IsSuccessStatusCode)
            {
                var data = JsonConvert.DeserializeObject<ResponseClient>(await resultCuti.Content.ReadAsStringAsync());
                HttpContext.Session.SetString("Cuti", data.dataCuti.FullName);
                return RedirectToAction("CutiPanel", "CutiPanel");
            }
            return View();
        }
    }
}
