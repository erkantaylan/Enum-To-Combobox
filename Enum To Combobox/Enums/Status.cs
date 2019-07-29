using System.ComponentModel;
using Enum_To_Combobox.Converters;

namespace Enum_To_Combobox.Enums
{
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum Status
    {
        [Description("This is horrible")]
        Horrible,
        [Description("This is bad")]
        Bad,
        [Description("This is so so")]
        SoSo,
        [Description("This is good")]
        Good,
        [Description("This is better")]
        Better,
        [Description("This is best")]
        Best
    }
}
