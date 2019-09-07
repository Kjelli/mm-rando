using MMRando.Models;
using ReactiveUI;

namespace NotWinForm.Models
{
    public partial class RandomizerSettings : ReactiveObject, ISettings
    {
        private ValidateRomResult _inputROMFormat;
        public ValidateRomResult InputROMFormat
        {
            get => _inputROMFormat;
            set => this.RaiseAndSetIfChanged(ref _inputROMFormat, value);
        }

        private string _inputROMFilename;
        public string InputROMFilename
        {
            get => _inputROMFilename;
            set => this.RaiseAndSetIfChanged(ref _inputROMFilename, value);
        }

        private string _inputPatchFilename;
        public string InputPatchFilename
        {
            get => _inputPatchFilename;
            set => this.RaiseAndSetIfChanged(ref _inputPatchFilename, value);
        }

        private string _userLogicFileName;
        public string UserLogicFileName
        {
            get => _userLogicFileName;
            set => this.RaiseAndSetIfChanged(ref _userLogicFileName, value);
        }

        private string _outputROMFilename;
        public string OutputROMFilename
        {
            get => _outputROMFilename;
            set => this.RaiseAndSetIfChanged(ref _outputROMFilename, value);
        }

        private bool _outputN64ROM;
        public bool OutputN64ROM
        {
            get => _outputN64ROM;
            set => this.RaiseAndSetIfChanged(ref _outputN64ROM, value);
        }

        private bool _outputVC;
        public bool OutputVC
        {
            get => _outputVC;
            set => this.RaiseAndSetIfChanged(ref _outputVC, value);
        }

        private bool _outputROMPatch;
        public bool OutputROMPatch
        {
            get => _outputROMPatch;
            set => this.RaiseAndSetIfChanged(ref _outputROMPatch, value);
        }


        private bool _outputTextSpoiler;
        public bool OutputTextSpoiler
        {
            get => _outputTextSpoiler;
            set => this.RaiseAndSetIfChanged(ref _outputTextSpoiler, value);
        }

        private bool _outputHTMLSpoiler;
        public bool OutputHTMLSpoiler
        {
            get => _outputHTMLSpoiler;
            set => this.RaiseAndSetIfChanged(ref _outputHTMLSpoiler, value);
        }

        private bool _outputGame;
        public bool OutputGame
        {
            get => _outputGame;
            set => this.RaiseAndSetIfChanged(ref _outputGame, value);
        }

        private bool _applyPatch;
        public bool ApplyPatch
        {
            get => _applyPatch;
            set => this.RaiseAndSetIfChanged(ref _applyPatch, value);
        }
    }
}
