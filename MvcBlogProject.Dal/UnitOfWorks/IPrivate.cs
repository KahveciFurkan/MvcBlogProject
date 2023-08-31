using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MvcBlogProject.Dal.UnitOfWorks
{
    public interface IPrivate:IAsyncDisposable
    {

        Task<T> GettAsync<T>() where T : class;
    }
}
