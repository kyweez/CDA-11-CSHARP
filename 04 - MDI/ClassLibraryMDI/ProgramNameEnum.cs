using System.ComponentModel;

namespace ClassLibraryMDI
{
    public enum ProgramNameEnum
    {
        // None
        [Description("None")]
        None = 0,

        // Console applications
        [Description("Butterfly console application")]
        Butterfly = 10,
        [Description("Zoo console application")]
        Zoo = 11,
        [Description("Forest console application")]
        Forest = 12,

        // First step
        [Description("Calculator")]
        Calculator = 20,

        // Input validation
        [Description("Input validation v1")]
        InputValidation_v1 = 30,
        [Description("Input validation v2")]
        InputValidation_v2 = 31,

        // Graphical objects
        [Description("Check box")]
        CheckBox = 40,
        [Description("List box")]
        ListBox = 41,
        [Description("Combo box")]
        ComboBox = 42,
        [Description("Scrolling v1")]
        Scrolling_v1 = 43,
        [Description("Scrolling v2")]
        Scrolling_v2 = 44,
        [Description("Loan v1")]
        Loan_v1 = 45,
        [Description("Loan v2")]
        Loan_v2 = 46,

        // Courses exercises
        [Description("Fraction")]
        Fraction = 50,
        [Description("Events")]
        Events = 51,
        [Description("Temperature v1")]
        Temperature_v1 = 52,
        [Description("Temperature v2")]
        Temperature_v2 = 53
    }
}