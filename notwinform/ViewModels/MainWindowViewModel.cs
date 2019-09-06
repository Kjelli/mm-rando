using Avalonia.Media;
using MMRando.Models;

namespace NotWinForm.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        #region Setting Values

        // Main Settings
        public FileSelectSettingsViewModel UploadRom { get; set; }
        public ComboSettingsViewModel<LogicMode> LogicMode { get; set; }

        // Gimmicks
        public ComboSettingsViewModel<DamageMode> DamageMode { get; set; }
        public ComboSettingsViewModel<DamageEffect> DamageEffect { get; set; }
        public ComboSettingsViewModel<MovementMode> MovementMode { get; set; }
        public ComboSettingsViewModel<FloorType> FloorType { get; set; }
        public ComboSettingsViewModel<ClockSpeed> ClockSpeed { get; set; }

        // Miscellaneous
        public ColorPickerSettingsViewModel TunicColor { get; set; }
        public ComboSettingsViewModel<Character> PlayerModel { get; set; }
        public ComboSettingsViewModel<TatlColorSchema> TatlColor { get; set; }
        public ComboSettingsViewModel<GossipHintStyle> GossipHints { get; set; }

        #endregion

        public MainWindowViewModel()
        {
            InitializeView();
        }

        private void InitializeView()
        {
            UploadRom = new FileSelectSettingsViewModel();
            LogicMode = new ComboSettingsViewModel<LogicMode>();

            DamageMode = new ComboSettingsViewModel<DamageMode>();
            DamageEffect = new ComboSettingsViewModel<DamageEffect>();
            MovementMode = new ComboSettingsViewModel<MovementMode>();
            FloorType = new ComboSettingsViewModel<FloorType>();
            ClockSpeed = new ComboSettingsViewModel<ClockSpeed>();

            TunicColor = new ColorPickerSettingsViewModel("Tunic Color", Color.FromRgb(0x1E, 0x69, 0x1B));
            PlayerModel = new ComboSettingsViewModel<Character>();
            TatlColor = new ComboSettingsViewModel<TatlColorSchema>();
            GossipHints = new ComboSettingsViewModel<GossipHintStyle>();
        }
    }
}
