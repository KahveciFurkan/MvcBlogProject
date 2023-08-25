using MvcBlogProject.Core.BaseEntities;
using MvcBlogProject.Core.IBaseRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBlogProject.Dal.Abstract
{
	public interface IBaseStandartContextRepo<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
	{
	}
}
