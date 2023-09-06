using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdminArea.onlinestore.reviewRow>;
using MyRow = AdminArea.onlinestore.reviewRow;

namespace AdminArea.onlinestore;

public interface IreviewListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class reviewListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IreviewListHandler
{
    public reviewListHandler(IRequestContext context)
            : base(context)
    {
    }
}