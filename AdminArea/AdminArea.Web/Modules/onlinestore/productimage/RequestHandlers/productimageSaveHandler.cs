using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<AdminArea.onlinestore.productimageRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdminArea.onlinestore.productimageRow;

namespace AdminArea.onlinestore;

public interface IproductimageSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class productimageSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IproductimageSaveHandler
{
    public productimageSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}