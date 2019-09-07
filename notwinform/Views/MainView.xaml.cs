using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace NotWinForm.Views
{
    public class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            new CheckBox();
            AvaloniaXamlLoader.Load(this);
        }
    }
}
