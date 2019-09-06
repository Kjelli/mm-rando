using Avalonia.Media;
using ReactiveUI;

namespace NotWinForm.ViewModels
{
    public class ColorPickerSettingsViewModel : ViewModelBase
    {
        private string _settingLabel;
        public string SettingLabel
        {
            get => _settingLabel;
            set => this.RaiseAndSetIfChanged(ref _settingLabel, value);
        }
        private Color _selectedColor;
        public Color SelectedColor
        {
            get => _selectedColor;
            set => this.RaiseAndSetIfChanged(ref _selectedColor, value);
        }

        public ColorPickerSettingsViewModel(string label, Color initialColor)
        {
            SettingLabel = label;
            SelectedColor = initialColor;
        }
    }
}
