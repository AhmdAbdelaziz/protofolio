using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdminArea.onlinestore.cartRow>;
using MyRow = AdminArea.onlinestore.cartRow;

namespace AdminArea.onlinestore;

public interface IcartListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class cartListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IcartListHandler
{
    public cartListHandler(IRequestContext context)
            : base(context)
    {
    }
}