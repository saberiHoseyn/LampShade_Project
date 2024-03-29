﻿using _0_Framework.Application;
using _01_LampShadeQuery.Contracts.Product;
using _01_LampShadeQuery.Contracts.ProductCategory;
using DiscountManagement.Infrastructure.EFCore;
using InventoryManagement.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;
using ShopManagement.Domain.ProductAgg;
using ShopManagement.Infrastructure.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;


namespace _01_LampShadeQuery.Query
{
    public class ProductCategoryQuery : IProductCategoryQuery
    {
        private readonly ShopContext _shopContext;
        private readonly InventoryContext _inventoryContext;
        private readonly DiscountContext _discountContext;

        public ProductCategoryQuery(ShopContext shopContext, InventoryContext inventoryContext, DiscountContext discountContext)
        {
            _shopContext = shopContext;
            _inventoryContext = inventoryContext;
            _discountContext = discountContext;
        }

        public List<ProductCategoryQueryModel> GetProductCategories()
        {
            return _shopContext.ProductCategories.Select(x => new ProductCategoryQueryModel
            {
                Id = x.Id,
                Name = x.Name,
                Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                Slug = x.Slug
            }).AsNoTracking().ToList();
        }

        public List<ProductCategoryQueryModel> GetProductCategoriesWithProducts()
        {
            var inventory = _inventoryContext.Inventory.Select(x => new { x.ProductId, x.UnitPrice }).AsNoTracking().ToList();
            var discounts = _discountContext.CustomerDiscounts
                                .Where(x => x.StartDate < DateTime.Now && x.EndDate > DateTime.Now)
                                .Select(x => new { x.ProductId, x.DiscountRate }).AsNoTracking().ToList();
            var categories = _shopContext.ProductCategories
                 .Include(x => x.Products)
                 .ThenInclude(x => x.Category).Select(x => new ProductCategoryQueryModel
                 {
                     Id = x.Id,
                     Name = x.Name,
                     Products = MapProducts(x.Products)
                 }).AsNoTracking().ToList();
            foreach (var category in categories)
            {
                foreach (var product in category.Products)
                {
                    var productInventory = inventory.FirstOrDefault(x => x.ProductId == product.Id);
                    if (productInventory != null)
                    {
                        var price = productInventory.UnitPrice;
                        product.Price = price.ToMoney();

                        var discount = discounts.FirstOrDefault(x => x.ProductId == product.Id);
                        if (discount != null)
                        {
                            var discountRate = discount.DiscountRate;
                            product.DiscountRate = discountRate;
                            product.HasDiscount = discountRate > 0;
                            var discountAmount = Math.Round((price * discountRate) / 100);
                            product.PriceWithDiscount = (price - discountAmount).ToMoney();
                        }
                    }

                }

            }

            return categories;
        }

        private static List<ProductQueryModel> MapProducts(List<Product> products)
        {
            return products.Select(p => new ProductQueryModel
            {
                Id = p.Id,
                Category = p.Category.Name,
                Name = p.Name,
                Picture = p.Picture,
                PictureAlt = p.PictureAlt,
                PictureTitle = p.PictureTitle,
                Slug = p.Slug
            }).ToList();
        }



        public ProductCategoryQueryModel GetProductCategoryWithProducstsBy(string slug)
        {
            var inventory = _inventoryContext.Inventory.Select(x => new { x.ProductId, x.UnitPrice }).AsNoTracking().ToList();
            var discounts = _discountContext.CustomerDiscounts
                                .Where(x => x.StartDate < DateTime.Now && x.EndDate > DateTime.Now)
                                .Select(x => new { x.ProductId, x.DiscountRate, x.EndDate }).AsNoTracking().ToList();
            var category = _shopContext.ProductCategories
                 .Include(x => x.Products)
                 .ThenInclude(x => x.Category).Select(x => new ProductCategoryQueryModel
                 {
                     Id = x.Id,
                     Name = x.Name,
                     Description = x.Description,
                     MetaDescription = x.MetaDescription,
                     Keywords = x.Keywords,
                     Slug = x.Slug,
                     Products = MapProducts(x.Products)
                 }).FirstOrDefault(x => x.Slug == slug);

            if(category.Products.Count > 0)
            {
                foreach (var product in category.Products)
            {
                var productInventory = inventory.FirstOrDefault(x => x.ProductId == product.Id);
                if (productInventory != null)
                {
                    var price = productInventory.UnitPrice;
                    product.Price = price.ToMoney();

                    var discount = discounts.FirstOrDefault(x => x.ProductId == product.Id);
                    if (discount != null)
                    {
                        var discountRate = discount.DiscountRate;
                        product.DiscountRate = discountRate;
                        product.DiscountExpireDate = discount.EndDate.ToDiscountFormat();
                        product.HasDiscount = discountRate > 0;
                        var discountAmount = Math.Round((price * discountRate) / 100);
                        product.PriceWithDiscount = (price - discountAmount).ToMoney();
                    }
                }

            }
            }
            return category;
        }
    }
}
