using System.ComponentModel;

namespace ClassLibraryMDI
{
    public enum ProgramNameEnum
    {
        // None
        [Description("None")]
        None = 0,

        // First step
        [Description("Calculator")]
        Calculator = 10,

        // Input validation
        [Description("Input validation v1")]
        InputValidation_v1 = 20,
        [Description("Input validation v2")]
        InputValidation_v2 = 21,

        // Graphical objects
        [Description("Check box")]
        CheckBox = 30,
        [Description("List box")]
        ListBox = 31,
        [Description("Combo box")]
        ComboBox = 32,
        [Description("Scrolling v1")]
        Scrolling_v1 = 33,
        [Description("Loan v1")]
        Loan_v1 = 34
    }
}