using Microsoft.AspNetCore.Identity;
using MvcBlogProject.Core.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBlogProject.Dal.Entities
{
	public class AppUser : IdentityUser<int>,IBaseEntity
	{
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Password { get; set; }
        public string? PaswordConfirm { get; set; }

        //public virtual AppRole? AppRole { get; set; }
        //public  int RoleId { get; set; }
        public int? ConfirmCode { get; set; }

        public int? ImageId { get; set; }

        //public virtual Image Image { get; set; }

        public virtual ICollection<Article> Articles { get; set; }
        public AppUser()
        {
            Articles = new List<Article>();
        }
    }
}
