using MvcBlogProject.Core.BaseEntities;

namespace MvcBlogProject.Dal.Entities
{
    public class Article : BaseEntity
	{
        public string ArticleName { get; set; }
        public string Content { get; set; }
        public int? ViewCount { get; set; } = 0;
        public int? CategoryId { get; set; }
        public virtual Category? Category { get; set; }
        public int? ImageId { get; set; }
        public virtual Image? Image { get; set; }

        public int? UserId { get; set; }

        //public virtual AppUser? User { get; set; }

    }
}
