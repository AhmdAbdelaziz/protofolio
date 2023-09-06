using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = AdminArea.onlinestore.diagramRow;

namespace AdminArea.onlinestore;

public interface IdiagramDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class diagramDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IdiagramDeleteHandler
{
    public diagramDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}