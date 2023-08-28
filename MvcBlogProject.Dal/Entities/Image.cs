using MvcBlogProject.Core.BaseEntities;
using System.Reflection.Metadata.Ecma335;

namespace MvcBlogProject.Dal.Entities
{
    public class Image : BaseEntity
    {
        public string FileName { get; set; }
        public string FileType { get; set; }

        public virtual ICollection<Article> Articles { get; set; }
        //public virtual ICollection<AppUser> Users { get; set; }

        public Image()
        {
            Articles = new HashSet<Article>();
            //Users = new HashSet<AppUser>();
        }
    }
}
