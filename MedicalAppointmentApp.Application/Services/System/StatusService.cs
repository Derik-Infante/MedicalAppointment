
using MedicalAppointmentApp.Application.Contracts;
using MedicalAppointmentApp.Application.Dtos.System.Status;
using MedicalAppointmentApp.Application.Responses.System.Status;
using MedicalAppointmentApp.Domain.Entities.System;
using MedicalAppointmentApp.Persistance.Interfaces.System;
using Microsoft.Extensions.Logging;

namespace MedicalAppointmentApp.Application.Services.System
{
    public class StatusService : IStatusService
    {
        private readonly IStatusRepository _statusRepository;
        private readonly ILogger<StatusService> _logger;

        public StatusService(IStatusRepository statusRepository,
                          ILogger<StatusService> logger)
        {
            _statusRepository = statusRepository;
            _logger = logger;
        }
        public async Task<StatusResponse> GetAll()
        {
            StatusResponse statusResponse = new StatusResponse();

            try
            {
                var result = await _statusRepository.GetAll();

                if (!result.Success)
                {
                    statusResponse.Message = result.Message;
                    statusResponse.IsSuccess = result.Success;
                    return statusResponse;
                }

                statusResponse.Data = result.Data;

            }
            catch (Exception ex)
            {

                statusResponse.IsSuccess = false;
                statusResponse.Message = "Error obteniendo el status";
                _logger.LogError(statusResponse.Message, ex.ToString());

            }

            return statusResponse;
        }

        public async Task<StatusResponse> GetById(int Id)
        {
            StatusResponse statusResponse = new StatusResponse();

            try
            {
                var result = await _statusRepository.GetEntityBy(Id);

                if (!result.Success)
                {
                    statusResponse.Message = result.Message;
                    statusResponse.IsSuccess = result.Success;
                    return statusResponse;
                }

                statusResponse.Data = result.Data;
            }
            catch (Exception ex)
            {

                statusResponse.IsSuccess = false;
                statusResponse.Message = "Error obteniendo el status";
                _logger.LogError(statusResponse.Message, ex.ToString());

            }

            return statusResponse;
        }

        public async Task<StatusResponse> SaveAsync(StatusSaveDto dto)
        {
            StatusResponse statusResponse = new StatusResponse();

            try
            {
                Status status = new Status();

                status.statusName = dto.statusName;

                var result = await _statusRepository.Save(status);

                if (result.Success)
                {
                    statusResponse.IsSuccess = true;
                    statusResponse.Message = "Se guardó correctamente el status";
                }
                else
                {
                    statusResponse.IsSuccess = false;
                    statusResponse.Message = result.Message;
                }
            }
            catch (Exception ex)
            {

                statusResponse.IsSuccess = false;
                statusResponse.Message = "Error guardando el status";
                _logger.LogError(statusResponse.Message, ex.ToString());
            }

            return statusResponse;
        }

        public async Task<StatusResponse> UpdateAsync(StatusUpdateDto dto)
        {
            StatusResponse statusResponse = new StatusResponse();

            try
            {
                var resultGetById = await _statusRepository.GetStatusByStatusID(dto.statusID);

                if (!resultGetById.Success)
                {
                    statusResponse.IsSuccess = resultGetById.Success;
                    statusResponse.Message = resultGetById.Message;
                    return statusResponse;
                }


                if (resultGetById.Data == null)
                {
                    statusResponse.IsSuccess = false;
                    statusResponse.Message = "No se encontró el status";
                    return statusResponse;
                }

                if (!(resultGetById.Data is Status status))
                {
                    statusResponse.IsSuccess = false;
                    statusResponse.Message = "El tipo de datos es incorrecto.";
                    return statusResponse;
                }

                status.statusID = dto.statusID;
                status.statusName = dto.statusName;


                var result = await _statusRepository.Update(status);

                if (result.Success)
                {
                    statusResponse.IsSuccess = true;
                    statusResponse.Message = "El status fue actualizado correctamente.";
                }
                else
                {
                    statusResponse.IsSuccess = false;
                    statusResponse.Message = result.Message;
                }
            }
            catch (Exception ex)
            {

                statusResponse.IsSuccess = false;
                statusResponse.Message = "Error actualizando el status";
                _logger.LogError(statusResponse.Message, ex.ToString());
            }

            return statusResponse;
        }
    }
}
