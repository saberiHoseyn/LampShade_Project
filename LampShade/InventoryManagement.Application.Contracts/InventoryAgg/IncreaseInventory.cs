namespace InventoryManagement.Application.Contracts.InventoryAgg
{
    public class IncreaseInventory
    {
        public long Count { get; set; }
        public long operatorId { get; set; }
        public string Description { get; set; }
    }
}
