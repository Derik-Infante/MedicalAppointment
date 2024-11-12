
using MedicalAppointmentApp.Application.Contracts;
using MedicalAppointmentApp.Application.Dtos.System.Notifications;
using MedicalAppointmentApp.Application.Responses.System.Notifications;
using MedicalAppointmentApp.Domain.Entities.System;
using MedicalAppointmentApp.Persistance.Interfaces.System;
using Microsoft.Extensions.Logging;

namespace MedicalAppointmentApp.Application.Services.System
{
    public class NotificationsService : INotificationsService
    {
        private readonly INotificationsRepository _notificationsRepository;
        private readonly ILogger<NotificationsService> _logger;

        public NotificationsService(INotificationsRepository notificationsRepository,
                          ILogger<NotificationsService> logger)
        {
            _notificationsRepository = notificationsRepository;
            _logger = logger;
        }
        public async Task<NotificationsResponse> GetAll()
        {
            NotificationsResponse notificationResponse = new NotificationsResponse();

            try
            {
                var result = await _notificationsRepository.GetAll();

                if (!result.Success)
                {
                    notificationResponse.Message = result.Message;
                    notificationResponse.IsSuccess = result.Success;
                    return notificationResponse;
                }

                notificationResponse.Data = result.Data;

            }
            catch (Exception ex)
            {

                notificationResponse.IsSuccess = false;
                notificationResponse.Message = "Error obteniendo las notificaciones";
                _logger.LogError(notificationResponse.Message, ex.ToString());

            }

            return notificationResponse;
        }

        public async Task<NotificationsResponse> GetById(int Id)
        {
            NotificationsResponse notificationResponse = new NotificationsResponse();

            try
            {
                var result = await _notificationsRepository.GetEntityBy(Id);

                if (!result.Success)
                {
                    notificationResponse.Message = result.Message;
                    notificationResponse.IsSuccess = result.Success;
                    return notificationResponse;
                }

                notificationResponse.Data = result.Data;

            }
            catch (Exception ex)
            {

                notificationResponse.IsSuccess = false;
                notificationResponse.Message = "Error obteniendo la notificación";
                _logger.LogError(notificationResponse.Message, ex.ToString());

            }

            return notificationResponse;
        }

        public async Task<NotificationsResponse> SaveAsync(NotificationsSaveDto dto)
        {
            NotificationsResponse notificationResponse = new NotificationsResponse();

            try
            {
                Notifications notification = new Notifications();
                
                notification.UserID = dto.UserID;
                notification.Message = dto.Message;
                notification.SentAt = dto.SentAt;


                var result = await _notificationsRepository.Save(notification);
                
                if (result.Success)
                {
                    notificationResponse.IsSuccess = true;
                    notificationResponse.Message = "Se guardó correctamente la notificación"; 
                }
                else
                {
                    notificationResponse.IsSuccess = false;
                    notificationResponse.Message = result.Message; 
                }
            }
            catch (Exception ex)
            {

                notificationResponse.IsSuccess = false;
                notificationResponse.Message = "Error guardando la notificación.";
                _logger.LogError(notificationResponse.Message, ex.ToString());
            }

            return notificationResponse;
        }

        public async Task<NotificationsResponse> UpdateAsync(NotificationsUpdateDto dto)
        {
            NotificationsResponse notificationResponse = new NotificationsResponse();

            try
            {
                var resultGetById = await _notificationsRepository.GetNotificationByNotificationID(dto.NotificationID);

                if (!resultGetById.Success)
                {
                    notificationResponse.IsSuccess = resultGetById.Success;
                    notificationResponse.Message = resultGetById.Message;
                    return notificationResponse;
                }


                if (resultGetById.Data == null)
                {
                    notificationResponse.IsSuccess = false;
                    notificationResponse.Message = "No se encontró la notificación";
                    return notificationResponse;
                }

                if (!(resultGetById.Data is Notifications notification))
                {
                    notificationResponse.IsSuccess = false;
                    notificationResponse.Message = "El tipo de datos es incorrecto.";
                    return notificationResponse;
                }

                notification.NotificationID = dto.NotificationID;
                notification.Message = dto.Message;
               

                var result = await _notificationsRepository.Update(notification);
                
                if (result.Success)
                {
                    notificationResponse.IsSuccess = true;
                    notificationResponse.Message = "La notificación fue actualizada correctamente."; 
                }
                else
                {
                    notificationResponse.IsSuccess = false;
                    notificationResponse.Message = result.Message; 
                }
            
            }
            catch (Exception ex)
            {

                notificationResponse.IsSuccess = false;
                notificationResponse.Message = "Error actualizando la notificación.";
                _logger.LogError(notificationResponse.Message, ex.ToString());
            }

            return notificationResponse;
        }
    }
}
