using System;

namespace FrogsAndLamps
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] lampsArray = new bool[100];
            int[] frogsArray = new int[100];

            //for (int i = 1; i < lampsArray.Length; i++)
            //{
            //    lampsArray[i] = false;
            //}

            for (int j = 1; j < frogsArray.Length; j++)
            {
                frogsArray[j] = j;
            }

                for (int j = 0; j < frogsArray.Length; j++)
                {

                for (int i = 0; i < lampsArray.Length; i++)
                {
                    if (i % j == 0)
                    {
                        lampsArray[i] = true;
                    }
                }
                
                    
                }

            





            //for (int j = 0; j < frogsArray.Length; j++)
            //{               
                
            //        for (int i = 0; i < lampsArray.Length; i=(2*j)+1)
            //        {
            //            Console.WriteLine(frogsArray[j]);
            //            break;
            //        }
                
            //}
            Console.ReadKey();
        }
    }
}
