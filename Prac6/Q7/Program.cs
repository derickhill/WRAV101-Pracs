using System;

namespace Q7
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong[] arr = new ulong[100];

            arr[0] = 1;
            arr[1] = 1;
            
            for(int i = 2; i < 100; i++)
            {
                arr[i] = arr[i-1] + arr[i-2];
            }

            for(int j = 0; j < 100; j++)
            {
                if(arr[j] < 5000)
                {
                    Console.WriteLine(arr[j]);
                }
            }    
        }
    }
}
