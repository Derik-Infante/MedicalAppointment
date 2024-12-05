using MedicalAppointmentApp.Application.Dtos.System.Roles;
using MedicalAppointmentApp.Persistance.Models;
using MedicalAppointmentApp.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

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
                    ViewBag.Message = "Error fetching data.";
                }
            }

            return View(rolesGetAllResultModel?.data ?? new List<RoleModel>());

        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(RolesSaveDto rolesSaveDto)
        {
            BaseApiResponseModel model = new BaseApiResponseModel();

            try
            {
                string url = "http://localhost:5133/api/";

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(url);


                    var responseTask = await client.PostAsJsonAsync<RolesSaveDto>("Roles/SaveRole", rolesSaveDto);

                    if (responseTask.IsSuccessStatusCode)
                    {
                        string response = await responseTask.Content.ReadAsStringAsync();

                        model = JsonConvert.DeserializeObject<BaseApiResponseModel>(response);


                        if (!model.success)
                        {
                            ViewBag.Message = model.message;
                            return View();

                        }
                        else
                        {

                            return RedirectToAction(nameof(Index));
                        }
                    }
                    else
                    {
                        string response = await responseTask.Content.ReadAsStringAsync();
                        model = JsonConvert.DeserializeObject<BaseApiResponseModel>(response);

                        ViewBag.Message = model.message;
                        return View();
                    }


                }

            }
            catch
            {
                return View();
            }
        }

        public async Task<ActionResult> Edit(int id)
        {
            string url = "http://localhost:5133/api/";

            RoleGetByIdModel? roleGetByIdModel = new RoleGetByIdModel();

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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task <IActionResult> Edit(RolesUpdateDto rolesUpdateDto)
        {
            BaseApiResponseModel model = new BaseApiResponseModel();

            try
            {
                string url = "http://localhost:5133/api/";

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(url);


                    var responseTask = await client.PutAsJsonAsync<RolesUpdateDto>("Roles/ModifyRole", rolesUpdateDto);

                    if (responseTask.IsSuccessStatusCode)
                    {
                        string response = await responseTask.Content.ReadAsStringAsync();

                        model = JsonConvert.DeserializeObject<BaseApiResponseModel>(response);


                        if (!model.success)
                        {
                            ViewBag.Message = model.message;
                            return View();

                        }
                        else
                        {

                            return RedirectToAction(nameof(Index));
                        }
                    }
                    else
                    {
                        string response = await responseTask.Content.ReadAsStringAsync();
                        model = JsonConvert.DeserializeObject<BaseApiResponseModel>(response);

                        ViewBag.Message = model.message;
                        return View();
                    }


                }
            }
            catch
            {
                return View();
            }
        }

    }
}


