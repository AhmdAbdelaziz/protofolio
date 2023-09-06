using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace AdminArea.onlinestore;

[ConnectionKey("WebApplication9"), Module("onlinestore"), TableName("sysdiagrams")]
[DisplayName("Diagram"), InstanceName("Diagram")]
[ReadPermission("diagram")]
[ModifyPermission("diagram")]
public sealed class diagramRow : Row<diagramRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Name"), Column("name"), Size(128), NotNull, QuickSearch, NameProperty]
    public string Name
    {
        get => fields.Name[this];
        set => fields.Name[this] = value;
    }

    [DisplayName("Principal Id"), Column("principal_id"), NotNull]
    public int? PrincipalId
    {
        get => fields.PrincipalId[this];
        set => fields.PrincipalId[this] = value;
    }

    [DisplayName("Diagram Id"), Column("diagram_id"), Identity, IdProperty]
    public int? DiagramId
    {
        get => fields.DiagramId[this];
        set => fields.DiagramId[this] = value;
    }

    [DisplayName("Version"), Column("version")]
    public int? Version
    {
        get => fields.Version[this];
        set => fields.Version[this] = value;
    }

    [DisplayName("Definition"), Column("definition")]
    public byte[] Definition
    {
        get => fields.Definition[this];
        set => fields.Definition[this] = value;
    }

    public class RowFields : RowFieldsBase
    {
        public StringField Name;
        public Int32Field PrincipalId;
        public Int32Field DiagramId;
        public Int32Field Version;
        public ByteArrayField Definition;

    }
}