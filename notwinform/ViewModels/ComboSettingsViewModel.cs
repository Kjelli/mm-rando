using MMRando.Extensions;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace NotWinForm.ViewModels
{
    public class ComboSettingsViewModel<T> : ViewModelBase where T : Enum
    {
        private string _settingLabel;
        public string SettingLabel
        {
            get => _settingLabel;
            set => this.RaiseAndSetIfChanged(ref _settingLabel, value);
        }

        public List<ComboSetting> Items { get; set; }

        private ComboSetting _selected;
        public ComboSetting Selected
        {
            get => _selected;
            set => this.RaiseAndSetIfChanged(ref _selected, value);
        }

        public ComboSettingsViewModel(string settingLabel = default, T defaultSelection = default)
        {
            SetLabelOrDefault(settingLabel);
            PopulateItems();
            Selected = Items.FirstOrDefault(i => i.Value.Equals(defaultSelection));
        }

        private void SetLabelOrDefault(string label)
        {
            if (label is null)
            {
                var descriptionAttr = typeof(T).GetAttribute<DescriptionAttribute>();
                if (descriptionAttr != null)
                {
                    SettingLabel = descriptionAttr.Description;
                }
                else
                {
                    SettingLabel = typeof(T).Name;
                }
            }
        }

        private void PopulateItems()
        {
            var items = new Dictionary<string, T>();
            var enums = (T[])Enum.GetValues(typeof(T));

            foreach (var value in enums)
            {
                string valueLabel;

                var descriptionAttr = value.GetAttribute<DescriptionAttribute>();
                if (descriptionAttr != null)
                {
                    valueLabel = descriptionAttr.Description;
                }
                else
                {
                    valueLabel = value.ToString();
                }

                items.Add(valueLabel, value);
            }


            Items = items.Select(kvp => new ComboSetting(kvp.Key, kvp.Value)).ToList();
        }

        public class ComboSetting
        {
            public string Label { get; set; }
            public T Value { get; set; }
            public ComboSetting(string label, T value)
            {
                Label = label;
                Value = value;
            }
        }
    }

}
