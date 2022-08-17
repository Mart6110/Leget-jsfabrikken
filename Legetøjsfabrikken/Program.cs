using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legetøjsfabrikken
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[5];
            double[] weight = new double[5];

            Console.WriteLine("Indtast venligst legetøj:");

            for(int i = 0; i < array.Length; i++)
            {
                array[i] = Console.In.ReadLine().ToLower();
            }

            Console.Write("Box 1: ");

            for(int i = 0; i < array.Length; i++)
            {
                switch(array[i])
                {
                    case "legetårn":
                        weight[i] = 2;
                        break;
                    case "badeand":
                        weight[i] = 0.4;
                        break;
                    case "byggeklodser":
                        weight[i] = 1;
                        break;
                    case "helikopter":
                        weight[i] = 1.7;
                        break;
                    case "bold":
                        weight[i] = 0.8;
                        break;
                    case "tog":
                        weight[i] = 2.4;
                        break;
                    case "bamse":
                        weight[i] = 0.9;
                        break;
                    case "rumskib":
                        weight[i] = 0.3;
                        break;
                }

                Console.Write(array[i] + ", ");
            }

            double totalWeight = weight[0] + weight[1] + weight[2] + weight[3] + weight[4];

            Console.Write("(" + totalWeight + " kg)");
            Console.ReadLine();
        }
    }
}
