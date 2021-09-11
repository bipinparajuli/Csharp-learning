using System;

namespace sumoffirstandlastfigit
{
    class Program
    {

        int sumofdigits(int n){

            if(n < 10)
            {
                return n;
            }

            //sadsadasd
            int last = n%10;
            while ( n > 10 )
            {
                n=n/10;
            }

            

            return n+last;

        } 

        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Enter any number");
            int num = Int32.Parse(Console.ReadLine());

            Console.WriteLine(p.sumofdigits(num));

        }
    }
}
