using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace NotWinForm.Views.Partials
{
    public class RomSettingsView : UserControl
    {
        public RomSettingsView()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
