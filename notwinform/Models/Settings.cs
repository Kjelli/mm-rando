using MMRando.Models;
using System.Collections.Generic;
using System.Drawing;

namespace NotWinForm.Models
{
    public class Settings : ISettings
    {
        public string Seed { get; set; }

        public LogicMode LogicMode { get; set; }

        public bool UseCustomItemList { get; set; }

        public bool AddSongs { get; set; }

        public bool AddDungeonItems { get; set; }

        public bool AddShopItems { get; set; }

        public bool AddMoonItems { get; set; }

        public bool AddFairyRewards { get; set; }

        public bool AddOtherItems { get; set; }

        public bool AddNutChest { get; set; }

        public bool CrazyStartingItems { get; set; }

        public bool RandomizeBottleCatchContents { get; set; }

        public bool ExcludeSongOfSoaring { get; set; }

        public GossipHintStyle GossipHintStyle { get; set; }

        public bool FreeHints { get; set; }

        public bool ClearHints { get; set; }

        public bool RandomizeDungeonEntrances { get; set; }

        public bool RandomizeEnemies { get; set; }

        public bool NoStartingItems { get; set; }

        public bool OutputGame { get; set; }

        public bool OutputN64ROM { get; set; }

        public bool OutputVC { get; set; }

        public string InputROMFilename { get; set; }

        public string InputPatchFilename { get; set; }

        public string UserLogicFileName { get; set; }

        public string OutputROMFilename { get; set; }

        public bool OutputTextSpoiler { get; set; }

        public bool OutputHTMLSpoiler { get; set; }

        public bool OutputROMPatch { get; set; }

        public bool ApplyPatch { get; set; }

        public bool RandomizeBGM { get; set; }

        public bool NoBGM { get; set; }

        public bool PreventDowngrades { get; set; }

        public bool UpdateShopAppearance { get; set; }

        public bool UpdateChests { get; set; }

        public bool FixEponaSword { get; set; }

        public DamageMode DamageMode { get; set; }

        public DamageEffect DamageEffect { get; set; }

        public MovementMode MovementMode { get; set; }

        public FloorType FloorType { get; set; }

        public ClockSpeed ClockSpeed { get; set; }

        public bool HideClock { get; set; }

        public bool ShortenCutscenes { get; set; }

        public bool QuickTextEnabled { get; set; }

        public Color TunicColor { get; set; }

        public Character Character { get; set; }

        public TatlColorSchema TatlColorSchema { get; set; }

        public List<int> CustomItemList { get; set; }

        public ValidateRomResult InputROMFormat { get; set; }
    }
}
