using System;

namespace hcflcm
{
    class Program
    {
        void calculate(){
             int a, b, Num1, Num2, temp, LCM, HCF;  
            Console.WriteLine("Enter the two numbers: ");  
            a = int.Parse(Console.ReadLine());  
            b = int.Parse(Console.ReadLine());  
            Num1 = a;  
            Num2 = b;  
            while (Num2 != 0)  
            {  
                temp = Num2;  
                Num2 = Num1 % Num2;  
                Num1 = temp;  
            }  
            HCF = Num1;  
            LCM = (a * b) / HCF;  
            Console.WriteLine("LCM: "+LCM);  
            Console.WriteLine("HCF: "+HCF);  
        }


        static void Main(string[] args)
        {
            Program p = new Program();
            p.calculate();
        }
    }
}
