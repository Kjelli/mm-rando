using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using ReactiveUI;
using System.Collections.Generic;
using System.Reactive;
using System.Threading.Tasks;

namespace NotWinForm.Views.Controls
{
    public class FileSelectView : UserControl
    {
        public static readonly StyledProperty<string> ButtonTextProperty =
           AvaloniaProperty.Register<FileSelectView, string>(nameof(ButtonText));

        public static readonly StyledProperty<string> DescriptionTextProperty =
           AvaloniaProperty.Register<FileSelectView, string>(nameof(DescriptionText));

        public static readonly StyledProperty<string> SelectedFilePathProperty =
           AvaloniaProperty.Register<FileSelectView, string>(nameof(SelectedFilePath));

        public static readonly StyledProperty<ReactiveCommand<string, Unit>> OnFileSelectProperty =
           AvaloniaProperty.Register<FileSelectView, ReactiveCommand<string, Unit>>(nameof(OnFileSelect));

        public string ButtonText
        {
            get { return GetValue(ButtonTextProperty); }
            set { SetValue(ButtonTextProperty, value); }
        }

        public string DescriptionText
        {
            get { return GetValue(ButtonTextProperty); }
            set { SetValue(ButtonTextProperty, value); }
        }
        public string SelectedFilePath
        {
            get { return GetValue(SelectedFilePathProperty); }
            set { SetValue(SelectedFilePathProperty, value); }
        }

        public ReactiveCommand<string, Unit> OnFileSelect
        {
            get { return GetValue(OnFileSelectProperty); }
            set { SetValue(OnFileSelectProperty, value); }
        }

        public ReactiveCommand<Unit, Unit> OpenBrowserCommand { get; }

        public FileSelectView()
        {
            InitializeComponent();

            OpenBrowserCommand = ReactiveCommand.CreateFromTask(OpenBrowser);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private async Task OpenBrowser()
        {
            // Code for executing the command here.
            var fileDialog = new OpenFileDialog
            {
                Filters = new List<FileDialogFilter>
                {
                    new FileDialogFilter
                    {
                        Name = "N64 ROM",
                        Extensions = new List<string>
                        {
                            "z64"
                        }
                    }
                }
            };

            var result = await fileDialog.ShowAsync(Application.Current.MainWindow);

            if (result.Length > 0)
            {
                SelectedFilePath = result[0];
                OnFileSelect?.Execute(result[0]);
            }
        }
    }
}
