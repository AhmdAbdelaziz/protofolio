using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = AdminArea.onlinestore.productsRow;

namespace AdminArea.onlinestore;

public interface IproductsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class productsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IproductsDeleteHandler
{
    public productsDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}