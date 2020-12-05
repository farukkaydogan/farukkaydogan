using System;
using System.Collections.Generic;
using System.Text;

namespace Vize_Nyp.CanlılarTopluluğu
{
    class Ordek : Canlılar, IKaradaYasayanlar, ISudaYasayanlar, IFlyable
    {

        public Ordek()
        {
            Beslenme_Turu = Beslenme.Hepcil.ToString();
            Canlı_Turu = "Ordek";
        }
        public override void Feed()
        {
            Console.WriteLine($"Ben {Beslenme_Turu} beslenirim");
        }
        public void KaradaYasa()
        {
            Console.WriteLine(" Ben Karada yaşarım");
        }
        public void SudaYasa()
        {
            Console.WriteLine("Ben Suda Yaşarım");
        }
        public void Fly()
        {
            Console.WriteLine("Ben uçabilirim");
        }

        public override string ToString()
        {
            Console.WriteLine($"Canlı Turu = {Canlı_Turu}");
            Feed();
            KaradaYasa();
            SudaYasa();
            Fly();
            Console.WriteLine(" \n");
            return "";
        }

    }
}
