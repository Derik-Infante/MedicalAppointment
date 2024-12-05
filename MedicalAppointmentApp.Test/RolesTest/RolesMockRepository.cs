

using MedicalAppointmentApp.Domain.Entities.System;
using MedicalAppointmentApp.Domain.Result;
using MedicalAppointmentApp.Persistance.Interfaces.System;
using System.Linq.Expressions;

namespace MedicalAppointmentApp.Test.RolesTest
{
    public class RolesMockRepository : IRolesRepository
    {
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

        public Task<OperationResult> Save(Roles entity)
        {
            throw new NotImplementedException();
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
