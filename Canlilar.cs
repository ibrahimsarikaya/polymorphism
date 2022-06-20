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

        public virtual void UyaranlaraTepki() // Sanal(Virtual) metotlar kalıtım alınan yani miras veren sınıf içerisinde(Bu programda canlılar oluyor yani) yazılan ve daha sonra alt sınıflarda yeniden yazılabilen metotlardır. Sealed ise classı gizlemek, kapatmak için kullanılır.
        {
            Console.WriteLine("Canlılar uyaranlara tepki verir.");
        }

    }
}