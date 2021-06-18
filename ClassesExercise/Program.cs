using System;

namespace ClassesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Ford";
            myCar.Model = "Focus";
            myCar.Year = 2013;

            /* Car() is a constructor - a special member method that helps create
               a new instance of the car class. */
            // It is a method so it had parenthesis.
            /* By creating the Car class, you created a custom type - you dont 
             * need to use var at the beginning. */
            

            Console.WriteLine($"{myCar.Make}");
            Console.WriteLine($"{myCar.Model}");
            Console.WriteLine($"{myCar.Year}");

           
        }
    }
}
           /*
           var mazda = new Car()
           {
               Make = "Mazda",
               Model = "CX-5",
               Year = 2016

               // This new object has nothing to do with the previous object,
                * but the previous Car class was a blueprint to be used again
                * with new variables. */
