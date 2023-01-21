using _0_Framework.Domain;
using ShopManagement.Application.Contracts.ProductAgg;
using System.Collections.Generic;


namespace ShopManagement.Domain.ProductAgg
{
    public interface IProductRepository : IRepository<long, Product>
    {
        Product GetProductWithCategory(long id);
        EditProduct GetDetails(long id);
        List<ProductVeiwModel> GetProducts();
        List<ProductVeiwModel> Search(ProductSearchModel searchModel);

    }
}
