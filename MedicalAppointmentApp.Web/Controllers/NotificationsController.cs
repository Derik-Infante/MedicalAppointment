using MedicalAppointmentApp.Application.Contracts;
using MedicalAppointmentApp.Persistance.Models;
using Microsoft.AspNetCore.Mvc;

namespace MedicalAppointmentApp.Web.Controllers
{
    [Route("Notifications")]
    public class NotificationsController : Controller
    {
        private readonly INotificationsService _notificationService;

        public NotificationsController(INotificationsService notificationService)
        {
            _notificationService = notificationService;
            
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await _notificationService.GetAll();

            if (!result.IsSuccess)
            {
                List<NotificationModel> notificationModel = (List<NotificationModel>)result.Data;

                return View(notificationModel);
            }

            return View();

        }








        [HttpGet("Details/{id}")]
        public ActionResult Details(int id)
        {
            return View();
        }

        [HttpGet("Create")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        
    }
}
