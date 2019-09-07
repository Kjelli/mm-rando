using MMRando.Models;
using ReactiveUI;
using System.Drawing;

namespace NotWinForm.Models
{
    public partial class SettingsViewModel : ReactiveObject, ISettings
    {
        private bool _shortenCutscenes;
        public bool ShortenCutscenes
        {
            get => _shortenCutscenes;
            set => this.RaiseAndSetIfChanged(ref _shortenCutscenes, value);
        }

        private bool _freeHints;
        public bool FreeHints
        {
            get => _freeHints;
            set => this.RaiseAndSetIfChanged(ref _freeHints, value);
        }

        private bool _quickTextEnabled;
        public bool QuickTextEnabled
        {
            get => _quickTextEnabled;
            set => this.RaiseAndSetIfChanged(ref _quickTextEnabled, value);
        }

        private bool _clearHints;
        public bool ClearHints
        {
            get => _clearHints;
            set => this.RaiseAndSetIfChanged(ref _clearHints, value);
        }

        private bool _randomizeBGM;
        public bool RandomizeBGM
        {
            get => _randomizeBGM;
            set => this.RaiseAndSetIfChanged(ref _randomizeBGM, value);
        }

        private bool _updateShopAppearance;
        public bool UpdateShopAppearance
        {
            get => _updateShopAppearance;
            set => this.RaiseAndSetIfChanged(ref _updateShopAppearance, value);
        }

        private bool _noBGM;
        public bool NoBGM
        {
            get => _noBGM;
            set => this.RaiseAndSetIfChanged(ref _noBGM, value);
        }

        private bool _updateChests;
        public bool UpdateChests
        {
            get => _updateChests;
            set => this.RaiseAndSetIfChanged(ref _updateChests, value);
        }

        private bool _fixEponaSword;
        public bool FixEponaSword
        {
            get => _fixEponaSword;
            set => this.RaiseAndSetIfChanged(ref _fixEponaSword, value);
        }

        private bool _preventDowngrades;
        public bool PreventDowngrades
        {
            get => _preventDowngrades;
            set => this.RaiseAndSetIfChanged(ref _preventDowngrades, value);
        }

        private Color _tunicColor;
        public Color TunicColor
        {
            get => _tunicColor;
            set => this.RaiseAndSetIfChanged(ref _tunicColor, value);
        }

        private Character _character;
        public Character Character
        {
            get => _character;
            set => this.RaiseAndSetIfChanged(ref _character, value);
        }

        private TatlColorSchema _tatlColorSchema;
        public TatlColorSchema TatlColorSchema
        {
            get => _tatlColorSchema;
            set => this.RaiseAndSetIfChanged(ref _tatlColorSchema, value);
        }

        private GossipHintStyle _gossipHintStyle;
        public GossipHintStyle GossipHintStyle
        {
            get => _gossipHintStyle;
            set => this.RaiseAndSetIfChanged(ref _gossipHintStyle, value);
        }
    }
}
