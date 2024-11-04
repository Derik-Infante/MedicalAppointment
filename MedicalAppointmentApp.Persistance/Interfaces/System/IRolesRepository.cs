using MedicalAppointmentApp.Domain.Entities.System;
using MedicalAppointmentApp.Domain.Repositories;
using MedicalAppointmentApp.Domain.Result;

namespace MedicalAppointmentApp.Persistance.Interfaces.System
{
    public interface IRolesRepository : IBaseRepository<Roles> 
    { 

        Task<OperationResult> GetRoleByRoleID(int RoleID); // Obtener rol por ID
        Task<IEnumerable<Roles>> GetAllRoles(); // Obtener todos los roles
        Task<OperationResult> AddRole(Roles role); // Agregar un nuevo rol
        Task<OperationResult> UpdateRole(Roles role); // Actualizar un rol existente
        Task<OperationResult> DeleteRole(int RoleID); // Eliminar rol
    }
}
