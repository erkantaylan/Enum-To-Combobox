using System.ComponentModel;

namespace Enum_To_Combobox
{
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
