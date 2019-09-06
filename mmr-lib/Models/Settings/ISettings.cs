using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace MMRando.Models
{
    public interface ISettings
    {
        /// <summary>
        /// The randomizer seed
        /// </summary>
        [Description("Seed")]
        string Seed { get; set; }

        /// <summary>
        /// Selected mode of logic (affects randomization rules)
        /// </summary>
        [Description("Logic Mode")]
        LogicMode LogicMode { get; }

        /// <summary>
        /// Use Custom Item list for the logic.
        /// </summary>
        [Description("Use custom item list")]
        bool UseCustomItemList { get; }

        /// <summary>
        /// Add songs to the randomization pool
        /// </summary>
        [Description("Shuffle songs")]
        bool AddSongs { get; }

        /// <summary>
        /// (KeySanity) Add dungeon items (maps, compasses, keys) to the randomization pool
        /// </summary>
        [Description("Shuffle dungeon items")]
        bool AddDungeonItems { get; }

        /// <summary>
        /// Add shop items to the randomization pool
        /// </summary>
        [Description("Shuffle shop items")]
        bool AddShopItems { get; set; }

        /// <summary>
        /// Add moon items to the randomization pool
        /// </summary>
        [Description("Shuffle moon items")]
        bool AddMoonItems { get; }

        /// <summary>
        /// Add great fairy rewards to the randomization pool
        /// </summary>
        [Description("Shuffle Great Fairy rewards")]
        bool AddFairyRewards { get; }

        /// <summary>
        /// Add everything else to the randomization pool
        /// </summary>
        [Description("Shuffle everything else")]
        bool AddOtherItems { get; }

        /// <summary>
        /// Add pre-clocktown nut chest to the randomization pool
        /// </summary>
        [Description("Shuffle pre-clocktown chest")]
        bool AddNutChest { get; }

        /// <summary>
        /// Add starting sword/shield/heart containers to the randomization pool
        /// </summary>
        [Description("Crazy starting items")]
        bool CrazyStartingItems { get; }


        /// <summary>
        /// Randomize the content of a bottle when catching (e.g. catching a fairy puts poe in bottle)
        /// </summary>
        [Description("Shuffle caught bottle contents")]
        bool RandomizeBottleCatchContents { get; }

        /// <summary>
        /// Exclude song of soaring from randomization (it will be found in vanilla location)
        /// </summary>
        [Description("Exclude Song of Soaring")]
        bool ExcludeSongOfSoaring { get; }

        /// <summary>
        /// Gossip stones give hints on where to find items, and sometimes junk
        /// </summary>
        [Description("Gossip Hints")]
        GossipHintStyle GossipHintStyle { get; }
        /// <summary>
        /// FrEe HiNtS FoR WeNiEs
        /// </summary>
        bool FreeHints { get; }

        /// <summary>
        /// Clear hints
        /// </summary>
        bool ClearHints { get; }
        /// <summary>
        /// Randomize which dungeon you appear in when entering one
        /// </summary>
        bool RandomizeDungeonEntrances { get; }

        /// <summary>
        /// (Beta) Randomize enemies
        /// </summary>
        bool RandomizeEnemies { get; }

        /// <summary>
        /// Prevents player starting with any items that are randomized.
        /// </summary>
        bool NoStartingItems { get; }

        /// <summary>
        /// Checks if a game needs to be built
        /// </summary>
        bool OutputGame { get; }

        /// <summary>
        ///  Outputs n64 rom if true (default: true)
        /// </summary>
        bool OutputN64ROM { get; }


        /// <summary>
        ///  Outputs virtual channel if true
        /// </summary>
        bool OutputVC { get; }

        /// <summary>
        /// Filepath to the input ROM
        /// </summary>
        string InputROMFilename { get; }

        /// <summary>
        /// Filepath to the input patch file
        /// </summary>
        string InputPatchFilename { get; }

        /// <summary>
        /// Filepath to the input logic file
        /// </summary>
        string UserLogicFileName { get; }

        /// <summary>
        /// Filepath to the output ROM
        /// </summary>
        string OutputROMFilename { get; }
        /// <summary>
        /// Generate spoiler log on randomizing
        /// </summary>
        bool OutputTextSpoiler { get; }

        /// <summary>
        /// Generate HTML spoiler log on randomizing
        /// </summary>
        bool OutputHTMLSpoiler { get; }

        /// <summary>
        /// Generate patch file
        /// </summary>
        bool OutputROMPatch { get; }

        /// <summary>
        /// Apply patch file during output generation
        /// </summary>
        bool ApplyPatch { get; }

        /// <summary>
        /// Randomize background music (includes bgm from other video games)
        /// </summary>
        bool RandomizeBGM { get; }

        /// <summary>
        /// Mute background music
        /// </summary>
        bool NoBGM { get; }
        /// <summary>
        /// Prevent downgrades
        /// </summary>
        bool PreventDowngrades { get; }

        /// <summary>
        /// Updates shop models and text
        /// </summary>
        bool UpdateShopAppearance { get; }

        /// <summary>
        /// Updates chest appearance to match contents
        /// </summary>
        bool UpdateChests { get; }

        /// <summary>
        /// Change epona B button behavior to prevent player losing sword if they don't have a bow.
        /// </summary>
        bool FixEponaSword { get; }

        /// <summary>
        /// Modifies the damage value when Link is damaged
        /// </summary>
        DamageMode DamageMode { get; }

        /// <summary>
        /// Adds an additional effect when Link is damaged
        /// </summary>
        DamageEffect DamageEffect { get; }

        /// <summary>
        /// Modifies Link's movement
        /// </summary>
        MovementMode MovementMode { get; }

        /// <summary>
        /// Sets the type of floor globally
        /// </summary>
        FloorType FloorType { get; }

        /// <summary>
        /// Sets the clock speed.
        /// </summary>
        ClockSpeed ClockSpeed { get; }

        /// <summary>
        /// Hides the clock UI.
        /// </summary>
        bool HideClock { get; }

        /// <summary>
        /// Certain cutscenes will play shorter, or will be skipped
        /// </summary>
        bool ShortenCutscenes { get; }

        /// <summary>
        /// Text is fast-forwarded
        /// </summary>
        bool QuickTextEnabled { get; }

        /// <summary>
        /// The color of Link's tunic
        /// </summary>
        Color TunicColor { get; }

        /// <summary>
        /// Replaces Link's default model
        /// </summary>
        Character Character { get; }

        /// <summary>
        /// Replaces Tatl's colors
        /// </summary>
        TatlColorSchema TatlColorSchema { get; }


        /// <summary>
        ///  Custom item list selections
        /// </summary>
        List<int> CustomItemList { get; }

        /// <summary>
        /// TOOD Should be removed, outside mmr lib this isn't really interesting.
        /// </summary>
        ValidateRomResult InputROMFormat { get; set; }
    }
}