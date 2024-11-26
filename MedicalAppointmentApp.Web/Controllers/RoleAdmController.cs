using MedicalAppointmentApp.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;

namespace MedicalAppointmentApp.Web.Controllers
{
    public class RoleAdmController : Controller
    {
        public async Task<IActionResult> Index()
        {
            string url = "http://localhost:5133/api/";

            RolesGetAllResultModel? rolesGetAllResultModel = new RolesGetAllResultModel();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);

                var responseTask = await client.GetAsync("Roles/GetRol");

                if (responseTask.IsSuccessStatusCode)
                {
                    string response = await responseTask.Content.ReadAsStringAsync();

                    rolesGetAllResultModel = JsonConvert.DeserializeObject<RolesGetAllResultModel>(response);

                }
                else
                {
                    ViewBag.Message = "";
                }

                return View();
            }

        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(IFormCollection collection)
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
        public async Task <IActionResult> Edit(int id, IFormCollection collection)
        {
            string url = "http://localhost:5133/api/";

            RoleGetByIdModel roleGetByIdModel = new RoleGetByIdModel();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);

                var responseTask = await client.GetAsync($"Roles/GetRoleByRoleID?id={id}");

                if (responseTask.IsSuccessStatusCode)
                {
                    string response = await responseTask.Content.ReadAsStringAsync();
                    roleGetByIdModel = JsonConvert.DeserializeObject<RoleGetByIdModel>(response);

                }
            }

            return View(roleGetByIdModel.data);
        }

    }
}


