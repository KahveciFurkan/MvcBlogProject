using MvcBlogProject.Core.BaseEntities;

namespace MvcBlogProject.Dal.Entities
{
    public class Image : BaseEntity
    {
        public string FileName { get; set; }
        public string FileType { get; set; }

        public virtual ICollection<Article> Articles { get; set; }
        public Image()
        {
            Articles = new HashSet<Article>();
        }
    }
}
