using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace NotWinForm.Views.Controls
{
    public class ComboView : UserControl
    {
        public ComboView()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
