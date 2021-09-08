using System;

namespace classobj
{
    class Program
    {
        int findAreaRectangle(int l,int b){
            return l*b;
        }

        int perimeterReactangle(int l,int b){
            int area = l+b;
            return 2*area;
        }


        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Enter two number");
            int l = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Area "+p.findAreaRectangle(l,b));
            Console.WriteLine("Area of Perimeter " + p.perimeterReactangle(l,b));

        }
    }
}
