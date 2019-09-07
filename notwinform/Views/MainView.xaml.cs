using Avalonia;
using Avalonia.Markup.Xaml;
using NotWinForm.ViewModels;

namespace NotWinForm.Views
{
    public class MainView : ReactiveWindow<MainViewModel>
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
            AvaloniaXamlLoader.Load(this);
        }
    }
}
