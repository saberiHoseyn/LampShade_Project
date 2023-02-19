using BlogManagement.Application.Contracts.ArticleCategoryAgg;
using System.Collections.Generic;

namespace BlogManagement.Application.Contracts.ArticleAgg
{
    public class ArticleSearchModel
    {
        public string Title { get; set; }
        public long CategoryId { get; set; }
    }
}
