using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<AdminArea.onlinestore.categoryRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdminArea.onlinestore.categoryRow;

namespace AdminArea.onlinestore;

public interface IcategorySaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class categorySaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IcategorySaveHandler
{
    public categorySaveHandler(IRequestContext context)
            : base(context)
    {
    }
}