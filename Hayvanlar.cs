using System;

namespace inheritance
{
    public class Hayvanlar:Canlılar
    {
        protected void Adaptasyon()
        {
            Console.WriteLine("Hayvanlar Adaptasyon Kurabilir.");
        }
        public override void UyaranlaraTepki() // Alt sınıfta yazılan sanal(virtual) methodlar. 
        {
            base.UyaranlaraTepki();
            Console.WriteLine("Hayvanlar Temasa Tepki verir.");
        }

    }
    public class Surungenler:Hayvanlar
    {
        public Surungenler(){
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }
        public void SurunerekHareketEtmek()
        {
            Console.WriteLine("Sürüngenler sürünerek hareket eder.");
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
        public void Ucar()
        {
            Console.WriteLine("Kuşlar Uçar.");
        }
    }
}