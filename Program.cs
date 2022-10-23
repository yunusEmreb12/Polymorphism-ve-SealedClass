using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //                                  Canlılar
            //                                     |
            //              Bitkiler                                Hayvanlar
            //       |                  |                      |                |
            //      Tohumlu         Tohumsuz               Sürüngenler        Kuslar

            TohumluBitkiler tohumluBitki = new TohumluBitkiler();
            tohumluBitki.TohumlaCogalma();

            Console.WriteLine("**********************");

            Kuslar martı = new Kuslar();
            martı.Ucmak();
        }
    }
}