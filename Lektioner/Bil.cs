using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BilInterface
{

    public class Bil : IComparable
    {
        public void CarRun()
        {

            //int n;
            //Console.WriteLine("Ange antal bilar: ");
            //n = int.Parse(Console.ReadLine());

            //Bil[] arrayBilar = new Bil[n];
            //for (int i = 0; i < n; i++)
            //{
            //    arrayBilar[i] = new Bil("", 0);
            //    InmätningBilar(arrayBilar[i]);
            //    Console.WriteLine();
            //}
            //Console.WriteLine();
            //Array.Sort(arrayBilar);
            //Console.WriteLine("\nArray sorterad efter tillverkare (stigande ordning)\n");

            //Array.Sort(arrayBilar, Bil.sortYearAscendin());
            //Console.WriteLine("\nArray sorterad efter tillverkningsår (stigande ordning)\n");

            //Array.Sort(arrayBilar, Bil.sortMakesDescending());
            //Console.WriteLine("\nArray sorterad efter tillverkare (fallande ordning)\n");
            //UtskriftBilar(arrayBilar);

            //Array.Sort(arrayBilar, Bil.sortYearDescending());
            //Console.WriteLine("\nArray sorterad efter tillverkningsår (fallabde ordning)\n");
            //UtskriftBilar(arrayBilar);

            //Console.ReadKey();
        }

        private string tillverkare;
        private int år;
        public Bil(string tillverkare, int år)
        {
            this.tillverkare = tillverkare;
            this.år = år;
        }
        public int År
        {
            get { return år; }
            set { år = value; }
        }
        public string Tillverkare
        {
            get { return tillverkare; }
            set { tillverkare = value; }
        }
        // Klass som sorterar efter år i stigande ordning
        private class SortÅrStigande : IComparer
        {
            int IComparer.Compare(object a, object b)
            {
                Bil c1 = (Bil)a;
                Bil c2 = (Bil)b;
                if (c1.år > c2.år)
                {
                    return 1;
                }
                if (c1.år < c2.år)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }
        private class SortÅrFallande : IComparer
        {
            int IComparer.Compare(object a, object b)
            {
                Bil c1 = (Bil)a;
                Bil c2 = (Bil)b;
                if (c1.år < c2.år)
                {
                    return 1;
                }
                if (c1.år > c2.år)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }
        private class SortTillverkareFallande : IComparer
        {
            int IComparer.Compare(object a, object b)
            {
                Bil c1 = (Bil)a;
                Bil c2 = (Bil)b;
                return String.Compare(c2.tillverkare, c1.tillverkare);

            }
        }
        // Implentering av IComparable CompareTo för att sortera efter tillverkare stigande
        int IComparable.CompareTo(object obj)
        {
            Bil c = (Bil)obj;
            return String.Compare(this.tillverkare, c.tillverkare);
        }
        public static IComparer sortYearAscendin()
        {
            return new SortÅrStigande();
        }
        public static IComparer sortYearDescending()
        {
            return new SortÅrFallande();
        }

        public static IComparer sortMakesDescending()
        {
            return new SortTillverkareFallande();
        }
    }
    static void InmätningBilar(Bil c)
    {
        Console.WriteLine("Ange bilinformation: ");
        Console.WriteLine("Tillverkare: ");
        c.Tillverkare = Console.ReadLine();
        Console.WriteLine("Tillverkningsår: ");
        c.År = int.Parse(Console.ReadLine());
    }
    static void UtskriftBilar(Bil[] arrayBilar)
    {
        foreach (Bil c in arrayBilar)
        {
            Console.WriteLine(c.Tillverkare + "\t\t" + c.År);
        }
    }
   
}

