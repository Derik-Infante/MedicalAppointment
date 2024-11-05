using MedicalAppointmentApp.Domain.Entities.System;
using MedicalAppointmentApp.Persistance.Interfaces.System;
using MedicalAppointmentApp.Persistance.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace MedicalAppointment.System.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationsController : ControllerBase
    {
        private readonly INotificationsRepository _notificationsRepository;

        public NotificationsController(INotificationsRepository NotificationsRepository) 
        {
            _notificationsRepository = NotificationsRepository;
        }
        // GET: api/<NotificationsController>
        [HttpGet("GetNotification")]
        public async Task<IActionResult> Get()
        {
            var result = await _notificationsRepository.GetAll();

            if (!result.Success)
                return BadRequest(result);

            return Ok(result);
        }

        // GET api/<NotificationsController>/5
        [HttpGet("GetNotificationByNotificationID")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _notificationsRepository.GetNotificationByNotificationID(id);

            if (!result.Success)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        // POST api/<NotificationsController>
        [HttpPost("SaveNotification")]
        public async Task<IActionResult> Post([FromBody] Notifications notification)
        {
            var result = await _notificationsRepository.Save(notification);

            if (!result.Success)
                return BadRequest(result);

            return Ok(result);
        }


        // PUT api/<NotificationsController>/5
        [HttpPut("ModifyNotification")]
        public async Task<IActionResult> Put([FromBody] Notifications notification)
        {
            var result = await _notificationsRepository.Update(notification);

            if (!result.Success)
                return BadRequest(result);

            return Ok(result);
        }


        // DELETE api/<NotificationsController>/5
        [HttpDelete("DisableNotification")]
        public async Task<IActionResult> DisableRuta(Notifications notification)
        {
            var result = await _notificationsRepository.Remove(notification);

            if (!result.Success)
                return BadRequest(result);

            return Ok(result);
        }
    }
}
