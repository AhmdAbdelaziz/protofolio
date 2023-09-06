using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdminArea.onlinestore.productimageRow>;
using MyRow = AdminArea.onlinestore.productimageRow;

namespace AdminArea.onlinestore;

public interface IproductimageRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class productimageRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IproductimageRetrieveHandler
{
    public productimageRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}