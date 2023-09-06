using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace AdminArea.onlinestore;

[ConnectionKey("WebApplication9"), Module("onlinestore"), TableName("REVIEW")]
[DisplayName("Review"), InstanceName("Review")]
[ReadPermission("review")]
[ModifyPermission("review")]
public sealed class reviewRow : Row<reviewRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id"), Identity, IdProperty]
    public int? Id
    {
        get => fields.Id[this];
        set => fields.Id[this] = value;
    }

    [DisplayName("Name"), QuickSearch, NameProperty]
    public string Name
    {
        get => fields.Name[this];
        set => fields.Name[this] = value;
    }

    [DisplayName("Description")]
    public string Description
    {
        get => fields.Description[this];
        set => fields.Description[this] = value;
    }

    [DisplayName("Subject")]
    public string Subject
    {
        get => fields.Subject[this];
        set => fields.Subject[this] = value;
    }

    [DisplayName("Email")]
    public string Email
    {
        get => fields.Email[this];
        set => fields.Email[this] = value;
    }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public StringField Name;
        public StringField Description;
        public StringField Subject;
        public StringField Email;

    }
}