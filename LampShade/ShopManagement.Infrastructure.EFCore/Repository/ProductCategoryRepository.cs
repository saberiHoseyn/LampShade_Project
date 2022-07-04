using _0_Framework.Infrastructure;
using ShopManagement.Application.Contracts.ProductCategoryAgg;
using ShopManagement.Domain.ProductCategoryAgg;
using ShopManagement.SM.Domain.ShopManagment.Domain.ProductCategoryAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Infrastructure.EFCore.Repository
{
    public class ProductCategoryRepository : RepositoryBase<long, ProductCategory>, IProductCategoryRepository
    {
        private readonly ShopContext context;

        public ProductCategoryRepository(ShopContext context) : base(context)
        {
            this.context = context;
        }

        public EditProductCategory GetDetails(long id)
        {
            return context.ProductCategories.Select(x => new EditProductCategory
            {
                Id = x.Id,
                Name = x.Name,
                Keywords = x.Keywords,
                Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                MetaDescription = x.MetaDescription,
                Slug = x.Slug,
                Description = x.Description
            }).FirstOrDefault(x => x.Id == id);
        }

        public List<ProductCategoryViewModel> GetProductCategories()
        {
            return context.ProductCategories.Select(x => new ProductCategoryViewModel
            {
                Id = x.Id,
                Name = x.Name,
            }).ToList();
        }

        public List<ProductCategoryViewModel> Search(ProductCategorySearchModel searchModel)
        {
            var qurey = context.ProductCategories.Select(x => new ProductCategoryViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Picture = x.Picture,
                CreationDate = x.CreationDate.ToString(),
            });

            if (!string.IsNullOrWhiteSpace(searchModel.Name))
                qurey = qurey.Where(x => x.Name.Contains(searchModel.Name));

            return qurey.OrderByDescending(x => x.Id).ToList();
        }
    }
}
