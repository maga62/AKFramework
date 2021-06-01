using AKFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKFramework.Core.DataAccess
{
    public interface IQueryableRepositoriy<T> where T:class,IEntity,new()
    {
        IQueryable<T> Table { get; }
    }
}
