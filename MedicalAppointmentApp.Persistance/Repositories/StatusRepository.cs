using MedicalAppointmentApp.Domain.Entities.System;
using MedicalAppointmentApp.Domain.Result;
using MedicalAppointmentApp.Persistance.Base;
using MedicalAppointmentApp.Persistance.Context;
using MedicalAppointmentApp.Persistance.Interfaces.System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace MedicalAppointmentApp.Persistance.Repositories
{
    public class StatusRepository : BaseRepository<Status>, IStatusRepository
    {
        private readonly MedicalAppointmentsContext _medicalAppointmentsContext;
        private readonly ILogger<RolesRepository> _logger;

        public StatusRepository(MedicalAppointmentsContext medicalAppointmentsContext, ILogger<RolesRepository> logger)
            : base(medicalAppointmentsContext)
        {
            _medicalAppointmentsContext = medicalAppointmentsContext;
            _logger = logger;
        }


        public async Task<IEnumerable<Status>> GetAllStatuses()
        {
            return await _medicalAppointmentsContext.Status.ToListAsync();
        }

        public async Task<OperationResult> GetStatusByStatusID(int statusID)
        {
            OperationResult operationResult = new OperationResult();
            try
            {
                var status = await _medicalAppointmentsContext.Status.FindAsync(statusID);
                if (status == null)
                {
                    operationResult.Success = false;
                    operationResult.Message = "Estado no encontrado.";
                }
                else
                {
                    operationResult.Success = true;
                    operationResult.Data = status;
                }
            }
            catch (Exception ex)
            {
                operationResult.Success = false;
                operationResult.Message = "Error obteniendo el estado por ID.";
                _logger.LogError(operationResult.Message, ex.ToString());
            }
            return operationResult;
        }

        public async Task<OperationResult> AddStatus(Status status)
        {
            return await base.Save(status);
        }

        public async Task<OperationResult> UpdateStatus(Status status)
        {
            return await base.Update(status);
        }

        public async Task<OperationResult> DeleteStatus(int statusID)
        {
            OperationResult operationResult = new OperationResult();
            try
            {
                var status = await _medicalAppointmentsContext.Status.FindAsync(statusID);
                if (status == null)
                {
                    operationResult.Success = false;
                    operationResult.Message = "Estado no encontrado.";
                    return operationResult;
                }

                await base.Remove(status);
                operationResult.Success = true;
                operationResult.Message = "Estado eliminado correctamente.";
            }
            catch (Exception ex)
            {
                operationResult.Success = false;
                operationResult.Message = "Error eliminando el estado.";
                _logger.LogError(operationResult.Message, ex.ToString());
            }
            return operationResult;

        }
    }
}
