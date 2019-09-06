using System.ComponentModel;

namespace MMRando.Models
{
    [Description("Tatl Color")]
    public enum TatlColorSchema
    {
        Default,
        Dark,
        Hot,
        Cool,
        [Description("Rainbow (cycle)")]
        Rainbow,
        Random,
    }
}
