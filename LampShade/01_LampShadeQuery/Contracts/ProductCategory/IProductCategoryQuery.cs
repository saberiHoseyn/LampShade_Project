using System.Collections.Generic;

namespace _01_LampShadeQuery.Contracts.ProductCategory
{
    public interface IProductCategoryQuery
    {
        List<ProductCategoryQueryModel> GetProductCategories();
        List<ProductCategoryQueryModel> GetProductCategoriesWithProducts();
        ProductCategoryQueryModel GetProductCategoryWithProducstsBy(string slug);
    }
}
