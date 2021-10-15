using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrollitöö
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Millist ülesannet soovite valida? [1, 2, 3]: ");
            int numb = Convert.ToInt32(Console.ReadLine());

            if (numb == 1)
            {
                Alamprogram.esimene();
            }
            else if (numb == 2)
            {
                Alamprogram.teine();
            }
            else if (numb == 3)
            {
                Alamprogram.kolmas();
            }

            /*
            do
            do class
            do class if;

            do this break size of public
            try if struct for auto static 
            while!!
            */
        }
    }
}
