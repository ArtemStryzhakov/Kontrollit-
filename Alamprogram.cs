using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrollitöö
{
    class Alamprogram
    {
        //Tehke kindlaks, kas algne tähemärk on ka palindroom (lugege sama algusest lõpuni). Tehakse reprodutseerimist ja katseid.
        public static void esimene()
        {
            int[] numbers = new int[4];
            Console.WriteLine();
            for (int i = 0; i < numbers.Length; i++)
            {
                do
                {
                    Console.Write($"Sisesta {i + 1} neljakohalise arvu väärtus: ");
                } while (!int.TryParse(Console.ReadLine(), out numbers[i]));
            };

            Array.Sort(numbers);
            Array.Reverse(numbers);
            Console.WriteLine();
            Console.Write("\nVastus: ");
            foreach (int item in numbers)
                Console.Write(item);

            Console.ReadLine();
        }

        /*Teile antakse täisarvude ruutmaatriks. Loendage negatiivsete ja positiivsete elementide arv ning
            printige ka nullielementide koordinaadid (rea number ja veeru number).*/
        public static void teine()
        {
            Console.WriteLine();
            Console.WriteLine("Sisesta texti: ");
            string x1 = Console.ReadLine();
            x1 = x1.Replace(" ", "").ToLower();
            Console.WriteLine(x1);
            string t = new string(x1.Reverse().ToArray());
            Console.WriteLine();

            if (t == x1)
            {
                Console.WriteLine("See on palindrom");
            }
            else
            {
                Console.WriteLine("See ei ole palindrom");
            }              
        }

        /*Sisestage klaviatuurilt suvalise pikkusega string, korraldage stringis olevad märgid nende koodi kasvavas järjekorras ja moodustage uus rida,
        milles märgid paigutatakse sorteeritud stringi suhtes vastupidises järjekorras.*/
        public static void kolmas()
            {
                Console.WriteLine();
                Console.Write("Ridade arv: ");
                Int32.TryParse(Console.ReadLine(), out int a);
                Console.Write("Veergude arv: ");
                Int32.TryParse(Console.ReadLine(), out int b);
                int[,] matx = new int[a, b];

                Random rand = new Random();
                int numb = 0;
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < b; j++)
                    {
                        matx[i, j] = rand.Next(0, 20);
                        if (matx[i, j] < 0)
                        {
                            numb++;
                        }
                    }
                }

                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < a; j++)
                    {
                        Console.Write(matx[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine($"Negatiivsete elementide arv: {numb}");
        }
    }
}
