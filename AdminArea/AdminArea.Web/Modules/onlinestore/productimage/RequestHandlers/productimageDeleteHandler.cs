using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = AdminArea.onlinestore.productimageRow;

namespace AdminArea.onlinestore;

public interface IproductimageDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class productimageDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IproductimageDeleteHandler
{
    public productimageDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}