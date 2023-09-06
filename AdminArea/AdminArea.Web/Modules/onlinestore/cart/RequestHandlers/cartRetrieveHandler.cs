using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdminArea.onlinestore.cartRow>;
using MyRow = AdminArea.onlinestore.cartRow;

namespace AdminArea.onlinestore;

public interface IcartRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class cartRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IcartRetrieveHandler
{
    public cartRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}