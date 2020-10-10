using System;

namespace _12._09._2020_Sablon
{
    public delegate void BardakDOlunca();
    class Program
    {
        static void Main(string[] args)
        {
            Bardak b = new Bardak();
            Makina m = new Makina(b);
            m.Doldur(2, b);
        }
    }

    class Bardak
    {
        int kapasite = 20;
        int miktar = 0;
        public event BardakDOlunca BardakDoldu;
        public void BArdagidoldur(int debi)
        {
            for (int i = 0; i < kapasite; i++)
            {
                if (miktar + debi < kapasite)
                {
                    miktar += debi;
                    Console.WriteLine(miktar.ToString());
                }
                else { Console.WriteLine("bardak doldu"); BardakDoldu(); return; }

            }
        }
    }
    class Makina
    {
        int debi;
        public void Doldur(int Debi, Bardak b)
        {
            debi = Debi;
            b.BArdagidoldur(debi);
        }
        void MusluguKapa()

        { debi = 0; Console.WriteLine("musluk kapandı"); }
        public Makina(Bardak b)
        {
           b.BardakDoldu+= new BardakDOlunca(MusluguKapa);
        }
   }
}

