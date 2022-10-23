using System;

namespace Polymorphism
{
    public class Hayvanlar:Canlilar
    {
        protected void Adaptasyon(){
            Console.WriteLine("Hayvanlar Adaptan Kurabilir.");
        }

        public override void UyaranlaraTepki()
        {
            base.UyaranlaraTepki();
            Console.WriteLine("Hayvanlar Temasa Tepki Verir.");
        }
    }

    public class Sürüngenler:Hayvanlar
    {
         public Sürüngenler(){
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }
        public void SürünerekHareketEderler(){
            Console.WriteLine("Sürüngenler Sürünerek Haraket Eder.");
        } 
    }

    public class Kuslar:Hayvanlar
    {
        public Kuslar(){
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
            base.UyaranlaraTepki();

        }
        public void Ucmak(){
            Console.WriteLine("Kuşlar uçar.");
        } 
    }        
}