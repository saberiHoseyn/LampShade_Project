namespace ShopManagement.Application.Contracts.SlideAgg
{
    public class SlideViewModel
    {
        public long Id { get; set; }
        public string Picture { get; set; }
        public string Heding { get; set; }
        public string Title { get; set; }
        public bool IsRemove { get; set; }
        public string CreationDate { get; set; }
        public string Link { get; set; }
    }
}
