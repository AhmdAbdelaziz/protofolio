﻿using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = AdminArea.onlinestore.categoryRow;

namespace AdminArea.onlinestore;

public interface IcategoryDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class categoryDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IcategoryDeleteHandler
{
    public categoryDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}