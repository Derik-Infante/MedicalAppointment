using MedicalAppointmentApp.Domain.Entities.System;
using MedicalAppointmentApp.Persistance.Interfaces.System;
using Microsoft.AspNetCore.Mvc;

namespace MedicalAppointmentApp.Web.Controllers
{
    public class RolesController : Controller
    {
        private readonly IRolesRepository _rolesRepository;

        public RolesController(IRolesRepository rolesRepository)
        {
            _rolesRepository = rolesRepository;
        }

        public async Task<IActionResult> Index()
        {
            var roles = await _rolesRepository.GetAllRoles();
            return View(roles); 
        }

        public IActionResult Create()
        {
            return View(); 
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Roles role)
        {
            if (ModelState.IsValid)
            {
                var result = await _rolesRepository.AddRole(role);
                if (result.Success)
                {
                    return RedirectToAction(nameof(Index));
                }
                ModelState.AddModelError("", result.Message);
            }
            return View(role);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var result = await _rolesRepository.GetRoleByRoleID(id);
            if (result.Success)
            {
                return View(result.Data); 
            }
            return NotFound("Rol no encontrado.");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Roles role)
        {
            if (ModelState.IsValid)
            {
                var result = await _rolesRepository.UpdateRole(role);
                if (result.Success)
                {
                    return RedirectToAction(nameof(Index));
                }
                ModelState.AddModelError("", result.Message);
            }
            return View(role);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var result = await _rolesRepository.GetRoleByRoleID(id);
            if (result.Success)
            {
                return View(result.Data); 
            }
            return NotFound("Rol no encontrado.");
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var result = await _rolesRepository.DeleteRole(id);
            if (result.Success)
            {
                return RedirectToAction(nameof(Index));
            }
            ModelState.AddModelError("", result.Message);
            return RedirectToAction(nameof(Delete), new { id });
        }
    }
}
