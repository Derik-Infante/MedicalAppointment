using MedicalAppointmentApp.Domain.Entities.System;
using MedicalAppointmentApp.Persistance.Interfaces.System;
using MedicalAppointmentApp.Persistance.Repositories;
using Microsoft.AspNetCore.Mvc;


namespace MedicalAppointment.System.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        private readonly IStatusRepository _statusRepository;
        public StatusController(IStatusRepository statusRepository)
        {
            _statusRepository = statusRepository;
        }
        // GET: api/<StatusController>
        [HttpGet("GetStatus")]
        public async Task<IActionResult> Get()
        {
            var result = await _statusRepository.GetAll();

            if (!result.Success)
                return BadRequest(result);

            return Ok(result);
        }

        // GET api/<StatusController>/5
        [HttpGet("GetStatusByStatusID")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _statusRepository.GetStatusByStatusID(id);

            if (!result.Success)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        // POST api/<StatusController>
        [HttpPost("SaveStatus")]
        public async Task<IActionResult> Post([FromBody] Status status)
        {
            var result = await _statusRepository.Save(status);

            if (!result.Success)
                return BadRequest(result);

            return Ok(result);
        }

        // PUT api/<StatusController>/5
        [HttpPut("ModifyStatus")]
        public async Task<IActionResult> Put([FromBody] Status status) 
        { 
            var result = await _statusRepository.Update(status);

            if (!result.Success)
                return BadRequest(result);

            return Ok(result);
        }

        // DELETE api/<StatusController>/5
        [HttpDelete("DisableStatus")]
        public async Task<IActionResult> DisableRuta(Status status)
        {
            var result = await _statusRepository.Remove(status);

            if (!result.Success)
                return BadRequest(result);

            return Ok(result);
        }
    }
}
