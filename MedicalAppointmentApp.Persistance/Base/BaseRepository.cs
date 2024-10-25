

using System.Linq.Expressions;
using System.Runtime.InteropServices;
using MedicalAppointmentApp.Domain.Repositories;
using MedicalAppointmentApp.Domain.Result;
using MedicalAppointmentApp.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;


namespace MedicalAppointmentApp.Persistance.Base
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly MedicalAppointmentsContext _medicalAppointmentsContext;

        private DbSet<TEntity> entities;

        public BaseRepository(MedicalAppointmentsContext medicalAppointmentsContext)
        {
            _medicalAppointmentsContext = medicalAppointmentsContext;
            this.entities = _medicalAppointmentsContext.Set<TEntity>();
        }
        public virtual async Task<OperationResult> Exist(Expression<Func<TEntity, bool>> filter)
        {
           
            OperationResult result = new OperationResult();

            try
            {
               var exists = await this.entities.AnyAsync(filter);
               result.Data = exists;

            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = $"Ocurrió el error {ex.Message} verificando que existe el registro" ;
            }

            return result;

            
        }

        public virtual async Task<OperationResult> GetAll()
        {
            OperationResult result = new OperationResult();

            try
            {
                var datos = await this.entities.ToListAsync();
                result.Data = datos;
                

            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = $"Ocurrió el error {ex.Message} obteniendo los datos";
            }

            return result;
        }

        public virtual async Task<OperationResult> GetEntityBy(int Id)
        {
            OperationResult result = new OperationResult();

            try
            {
                var entity = await this.entities.FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                
            }

            return result;
        }

        public virtual Task<OperationResult> Remove(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public virtual Task<OperationResult> Save(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public virtual Task<OperationResult> Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
