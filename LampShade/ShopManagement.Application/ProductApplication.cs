using _0_Framework.Application;
using ShopManagement.Application.Contracts.ProductAgg;
using ShopManagement.Domain.ProductAgg;
using ShopManagement.Domain.ProductCategoryAgg;
using System.Collections.Generic;


namespace ShopManagement.Application
{
    public class ProductApplication : IProductApplication
    {
        private readonly IProductCategoryRepository _productCategoryRepository;
        private readonly IProductRepository productRepository;
        private readonly IFileUploader _fileUploader;

        public ProductApplication(IProductRepository productRepository, IFileUploader fileUploader, IProductCategoryRepository productCategoryRepository)
        {
            this.productRepository = productRepository;
            _fileUploader = fileUploader;
            _productCategoryRepository = productCategoryRepository;
        }

        public OperationResult Create(CreateProduct command)
        {
            var opration = new OperationResult();
            if (productRepository.Exists(x => x.Name == command.Name))
                return opration.Failed(ApplicationMessages.DuplicatedRecord);

            var slug = command.Slug.Slugify();
            var categorySlug = _productCategoryRepository.GetSlugById(command.CategoryId);
            var path = $"{categorySlug}/{slug}";
            var picturePath = _fileUploader.Upload(command.Picture, path);
            var product = new Product(command.Name, command.Code, command.ShortDescription,
                command.Description, picturePath, command.PictureAlt, command.PictureTitle,
                command.CategoryId, slug, command.Keywords, command.MetaDescription);
            productRepository.Create(product);
            productRepository.SaveChanges();
            return opration.Succedded();
        }

        public OperationResult Edit(EditProduct command)
        {
            var opration = new OperationResult();
            var product = productRepository.GetProductWithCategory(command.Id);
            if (product == null)
                return opration.Failed(ApplicationMessages.RecordNotFound);
            
            if (productRepository.Exists(x => x.Name == command.Name && x.Id != command.Id))
                return opration.Failed(ApplicationMessages.DuplicatedRecord);

            var slug = command.Slug.Slugify();
            var path = $"{product.Category.Slug}/{slug}";
            var picturePath = _fileUploader.Upload(command.Picture, path);

            product.Edit(command.Name, command.Code, command.ShortDescription, command.Description,
                picturePath, command.PictureAlt, command.PictureTitle, command.CategoryId, slug,
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

        public List<ProductVeiwModel> Search(ProductSearchModel command)
        {
            return productRepository.Search(command);
        }
    }
}
