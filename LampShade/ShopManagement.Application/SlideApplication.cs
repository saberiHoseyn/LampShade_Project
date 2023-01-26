using _0_Framework.Application;
using ShopManagement.Application.Contracts.SlideAgg;
using ShopManagement.Domain.SlideAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Application
{
    public class SlideApplication : ISlideApplication
    {
        private readonly ISlideRepository slideRepository;
        private readonly IFileUploader _fileUploader;


        public SlideApplication(ISlideRepository islideRepository, IFileUploader fileUploader)
        {
            this.slideRepository = islideRepository;
            _fileUploader = fileUploader;
        }

        public OperationResult Create(CreateSlide command)
        {
            var operation = new OperationResult();

            var pictureName = _fileUploader.Upload(command.Picture, "slides");
            var slide = new Slide(pictureName, command.PictureAlt, command.PictureTitle,
                command.Heding, command.Title, command.Text, command.BtnText, command.Link);
            slideRepository.Create(slide);
            slideRepository.SaveChanges();
            return operation.Succedded();
        }

        public OperationResult Edit(EditSlide command)
        {
            var operation = new OperationResult();

            var slide = slideRepository.Get(command.Id);
            if (slide == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            var pictureName = _fileUploader.Upload(command.Picture, "slides");
            slide.Edit(pictureName, command.PictureAlt, command.PictureTitle,
                command.Heding, command.Title, command.Text, command.BtnText, command.Link);
            slideRepository.SaveChanges();
            return operation.Succedded();

        }

        public EditSlide GetDetails(long id)
        {
            return slideRepository.GetDetails(id);
        }

        public List<SlideViewModel> GetListSlid()
        {
            return slideRepository.GetList();
        }

        public OperationResult Remove(long id)
        {
            var opration = new OperationResult();

            var slide = slideRepository.Get(id);
            if (slide == null)
                return opration.Failed(ApplicationMessages.RecordNotFound);

            slide.Remove();
            slideRepository.SaveChanges();
            return opration.Succedded();
        }

        public OperationResult Restore(long id)
        {
            var opration = new OperationResult();

            var slide = slideRepository.Get(id);
            if (slide == null)
                return opration.Failed(ApplicationMessages.RecordNotFound);

            slide.Restore();
            slideRepository.SaveChanges();
            return opration.Succedded();
        }
    }
}
