using System;

namespace SortowanieBabelkowe
{
    class Program
    {
        static string[] Sortuj(string[] tablica)
        {
            for (int k = 0; k < tablica.Length - 1; k++)
            {
                for (int i = 0; i < tablica.Length - 1; i++)
                {
                    if (tablica[i].CompareTo(tablica[i + 1]) > 0)
                    {
                        string x = tablica[i];
                        tablica[i] = tablica[i + 1];
                        tablica[i + 1] = x;
                    }
                }
            }
            return tablica;
        }

        static double[] Sortuj(double [] tablica)
        {
            for (int k = 0; k < tablica.Length - 1; k++)
            {
                for (int i = 0; i < tablica.Length - 1; i++)
                {
                    if (tablica[i] > tablica[i + 1])
                    {
                        double x = tablica[i];
                        tablica[i] = tablica[i + 1];
                        tablica[i + 1] = x;
                    }
                }
            }
            return tablica;
        }

        public static void Main()
        {
            var tablica = new double[]{ 10.0, 5.0, 3.0, 1.0 };
            Sortuj(tablica);
            foreach (var x in tablica)
            {
                Console.WriteLine(x);
            }

            var napisy = new string[] { "żółć", "złoto", "ala", "ąąąą"  };

            Sortuj(napisy);
            foreach (var x in napisy)
            {
                Console.WriteLine(x);
            }
        }
    }
}
