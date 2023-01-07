using _01_LampShadeQuery.Contracts.ProductCategory;
using Microsoft.AspNetCore.Mvc;


namespace ServiceHost.ViewComponents
{
    public class ProductCategoryViewComponent : ViewComponent
    {
        private readonly IProductCategoryQuery productCategoryQuary;

        public ProductCategoryViewComponent(IProductCategoryQuery productCategoryQuary)
        {
            this.productCategoryQuary = productCategoryQuary;
        }

        public IViewComponentResult Invoke()
        {
            var categories = productCategoryQuary.GetProductCategories();

            return View(categories);
        }
    }
}
