using System;

namespace Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n");
            
            
            
            
            
            for(int i = 0; i < 20; i++)
            {
                Console.Write("{0} ", Math.Pow(2, i));
            }

            






            
            Console.WriteLine("\n");





            
            for(int i = 0; i < 20; i++)
            {
                int temp = 1;
                
                for(int j = 0; j <= i; j++)
                { 
                    if(j != 0)
                    {
                        temp  *= 2;
                    }
                }

                Console.Write("{0} ", temp);
            }





            Console.WriteLine("\n");






            int x = 1;

            Console.Write("{0} ", x);

            for(int i = 2; i <= 20; i++)
            {
                x *= 2;

                Console.Write("{0} ", x);
            }





            Console.WriteLine("\n");



            for(int i = 1; i <= Math.Pow(2, 19); i *= 2)
            {
                Console.Write("{0} ", i);
            }





            Console.WriteLine("\n");
        }
    }
}
