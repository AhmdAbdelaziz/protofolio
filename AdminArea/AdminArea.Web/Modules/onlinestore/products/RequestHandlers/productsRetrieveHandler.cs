using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdminArea.onlinestore.productsRow>;
using MyRow = AdminArea.onlinestore.productsRow;

namespace AdminArea.onlinestore;

public interface IproductsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class productsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IproductsRetrieveHandler
{
    public productsRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}