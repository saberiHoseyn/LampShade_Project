﻿namespace InventoryManagement.Application.Contracts.InventoryAgg
{
    public class InventoryViewModel
    {
        public long Id { get; set; }
        public string ProductName { get; set; }
        public long ProductId { get; set; }
        public bool InStock { get; set; }
        public string CreationDate { get; set; }
        public double UnitPrice { get; set; }
        public long CurrentCount { get; set; }
    }
}
