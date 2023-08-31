using Microsoft.EntityFrameworkCore;
using MvcBlogProject.Core.BaseEntities;
using MvcBlogProject.Dal.Abstract;
using MvcBlogProject.Dal.Concrete.Context;
using MvcBlogProject.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace MvcBlogProject.Dal.Concrete.Repositories.StandartRepo
{
    public class Repository<T>  : IRepository<T> where T : class 
    {
        private readonly StandartContext context;
        private readonly AppIdentityContext appIdentityContext;

        public Repository(StandartContext context)
        {
            this.context = context;
           
        }
        public Repository(AppIdentityContext appIdentityContext)
        {
            this.appIdentityContext = appIdentityContext;
        }
        private DbSet<T> Table { get => context.Set<T>(); }

        public async Task<List<T>> GetAllAsync(Expression<Func<T,bool>> predicate = null,params Expression<Func<T, object>>[] includeProporties)
        {
            IQueryable<T> query = Table;
            if(predicate != null)
            {
                query = query.Where(predicate);
            }
            if(includeProporties.Any())
            {
                foreach (var item in includeProporties)
                {
                    query = query.Include(item);
                }
            }

            return await query.ToListAsync();
        }

        public async Task AddAsync(T entity)
        {
            await Table.AddAsync(entity);
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] includeProporties)
        {
            IQueryable<T> query = Table;
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

        public async Task<T> GetByIdAsync(int id)
        {
            return await Table.FindAsync(id);
        }

        public async Task<T> UpdateAsync(T entity)
        {
            await Task.Run(() => Table.Update(entity));
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            await Task.Run(() => Table.Remove(entity));
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> predicate)
        {
            return await Table.AnyAsync(predicate);
        }

        public async Task<int> CountAsync(Expression<Func<T, bool>> predicate = null)
        {
            return await Table.CountAsync(predicate);
        }
    }
}
