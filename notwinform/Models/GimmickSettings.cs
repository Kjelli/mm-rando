using MMRando.Models;
using ReactiveUI;

namespace NotWinForm.Models
{
    public partial class RandomizerSettings : ReactiveObject, ISettings
    {
        private DamageMode _damageMode;
        public DamageMode DamageMode
        {
            get => _damageMode;
            set => this.RaiseAndSetIfChanged(ref _damageMode, value);
        }

        private DamageEffect _damageEffect;
        public DamageEffect DamageEffect
        {
            get => _damageEffect;
            set => this.RaiseAndSetIfChanged(ref _damageEffect, value);
        }

        private MovementMode _movementMode;
        public MovementMode MovementMode
        {
            get => _movementMode;
            set => this.RaiseAndSetIfChanged(ref _movementMode, value);
        }

        private FloorType _floorType;
        public FloorType FloorType
        {
            get => _floorType;
            set => this.RaiseAndSetIfChanged(ref _floorType, value);
        }

        private ClockSpeed _clockSpeed;
        public ClockSpeed ClockSpeed
        {
            get => _clockSpeed;
            set => this.RaiseAndSetIfChanged(ref _clockSpeed, value);
        }

        private bool _hideClock;
        public bool HideClock
        {
            get => _hideClock;
            set => this.RaiseAndSetIfChanged(ref _hideClock, value);
        }
    }
}
