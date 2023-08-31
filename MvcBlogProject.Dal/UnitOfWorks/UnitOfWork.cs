using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using MvcBlogProject.Core.BaseEntities;
using MvcBlogProject.Dal.Abstract;
using MvcBlogProject.Dal.Concrete.Context;
using MvcBlogProject.Dal.Concrete.Repositories.StandartRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MvcBlogProject.Dal.Entities;

namespace MvcBlogProject.Dal.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly StandartContext standartContext;
        private readonly AppIdentityContext appIdentityContext;

        public UnitOfWork(StandartContext standartContext,AppIdentityContext appIdentityContext)
        {
            this.standartContext = standartContext;
            this.appIdentityContext = appIdentityContext;
        }
        public async ValueTask DisposeAsync()
        {
            await standartContext.DisposeAsync();
            await appIdentityContext.DisposeAsync();
        }

        public IRepository<T> GetRepository<T>() where T : class
        {
            return new Repository<T>(standartContext);


        }
        public IRepository<T> GetRepositoryApp<T>() where T : class
        {
            return new Repository<T>(appIdentityContext);


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
