using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char[] BoloLolo = text.ToArray();
            string newBoloLolo = "";
            for (int i = text.Length-1; i >-1; i--)
            {
                newBoloLolo += BoloLolo[i];
            }
            Console.WriteLine(newBoloLolo);
            Console.ReadLine();

        }
    }
}
