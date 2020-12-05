using System.ComponentModel;

namespace ClassLibraryCrateProduction_v2
{
    public enum ProductionStatusEnum
    {
        [Description("Not started")]
        notStarted = 0,

        [Description("Started")]
        started = 1,

        [Description("Paused")]
        paused = 2,

        [Description("Restarted")]
        restarted = 3,

        [Description("Finished")]
        finished = 4
    }
}