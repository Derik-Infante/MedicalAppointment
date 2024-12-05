

using MedicalAppointmentApp.Domain.Entities.System;
using MedicalAppointmentApp.Domain.Result;
using MedicalAppointmentApp.Persistance.Interfaces.System;
using MedicalAppointmentApp.Test.Context;
using System.Linq.Expressions;

namespace MedicalAppointmentApp.Test.StatusTest
{
    public class StatusMockRepository : IStatusRepository
    {
        private readonly MedicalAppointmentsMockContext context;
        public StatusMockRepository(MedicalAppointmentsMockContext context)
        {
            this.context = context;
        }
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

        public async Task<OperationResult> Save(Status entity)
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

                if (string.IsNullOrEmpty(entity.statusName))
                {
                    result.Success = false;
                    result.Message = "Nombre requerido";
                    return result;
                }
                await this.context.AddAsync(entity);
                await this.context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                result.Message = "Ocurrio un error guardando el status";
                result.Success = false;
            }

            return result;
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
