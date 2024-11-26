﻿using MedicalAppointmentApp.Application.Contracts;
using MedicalAppointmentApp.Application.Dtos.System.Roles;
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
                List<RoleModel> roleModel = (List<RoleModel>)result.Data;
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


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id)
        {
            var result = await _rolesService.GetById(id);

            if (result.IsSuccess)
            {
                RoleModel roleModel = (RoleModel)result.Data;

                return View(roleModel);
            }

            return View();
        }

        
    }
}
