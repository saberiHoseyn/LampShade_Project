using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShopManagement.Application.Contracts.ProductAgg;
using ShopManagement.Application.Contracts.ProductCategoryAgg;

namespace ServiceHost.Areas.Administration.Pages.Shop.Products
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }  
        public ProductSearchModel SearchModel;
        public List<ProductVeiwModel> Products;
        public SelectList ProductCategories;

        private readonly IProductApplication productApplication;
        private readonly IProductPictureApplication productCategoryApplication;

        public IndexModel(IProductPictureApplication productCategoryApplication, IProductApplication productApplication)
        {
            this.productCategoryApplication = productCategoryApplication;
            this.productApplication = productApplication;
        }

        public void OnGet(ProductSearchModel searchModel)
        {
            ProductCategories = new SelectList(productCategoryApplication.GetProductCategories(), "Id", "Name");
            Products = productApplication.Search(searchModel);
        }

        public IActionResult OnGetCreate()
        {
            var command = new CreateProduct
            {
                Categories = productCategoryApplication.GetProductCategories()
            };

            return Partial("./Create", command);
        }

        public JsonResult OnPostCreate(CreateProduct command)
        {
            var result = productApplication.Create(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(long id)
        {
            var product = productApplication.GetDetails(id);
            product.Categories = productCategoryApplication.GetProductCategories();
            return Partial("./Edit", product);
        }

        public JsonResult OnPostEdit(EditProduct command)
        {
            var result = productApplication.Edit(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetIsInStock(long id)
        {
            var result = productApplication.IsStock(id);
            if (result.IsSuccedded)
                return RedirectToPage("./Index");

            Message = result.Message;
            return RedirectToPage("./Index");
        }

        public IActionResult OnGetNotInStock(long id)
        {
            var result = productApplication.NotInStock(id);
            if (result.IsSuccedded)
                return RedirectToPage("./Index");

            Message = result.Message;
            return RedirectToPage("./Index");
        }
    }
}
