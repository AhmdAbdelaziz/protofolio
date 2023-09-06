using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = AdminArea.onlinestore.reviewRow;

namespace AdminArea.onlinestore;

public interface IreviewDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class reviewDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IreviewDeleteHandler
{
    public reviewDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}