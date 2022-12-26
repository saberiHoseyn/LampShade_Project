using _0_Framework.Domain;
using InventoryManagement.Application.Contracts.InventoryAgg;
using System.Collections.Generic;


namespace InventoryManagement.Domain.InventoryAgg
{
    public interface IInventoryRepository : IRepository<long, Inventory>
    {
        EditInventory GetDetails(long id);
        List<InventoryViewModel> Search(InventorySearchModel command);
        Inventory GetBy(long productId);
        List<InventoryOperationViewModel> GetOperationLog(long inventoryId);
    }
}
