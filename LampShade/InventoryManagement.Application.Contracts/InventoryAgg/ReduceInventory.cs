namespace InventoryManagement.Application.Contracts.InventoryAgg
{
    public class ReduceInventory
    {
        public long Count { get; set; }
        public long ProductId { get; set; }
        public long OrderId { get; set; }
    }
}
