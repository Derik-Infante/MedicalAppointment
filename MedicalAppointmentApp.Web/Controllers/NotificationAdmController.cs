using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Net.WebRequestMethods;

namespace MedicalAppointmentApp.Web.Controllers
{
    public class NotificationAdmController : Controller
    {
        public ActionResult Index()
        {
            string url = "http://localhost:5133/api/Notifications/GetNotification";

            return View();
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        
    }
}
