using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<AdminArea.onlinestore.diagramRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdminArea.onlinestore.diagramRow;

namespace AdminArea.onlinestore;

public interface IdiagramSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class diagramSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IdiagramSaveHandler
{
    public diagramSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}