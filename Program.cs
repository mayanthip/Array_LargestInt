using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] number = {1,5,4,9,8,6,7,10,8};
             int maxInt=0;
            for (int i =0; i<number.Length;i++)
            {
                if(number[i]>maxInt)
                maxInt=number[i]; 
                
            }
            Console.WriteLine("The largest number  in the array is  {0}",maxInt );
        }
    }

}