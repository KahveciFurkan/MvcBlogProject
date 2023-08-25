using MvcBlogProject.Core.BaseEntities;

namespace MvcBlogProject.Dal.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<Article> Articles { get; set; }
        public Category()
        {
            Articles = new HashSet<Article>();
        }
    }
}
