using Avalonia;
using Avalonia.Media;
using MMRando;
using NotWinForm.Models;
using NotWinForm.Services;
using ReactiveUI;
using Splat;
using System;
using System.ComponentModel;
using System.Reactive;
using System.Threading.Tasks;

namespace NotWinForm.ViewModels
{
    public partial class MainViewModel : ViewModelBase
    {
        public ColorPickerViewModel TunicColor { get; set; }

        #region Commands
        public ReactiveCommand<string, Unit> RomSelectedCommand { get; set; }
        public ReactiveCommand<Unit, Unit> RandomizeCommand { get; private set; }
        #endregion

        public SettingsViewModel Settings { get; set; }
        public DialogMessageService Messages { get; set; }

        public MainViewModel()
        {
            InitializeView();
            InitializeCommands();

            Settings = Locator.Current.GetService<SettingsViewModel>();
            Messages = Locator.Current.GetService<DialogMessageService>();
        }


        private void InitializeView()
        {
            TunicColor = new ColorPickerViewModel("Tunic Color", Color.FromRgb(0x1E, 0x69, 0x1B));
        }

        private void InitializeCommands()
        {
            RomSelectedCommand = ReactiveCommand.CreateFromTask<string, Unit>(RomSelected);
            RandomizeCommand = ReactiveCommand.CreateFromTask<Unit, Unit>(Randomize);
        }

        private Task<Unit> Randomize(Unit _)
        {
            try
            {
                Randomizer r = new Randomizer(Settings);

                var foo = new BackgroundWorker();
                foo.WorkerReportsProgress = true;
                var nice = r.Randomize(foo);

                Messages.SuccessOk("Randomization complete!", "Success", "Success")
                    .ShowDialog(Application.Current.MainWindow);
            }
            catch (Exception e)
            {
                Messages
                    .ErrorOk(e.Message, "Critical: Could not randomize", "Critical Error")
                    .ShowDialog(Application.Current.MainWindow);
                Messages
                    .ErrorOk(e.StackTrace, "Critical: Could not randomize", "Critical Error")
                    .ShowDialog(Application.Current.MainWindow);
            }
            return Task.FromResult(Unit.Default);
        }

        private Task<Unit> RomSelected(string foo)
        {
            var message = Messages.SuccessOk("TEST");

            message.ShowDialog(Application.Current.MainWindow);

            return Task.FromResult(Unit.Default);
        }
    }
}
