using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdminArea.onlinestore.productsRow>;
using MyRow = AdminArea.onlinestore.productsRow;

namespace AdminArea.onlinestore;

public interface IproductsListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class productsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IproductsListHandler
{
    public productsListHandler(IRequestContext context)
            : base(context)
    {
    }
}