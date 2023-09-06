using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdminArea.onlinestore.diagramRow>;
using MyRow = AdminArea.onlinestore.diagramRow;

namespace AdminArea.onlinestore;

public interface IdiagramListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class diagramListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IdiagramListHandler
{
    public diagramListHandler(IRequestContext context)
            : base(context)
    {
    }
}