using System;

namespace palindrome
{
    class Program
    {

        public static bool checkPalindrome(int n)
        {
            int temp = n;
            int pall =0,rem = 0;

            while(n !=0){
                rem= n%10;
                n= n/10;
                pall = pall*10 +rem;
                Console.WriteLine(pall);
            }

            if(pall == temp)
            {
                return true;
            }
            else{
                return false;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number: ");
            int num = Int32.Parse(Console.ReadLine());
            Console.WriteLine(Program.checkPalindrome(num));
        }
    }
}
