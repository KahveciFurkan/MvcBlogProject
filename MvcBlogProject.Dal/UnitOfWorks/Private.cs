using Microsoft.EntityFrameworkCore;
using MvcBlogProject.Dal.Abstract;
using MvcBlogProject.Dal.Concrete.Context;
using MvcBlogProject.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MvcBlogProject.Dal.UnitOfWorks
{
    public class Private : IPrivate 
    {
        private readonly AppIdentityContext identityContext;

        public Private(AppIdentityContext identityContext)
        {
            this.identityContext = identityContext;
        }
        private DbSet<AppUser> Table { get => identityContext.Set<AppUser>(); }

        public async ValueTask DisposeAsync()
        {
            await identityContext.DisposeAsync();
        }

        public async Task<AppUser> GettAsync(Expression<Func<AppUser, bool>> predicate = null, params Expression<Func<AppUser, object>>[] includeProporties)
        {
            IQueryable<AppUser> query = Table;
            query = query.Where(predicate);
            if (includeProporties.Any())
            {
                foreach (var item in includeProporties)
                {
                    query = query.Include(item);
                }
            }
            return await query.SingleAsync();
        }

        public Task<T> GettAsync<T>() where T : class
        {
            throw new NotImplementedException();
        }
    }
}
