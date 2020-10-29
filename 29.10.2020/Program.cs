using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29._10._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pe planeta Marte anul marțian durează x zile marțiene, iar o zi marțiană durează y ore.
            // În fiecare oră, marțianului Iggle îi crește o antenă. După cât timp va avea Iggle n antene?

            int x, y, n;
            string line;

            line = Console.ReadLine();
            string[] numere = line.Split(' ');
            x = int.Parse(numere[0]);
            y = int.Parse(numere[1]);
            n = int.Parse(numere[2]);

            int a, z, h;

            a = n / (x * y);
            z = (n - a * (x * y)) / y;
            h = (n - a * (x * y)) - (z * y);

            Console.WriteLine(a);
            Console.WriteLine(z);
            Console.WriteLine(h);

        }
    }
}
