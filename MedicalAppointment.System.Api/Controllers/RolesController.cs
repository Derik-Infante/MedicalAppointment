using MedicalAppointmentApp.Domain.Entities.System;
using MedicalAppointmentApp.Persistance.Interfaces.System;
using Microsoft.AspNetCore.Mvc;

namespace MedicalAppointment.System.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly IRolesRepository _rolesRepository;

        public RolesController(IRolesRepository rolesRepository)
        {
            _rolesRepository = rolesRepository;
        }
        // GET: api/<RolesController>
        [HttpGet("GetRol")]
        public async Task<IActionResult> Get()
        {
            var result = await _rolesRepository.GetAll();

            if (!result.Success)
                return BadRequest(result);

            return Ok(result);
        }

        // GET api/<RolesController>/5
        [HttpGet("GetRoleByRoleID")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _rolesRepository.GetRoleByRoleID(id);

            if (!result.Success)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        // POST api/<RolesController>
        [HttpPost("SaveRole")]
        public async Task<IActionResult> Post([FromBody] Roles rol)
        {
            var result = await _rolesRepository.Save(rol);

            if (!result.Success)
                return BadRequest(result);

            return Ok(result);
        }

        // PUT api/<RolesController>/5
        [HttpPut("ModifyRole")]
        public async Task<IActionResult> Put([FromBody] Roles rol)
        {
            var result = await _rolesRepository.Update(rol);

            if (!result.Success)
                return BadRequest(result);

            return Ok(result);
        }

        // DELETE api/<RolesController>/5
        [HttpDelete("DisableRole")]
        public async Task<IActionResult> DisableRuta(Roles rol)
        {
            var result = await _rolesRepository.Remove(rol);

            if (!result.Success)
                return BadRequest(result);

            return Ok(result);
        }
    }
}
