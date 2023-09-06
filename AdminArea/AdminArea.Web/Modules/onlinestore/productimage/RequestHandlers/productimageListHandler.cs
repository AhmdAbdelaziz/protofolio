using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdminArea.onlinestore.productimageRow>;
using MyRow = AdminArea.onlinestore.productimageRow;

namespace AdminArea.onlinestore;

public interface IproductimageListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class productimageListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IproductimageListHandler
{
    public productimageListHandler(IRequestContext context)
            : base(context)
    {
    }
}