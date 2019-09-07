using Avalonia;
using Avalonia.Logging.Serilog;
using NotWinForm.Models;
using NotWinForm.Services;
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
        public static void Main(string[] args) => BuildAvaloniaApp().Start<MainView>(() => new MainViewModel());

        // Avalonia configuration, don't remove; also used by visual designer.
        public static AppBuilder BuildAvaloniaApp()
        {
            Locator.CurrentMutable.RegisterLazySingleton(() => new ConventionalViewLocator(), typeof(IViewLocator));
            Locator.CurrentMutable.RegisterViewsForViewModels(Assembly.GetExecutingAssembly());

            Locator.CurrentMutable.RegisterConstant(new SettingsViewModel(), typeof(SettingsViewModel));
            Locator.CurrentMutable.RegisterConstant(new DialogMessageService(), typeof(DialogMessageService));

            return AppBuilder.Configure<App>()
                           .UseReactiveUI()
                           .UsePlatformDetect()
                           .LogToDebug();
        }
    }
}
