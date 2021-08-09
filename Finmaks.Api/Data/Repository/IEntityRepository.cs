using Finmaks.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Finmaks.Data
{
 public interface IEntityRepository<T> where T:class,IEntity,new() 
    {

        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        
    }
}
