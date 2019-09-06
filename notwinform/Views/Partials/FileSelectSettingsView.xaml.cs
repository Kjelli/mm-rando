using Avalonia;
using Avalonia.Markup.Xaml;
using NotWinForm.ViewModels;
using ReactiveUI;

namespace NotWinForm.Views.Partials
{
    public class FileSelectSettingsView : ReactiveUserControl<FileSelectSettingsViewModel>
    {
        public static readonly StyledProperty<string> ButtonTextProperty =
            AvaloniaProperty.Register<FileSelectSettingsView, string>(nameof(ButtonText));

        public static readonly StyledProperty<string> DescriptionTextProperty =
            AvaloniaProperty.Register<FileSelectSettingsView, string>(nameof(DescriptionText));

        public static readonly StyledProperty<string> InitialFilePathProperty =
            AvaloniaProperty.Register<FileSelectSettingsView, string>(nameof(InitialFilePath));

        public string ButtonText
        {
            get { return GetValue(ButtonTextProperty); }
            set { SetValue(ButtonTextProperty, value); }
        }

        public string DescriptionText
        {
            get { return GetValue(DescriptionTextProperty); }
            set { SetValue(DescriptionTextProperty, value); }
        }

        public string InitialFilePath
        {
            get { return GetValue(InitialFilePathProperty); }
            set { SetValue(InitialFilePathProperty, value); }
        }

        public FileSelectSettingsView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.WhenActivated(disposables => { System.Console.WriteLine("activados"); });
            AvaloniaXamlLoader.Load(this);
        }
    }
}
