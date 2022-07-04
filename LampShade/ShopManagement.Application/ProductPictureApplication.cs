using _0_Framework.Application;
using ShopManagement.Application.Contracts.ProductPictureAgg;
using ShopManagement.Domain.ProductPictureAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Application
{
    public class ProductPictureApplication : IProductPictureApplication
    {
        private readonly IProductPictureRepository productPictureRepository;

        public ProductPictureApplication(IProductPictureRepository productPictureRepository)
        {
            this.productPictureRepository = productPictureRepository;
        }

        public OperationResult Create(CreateProductPicture command)
        {
            var opration = new OperationResult();
            if (productPictureRepository.Exists(x => x.Picture == command.Picture && x.ProductId == command.ProductId))
                return opration.Failed(ApplicationMessages.DuplicatedRecord);
            var productPicture = new ProductPicture(command.ProductId, command.Picture, command.PictureAlt, command.PictureTitle);
            productPictureRepository.Create(productPicture);
            productPictureRepository.SaveChanges();
            return opration.Succedded();
        }

        public OperationResult Edit(EditProductPicture command)
        {
            var opration = new OperationResult();

            var productPicture = productPictureRepository.Get(command.Id);
            if (productPicture == null)
                return opration.Failed(ApplicationMessages.RecordNotFound);

            if (productPictureRepository.Exists(x => x.Picture == command.Picture &&
            x.ProductId == command.ProductId && x.Id != command.Id))
                return opration.Failed(ApplicationMessages.DuplicatedRecord);

            productPicture.Edit(command.ProductId, command.Picture, command.PictureAlt, command.PictureTitle);
            productPictureRepository.SaveChanges();
            return opration.Succedded();
        }

        public EditProductPicture GetDetails(long id)
        {
            return productPictureRepository.GetDetails(id);
        }

        public OperationResult Remove(long id)
        {
            var opration = new OperationResult();
            
            var productPicture = productPictureRepository.Get(id);
            if (productPicture == null)
                return opration.Failed(ApplicationMessages.RecordNotFound);

            productPicture.Remove();
            productPictureRepository.SaveChanges();
            return opration.Succedded();
        }

        public OperationResult Restore(long id)
        {
            var opration = new OperationResult();

            var productPicture = productPictureRepository.Get(id);
            if (productPicture == null)
                return opration.Failed(ApplicationMessages.RecordNotFound);

            productPicture.Restore();
            productPictureRepository.SaveChanges();
            return opration.Succedded();
        }

        public List<ProductPictureViewModel> Search(ProductPictureSearchModel searchModel)
        {
            return productPictureRepository.Search(searchModel);
        }
    }
}
