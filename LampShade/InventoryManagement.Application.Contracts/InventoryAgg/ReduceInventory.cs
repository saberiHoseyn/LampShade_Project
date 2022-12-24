﻿namespace InventoryManagement.Application.Contracts.InventoryAgg
{
    public class ReduceInventory
    {
        public long InventoryId { get; set; }
        public long Count { get; set; }
        public long ProductId { get; set; }
        public string Description { get; set; }
        public long OrderId { get; set; }
    }
}
