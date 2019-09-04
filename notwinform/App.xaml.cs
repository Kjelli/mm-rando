using Avalonia;
using Avalonia.Markup.Xaml;

namespace NotWinForm
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
