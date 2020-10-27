using System.ComponentModel;

namespace LoanClassLibrary
{
    public enum RepaymentPeriodicity
    {
        [Description("Every months")]
        Monthly = 1,
        [Description("Every two months")]
        Bimonthly = 2,
        [Description("Every three months")]
        Quarterly = 3,
        [Description("Every six months")]
        SemiAnnual = 6,
        [Description("Every year")]
        Annual = 12
    }
}