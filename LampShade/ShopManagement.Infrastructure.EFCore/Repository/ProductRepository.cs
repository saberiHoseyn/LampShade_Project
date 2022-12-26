using _0_Framework.Application;
using _0_Framework.Infrastructure;
using Microsoft.EntityFrameworkCore;
using ShopManagement.Application.Contracts.ProductAgg;
using ShopManagement.Domain.ProductAgg;
using System.Collections.Generic;
using System.Linq;


namespace ShopManagement.Infrastructure.EFCore.Repository
{
    public class ProductRepository : RepositoryBase<long, Product>, IProductRepository
    {
        private readonly ShopContext context;

        public ProductRepository(ShopContext context) : base(context)
        {
            this.context = context;
        }

        public EditProduct GetDetails(long id)
        {
            return context.Products.Select(x => new EditProduct
            {
                Id = x.Id,
                Name = x.Name,
                Code = x.Code,
                Slug = x.Slug,
                CategoryId = x.CategoryId,
                Description = x.Description,
                Keywords = x.Keywords,
                MetaDescription = x.MetaDescription,
                Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                ShortDescription = x.ShortDescription
            }).FirstOrDefault(x => x.Id == id);

        }

        public List<ProductVeiwModel> GetProducts()
        {
            return context.Products.Select(x => new ProductVeiwModel
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
        }

        public List<ProductVeiwModel> Search(ProductSearchModel searchModel)
        {
            var query = context.Products.Include(x => x.Category).Select(x => new ProductVeiwModel
            {
                Id = x.Id,
                Name = x.Name,
                code = x.Code,
                CategoryId = x.CategoryId,
                Picture = x.Picture,
                Category = x.Category.Name,
                CreationDate = x.CreationDate.ToFarsi()
            });

            if (!string.IsNullOrWhiteSpace(searchModel.Name))
                query = query.Where(x => x.Name.Contains(searchModel.Name));
            if (!string.IsNullOrWhiteSpace(searchModel.Code))
                query = query.Where(x => x.code.Contains(searchModel.Code));
            if (searchModel.CategoryId != 0)
                query = query.Where(x => x.CategoryId == searchModel.CategoryId);

            return query.OrderByDescending(x => x.Id).ToList();
        }
    }
}
