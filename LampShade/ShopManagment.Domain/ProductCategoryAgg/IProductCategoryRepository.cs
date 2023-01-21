using _0_Framework.Domain;
using ShopManagement.Application.Contracts.ProductCategoryAgg;
using ShopManagement.SM.Domain.ShopManagment.Domain.ProductCategoryAgg;
using System.Collections.Generic;

namespace ShopManagement.Domain.ProductCategoryAgg
{
    public interface IProductCategoryRepository : IRepository<long, ProductCategory>
    {
        string GetSlugById(long id);
        List<ProductCategoryViewModel> GetProductCategories();
        EditProductCategory GetDetails(long id);
        List<ProductCategoryViewModel> Search(ProductCategorySearchModel searchModel);
    }
}
