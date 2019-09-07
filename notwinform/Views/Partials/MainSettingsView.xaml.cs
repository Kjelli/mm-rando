using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace NotWinForm.Views.Partials
{
    public class MainSettingsView : UserControl
    {
        public MainSettingsView()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
