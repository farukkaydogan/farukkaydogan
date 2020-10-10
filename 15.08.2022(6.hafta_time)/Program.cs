using System;

namespace _15._08._2020_6.hafta_time_
{
    class Notlar
    {
        private int mNot;
        public int Not
        {
            get { return mNot; }
            set
            {
                if (value > 100)
                    throw new FazlaNotHatasi();
                else if (value < 0)
                    throw new DusukNotHatasi();
                else mNot = value;
            }
        }
        public class FazlaNotHatasi : ApplicationException
        {
            override public string Message { get { return "Not 100'den büyük olamaz."; } }
        }
        public class DusukNotHatasi : ApplicationException
        {
            override public string Message
            {
                get { return "Not 0'dan küçük olamaz."; }
            }
        }
    }
    class Ana
    {
        static void Main()
        {
            try

            {
                Notlar a = new Notlar();
                Console.Write("Not girin: ");
                int b = Int32.Parse(Console.ReadLine());
                a.Not = b;
                Console.WriteLine("Notu başarıyla girdiniz.");
            }
            catch (Exception nesne)
            { Console.WriteLine(nesne.Message); }
        }
    }
}
