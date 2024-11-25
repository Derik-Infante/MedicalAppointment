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

                var responseTask = await client.GetAsync("Notifications / GetNotification");

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

                var responseTask = await client.GetAsync($"");

                if (responseTask.IsSuccessStatusCode)
                {
                    string response = await responseTask.Content.ReadAsStringAsync();

                }
            }

            return View();
        }


    }
}
