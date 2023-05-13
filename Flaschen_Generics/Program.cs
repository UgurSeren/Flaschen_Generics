using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flaschen_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Flasche flasche = new Flasche(false);

            while (true)
            {
                flasche.IsLeer();
                Console.WriteLine("-----------------");
                Console.WriteLine("\t Getränke:\n");
                flasche.ZeigGetraenke();
            }
                       
            

            
            Console.ReadLine();
        }
    }
}
