using System.Linq.Expressions;
using MedicalAppointmentApp.Domain.Repositories;
using MedicalAppointmentApp.Domain.Result;
using MedicalAppointmentApp.Persistance.Context;
using Microsoft.EntityFrameworkCore;



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
                result.Message = $"Ocurrió un error {ex.Message} obteniendo los datos";
            }

            return result;
        }

        public virtual async Task<OperationResult> GetEntityBy(int Id)
        {
            OperationResult result = new OperationResult();

            try
            {
                var entity = await this.entities.FindAsync(Id);
                if (entity == null)
                {
                    result.Success = false;
                    result.Message = "Entidad no encontrada.";
                }
                else
                {
                    result.Success = true;
                    result.Data = entity;
                }
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = $"Ocurrió un error {ex.Message} al obtener la entidad";
            }

            return result;
        }

        public virtual async Task<OperationResult> Remove(TEntity entity)
        {
            OperationResult result = new OperationResult();

            try
            {
                entities.Remove(entity);
                await _medicalAppointmentsContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = $"Ocurrió un error {ex.Message} ocurrió un error removiendo la entidad";
            }

            return result;
        }

        public virtual async Task<OperationResult> Save(TEntity entity)
        {
            OperationResult result = new OperationResult();

            try
            {
                entities.Add(entity);
                await _medicalAppointmentsContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = $"Ocurrió un error {ex.Message} ocurrió un error guardando la entidad";
            }

            return result;
        }

        public virtual async Task<OperationResult> Update(TEntity entity)
        {
            OperationResult result = new OperationResult();

            try
            {
                entities.Update(entity);
                await _medicalAppointmentsContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = $"Ocurrió un error {ex.Message} ocurrió un error actualizando la entidad";
            }

            return result;
        }
    }
}
