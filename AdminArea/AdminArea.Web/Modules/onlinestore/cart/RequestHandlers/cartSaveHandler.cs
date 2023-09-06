using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<AdminArea.onlinestore.cartRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdminArea.onlinestore.cartRow;

namespace AdminArea.onlinestore;

public interface IcartSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class cartSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IcartSaveHandler
{
    public cartSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}