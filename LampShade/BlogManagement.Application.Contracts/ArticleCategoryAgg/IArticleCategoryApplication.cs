using _0_Framework.Application;
using System.Collections.Generic;

namespace BlogManagement.Application.Contracts.ArticleCategoryAgg
{
    public interface IArticleCategoryApplication
    {
        EditArticleCategory GetDetails(long id);
        OperationResult Edit(EditArticleCategory command);
        OperationResult Create(CreateArticleCategory command);
        List<ArticleCategoryViewModel> GetArticleCategories();
        List<ArticleCategoryViewModel> Search(ArticleCategorySearchModel searchModel);
    }
}
