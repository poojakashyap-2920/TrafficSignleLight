using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traffic_Signle
{
    internal class TrafficLight
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("****** TRAFFIC LIGHT CHANGES BASED ON TIME INTERVAL ******");
            for (int i = 60; i > 20; i--)
            {
                Console.WriteLine(i + " " + "red");
                Thread.Sleep(1000);



            }
            for (int j = 20; j > 1; j--)
            {
                Console.WriteLine(j + " " + "yello");
                Thread.Sleep(1000);



            }

            for (int k = 1; k >= 0; k--)
            {
                Console.WriteLine(k + " " + "green");
                Thread.Sleep(1000);



            }

        }

    }
}
