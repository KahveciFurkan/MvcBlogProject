﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBlogProject.Core.IBaseRepositories
{
	public interface IIdentityRepo<TEntity> : IBaseRepository<TEntity> where TEntity : class
	{
	}
}
