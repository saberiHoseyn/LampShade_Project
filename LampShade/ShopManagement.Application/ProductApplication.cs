using _0_Framework.Application;
using ShopManagement.Application.Contracts.ProductAgg;
using ShopManagement.Domain.ProductAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Application
{
    public class ProductApplication : IProductApplication
    {
        private readonly IProductRepository productRepository;

        public ProductApplication(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public OperationResult Create(CreateProduct command)
        {
            var opration = new OperationResult();
            if (productRepository.Exists(x => x.Name == command.Name))
                return opration.Failed(ApplicationMessages.DuplicatedRecord);

            var slug = command.Slug.Slugify();
            var product = new Product(command.Name, command.Code, command.ShortDescription,
                command.Description, command.Picture, command.PictureAlt, command.PictureTitle,
                command.CategoryId, slug, command.Keywords, command.MetaDescription);
            productRepository.Create(product);
            productRepository.SaveChanges();
            return opration.Succedded();
        }

        public OperationResult Edit(EditProduct command)
        {
            var opration = new OperationResult();
            var product = productRepository.Get(command.Id);
            if (product == null)
                return opration.Failed(ApplicationMessages.RecordNotFound);
            
            if (productRepository.Exists(x => x.Name == command.Name && x.Id != command.Id))
                return opration.Failed(ApplicationMessages.DuplicatedRecord);

            var slug = command.Slug.Slugify();
            product.Edit(command.Name, command.Code, command.ShortDescription, command.Description,
                command.Picture, command.PictureAlt, command.PictureTitle, command.CategoryId, slug,
                command.Keywords, command.MetaDescription);
            productRepository.SaveChanges();
            return opration.Succedded();
        }

        public EditProduct GetDetails(long id)
        {
            return productRepository.GetDetails(id);
        }

        public List<ProductVeiwModel> GetProducts()
        {
            return productRepository.GetProducts();
        }

        public OperationResult IsStock(long id)
        {
            var opration = new OperationResult();

            var product = productRepository.Get(id);
            if (product == null)
                return opration.Failed(ApplicationMessages.RecordNotFound);

            product.InStock();
            productRepository.SaveChanges();
            return opration.Succedded();
        }

        public OperationResult NotInStock(long id)
        {
            var opration = new OperationResult();

            var product = productRepository.Get(id);
            if (product == null)
                return opration.Failed(ApplicationMessages.RecordNotFound);

            product.NotInStock();
            productRepository.SaveChanges();
            return opration.Succedded();
        }

        public List<ProductVeiwModel> Search(ProductSearchModel command)
        {
            return productRepository.Search(command);
        }
    }
}
