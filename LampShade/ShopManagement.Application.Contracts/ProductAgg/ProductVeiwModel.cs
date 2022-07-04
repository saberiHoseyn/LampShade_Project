namespace ShopManagement.Application.Contracts.ProductAgg
{
    public class ProductVeiwModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string code { get; set; }
        public double UnitPrice { get; set; }
        public string Picture { get; set; }
        public string Category { get; set; }
        public long CategoryId { get; set; }
        public string CreationDate { get; set; }
        public bool IsInStock { get; set; }
    }
}
