using MedicalAppointmentApp.Application.Contracts;
using MedicalAppointmentApp.Application.Dtos.System.Roles;
using MedicalAppointmentApp.Domain.Entities.System;
using MedicalAppointmentApp.Persistance.Models;
using Microsoft.AspNetCore.Mvc;

namespace MedicalAppointmentApp.Web.Controllers
{
    public class RolesController : Controller
    {
        private readonly IRolesService _rolesService;

        public RolesController(IRolesService rolesService)
        {
            _rolesService = rolesService;

        }

        public async Task<ActionResult> Index()
        {
            var result = await _rolesService.GetAll();

            if (result.IsSuccess && result.Data != null)
            {
                List<RoleModel> roleModel = ((List<Roles>)result.Data)
                    .Select(r => new RoleModel
                    {
                        RoleId = r.RoleID,
                        RoleName = r.RoleName,
                        CreatedAt = r.CreatedAt,
                        UpdatedAt = r.UpdatedAt,
                        IsActive = r.IsActive
                    })
                    .ToList();

                return View(roleModel);
            }

            return View(new List<RoleModel>());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(RolesSaveDto rolesSave)
        {
            try
            {
                rolesSave.RoleID = 1;
                rolesSave.CreatedAt = DateTime.Now;
                var result = await _rolesService.SaveAsync(rolesSave);

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