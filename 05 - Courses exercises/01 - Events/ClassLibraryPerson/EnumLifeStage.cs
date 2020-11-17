using System.ComponentModel;

namespace ClassLibraryPerson
{
    public enum EnumLifeStage
    {
        [Description("\nThe child can stand up and walk\n")]
        WalkingAge = 3,

        [Description("\nThe child makes whims\n")]
        CanWalk = 10,

        [Description("\nThe child is an young adult\n")]
        AdultAge = 18,

        [Description("\nThe adult is near his midlife crisis\n")]
        MidlifeCrisisAge = 40,

        [Description("\nThe adult is retired\n")]
        RetirementAge = 60
    }
}