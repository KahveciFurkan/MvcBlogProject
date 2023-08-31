using MvcBlogProject.Core.BaseEntities;
using MvcBlogProject.Dal.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBlogProject.Dal.UnitOfWorks
{
    public interface IUnitOfWork :IAsyncDisposable
    {
        IRepository<T> GetRepository<T>() where T : class;
        IRepository<T> GetRepositoryApp<T>() where T : class;
        Task<int> SaveAsync();

        int Save();
    }
}
