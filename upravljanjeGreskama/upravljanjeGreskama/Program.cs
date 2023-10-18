using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upravljanjeGreskama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int godRod;
            bool kontrola = false;
            do
            {
                Console.WriteLine("Upiši svoju godinu rođenja:  ");
                try
                {
                    godRod = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Rođen si: " + godRod + ".godine");
                    kontrola = true;
                }
                catch (Exception greska)
                {
                    Console.WriteLine(greska.Message);
                    kontrola = false;
                }
            } while (kontrola == false);
            Console.ReadLine();

        }
    }
}
