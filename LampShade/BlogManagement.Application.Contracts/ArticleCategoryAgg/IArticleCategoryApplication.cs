using _0_Framework.Application;
using System.Collections.Generic;

namespace BlogManagement.Application.Contracts.ArticleCategoryAgg
{
    public interface IArticleCategoryApplication
    {
        OperationResult Create(CreateArticleCategory command);
        OperationResult Edit(EditArticleCategory command);
        EditArticleCategory GetDetails(long id);
        List<ArticleCategoryViewModel> Search(ArticleCategorySearchModel searchModel);
    }
}
