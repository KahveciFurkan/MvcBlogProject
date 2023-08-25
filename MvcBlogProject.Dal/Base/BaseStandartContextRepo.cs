using Microsoft.EntityFrameworkCore;
using MvcBlogProject.Core.BaseEntities;
using MvcBlogProject.Dal.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBlogProject.Dal.Base
{
	public class BaseStandartContextRepo<TEntity, TContext> : IBaseStandartContextRepo<TEntity> where TEntity : BaseEntity
		where TContext : DbContext
	{
		public Task Create(TEntity entity)
		{
			throw new NotImplementedException();
		}

		public Task Delete(TEntity entity)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<TEntity>> GetAll()
		{
			throw new NotImplementedException();
		}

		public Task Update(TEntity entity)
		{
			throw new NotImplementedException();
		}
	}
}
