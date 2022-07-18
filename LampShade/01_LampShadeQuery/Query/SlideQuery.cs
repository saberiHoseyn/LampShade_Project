using _01_LampShadeQuery.Contracts.Slide;
using ShopManagement.Infrastructure.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_LampShadeQuery.Query
{
    public class SlideQuery : ISlideQuery
    {
        private readonly ShopContext shopContext;

        public SlideQuery(ShopContext shopContext)
        {
            this.shopContext = shopContext;
        }

        public List<SlideQueryModel> GetSlides()
        {
            return shopContext.Slides
                .Where(x => x.IsRemove == false)
                .Select(x => new SlideQueryModel
                {
                    Picture = x.Picture,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                    Heding = x.Heding,
                    Title = x.Title,
                    Text = x.Text,
                    BtnText = x.BtnText,
                    Link = x.Link
                })
                .ToList();
        }
    }
}
