using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Kisi> Kisiler = new List<Kisi>();

            Kisi kisi1 = new Kisi();
            Kisi kisi2 = new Kisi();
            Kisi kisi3 = new Kisi();

            kisi1.Ad = "Eymen";
            kisi2.Ad = "Elif";
            kisi3.Ad = "Elif";
            Kisiler.Add(kisi1);
            Kisiler.Add(kisi2);
            Kisiler.Add(kisi3);
            string[] dizi2 = new string[Kisiler.Count];
            for (int i = 0; i < Kisiler.Count; i++)
            {
                for (int j = i; j < Kisiler.Count; j++)
                {
                    if (Kisiler[i].Ad != Kisiler[j].Ad)
                        dizi++;
                }
            }
            Console.WriteLine(dizi);
        }
    }

    class Kisi
    {
        string ad;
        private bool disposedValue;
        public string Ad
        {
            get
            {    return ad;}
            set
            {  ad = value;}
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }
                --Program.dizi;
                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }
    }
}


