using System;

namespace DiziSınırıAsıldı
{
    class sınıf
    {
        public static void Main(string[] args)
        {
            try
            {
                int giris = Convert.ToInt32(Console.ReadLine());
                NOT not = new NOT();
                not.Notlar = giris;
                Console.WriteLine("notu başarılı ile girdin");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
    class NOT
    {
        int not;
        public int Notlar
        {
            get { return not; }
            set { if (value < 0) throw new Dusuknot(); else if (value > 100) throw new FazlaNot(); else value = not; }
        }
    }
    

    class Dusuknot : ApplicationException
    {
        public override string Message
        {
            get { return "0'dan küçük olamaz"; }
        }
    }
    class FazlaNot : ApplicationException
    {
        public override string Message { get { return "Not 100'den büyük olamaz"; } }
    }
}




