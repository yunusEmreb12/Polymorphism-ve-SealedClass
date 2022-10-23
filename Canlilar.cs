using System;

namespace Polymorphism
{
    public class Canlilar
    {
        protected void Beslenme(){
            Console.WriteLine("Canlılar Beslenir.");
        }

        protected void Solunum(){
            Console.WriteLine("Canlılar Solunum yapar.");
        }

        protected void Bosaltim(){
            Console.WriteLine("Canlılar Boşaltım yapar.");
        }

        public virtual void UyaranlaraTepki(){
            Console.WriteLine("Canlılar Uyaranlara Tepki Verir.");
        }       
    }   
}