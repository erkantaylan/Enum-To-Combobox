using Enum_To_Combobox.ViewModels;

namespace Enum_To_Combobox.Views
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new ViewModel();
        }
    }
}
