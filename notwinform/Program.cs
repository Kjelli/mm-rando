using Avalonia;
using Avalonia.Logging.Serilog;
using NotWinForm.ViewModels;
using NotWinForm.Views;
using ReactiveUI;
using Splat;
using System.Reflection;

namespace NotWinForm
{
    class Program
    {
        // Initialization code. Don't use any Avalonia, third-party APIs or any
        // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
        // yet and stuff might break.
        public static void Main(string[] args) => BuildAvaloniaApp().Start<MainWindowView>(() => new MainWindowViewModel());

        // Avalonia configuration, don't remove; also used by visual designer.
        public static AppBuilder BuildAvaloniaApp()
        {
            Locator.CurrentMutable.RegisterLazySingleton(() => new ConventionalViewLocator(), typeof(IViewLocator));
            Locator.CurrentMutable.RegisterViewsForViewModels(Assembly.GetExecutingAssembly());

            return AppBuilder.Configure<App>()
                           .UsePlatformDetect()
                           .LogToDebug()
                           .UseReactiveUI();
        }
    }
}
