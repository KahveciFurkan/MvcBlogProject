using MvcBlogProject.Core.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBlogProject.Dal.Entities
{
	public class Article : BaseEntity
	{
        public string ArticleName { get; set; }

        public int UserId { get; set; }
    }
}
