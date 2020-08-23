using System;

namespace Es_n1_Vacanze
{
    public class LibraryEsN1
    {
        public static int Massimo(int a,int b)
        {
            int massimo = Math.Max(a, b);
            return massimo;
        }
        public static int Minimo(int a, int b)
        {
            int minimo = Math.Min(a, b);
            return minimo;
        }
        public static double Media(double a,double b)
        {
            double somma = a + b;
            double media = somma / 2;
            return media;
        }
    }
}
