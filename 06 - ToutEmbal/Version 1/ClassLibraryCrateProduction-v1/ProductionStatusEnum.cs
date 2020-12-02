using System.ComponentModel;

namespace ClassLibraryCrateProduction_v1
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

        [Description("Stopped")]
        stopped = 4,

        [Description("Finished")]
        finished = 5
    }
}