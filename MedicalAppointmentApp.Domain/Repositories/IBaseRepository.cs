
using System.Linq.Expressions;

namespace MedicalAppointmentApp.Domain.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        /// <Sumary>
        /// 
        /// </Sumary>
        /// <param name="entity"></param>
        
        void Save(TEntity entity);
        /// <Sumary>
        /// 
        /// </Sumary>
        /// <param name="entity"></param>
        
        void Update(TEntity entity);
        /// <Sumary>
        /// 
        /// </Sumary>
        /// <param name="entity"></param>
        
        void Remove(TEntity entity);
        /// <Sumary>
        /// 
        /// </Sumary>
        /// <param name="entity"></param>



    }





}
