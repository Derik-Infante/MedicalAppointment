using MedicalAppointmentApp.Domain.Entities.System;
using MedicalAppointmentApp.Persistance.Interfaces.System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MedicalAppointmentApp.Web.Controllers
{
    public class StatusController : Controller
    {
        private readonly IStatusRepository _statusRepository;

        public StatusController(IStatusRepository statusRepository)
        {
            _statusRepository = statusRepository;
        }

        // Listar todos los estados
        public async Task<IActionResult> Index()
        {
            var statuses = await _statusRepository.GetAllStatuses();
            return View(statuses); // Devuelve la lista de estados a la vista Index
        }

        // Crear un nuevo estado (formulario)
        public IActionResult Create()
        {
            return View(); // Devuelve la vista para crear un nuevo estado
        }

        // Guardar el estado creado
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Status status)
        {
            if (ModelState.IsValid)
            {
                var result = await _statusRepository.AddStatus(status);
                if (result.Success)
                {
                    return RedirectToAction(nameof(Index));
                }
                ModelState.AddModelError("", result.Message);
            }
            return View(status);
        }

        // Editar un estado (formulario)
        public async Task<IActionResult> Edit(int id)
        {
            var result = await _statusRepository.GetStatusByStatusID(id);
            if (result.Success)
            {
                return View(result.Data); // Devuelve la vista para editar el estado
            }
            return NotFound("Estado no encontrado.");
        }

        // Guardar los cambios del estado editado
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Status status)
        {
            if (ModelState.IsValid)
            {
                var result = await _statusRepository.UpdateStatus(status);
                if (result.Success)
                {
                    return RedirectToAction(nameof(Index));
                }
                ModelState.AddModelError("", result.Message);
            }
            return View(status);
        }

        // Eliminar un estado
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _statusRepository.GetStatusByStatusID(id);
            if (result.Success)
            {
                return View(result.Data); // Devuelve la vista de confirmación de eliminación
            }
            return NotFound("Estado no encontrado.");
        }

        // Confirmar eliminación
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var result = await _statusRepository.DeleteStatus(id);
            if (result.Success)
            {
                return RedirectToAction(nameof(Index));
            }
            ModelState.AddModelError("", result.Message);
            return RedirectToAction(nameof(Delete), new { id });
        }
    }
}
