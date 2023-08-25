using Microsoft.EntityFrameworkCore;
using MvcBlogProject.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBlogProject.Dal.Concrete.Context
{
	public class StandartContext :DbContext
	{
        public StandartContext(DbContextOptions<StandartContext> opt) : base(opt) { }

        public virtual DbSet<Article> Articles { get; set; }
    }
}
