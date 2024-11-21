

using MedicalAppointmentApp.Domain.Entities.System;
using MedicalAppointmentApp.Persistance.Interfaces.System;
using Microsoft.AspNetCore.Mvc;

namespace MedicalAppointmentApp.Web.Controllers
{
    public class NotificationController : Controller
    {
        private readonly INotificationsRepository _notificationsRepository;

        public NotificationController(INotificationsRepository notificationsRepository)
        {
            _notificationsRepository = notificationsRepository;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _notificationsRepository.GetAll();
            if (result.Success)
            {
                return View(result.Data); 
            }
            ModelState.AddModelError("", result.Message ?? "Error al cargar las notificaciones.");
            return View(new List<Notifications>());
        }

        public IActionResult Create()
        {
            return View(); 
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Notifications notification)
        {
            if (ModelState.IsValid)
            {
                var result = await _notificationsRepository.AddNotification(notification);
                if (result.Success)
                {
                    return RedirectToAction(nameof(Index));
                }
                ModelState.AddModelError("", result.Message);
            }
            return View(notification);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var result = await _notificationsRepository.GetNotificationByNotificationID(id);
            if (result.Success)
            {
                return View(result.Data); 
            }
            return NotFound("Notificación no encontrada.");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Notifications notification)
        {
            if (ModelState.IsValid)
            {
                var result = await _notificationsRepository.Update(notification);
                if (result.Success)
                {
                    return RedirectToAction(nameof(Index));
                }
                ModelState.AddModelError("", result.Message);
            }
            return View(notification);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var result = await _notificationsRepository.GetNotificationByNotificationID(id);
            if (result.Success)
            {
                return View(result.Data); 
            }
            return NotFound("Notificación no encontrada.");
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var result = await _notificationsRepository.DeleteNotification(id);
            if (result.Success)
            {
                return RedirectToAction(nameof(Index));
            }
            ModelState.AddModelError("", result.Message);
            return RedirectToAction(nameof(Delete), new { id });
        }
    }

}
