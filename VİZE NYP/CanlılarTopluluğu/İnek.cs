using System;
using System.Collections.Generic;
using System.Text;

namespace Vize_Nyp.CanlılarTopluluğu
{
    class İnek : Canlılar, IKaradaYasayanlar
    {

        public İnek()
        {
            Beslenme_Turu = Beslenme.Otcul.ToString();
            Canlı_Turu = "İnek";
        }
        public override void Feed()
        {
            Console.WriteLine($"Ben {Beslenme_Turu} beslenirim");
        }
        public void KaradaYasa()
        {
            Console.WriteLine($" Ben Karada yaşarım");
        }

        public override string ToString()
        {
            Console.WriteLine($"Canlı Turu = {Canlı_Turu}");
            Feed();
            KaradaYasa();
            Console.WriteLine(" \n");
            return "";
        }

    }
}
