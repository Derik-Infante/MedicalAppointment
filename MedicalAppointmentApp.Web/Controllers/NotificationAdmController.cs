using MedicalAppointmentApp.Application.Dtos.System.Notifications;
using MedicalAppointmentApp.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MedicalAppointmentApp.Web.Controllers
{
    public class NotificationAdmController : Controller
    {

        public async Task<IActionResult> Index()
        {
            string url = "http://localhost:5133/api/";

            NotificationGetAllResultModel? notificationGetAllResultModel = new NotificationGetAllResultModel();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);

                var responseTask = await client.GetAsync("Notifications/GetNotification");

                if (responseTask.IsSuccessStatusCode)
                {
                    string response = await responseTask.Content.ReadAsStringAsync();

                    notificationGetAllResultModel = JsonConvert.DeserializeObject<NotificationGetAllResultModel>(response);

                }
                else
                {
                    ViewBag.Message = "";
                }
            }

            return View();
        }

        public async Task<IActionResult> Details(int id)
        {
            string url = "http://localhost:5133/api/";

            NotificationGetAllResultModel? notificationGetAllResultModel = new NotificationGetAllResultModel();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);

                var responseTask = await client.GetAsync($"Notifications/GetNotificationByNotificationID?id={id}");

                if (responseTask.IsSuccessStatusCode)
                {
                    string response = await responseTask.Content.ReadAsStringAsync();

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
        public async Task<IActionResult> Create(NotificationsSaveDto notificationsSave)
        {
            BaseApiResponseModel? model = new BaseApiResponseModel();

            try
            {
                string url = "http://localhost:5133/api/";

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(url);


                    var responseTask = await client.PostAsJsonAsync<NotificationsSaveDto>("Notifications/SaveNotification", notificationsSave);

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
