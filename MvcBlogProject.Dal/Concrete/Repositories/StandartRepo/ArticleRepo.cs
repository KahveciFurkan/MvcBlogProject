using MvcBlogProject.Dal.Abstract;
using MvcBlogProject.Dal.Base;
using MvcBlogProject.Dal.Concrete.Context;
using MvcBlogProject.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBlogProject.Dal.Concrete.Repositories.StandartRepo
{
	public class ArticleRepo :BaseStandartContextRepo<Article,StandartContext>,IArticleRepo
	{
	}
}
