using Avalonia;
using Avalonia.Media;
using MMRando.Models;
using NotWinForm.Models;
using NotWinForm.Utils;
using ReactiveUI;
using System.Reactive;
using System.Threading.Tasks;

namespace NotWinForm.ViewModels
{
    public partial class MainViewModel : ViewModelBase
    {
        #region Setting Values

        // Main Settings
        public ComboViewModel<LogicMode> LogicMode { get; set; }

        // Gimmicks
        public ComboViewModel<DamageMode> DamageMode { get; set; }
        public ComboViewModel<DamageEffect> DamageEffect { get; set; }
        public ComboViewModel<MovementMode> MovementMode { get; set; }
        public ComboViewModel<FloorType> FloorType { get; set; }
        public ComboViewModel<ClockSpeed> ClockSpeed { get; set; }

        // Miscellaneous
        public ColorPickerViewModel TunicColor { get; set; }
        public ComboViewModel<Character> PlayerModel { get; set; }
        public ComboViewModel<TatlColorSchema> TatlColor { get; set; }
        public ComboViewModel<GossipHintStyle> GossipHints { get; set; }

        #endregion

        #region Commands
        public ReactiveCommand<string, Unit> RomSelectedCommand { get; set; }
        #endregion

        public RandomizerSettings Settings { get; set; }

        public MainViewModel()
        {
            InitializeView();
            InitializeCommands();

            Settings = new RandomizerSettings();
        }


        private void InitializeView()
        {
            LogicMode = new ComboViewModel<LogicMode>();

            DamageMode = new ComboViewModel<DamageMode>();
            DamageEffect = new ComboViewModel<DamageEffect>();
            MovementMode = new ComboViewModel<MovementMode>();
            FloorType = new ComboViewModel<FloorType>();
            ClockSpeed = new ComboViewModel<ClockSpeed>();

            TunicColor = new ColorPickerViewModel("Tunic Color", Color.FromRgb(0x1E, 0x69, 0x1B));
            PlayerModel = new ComboViewModel<Character>();
            TatlColor = new ComboViewModel<TatlColorSchema>();
            GossipHints = new ComboViewModel<GossipHintStyle>();
        }

        private void InitializeCommands()
        {
            RomSelectedCommand = ReactiveCommand.CreateFromTask<string, Unit>(RomSelected);
        }

        private Task<Unit> RomSelected(string foo)
        {
            var message = DialogBuilder.SuccessOk("TEST");

            message.ShowDialog(Application.Current.MainWindow);

            return Task.FromResult(Unit.Default);
        }
    }
}
