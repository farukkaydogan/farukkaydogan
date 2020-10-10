using System;

namespace _7._08._2020
{

    class Sekil
    {
        public double Boy;
        public double En;

        public Sekil(double boy, double en)
        {
            this.Boy = boy;
            this.En = en;
        }
        virtual public double Alan()
        {
            return 0;

        }

    }
        class Dortgen : Sekil
        {
            public Dortgen(int boy, int en) : base(boy, en)
            {
            }
            override public double Alan()
            {
                return En * Boy;
            }
        }
        class UCgen : Sekil
        {
            public UCgen(int boy, int en) : base(boy, en)
            {
            }
            override public double Alan()
            {
                return En * Boy / 2;

            }
        }

        class Program
        {
            public static void AlanBul(Sekil sekil)
            { Console.WriteLine("Şeklin alaanı : " + sekil.Alan()); ; }
            static void Main(string[] args)
            {
                UCgen ucgen = new UCgen(10, 50);
                AlanBul(ucgen);
                Dortgen dortgen = new Dortgen(10, 50);
                AlanBul(dortgen);
                Sekil sekil = new Sekil(10, 50);
                AlanBul(sekil);
            }
        }
    
}
