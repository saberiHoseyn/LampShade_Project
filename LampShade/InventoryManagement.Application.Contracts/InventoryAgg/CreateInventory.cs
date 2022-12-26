using ShopManagement.Application.Contracts.ProductAgg;
using System.Collections.Generic;

namespace InventoryManagement.Application.Contracts.InventoryAgg
{
    public class CreateInventory
    {
        public long ProductId { get; set; }
        public double UnitPrice { get; set; }
        public List<ProductVeiwModel> Products { get; set; }
    }
}
