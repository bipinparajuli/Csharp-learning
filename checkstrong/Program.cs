using System;

namespace checkstrong
{
    class Program
    {

        public bool checkStrong(int num){

        int sum =1;
        int value = num;

    while (num >10)
    {
        int rem = num%10;
        int tem=1;
        for(int i=1;i<=rem;i++)
        {
            tem=tem*i;

        }
        sum = sum+tem;
        
        num=num/10;   

    }

    if(sum == value)
{

    return true;
}

else{
    return false;
}

    


        }

        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Enter any number");
            int num= Int32.Parse(Console.ReadLine());    
            Console.WriteLine(p.checkStrong(num));
        }
    }
}
