using System;

namespace inheritance
{
    public class Canlılar
    {
        protected void Beslenme()
        {
            Console.WriteLine("Canlılar Beslenir.");
        }
        protected void Solunum()
        {
            Console.WriteLine("Canlılar Solunum Yapar.");
        }
        protected void Bosaltim()
        {
            Console.WriteLine("Canlılar Boşaltım Yapar.");
        }

        public virtual void UyaranlaraTepki()
        {
            Console.WriteLine("Canlılar uyaranlara tepki verir.");
        }

    }
}