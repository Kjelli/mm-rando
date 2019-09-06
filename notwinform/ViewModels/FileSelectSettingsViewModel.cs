using Avalonia;
using Avalonia.Controls;
using ReactiveUI;
using System.Collections.Generic;
using System.Reactive;
using System.Threading.Tasks;

namespace NotWinForm.ViewModels
{
    public class FileSelectSettingsViewModel : ViewModelBase
    {
        private string _descriptionText;
        public string DescriptionText
        {
            get => _descriptionText;
            set => this.RaiseAndSetIfChanged(ref _descriptionText, value);
        }

        private string _buttonText;
        public string ButtonText
        {
            get => _buttonText;
            set => this.RaiseAndSetIfChanged(ref _buttonText, value);
        }

        private string _selectedFilePath;
        public string SelectedFilePath
        {
            get => _selectedFilePath;
            set => this.RaiseAndSetIfChanged(ref _selectedFilePath, value);
        }

        public ReactiveCommand<Unit, Unit> OpenBrowserCommand { get; }


        public FileSelectSettingsViewModel()
        {
            ButtonText = "Hei";
            OpenBrowserCommand = ReactiveCommand.CreateFromTask(RunTheThing);
        }
        private async Task RunTheThing()
        {
            // Code for executing the command here.
            var fileDialog = new OpenFileDialog
            {
                Filters = new List<FileDialogFilter>
                {
                    new FileDialogFilter
                    {
                        Name = "ROM",
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
            }
        }
    }
}
