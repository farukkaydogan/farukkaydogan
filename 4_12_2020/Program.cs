using System;

namespace _4_12_2020
{

    public abstract class Canlılar
    {
        //burda base class olan abstract class oluşur soyut sınıftır gerekli özellikler belirlenir
        public string HayvanTuru;
        private BeslenmeTuru _beslenmeTuru;
        public Canlılar(BeslenmeTuru beslenmeTuru)
        {
            _beslenmeTuru = beslenmeTuru;
        }
        public abstract string Beslen();
    }
    //beslebme seçenekleri sunulur 
    public enum BeslenmeTuru
    {
        Otcul,
        Etcil,
        HemOtculHemEtcil
    }

    //burada interface ile canlnın ne yapabildiği belirtilir
    public interface ISuda
    {
        public void SudaYasa();
    }

    public interface IKarada
    {
        public void SudaYasa();
    }
   // canlılar sınıfından yeni sınıf tanımlanır ve kalıtırlır adıda ördektir hareket olarak I ile interfaceleri kalıtırlır
    public class Ordek : Canlılar ,ISuda,IKarada,IFly
    {
        public BeslenmeTuru beslenme { get; set; }
        public Ordek(BeslenmeTuru beslenmeTuru) : base(beslenmeTuru)
        {
            beslenme = beslenmeTuru;
            HayvanTuru = "Ordek";
        }

        public void SudaYasa()
        {
            Console.WriteLine("Suda");
        }

        public void Uc()
        {
            Console.WriteLine("Ucabilir");
        }

      // override edilir 
        public override string ToString()
        {
            SudaYasa();
            Uc();
            Console.WriteLine($"Ben bir {HayvanTuru} turunde hayvanım");
            return "";
        }

        public override string Beslen()
        {
            return string.Format("Benim beslenme türüm: {0}", (BeslenmeTuru)Enum.Parse(typeof(BeslenmeTuru), beslenme.ToString()));
        }
    }
    public interface IFly
    {
        public void Uc();
    }
   

    class Program
    {
        static void Main(string[] args)
        { // Main metotta ordek adında nesne oluşturulu bunun gerekli atamaları yapılır
            Ordek Ordek = new Ordek(BeslenmeTuru.HemOtculHemEtcil);
            Ordek.ToString();
            Console.WriteLine(Ordek.Beslen());
            Console.WriteLine(" ");

        }
    }
}
