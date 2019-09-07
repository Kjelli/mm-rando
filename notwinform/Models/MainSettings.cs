using MMRando.Models;
using ReactiveUI;
using System.Collections.Generic;

namespace NotWinForm.Models
{
    public partial class RandomizerSettings : ReactiveObject, ISettings
    {
        private string _seed;
        public string Seed
        {
            get => _seed;
            set => this.RaiseAndSetIfChanged(ref _seed, value);
        }

        private LogicMode _logicMode;
        public LogicMode LogicMode
        {
            get => _logicMode;
            set => this.RaiseAndSetIfChanged(ref _logicMode, value);
        }

        private bool _excludeSongOfSoaring;
        public bool ExcludeSongOfSoaring
        {
            get => _excludeSongOfSoaring;
            set => this.RaiseAndSetIfChanged(ref _excludeSongOfSoaring, value);
        }

        private bool _addMoonItems;
        public bool AddMoonItems
        {
            get => _addMoonItems;
            set => this.RaiseAndSetIfChanged(ref _addMoonItems, value);
        }

        private bool _addDungeonItems;
        public bool AddDungeonItems
        {
            get => _addDungeonItems;
            set => this.RaiseAndSetIfChanged(ref _addDungeonItems, value);
        }

        private bool _addFairyRewards;
        public bool AddFairyRewards
        {
            get => _addFairyRewards;
            set => this.RaiseAndSetIfChanged(ref _addFairyRewards, value);
        }

        private bool _addShopItems;
        public bool AddShopItems
        {
            get => _addShopItems;
            set => this.RaiseAndSetIfChanged(ref _addShopItems, value);
        }

        private bool _addOtherItems;
        public bool AddOtherItems
        {
            get => _addOtherItems;
            set => this.RaiseAndSetIfChanged(ref _addOtherItems, value);
        }

        private bool _randomizeBottleCatchContents;
        public bool RandomizeBottleCatchContents
        {
            get => _randomizeBottleCatchContents;
            set => this.RaiseAndSetIfChanged(ref _randomizeBottleCatchContents, value);
        }

        private bool _addNutChest;
        public bool AddNutChest
        {
            get => _addNutChest;
            set => this.RaiseAndSetIfChanged(ref _addNutChest, value);
        }

        private bool _crazyStartingItems;
        public bool CrazyStartingItems
        {
            get => _crazyStartingItems;
            set => this.RaiseAndSetIfChanged(ref _crazyStartingItems, value);
        }

        private bool _useCustomItemList;
        public bool UseCustomItemList
        {
            get => _useCustomItemList;
            set => this.RaiseAndSetIfChanged(ref _useCustomItemList, value);
        }

        public List<int> CustomItemList { get; set; }

        private bool _randomizeDungeonEntrances;
        public bool RandomizeDungeonEntrances
        {
            get => _randomizeDungeonEntrances;
            set => this.RaiseAndSetIfChanged(ref _randomizeDungeonEntrances, value);
        }

        private bool _noStartingItems;
        public bool NoStartingItems
        {
            get => _noStartingItems;
            set => this.RaiseAndSetIfChanged(ref _noStartingItems, value);
        }

        private bool _addSongs;
        public bool AddSongs
        {
            get => _addSongs;
            set => this.RaiseAndSetIfChanged(ref _addSongs, value);
        }

        private bool _randomizeEnemies;
        public bool RandomizeEnemies
        {
            get => _randomizeEnemies;
            set => this.RaiseAndSetIfChanged(ref _randomizeEnemies, value);
        }
    }
}
