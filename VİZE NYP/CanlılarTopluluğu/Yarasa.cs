using System;
using System.Collections.Generic;
using System.Text;

namespace Vize_Nyp.CanlılarTopluluğu
{
    class Yarasa : Canlılar, IFlyable, IKaradaYasayanlar
    {

        public Yarasa()
        {
            Beslenme_Turu = Beslenme.Etcil.ToString();

            Canlı_Turu = "Yarasa  ";
        }
        public override void Feed()
        {
            Console.WriteLine($"  ben {Beslenme_Turu} beslenirim");
        }
        public void Fly()
        {
            Console.Write(" Ben Uçabilirim");
        }
        public void KaradaYasa()
        {
            Console.Write("  Ben karada yaşarım");
        }
        public override string ToString()
        {
            Console.WriteLine($" Canlı Turu = {Canlı_Turu}  ");
            Feed(); Fly(); KaradaYasa();
            Console.WriteLine(" \n");

            return "";

        }
    }
}
