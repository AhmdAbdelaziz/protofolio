using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdminArea.onlinestore.categoryRow>;
using MyRow = AdminArea.onlinestore.categoryRow;

namespace AdminArea.onlinestore;

public interface IcategoryRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class categoryRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IcategoryRetrieveHandler
{
    public categoryRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}