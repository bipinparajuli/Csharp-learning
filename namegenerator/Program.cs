using System;

namespace namegenerator
{
    class Program
    {
        public int temp = 0;

       static string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};

        // Instantiate random number generator.  
private readonly Random _random = new Random();  
  
// Generates a random number within a range.      
public void RandomNumber(int max)  
{  
  temp= _random.Next(max);  
}  

public void RandomName(){
    Console.WriteLine(cars[temp]);
}



        static void Main(string[] args)
        {
            Program p = new Program();
int num = Program.cars.Length;

            p.RandomNumber(num);
            p.RandomName();
      while (Console.ReadKey().Key != ConsoleKey.Enter) {
            p.RandomNumber(num);
            p.RandomName();
            Console.WriteLine("Press any key to continue and <Enter> to exit... ");

      }
        }
    }
}
