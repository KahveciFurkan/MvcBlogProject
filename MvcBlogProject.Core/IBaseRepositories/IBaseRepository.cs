using MvcBlogProject.Core.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBlogProject.Core.IBaseRepositories
{
	public interface IBaseRepository<TEntity> where TEntity : class
	{
		Task Create(TEntity entity);
		Task Update(TEntity entity);
		Task Delete(TEntity entity);
		Task<IEnumerable<TEntity>> GetAll();
	}
}
