using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<AdminArea.onlinestore.reviewRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdminArea.onlinestore.reviewRow;

namespace AdminArea.onlinestore;

public interface IreviewSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class reviewSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IreviewSaveHandler
{
    public reviewSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}