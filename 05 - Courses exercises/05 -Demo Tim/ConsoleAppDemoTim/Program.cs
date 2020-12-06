using ClassLibraryCar;
using System;

namespace ConsoleAppDemoTim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("####### TEST MOTOR #######");
            Motor motorWithBadArgument1 = new Motor(null, -1); // 2 bad args
            Motor motorWithBadArgument2 = new Motor("Renault", -1); // int bad args
            Motor motorWithBadArgument3 = new Motor(null, 300); // string bad args
            Motor motorWithGoodArgument = new Motor("Renault", 400); // string bad args

            Console.WriteLine($"BAD\nBrand : {motorWithBadArgument1.Brand}\nSpeed : {motorWithBadArgument1.MaxSpeedInKmPerHour}\n");
            Console.WriteLine($"BAD\nBrand : {motorWithBadArgument2.Brand}\nSpeed : {motorWithBadArgument2.MaxSpeedInKmPerHour}\n");
            Console.WriteLine($"BAD\nBrand : {motorWithBadArgument3.Brand}\nSpeed : {motorWithBadArgument3.MaxSpeedInKmPerHour}\n");
            Console.WriteLine($"GOOD\nBrand : {motorWithGoodArgument.Brand}\nSpeed : {motorWithGoodArgument.MaxSpeedInKmPerHour}\n");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("####### TEST CAR #######");
            Car carWithBadArgument1 = new Car(null, null, -1, null);
            Car carWithBadArgument2 = new Car(null, "Megane", -1, motorWithGoodArgument);
            Car carWithBadArgument3 = new Car("Renault", null, 200, null);
            Car carWithBadArgument4 = new Car("Renault", null, 200, motorWithGoodArgument);
            Car carWithGoodArgument1 = new Car("Renault", "Megane", 200, motorWithGoodArgument);
            Car carWithGoodArgument2 = new Car("Renault", "Laguna", motorWithGoodArgument);

            Console.WriteLine($"BAD \n{carWithBadArgument1.GetInfo()}" +
                $"\nMotor :\nBrand : {carWithBadArgument1.CurrentMotor.Brand}\n" +
                $"Speed : {carWithBadArgument1.CurrentMotor.MaxSpeedInKmPerHour}\n"); 
            
            Console.WriteLine($"BAD: \n{carWithBadArgument2.GetInfo()}" +
                $"\nMotor :\nBrand : {carWithBadArgument2.CurrentMotor.Brand}\n" +
                $"Speed : {carWithBadArgument2.CurrentMotor.MaxSpeedInKmPerHour}\n"); 
            
            Console.WriteLine($"BAD : \n{carWithBadArgument3.GetInfo()}" +
                $"\nMotor :\nBrand : {carWithBadArgument3.CurrentMotor.Brand}\n" +
                $"Speed : {carWithBadArgument3.CurrentMotor.MaxSpeedInKmPerHour}\n");  
            
            Console.WriteLine($"BAD : \n{carWithBadArgument4.GetInfo()}" +
                $"\nMotor :\nBrand : {carWithBadArgument4.CurrentMotor.Brand}\n" +
                $"Speed : {carWithBadArgument4.CurrentMotor.MaxSpeedInKmPerHour}\n");  
            
            Console.WriteLine($"GOOD : \n{carWithGoodArgument1.GetInfo()}" +
                $"\nMotor :\nBrand : {carWithGoodArgument1.CurrentMotor.Brand}\n" +
                $"Speed : {carWithGoodArgument1.CurrentMotor.MaxSpeedInKmPerHour}\n");  
            
            Console.WriteLine($"GOOD : \n{carWithGoodArgument2.GetInfo()}" +
                $"\nMotor :\nBrand : {carWithGoodArgument2.CurrentMotor.Brand}\n" +
                $"Speed : {carWithGoodArgument2.CurrentMotor.MaxSpeedInKmPerHour}\n");

            Console.WriteLine($"Speed car 1 : {carWithGoodArgument1.CalculateMaxSpeed()}\n");
            
            Console.WriteLine($"Speed car 2 : {carWithGoodArgument2.CalculateMaxSpeed()}\n");
        }
    }
}