using _01_LampShadeQuery.Contracts.ProductCategory;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceHost.ViewComponents
{
    public class ProductCategoryViewComponent : ViewComponent
    {
        private readonly IProductCategoryQuary productCategoryQuary;

        public ProductCategoryViewComponent(IProductCategoryQuary productCategoryQuary)
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
