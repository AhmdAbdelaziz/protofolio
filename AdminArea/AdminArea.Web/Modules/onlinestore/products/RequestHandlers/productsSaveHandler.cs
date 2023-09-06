using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<AdminArea.onlinestore.productsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdminArea.onlinestore.productsRow;

namespace AdminArea.onlinestore;

public interface IproductsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class productsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IproductsSaveHandler
{
    public productsSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}