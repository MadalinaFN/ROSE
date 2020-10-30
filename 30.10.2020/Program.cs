using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._10._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevisibanci();
            Ora();
        }

        static void Elevisibanci()
        {
            //Dacă elevii unei clase se așează câte n într - o bancă, vor rămâne e elevi în picioare, 
            //iar dacă se așează câte m într-o bancă, vor rămâne b bănci neocupate.
            //Care este numărul de elevi, respectiv de bănci, din clasa respectivă?

            int n, m, e, b;
            string line;

            line = Console.ReadLine();
            string[] numere = line.Split(' ');
            n = int.Parse(numere[0]);
            m = int.Parse(numere[1]);
            e = int.Parse(numere[2]);
            b = int.Parse(numere[3]);

            int elevi, banci;

            banci = ((b * m) + e) / (m - n);
            elevi = n * banci + e;

            Console.WriteLine(elevi);
            Console.WriteLine(banci);
        }
        static void Ora()
        {
            //Se dau 2 numere naturale h m, reprezentând un ora curentă exprimată în ore şi minute.
            //Să se determine care va fi ora peste x minute.

            int h1, m1, x;
            string line;

            line = Console.ReadLine();
            string[] numere = line.Split(' ');
            h1 = int.Parse(numere[0]);
            m1 = int.Parse(numere[1]);
            x = int.Parse(numere[2]);

            int h2, m2;

            h2 = h1 + (m1 / 60) + (x / 60);
            m2 = (m1 + x) % 60;

            Console.WriteLine($"{h2} {m2}");
        }
    }
}
