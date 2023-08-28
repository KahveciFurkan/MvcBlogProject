using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBlogProject.Dal.Entities
{
	public class AppUser : IdentityUser<int>
	{
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int? ImageId { get; set; }

        //public virtual Image Image { get; set; }

        public virtual ICollection<Article> Articles { get; set; }
        public AppUser()
        {
            Articles = new List<Article>();
        }
    }
}
