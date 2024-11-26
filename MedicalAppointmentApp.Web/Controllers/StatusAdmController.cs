using MedicalAppointmentApp.Application.Dtos.System.Notifications;
using MedicalAppointmentApp.Application.Dtos.System.Status;
using MedicalAppointmentApp.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MedicalAppointmentApp.Web.Controllers
{
    public class StatusAdmController : Controller
    {
        public async Task<IActionResult> Index()
        {
            string url = "http://localhost:5133/api/";

            StatusGetAllResultModel? statusGetAllResultModel = new StatusGetAllResultModel();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);

                var responseTask = await client.GetAsync("Status/GetStatus");

                if (responseTask.IsSuccessStatusCode)
                {
                    string response = await responseTask.Content.ReadAsStringAsync();

                    statusGetAllResultModel = JsonConvert.DeserializeObject<StatusGetAllResultModel>(response);

                }
                else
                {
                    ViewBag.Message = "";
                }
            }

            return View();
        }


        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(StatusSaveDto statusSave)
        {
            BaseApiResponseModel? model = new BaseApiResponseModel();

            try
            {
                string url = "http://localhost:5133/api/";

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(url);


                    var responseTask = await client.PostAsJsonAsync<StatusSaveDto>("Status/SaveStatus", statusSave);

                    if (responseTask.IsSuccessStatusCode)
                    {
                        string response = await responseTask.Content.ReadAsStringAsync();

                        model = JsonConvert.DeserializeObject<BaseApiResponseModel>(response);


                        if (!model.success)
                        {
                            ViewBag.Message = model.message;
                            return View();

                        }
                        else
                        {

                            return RedirectToAction(nameof(Index));
                        }
                    }
                    else
                    {
                        string response = await responseTask.Content.ReadAsStringAsync();
                        model = JsonConvert.DeserializeObject<BaseApiResponseModel>(response);

                        ViewBag.Message = model.message;
                        return View();
                    }


                }

            }
            catch
            {
                return View();
            }
        }

    }
}
