using AKFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKFramework.Core.DataAccess.NHihabernate
{
    public class NhQueryableRepositoriy<T> : IQueryableRepositoriy<T>
        where T : class, IEntity, new()
    {
        private NHibernateHelper _nHibernateHelper;
        private IQueryable<T> _entities;
        

        public NhQueryableRepositoriy(NHibernateHelper nHibernateHelper)
        {
            _nHibernateHelper = nHibernateHelper;
        }

        public IQueryable<T> Table { get { return this.Entities; } }
        public virtual IQueryable<T> Entities {
            get
            {
                if (_entities==null)
                {
                    _entities = _nHibernateHelper.OpenSession().Query<T>();

                }
                return _entities;
            }
            }
    }
}
