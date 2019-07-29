using System.ComponentModel;
using Enum_To_Combobox.Converters;

namespace Enum_To_Combobox.Enums
{
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ImageFormat
    {
        [Description("Windows Bitmap")]
        BMP,
        [Description("Graphics Interchange Format")]
        GIF,
        [Description("Joint Photographic Experts Group Format")]
        JPG,
        [Description("Portable Network Graphics Format")]
        PNG,
        [Description("Tagged Image Format")]
        TIFF,
        [Description("Windows Media Photo Format")]
        WDP
    }
}
