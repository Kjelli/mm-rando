using Avalonia;
using Avalonia.Markup.Xaml;
using NotWinForm.ViewModels;
using ReactiveUI;
using System;

namespace NotWinForm.Views.Controls
{
    public class EnumComboView : ReactiveUserControl<EnumComboViewModel>
    {
        #region Properties
        public static readonly StyledProperty<string> LabelProperty =
           AvaloniaProperty.Register<EnumComboView, string>(nameof(Label));

        public static readonly StyledProperty<Type> EnumProperty =
           AvaloniaProperty.Register<EnumComboView, Type>(nameof(EnumType));

        public string Label
        {
            get { return GetValue(LabelProperty); }
            set { SetValue(LabelProperty, value); }
        }


        public Type EnumType
        {
            get { return GetValue(EnumProperty); }
            set { SetValue(EnumProperty, value); }
        }

        #endregion

        public EnumComboView()
        {
            InitializeComponent();
            this.WhenActivated(_ =>
            {
                ViewModel.Activator.Activate();
            });

            this.WhenAnyValue(x => x.EnumType)
                .BindTo(this, x => x.ViewModel.EnumType);

            this.WhenAnyValue(x => x.Label)
                .BindTo(this, x => x.ViewModel.Label);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
