

using MedicalAppointmentApp.Domain.Entities.System;
using MedicalAppointmentApp.Domain.Result;
using MedicalAppointmentApp.Persistance.Interfaces.System;
using MedicalAppointmentApp.Test.Context;
using System.Linq.Expressions;

namespace MedicalAppointmentApp.Test.RolesTest
{
    public class RolesMockRepository : IRolesRepository
    {
        private readonly MedicalAppointmentsMockContext context;
        public RolesMockRepository(MedicalAppointmentsMockContext context)
        {
            this.context = context;
        }
        public Task<OperationResult> AddRole(Roles role)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult> DeleteRole(int RoleID)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult> Exist(Expression<Func<Roles, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Roles>> GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult> GetEntityBy(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult> GetRoleByRoleID(int RoleID)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult> Remove(Roles entity)
        {
            throw new NotImplementedException();
        }

        public async Task<OperationResult> Save(Roles entity)
        {
            OperationResult result = new OperationResult();

            try
            {

                if (entity == null)
                {
                    result.Success = false;
                    result.Message = "La entidad es requerida.";
                    return result;
                }

                if (string.IsNullOrEmpty(entity.RoleName))
                {
                    result.Success = false;
                    result.Message = "Nombre del rol requerido";
                    return result;
                }
                await this.context.AddAsync(entity);
                await this.context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                result.Message = $"Ocurrió un error guardando el rol: {ex.Message}";
                result.Success = false;
            }

            return result;
        }

        public Task<OperationResult> Update(Roles entity)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult> UpdateRole(Roles role)
        {
            throw new NotImplementedException();
        }
    }
}
