using Avalonia.Media;
using NotWinForm.ViewModels;
using System;

namespace NotWinForm.Design
{
    public class ViewModels
    {
        public static MainViewModel ExampleMainWindow => new MainViewModel();
        public static ComboViewModel<DayOfWeek> ExampleCombo => new ComboViewModel<DayOfWeek>("Day of week");
        public static ColorPickerViewModel ExampleColorPicker => new ColorPickerViewModel("Favorite Color", Color.FromRgb(255, 255, 0));
    }
}
