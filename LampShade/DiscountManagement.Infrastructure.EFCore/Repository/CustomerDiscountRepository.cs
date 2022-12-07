using _0_Framework.Application;
using _0_Framework.Infrastructure;
using DiscountManagement.Application.Contracts.CustomerDiscount;
using DiscountManagement.Domain.CustomerDiscountAgg;
using ShopManagement.Infrastructure.EFCore;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;



namespace DiscountManagement.Infrastructure.EFCore.Repository
{
    public class CustomerDiscountRepository : RepositoryBase<long, CustomerDiscount>, ICustomerDiscountRepository
    {
        private readonly DiscountContext _context;
        private readonly ShopContext _shopContext;

        public CustomerDiscountRepository(DiscountContext context, ShopContext shopContext) : base(context)
        {
            _context = context;
            _shopContext = shopContext;
        }

        public EditCustomerDiscount GetDetails(long id)
        {
            return _context.CustomerDiscounts.Select(x => new EditCustomerDiscount
            {
                Id = x.Id,
                ProductId = x.ProductId,
                DiscountRate = x.DiscountRate,
                StartDate = x.StartDate.ToString(CultureInfo.InvariantCulture),
                EndDate = x.EndDate.ToString(CultureInfo.InvariantCulture),
                Reason = x.Reason
            }).FirstOrDefault(x => x.Id == id);
        }

        public List<CustomerDiscountViewModel> Search(CustomerDiscountSearchModel command)
        {
            var products = _shopContext.Products.Select(x => new { x.Id, x.Name });

            var query = _context.CustomerDiscounts.Select(x => new CustomerDiscountViewModel()
            {
                Id = x.Id,
                ProductId = x.ProductId,
                DiscountRate = x.DiscountRate,
                Reason = x.Reason,
                StartDateGr = x.StartDate,
                EndDateGr = x.EndDate,
                EndDate = x.EndDate.ToFarsi(),
                StartDate = x.StartDate.ToFarsi(),
                CreationDate = x.CreationDate.ToFarsi()
            });

            if (command.ProductId > 0)
                query = query.Where(x => x.ProductId == command.ProductId);

            if (!string.IsNullOrWhiteSpace(command.StartDate))
            {
                var startDate = command.StartDate.ToGeorgianDateTime();
                query = query.Where(x => x.StartDateGr > startDate);
            }

            if (!string.IsNullOrWhiteSpace(command.EndDate))
            {
                var EndDate = command.EndDate.ToGeorgianDateTime();
                query = query.Where(x => x.EndDateGr < EndDate);
            }

            var discounts = query.ToList();
            discounts.ForEach(discounts =>
                    discounts.ProductName = products.FirstOrDefault(x => x.Id == discounts.ProductId)?.Name);
            return discounts;
        }
    }
}
