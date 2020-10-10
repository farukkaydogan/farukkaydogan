using System;

namespace Base_Virtual
{
    class Memeli
    {
        public int Boy, En;
        public Memeli(int boy, int en)
        {
            this.Boy = boy; this.En = en;
        }
        virtual public void Yazdır()
        {
            Console.WriteLine(  "Konuşamam");
        }

    }
    class Koyun : Memeli
    {
        public string Tur;
        public Koyun(string tur, int boy, int en) : base(boy, en)
        {
            this.Tur = tur;

        }
        override  public void Yazdır()
        {
            Console.WriteLine("Ben koyunum");
        }
    }
    class Kedi : Memeli
    {
        public string Tur;
        public Kedi(string tur, int boy, int en) : base(boy, en)
        {
            this.Tur = tur;

        }
        override public void Yazdır()
        {
            Console.WriteLine("Ben Kediyim");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Kedi kedi = new Kedi("bitlis", 10, 50);
            kedi.Yazdır();
            Koyun kooyun = new Koyun("ankara", 20, 100);
            kooyun.Yazdır();
            Memeli memeli = new Memeli(10, 20);
            memeli.Yazdır();

        }
    }
}
