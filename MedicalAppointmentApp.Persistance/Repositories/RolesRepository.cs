using MedicalAppointmentApp.Domain.Entities.System;
using MedicalAppointmentApp.Domain.Result;
using MedicalAppointmentApp.Persistance.Base;
using MedicalAppointmentApp.Persistance.Context;
using MedicalAppointmentApp.Persistance.Interfaces.System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace MedicalAppointmentApp.Persistance.Repositories
{
    public class RolesRepository : BaseRepository<Roles>, IRolesRepository
    {
        private readonly MedicalAppointmentsContext _medicalAppointmentsContext;
        private readonly ILogger<RolesRepository> _logger;

        public RolesRepository(MedicalAppointmentsContext medicalAppointmentsContext, ILogger<RolesRepository> logger)
            : base(medicalAppointmentsContext)
        {
            _medicalAppointmentsContext = medicalAppointmentsContext;
            _logger = logger;
        }

        public async Task<OperationResult> GetRoleByRoleID(int RoleID)
        {
            OperationResult operationResult = new OperationResult();
            try
            {
                var role = await _medicalAppointmentsContext.Roles.FindAsync(RoleID);
                if (role != null)
                {
                    operationResult.Data = role;
                }
                else
                {
                    operationResult.Success = false;
                    operationResult.Message = "Rol no encontrado.";
                }
            }
            catch (Exception ex)
            {
                operationResult.Success = false;
                operationResult.Message = "Error obteniendo el rol por ID.";
                _logger.LogError(operationResult.Message, ex.ToString());
            }
            return operationResult;
        }

        public async Task<IEnumerable<Roles>> GetAllRoles()
        {
            return await _medicalAppointmentsContext.Roles.ToListAsync();
        }

        public async Task<OperationResult> AddRole(Roles role)
        {
            OperationResult operationResult = new OperationResult();
            try
            {
                await _medicalAppointmentsContext.Roles.AddAsync(role);
                await _medicalAppointmentsContext.SaveChangesAsync();
                operationResult.Success = true;
            }
            catch (Exception ex)
            {
                operationResult.Success = false;
                operationResult.Message = "Error agregando el rol.";
                _logger.LogError(operationResult.Message, ex.ToString());
            }
            return operationResult;
        }

        public async Task<OperationResult> UpdateRole(Roles role)
        {
            OperationResult operationResult = new OperationResult();
            try
            {
                _medicalAppointmentsContext.Roles.Update(role);
                await _medicalAppointmentsContext.SaveChangesAsync();
                operationResult.Success = true;
            }
            catch (Exception ex)
            {
                operationResult.Success = false;
                operationResult.Message = "Error actualizando el rol.";
                _logger.LogError(operationResult.Message, ex.ToString());
            }
            return operationResult;
        }

        public async Task<OperationResult> DeleteRole(int RoleID)
        {
            OperationResult operationResult = new OperationResult();
            try
            {
                var role = await _medicalAppointmentsContext.Roles.FindAsync(RoleID);
                if (role != null)
                {
                    _medicalAppointmentsContext.Roles.Remove(role);
                    await _medicalAppointmentsContext.SaveChangesAsync();
                    operationResult.Success = true;
                }
                else
                {
                    operationResult.Success = false;
                    operationResult.Message = "Rol no encontrado.";
                }
            }
            catch (Exception ex)
            {
                operationResult.Success = false;
                operationResult.Message = "Error eliminando el rol.";
                _logger.LogError(operationResult.Message, ex.ToString());
            }
            return operationResult;
        }
    }
}

