using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = AdminArea.onlinestore.cartRow;

namespace AdminArea.onlinestore;

public interface IcartDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class cartDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IcartDeleteHandler
{
    public cartDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}