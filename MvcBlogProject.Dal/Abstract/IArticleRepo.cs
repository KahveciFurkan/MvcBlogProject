using MvcBlogProject.Core.IBaseRepositories;
using MvcBlogProject.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBlogProject.Dal.Abstract
{
	public interface IArticleRepo :IBaseStandartContextRepo<Article>
	{

	}
}
