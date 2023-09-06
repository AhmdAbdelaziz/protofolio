using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdminArea.onlinestore.reviewRow>;
using MyRow = AdminArea.onlinestore.reviewRow;

namespace AdminArea.onlinestore;

public interface IreviewRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class reviewRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IreviewRetrieveHandler
{
    public reviewRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}