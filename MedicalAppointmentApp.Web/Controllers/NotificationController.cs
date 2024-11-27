using MedicalAppointmentApp.Application.Contracts;
using MedicalAppointmentApp.Application.Dtos.System.Notifications;
using MedicalAppointmentApp.Domain.Entities.System;
using MedicalAppointmentApp.Persistance.Models;
using Microsoft.AspNetCore.Mvc;

namespace Front_end.Controllers
{
    public class NotificationsController : Controller
    {
        private readonly INotificationsService _notificationService;

        public NotificationsController(INotificationsService notificationService)
        {
            _notificationService = notificationService;

        }
        public async Task<IActionResult> Index()
        {
            var result = await _notificationService.GetAll();

            if (result.IsSuccess && result.Data != null)
            {
                List<NotificationModel> notificationModel = ((List<Notifications>)result.Data)
                     .Select(n => new NotificationModel
                     {
                         NotificationId = n.NotificationID,  
                         UserId = n.UserID,                  
                         Message = n.Message,                
                         SentAt = n.SentAt                     
                     })
                     .ToList();

                return View(notificationModel);
            }

            return View(new List<NotificationModel>());

        }


        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(NotificationsSaveDto notificationsSave)
        {
            try
            {
                notificationsSave.SentAt = DateTime.Now;
                notificationsSave.NotificationID = 1;
                var result = await _notificationService.SaveAsync(notificationsSave);

                if (result.IsSuccess)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ViewBag.Message = result.Message;
                    return View();
                }

            }
            catch
            {
                return View();
            }
        }

    }
}