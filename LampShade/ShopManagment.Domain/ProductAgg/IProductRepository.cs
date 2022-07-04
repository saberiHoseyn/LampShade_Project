using _0_Framework.Domain;
using ShopManagement.Application.Contracts.ProductAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Domain.ProductAgg
{
    public interface IProductRepository : IRepository<long, Product>
    {
        EditProduct GetDetails(long id);
        List<ProductVeiwModel> GetProducts();
        List<ProductVeiwModel> Search(ProductSearchModel searchModel);

    }
}
