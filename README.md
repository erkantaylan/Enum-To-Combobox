# Enum-To-Combobox
Better way to show enum values on lists XAML WPF

It is as easy like this to show enums and descriptions at xaml side 


XAML Side
```
<ListBox ItemsSource="{Binding Source={extensions:EnumBindingSource {x:Type local:ImageFormat}}}"
                     Padding="10"
                     Margin="10" />
```

Sample enum (`[TypeConverter(typeof(EnumDescriptionTypeConverter))]` is must)
```
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
