using System.ComponentModel;

namespace MMRando.Models
{
    [Description("Clock Speed")]
    public enum ClockSpeed
    {
        Default,
        [Description("1/3x")]
        VerySlow,
        [Description("2/3x")]
        Slow,
        [Description("2x")]
        Fast,
        [Description("3x")]
        VeryFast,
        [Description("6")]
        SuperFast
    }
}
