using MedicalAppointmentApp.Application.Contracts;
using MedicalAppointmentApp.Application.Dtos.System.Status;
using MedicalAppointmentApp.Domain.Entities.System;
using MedicalAppointmentApp.Persistance.Models;
using Microsoft.AspNetCore.Mvc;

namespace MedicalAppointmentApp.Web.Controllers
{
    public class StatusController : Controller
    {
        private readonly IStatusService _statusService;

        public StatusController(IStatusService statusService)
        {
            _statusService = statusService;

        }
        public async Task<ActionResult>Index()
        {
            var result = await _statusService.GetAll();

            if (result.IsSuccess && result.Data != null)
            {
                List<StatusModel> statusModel = ((List<Status>)result.Data)
                    .Select(s => new StatusModel
                    {
                        StatusId = s.statusID,  
                        StatusName = s.statusName ?? string.Empty  
                    })
                    .ToList();

                return View(statusModel);
            }

            return View(new List<StatusModel>());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(StatusSaveDto statusSave)
        {
            try
            {
                statusSave.statusID = 1;
                var result = await _statusService.SaveAsync(statusSave);

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
