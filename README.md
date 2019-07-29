# Enum-To-Combobox
Better way to show enum values on lists XAML WPF

It is as easy like this to show enums and descriptions at xaml side 


XAML Side
```xaml
<ListBox ItemsSource="{Binding Source={extensions:EnumBindingSource {x:Type local:Status}}}" />
```

Sample enum (`[TypeConverter(typeof(EnumDescriptionTypeConverter))]` is must)
```C#
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
```
