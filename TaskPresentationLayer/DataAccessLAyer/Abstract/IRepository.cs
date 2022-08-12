using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccessLayer.Concrete
{
    interface IRepository<T>
    {
        List<T> GetItemByName(Expression<Func<T, bool>> filterExpression);
    }
}
