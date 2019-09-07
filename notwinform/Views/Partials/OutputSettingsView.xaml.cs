using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace NotWinForm.Views.Partials
{
    public class OutputSettingsView : UserControl
    {
        public OutputSettingsView()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
