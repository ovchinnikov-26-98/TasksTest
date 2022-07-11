using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstTestTask.Interface
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> FindaAll();
    }
}
