

using MedicalAppointmentApp.Domain.Entities.System;
using MedicalAppointmentApp.Domain.Result;
using MedicalAppointmentApp.Persistance.Interfaces.System;
using System.Linq.Expressions;

namespace MedicalAppointmentApp.Test.StatusTest
{
    public class StatusMockRepository : IStatusRepository
    {
        public Task<OperationResult> AddStatus(Status status)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult> DeleteStatus(int statusID)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult> Exist(Expression<Func<Status, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Status>> GetAllStatuses()
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult> GetEntityBy(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult> GetStatusByStatusID(int statusID)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult> Remove(Status entity)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult> Save(Status entity)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult> Update(Status entity)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult> UpdateStatus(Status status)
        {
            throw new NotImplementedException();
        }
    }
}
