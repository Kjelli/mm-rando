using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace NotWinForm.Views.Partials
{
    public class PatchSettingsView : UserControl
    {
        public PatchSettingsView()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
