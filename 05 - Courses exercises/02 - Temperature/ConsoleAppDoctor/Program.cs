using ClassLibraryTemperature;
using ClassLibraryTemperature.Exceptions;
using System;

namespace ConsoleAppDoctor
{
    class Program
    {
        static void Main(string[] args)
        {
            Temperature patientTemperature;

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("===================================================");
            Console.WriteLine("====================== START ======================");
            Console.WriteLine("===================================================\n");
            Console.ResetColor();

            #region ############### BAD CONSTRUCTION CASES ###############
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("################### CONSTRUCTION WITH TOO HIGH VALUE CASE ##################\n");
            Console.ResetColor();
            try
            {
                patientTemperature = new Temperature(10000000000f);
                patientTemperature.FeverTemperature += PatientTemperature_FeverTemperature;
                Console.WriteLine($"Temperature value afer construction : {patientTemperature.TemperatureInCelsius}\n");

                //Trying to trigger the fever event
                patientTemperature.IncreaseTemperature(2f);
                Console.WriteLine($"Patient fever == {patientTemperature.TemperatureInCelsius}\n");

                //Checking if the freezing event is triggered
                patientTemperature.DecreaseTemperature(50f);
                Console.WriteLine($"Patient fever == {patientTemperature.TemperatureInCelsius}\n");

                //Trying to trigger again the fever event
                patientTemperature.IncreaseTemperature(70f);
                Console.WriteLine($"Patient fever == {patientTemperature.TemperatureInCelsius}\n");
            }
            catch (ImpossibleTemperatureException e)
            {
                Console.WriteLine($"Object can't be instanciated : {e.Message} in {e.Source}");
            }
            catch (WrongTemperatureArgumentException e)
            {
                Console.WriteLine($"Bad argument : {e.Message} . Error comes from {e.Source}");
            }
            catch (ImpossibleTemperatureIncreasingException e)
            {
                Console.WriteLine($"Increasing issue : {e.Message}. Error comes from {e.Source}");
            }
            catch (ImpossibleTemperatureDecreasingException e)
            {
                Console.WriteLine($"Decreasing issue : {e.Message}. Error comes from {e.Source}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("\nPress any key to continue\n");
            Console.ReadKey();
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("################### CONSTRUCTION WITH TOO LOW VALUE CASE ##################\n");
            Console.ResetColor();
            try
            {
                patientTemperature = new Temperature(-600f);
                patientTemperature.FeverTemperature += PatientTemperature_FeverTemperature;
                Console.WriteLine($"Temperature value afer construction : {patientTemperature.TemperatureInCelsius}\n");

                //Trying to trigger the fever event
                patientTemperature.IncreaseTemperature(2f);
                Console.WriteLine($"Patient fever == {patientTemperature.TemperatureInCelsius}\n");

                //Checking if the freezing event is triggered
                patientTemperature.DecreaseTemperature(50f);
                Console.WriteLine($"Patient fever == {patientTemperature.TemperatureInCelsius}\n");

                //Trying to trigger again the fever event
                patientTemperature.IncreaseTemperature(70f);
                Console.WriteLine($"Patient fever == {patientTemperature.TemperatureInCelsius}\n");
            }
            catch (ImpossibleTemperatureException e)
            {
                Console.WriteLine($"Object can't be instanciated : {e.Message} in {e.Source}");
            }
            catch (WrongTemperatureArgumentException e)
            {
                Console.WriteLine($"Bad argument : {e.Message} . Error comes from {e.Source}");
            }
            catch (ImpossibleTemperatureIncreasingException e)
            {
                Console.WriteLine($"Increasing issue : {e.Message}. Error comes from {e.Source}");
            }
            catch (ImpossibleTemperatureDecreasingException e)
            {
                Console.WriteLine($"Decreasing issue : {e.Message}. Error comes from {e.Source}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("\nPress any key to continue\n");
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region ############### BAD ARGUMENT IN METHODS CASES ###############
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("################### BAD ARGUMENT IN INCREASING METHOD CASE ##################\n");
            Console.ResetColor();
            try
            {
                patientTemperature = new Temperature(37.0f);
                patientTemperature.FeverTemperature += PatientTemperature_FeverTemperature;
                Console.WriteLine($"Temperature value afer construction : {patientTemperature.TemperatureInCelsius}\n");

                //Trying to trigger the fever event
                patientTemperature.IncreaseTemperature(-2f);
                Console.WriteLine($"Patient fever == {patientTemperature.TemperatureInCelsius}\n");

                //Checking if the freezing event is triggered
                patientTemperature.DecreaseTemperature(50f);
                Console.WriteLine($"Patient fever == {patientTemperature.TemperatureInCelsius}\n");

                //Trying to trigger again the fever event
                patientTemperature.IncreaseTemperature(70f);
                Console.WriteLine($"Patient fever == {patientTemperature.TemperatureInCelsius}\n");
            }
            catch (ImpossibleTemperatureException e)
            {
                Console.WriteLine($"Object can't be instanciated : {e.Message} in {e.Source}");
            }
            catch (WrongTemperatureArgumentException e)
            {
                Console.WriteLine($"Bad argument : {e.Message} . Error comes from {e.Source}");
            }
            catch (ImpossibleTemperatureIncreasingException e)
            {
                Console.WriteLine($"Increasing issue : {e.Message}. Error comes from {e.Source}");
            }
            catch (ImpossibleTemperatureDecreasingException e)
            {
                Console.WriteLine($"Decreasing issue : {e.Message}. Error comes from {e.Source}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("\nPress any key to continue\n");
            Console.ReadKey();
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("################### BAD ARGUMENT IN DECREASING METHOD CASE ##################\n");
            Console.ResetColor();
            try
            {
                patientTemperature = new Temperature(37.0f);
                patientTemperature.FeverTemperature += PatientTemperature_FeverTemperature;
                Console.WriteLine($"Temperature value afer construction : {patientTemperature.TemperatureInCelsius}\n");

                //Trying to trigger the fever event
                //patientTemperature.IncreaseTemperature(2f);
                //Console.WriteLine($"Patient fever == {patientTemperature.TemperatureInCelsius}\n");

                //Checking if the freezing event is triggered
                patientTemperature.DecreaseTemperature(-50f);
                Console.WriteLine($"Patient fever == {patientTemperature.TemperatureInCelsius}\n");

                //Trying to trigger again the fever event
                patientTemperature.IncreaseTemperature(70f);
                Console.WriteLine($"Patient fever == {patientTemperature.TemperatureInCelsius}\n");
            }
            catch (ImpossibleTemperatureException e)
            {
                Console.WriteLine($"Object can't be instanciated : {e.Message} in {e.Source}");
            }
            catch (WrongTemperatureArgumentException e)
            {
                Console.WriteLine($"Bad argument : {e.Message} . Error comes from {e.Source}");
            }
            catch (ImpossibleTemperatureIncreasingException e)
            {
                Console.WriteLine($"Increasing issue : {e.Message}. Error comes from {e.Source}");
            }
            catch (ImpossibleTemperatureDecreasingException e)
            {
                Console.WriteLine($"Decreasing issue : {e.Message}. Error comes from {e.Source}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("\nPress any key to continue\n");
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region ############### IMPOSSIBLE INCREASING CASES ###############
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("################### IMPOSSIBLE INCREASING CASE 1 ##################\n");
            Console.ResetColor();
            try
            {
                patientTemperature = new Temperature(1000000000f);
                patientTemperature.FeverTemperature += PatientTemperature_FeverTemperature;
                Console.WriteLine($"Temperature value afer construction : {patientTemperature.TemperatureInCelsius}\n");

                //Trying to trigger the fever event
                patientTemperature.IncreaseTemperature(10f);
                Console.WriteLine($"Patient fever == {patientTemperature.TemperatureInCelsius}\n");

                //Checking if the freezing event is triggered
                patientTemperature.DecreaseTemperature(50f);
                Console.WriteLine($"Patient fever == {patientTemperature.TemperatureInCelsius}\n");

                //Trying to trigger again the fever event
                patientTemperature.IncreaseTemperature(70f);
                Console.WriteLine($"Patient fever == {patientTemperature.TemperatureInCelsius}\n");
            }
            catch (ImpossibleTemperatureException e)
            {
                Console.WriteLine($"Object can't be instanciated : {e.Message} in {e.Source}");
            }
            catch (WrongTemperatureArgumentException e)
            {
                Console.WriteLine($"Bad argument : {e.Message} . Error comes from {e.Source}");
            }
            catch (ImpossibleTemperatureIncreasingException e)
            {
                Console.WriteLine($"Increasing issue : {e.Message}. Error comes from {e.Source}");
            }
            catch (ImpossibleTemperatureDecreasingException e)
            {
                Console.WriteLine($"Decreasing issue : {e.Message}. Error comes from {e.Source}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("\nPress any key to continue\n");
            Console.ReadKey();
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("################### IMPOSSIBLE INCREASING CASE 2 ##################\n");
            Console.ResetColor();
            try
            {
                patientTemperature = new Temperature(100f);
                //patientTemperature = new Temperature(10f);
                //patientTemperature = new Temperature(1f);
                patientTemperature.FeverTemperature += PatientTemperature_FeverTemperature;
                Console.WriteLine($"Temperature value afer construction : {patientTemperature.TemperatureInCelsius}\n");

                //Trying to trigger the fever event
                patientTemperature.IncreaseTemperature(1000000000f);
                Console.WriteLine($"Patient fever == {patientTemperature.TemperatureInCelsius}\n");

                //Checking if the freezing event is triggered
                patientTemperature.DecreaseTemperature(50f);
                Console.WriteLine($"Patient fever == {patientTemperature.TemperatureInCelsius}\n");

                //Trying to trigger again the fever event
                patientTemperature.IncreaseTemperature(70f);
                Console.WriteLine($"Patient fever == {patientTemperature.TemperatureInCelsius}\n");
            }
            catch (ImpossibleTemperatureException e)
            {
                Console.WriteLine($"Object can't be instanciated : {e.Message} in {e.Source}");
            }
            catch (WrongTemperatureArgumentException e)
            {
                Console.WriteLine($"Bad argument : {e.Message} . Error comes from {e.Source}");
            }
            catch (ImpossibleTemperatureIncreasingException e)
            {
                Console.WriteLine($"Increasing issue : {e.Message}. Error comes from {e.Source}");
            }
            catch (ImpossibleTemperatureDecreasingException e)
            {
                Console.WriteLine($"Decreasing issue : {e.Message}. Error comes from {e.Source}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("\nPress any key to continue\n");
            Console.ReadKey();
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("################### IMPOSSIBLE INCREASING CASE 3 ##################\n");
            Console.ResetColor();
            try
            {
                patientTemperature = new Temperature(-10f);
                patientTemperature.FeverTemperature += PatientTemperature_FeverTemperature;
                Console.WriteLine($"Temperature value afer construction : {patientTemperature.TemperatureInCelsius}\n");

                //Trying to trigger the fever event
                patientTemperature.IncreaseTemperature(1000000273f);
                Console.WriteLine($"Patient fever == {patientTemperature.TemperatureInCelsius}\n");

                //Checking if the freezing event is triggered
                patientTemperature.DecreaseTemperature(50f);
                Console.WriteLine($"Patient fever == {patientTemperature.TemperatureInCelsius}\n");

                //Trying to trigger again the fever event
                patientTemperature.IncreaseTemperature(70f);
                Console.WriteLine($"Patient fever == {patientTemperature.TemperatureInCelsius}\n");
            }
            catch (ImpossibleTemperatureException e)
            {
                Console.WriteLine($"Object can't be instanciated : {e.Message} in {e.Source}");
            }
            catch (WrongTemperatureArgumentException e)
            {
                Console.WriteLine($"Bad argument : {e.Message} . Error comes from {e.Source}");
            }
            catch (ImpossibleTemperatureIncreasingException e)
            {
                Console.WriteLine($"Increasing issue : {e.Message}. Error comes from {e.Source}");
            }
            catch (ImpossibleTemperatureDecreasingException e)
            {
                Console.WriteLine($"Decreasing issue : {e.Message}. Error comes from {e.Source}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("\nPress any key to continue\n");
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region ############### IMPOSSIBLE DECREASING CASES ###############
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("################### IMPOSSIBLE DECREASING CASE 1 ##################\n");
            Console.ResetColor();
            try
            {
                patientTemperature = new Temperature(-273.15f);
                patientTemperature.FeverTemperature += PatientTemperature_FeverTemperature;
                Console.WriteLine($"Temperature value afer construction : {patientTemperature.TemperatureInCelsius}\n");

                //Trying to trigger the fever event
                //patientTemperature.IncreaseTemperature(10f);
                //Console.WriteLine($"Patient fever == {patientTemperature.TemperatureInCelsius}\n");

                //Checking if the freezing event is triggered
                patientTemperature.DecreaseTemperature(1f);
                Console.WriteLine($"Patient fever == {patientTemperature.TemperatureInCelsius}\n");

                //Trying to trigger again the fever event
                patientTemperature.IncreaseTemperature(70f);
                Console.WriteLine($"Patient fever == {patientTemperature.TemperatureInCelsius}\n");
            }
            catch (ImpossibleTemperatureException e)
            {
                Console.WriteLine($"Object can't be instanciated : {e.Message} in {e.Source}");
            }
            catch (WrongTemperatureArgumentException e)
            {
                Console.WriteLine($"Bad argument : {e.Message} . Error comes from {e.Source}");
            }
            catch (ImpossibleTemperatureIncreasingException e)
            {
                Console.WriteLine($"Increasing issue : {e.Message}. Error comes from {e.Source}");
            }
            catch (ImpossibleTemperatureDecreasingException e)
            {
                Console.WriteLine($"Decreasing issue : {e.Message}. Error comes from {e.Source}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("\nPress any key to continue\n");
            Console.ReadKey();
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("################### IMPOSSIBLE DECREASING CASE 2 ##################\n");
            Console.ResetColor();
            try
            {
                patientTemperature = new Temperature(100f);
                //patientTemperature = new Temperature(10f);
                //patientTemperature = new Temperature(1f);
                patientTemperature.FeverTemperature += PatientTemperature_FeverTemperature;
                Console.WriteLine($"Temperature value afer construction : {patientTemperature.TemperatureInCelsius}\n");

                //Trying to trigger the fever event
                //patientTemperature.IncreaseTemperature(1000000000f);
                //Console.WriteLine($"Patient fever == {patientTemperature.TemperatureInCelsius}\n");

                //Checking if the freezing event is triggered
                patientTemperature.DecreaseTemperature(384f);
                Console.WriteLine($"Patient fever == {patientTemperature.TemperatureInCelsius}\n");

                //Trying to trigger again the fever event
                patientTemperature.IncreaseTemperature(70f);
                Console.WriteLine($"Patient fever == {patientTemperature.TemperatureInCelsius}\n");
            }
            catch (ImpossibleTemperatureException e)
            {
                Console.WriteLine($"Object can't be instanciated : {e.Message} in {e.Source}");
            }
            catch (WrongTemperatureArgumentException e)
            {
                Console.WriteLine($"Bad argument : {e.Message} . Error comes from {e.Source}");
            }
            catch (ImpossibleTemperatureIncreasingException e)
            {
                Console.WriteLine($"Increasing issue : {e.Message}. Error comes from {e.Source}");
            }
            catch (ImpossibleTemperatureDecreasingException e)
            {
                Console.WriteLine($"Decreasing issue : {e.Message}. Error comes from {e.Source}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("\nPress any key to continue\n");
            Console.ReadKey();
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("################### IMPOSSIBLE DECREASING CASE 3 ##################\n");
            Console.ResetColor();
            try
            {
                patientTemperature = new Temperature(-10f);
                patientTemperature.FeverTemperature += PatientTemperature_FeverTemperature;
                Console.WriteLine($"Temperature value afer construction : {patientTemperature.TemperatureInCelsius}\n");

                //Trying to trigger the fever event
                //patientTemperature.IncreaseTemperature(1000000273f);
                //Console.WriteLine($"Patient fever == {patientTemperature.TemperatureInCelsius}\n");

                //Checking if the freezing event is triggered
                patientTemperature.DecreaseTemperature(273.15f);
                Console.WriteLine($"Patient fever == {patientTemperature.TemperatureInCelsius}\n");

                //Trying to trigger again the fever event
                patientTemperature.IncreaseTemperature(70f);
                Console.WriteLine($"Patient fever == {patientTemperature.TemperatureInCelsius}\n");
            }
            catch (ImpossibleTemperatureException e)
            {
                Console.WriteLine($"Object can't be instanciated : {e.Message} in {e.Source}");
            }
            catch (WrongTemperatureArgumentException e)
            {
                Console.WriteLine($"Bad argument : {e.Message} . Error comes from {e.Source}");
            }
            catch (ImpossibleTemperatureIncreasingException e)
            {
                Console.WriteLine($"Increasing issue : {e.Message}. Error comes from {e.Source}");
            }
            catch (ImpossibleTemperatureDecreasingException e)
            {
                Console.WriteLine($"Decreasing issue : {e.Message}. Error comes from {e.Source}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("\nPress any key to continue\n");
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region ############### NOMINAL CASE ###############
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("################### NOMINAL CASE ##################\n");
            Console.ResetColor();
            try
            {
                patientTemperature = new Temperature(37.0f);
                patientTemperature.FeverTemperature += PatientTemperature_FeverTemperature;
                Console.WriteLine($"Temperature value afer construction : {patientTemperature.TemperatureInCelsius}\n");

                //Trying to trigger the fever event
                patientTemperature.IncreaseTemperature(2f);
                Console.WriteLine($"Patient fever == {patientTemperature.TemperatureInCelsius}\n");

                //Checking if the freezing event is triggered
                patientTemperature.DecreaseTemperature(50f);
                Console.WriteLine($"Patient fever == {patientTemperature.TemperatureInCelsius}\n");

                //Trying to trigger again the fever event
                patientTemperature.IncreaseTemperature(70f);
                Console.WriteLine($"Patient fever == {patientTemperature.TemperatureInCelsius}\n");
            }
            catch (ImpossibleTemperatureException e)
            {
                Console.WriteLine($"Object can't be instanciated : {e.Message} in {e.Source}");
            }
            catch (WrongTemperatureArgumentException e)
            {
                Console.WriteLine($"Bad argument : {e.Message} . Error comes from {e.Source}");
            }
            catch (ImpossibleTemperatureIncreasingException e)
            {
                Console.WriteLine($"Increasing issue : {e.Message}. Error comes from {e.Source}");
            }
            catch (ImpossibleTemperatureDecreasingException e)
            {
                Console.WriteLine($"Decreasing issue : {e.Message}. Error comes from {e.Source}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("===================================================");
            Console.WriteLine("================== END OF PROGRAM =================");
            Console.WriteLine("===================================================\n");
            Console.ResetColor();
            #endregion
        }

        private static void PatientTemperature_FeverTemperature(Temperature sender)
        {
            Console.WriteLine("The event is triggered patient is feverish, please call a doctor !");
        }
    }
}