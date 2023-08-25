using MvcBlogProject.Core.BaseEntities;
using MvcBlogProject.Dal.Abstract;
using MvcBlogProject.Dal.Concrete.Context;
using MvcBlogProject.Dal.Concrete.Repositories.StandartRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBlogProject.Dal.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly StandartContext standartContext;

        public UnitOfWork(StandartContext standartContext)
        {
            this.standartContext = standartContext;
        }
        public async ValueTask DisposeAsync()
        {
            await standartContext.DisposeAsync();
        }

        public IRepository<T> GetRepository<T>() where T : BaseEntity
        {
            return new Repository<T>(standartContext);
        }

        public  int Save()
        {
            return standartContext.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            return await standartContext.SaveChangesAsync();
        }
    }
}
