using MedicalAppointmentApp.Domain.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalAppointmentApp.Domain.Repositories
{
    public  interface IBaseRepository<TEntity> where TEntity : class
    {
        Task<OperationResult> Save (TEntity entity);



    }

  
}
