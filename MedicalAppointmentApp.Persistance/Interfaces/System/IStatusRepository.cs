

using MedicalAppointmentApp.Domain.Entities.System;
using MedicalAppointmentApp.Domain.Repositories;
using MedicalAppointmentApp.Domain.Result;

namespace MedicalAppointmentApp.Persistance.Interfaces.System
{
    public interface IStatusRepository : IBaseRepository<Status>
    {
        Task<OperationResult> GetStatusByStatusID(int statusID); // Obtener estado por ID
        Task<IEnumerable<Status>> GetAllStatuses(); // Obtener todos los estados
        Task<OperationResult> AddStatus(Status status); // Agregar un nuevo estado
        Task<OperationResult> UpdateStatus(Status status); // Actualizar un estado existente
        Task<OperationResult> DeleteStatus(int statusID); // Eliminar estado
    }
}
