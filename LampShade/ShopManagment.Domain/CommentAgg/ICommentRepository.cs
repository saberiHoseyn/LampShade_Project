using _0_Framework.Domain;
using ShopManagement.Application.Contracts.CommentAgg;
using System.Collections.Generic;


namespace ShopManagement.Domain.CommentAgg
{
    public interface ICommentRepository : IRepository<long, Comment>
    {
        List<CommentViewModel> Search(CommentSearchModel searchModel);
    }
}
