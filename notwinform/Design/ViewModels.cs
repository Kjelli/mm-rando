using Avalonia.Media;
using NotWinForm.ViewModels;
using System;

namespace NotWinForm.Design
{
    public class ViewModels
    {
        public static MainWindowViewModel ExampleMainWindow => new MainWindowViewModel();
        public static ComboSettingsViewModel<DayOfWeek> ExampleCombo => new ComboSettingsViewModel<DayOfWeek>("Day of week");
        public static ColorPickerSettingsViewModel ExampleColorPicker => new ColorPickerSettingsViewModel("Favorite Color", Color.FromRgb(255, 255, 0));
        public static FileSelectSettingsViewModel ExampleFileSelect => new FileSelectSettingsViewModel
        {
            DescriptionText = "The file should be less than 250 Mb!",
            ButtonText = "Upload This",
            SelectedFilePath = "C:\\Users\\Foobar"

        };
    }
}
