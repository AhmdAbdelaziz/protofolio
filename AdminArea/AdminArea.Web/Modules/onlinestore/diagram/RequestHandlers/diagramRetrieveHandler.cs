using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdminArea.onlinestore.diagramRow>;
using MyRow = AdminArea.onlinestore.diagramRow;

namespace AdminArea.onlinestore;

public interface IdiagramRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class diagramRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IdiagramRetrieveHandler
{
    public diagramRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}