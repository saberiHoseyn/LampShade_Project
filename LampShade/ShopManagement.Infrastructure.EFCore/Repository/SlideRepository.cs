using _0_Framework.Infrastructure;
using ShopManagement.Application.Contracts.SlideAgg;
using ShopManagement.Domain.SlideAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Infrastructure.EFCore.Repository
{
    public class SlideRepository : RepositoryBase<long, Slide>, ISlideRepository
    {
        private readonly ShopContext context;

        public SlideRepository(ShopContext shopContext) : base(shopContext)
        {
            context = shopContext;
        }

        public EditSlide GetDetails(long id)
        {
            return context.Slides.Select(x => new EditSlide
            {
                Id = x.Id,
                Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                Heding = x.Heding,
                Text = x.Text,
                Title = x.Title,
                BtnText = x.BtnText,
                Link = x.Link
            }).FirstOrDefault(x => x.Id == id);
        }

        public List<SlideViewModel> GetList()
        {
            return context.Slides.Select(x => new SlideViewModel
            {
                Id = x.Id,
                Picture = x.Picture,
                Heding = x.Heding,
                Title = x.Title,
                IsRemove = x.IsRemove,
                Link = x.Link,
                CreationDate = x.CreationDate.ToString()
            }).OrderByDescending(x => x.Id).ToList();
        }
    }
}
