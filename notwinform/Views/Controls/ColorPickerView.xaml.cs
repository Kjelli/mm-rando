using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace NotWinForm.Views.Controls
{
    public class ColorPickerView : UserControl
    {
        public ColorPickerView()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
