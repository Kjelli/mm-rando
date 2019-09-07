using MMRando.Extensions;
using NotWinForm.Models;
using NotWinForm.Services;
using ReactiveUI;
using Splat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reactive.Disposables;

namespace NotWinForm.ViewModels
{
    public class EnumComboViewModel : ViewModelBase
    {
        #region Properties
        private string _label;
        public string Label
        {
            get => _label;
            set => this.RaiseAndSetIfChanged(ref _label, value);
        }

        public List<ComboItem> Items { get; set; }

        private ComboItem _selected;
        public ComboItem Selected
        {
            get => _selected;
            set => this.RaiseAndSetIfChanged(ref _selected, value);
        }

        private Type _enumType;
        public Type EnumType
        {
            get => _enumType;
            set => this.RaiseAndSetIfChanged(ref _enumType, value);
        }

        #endregion

        private readonly SettingsViewModel _settings;
        private readonly DialogMessageService _messages;
        public EnumComboViewModel()
        {
            _settings = Locator.CurrentMutable.GetService<SettingsViewModel>();
            _messages = Locator.CurrentMutable.GetService<DialogMessageService>();

            this.WhenActivated((CompositeDisposable disposable) =>
            {
                PopulateItems();
                SetLabelOrDefault(Label);
            });

            this.WhenAnyValue(x => x.Selected)
                .Subscribe(x => TryUpdateSettings(x));
        }

        private void TryUpdateSettings(ComboItem x)
        {
            try
            {
                if (EnumType == null) return;

                var type = _settings.GetType();
                var propName = EnumType.Name;
                var prop = type.GetProperty(propName);

                prop.SetValue(_settings, Selected.Value);
            }
            catch (Exception)
            {
                _messages.ErrorOk($"Could not update setting {Label}. This is not meant to happen. Please contact the development team on Discord.", "Critical Error", "Critical Error");
            }
        }

        private void SetLabelOrDefault(string label)
        {
            if (label is null)
            {
                var descriptionAttr = EnumType.GetAttribute<DescriptionAttribute>();
                if (descriptionAttr != null)
                {
                    Label = descriptionAttr.Description;
                }
                else
                {
                    Label = EnumType.Name;
                }
            }
        }

        private void PopulateItems()
        {
            var items = new Dictionary<string, Enum>();
            var enums = Enum.GetValues(EnumType).Cast<Enum>();

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


            Items = items.Select(kvp => new ComboItem(kvp.Key, kvp.Value)).ToList();

            var defaultSelection = Items.Where(combo => combo.Value.ToString().ToLower().Equals("default")).FirstOrDefault();
            if (defaultSelection != null)
            {
                Selected = defaultSelection;
            }
            else
            {
                Selected = Items.FirstOrDefault();
            }
        }


        public class ComboItem
        {
            public string Label { get; set; }
            public object Value { get; set; }
            public ComboItem(string label, object value)
            {
                Label = label;
                Value = value;
            }
        }
    }

}