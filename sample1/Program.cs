using System;  
using System.Collections.Generic;  
namespace ConsoleApplication2  
{  
    delegate T numbermanipulate<T>(T num);  
    class Program  
    {  
        static int number = 10;  
        
         int addnumber(int n)  
        {  
            number = number + n;  
            return number;  
  
  
        }  
        
         int multinumber(int q)  
        {  
            number = number * q;  
            return number;  
  
        }  
  
  
        static void Main(string[] args)  
        {  
            Console.WriteLine("enter two values");  
            int k = Convert.ToInt32(Console.ReadLine());  
            int m = Convert.ToInt32(Console.ReadLine());  
   
            Program p= new Program();

            numbermanipulate<int> nm = new numbermanipulate<int>(p.addnumber);  
            Console.WriteLine("addnumber values" + nm(k));  

            numbermanipulate<int> nm1 = new numbermanipulate<int>(p.multinumber);  
            Console.WriteLine("multi values" + nm1(m));    
        }  
    }  
}  