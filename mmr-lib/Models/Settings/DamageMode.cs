using System.ComponentModel;

namespace MMRando.Models
{
    [Description("Damage Mode")]
    public enum DamageMode
    {
        Default,
        [Description("2x")]
        Double,
        [Description("4x")]
        Quadruple,
        [Description("One Hit Knockout")]
        OHKO,
        Doom
    }
}
