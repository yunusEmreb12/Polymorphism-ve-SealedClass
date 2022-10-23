using System;

namespace Polymorphism
{
    public class Bitkiler:Canlilar
    {
        protected void FotosentezYapmak(){
            Console.WriteLine("Bitkiler Fotosentez yapar.");
        }

        public override void UyaranlaraTepki()
        {
            //base.UyaranlaraTepki();
            Console.WriteLine("Bitkiler Güneşe Tepki verir.");
        }
    }

    public class TohumluBitkiler:Bitkiler
    {
        public TohumluBitkiler(){
            base.FotosentezYapmak();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
            base.UyaranlaraTepki();
        }
        public void TohumlaCogalma(){
            Console.WriteLine("Tohumlu Bitkiler tohumla çoğalır.");
        } 
    }

     public class TohumsuzBitkiler:Bitkiler
    {
         public TohumsuzBitkiler(){
            base.FotosentezYapmak();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }
        public void SporlaCogalma(){
            Console.WriteLine("Tohumsuz Bitkiler Sporla çoğalır.");
        } 
    }
} 