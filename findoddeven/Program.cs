using System;

namespace findoddeven
{
    class Program
    {

        int evenodd(int l,int h){

            int [] arr= new int[20];

            for(int i =l;i<=h;i++)
            {
                
                     for(int j =0;j<=arr.Length;j++)
            {
                
                arr[j] = 
            }

                    
                    // return i;
                    // Console.WriteLine("Even number: "+i);
                }
                else
                {
                    Console.WriteLine("Odd number: "+i);
                    
                }

            }
        }

        static void Main(string[] args)
        {
            
            Program p = new Program();
            Console.WriteLine("Enter given range");
            int low = Int32.Parse(Console.ReadLine());
            int high = Int32.Parse(Console.ReadLine());
            p.evenodd(low,high);

        }
    }
}
