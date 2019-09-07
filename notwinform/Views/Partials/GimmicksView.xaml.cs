using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace NotWinForm.Views.Partials
{
    public class GimmicksView : UserControl
    {
        public GimmicksView()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
