using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._12._2020
{
    class Program
    {
        /// <summary>
        /// Dându-se n numere naturale cu toate cifrele nenule, 
        /// să se determine câte dintre ele corespund unui model de deblocare.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int n, cifra, pfract, ok = 1, contor = 0;

            Console.WriteLine("Introduceti cate elemente sa aiba vectorul");
            n = int.Parse(Console.ReadLine());

            int[] v = new int[n];

            Console.WriteLine("Introduceti elementele vectorului");
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());

                while (v[i] / 10 != 0)
                {
                    cifra = v[i] % 10;
                    v[i] = v[i] / 10;

                    pfract = cifra - (v[i] % 10);

                    if (pfract > 4 || -pfract > 4 || pfract == 0 || pfract == 2)
                        ok = 0;
                }
                if (ok == 1)
                    contor++;
            }
            Console.WriteLine($"{contor} modele corespund unui model de deblocare");
        }
    }
}
