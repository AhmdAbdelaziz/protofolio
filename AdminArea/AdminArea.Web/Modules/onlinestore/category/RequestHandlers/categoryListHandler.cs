using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdminArea.onlinestore.categoryRow>;
using MyRow = AdminArea.onlinestore.categoryRow;

namespace AdminArea.onlinestore;

public interface IcategoryListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class categoryListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IcategoryListHandler
{
    public categoryListHandler(IRequestContext context)
            : base(context)
    {
    }
}