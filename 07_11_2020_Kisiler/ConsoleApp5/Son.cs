using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
    class Program
    {
        public static int dizi; 
        static void Main(string[] args)
        {
            List<Kisi> Kisiler = new List<Kisi>();

            Kisi kisi1 = new Kisi();
            Kisi kisi2 = new Kisi();
            Kisi kisi3 = new Kisi();
            Kisi kisi4 = new Kisi();
            Kisi kisi5 = new Kisi();
            Kisi kisi6 = new Kisi();

            kisi1.Ad = "Eymen";
            kisi2.Ad = "Elif";
            kisi3.Ad = "Elif";
         //   kisi4.Ad = "";
           // kisi5.Ad = "ismail";
           // kisi6.Ad = "ilhami";
            Kisiler.Add(kisi1);
            Kisiler.Add(kisi2);
            Kisiler.Add(kisi3);
           // Kisiler.Add(kisi4);
           // Kisiler.Add(kisi5);
           // Kisiler.Add(kisi6);

            //for (int i = 0; i < Kisiler.Count; i++)
            //{
            //    if (i == 0)
            //    {
            //        dizi[i] = Kisiler[i].Ad;
            //    }
            //    else
            //    {
            //        for (int j = 0; j < Kisiler.Count; j++)
            //        {
            //            if (dizi[i - 1] != Kisiler[j].Ad)
            //            {
            //                dizi[i] = Kisiler[j].Ad;
            //            }
            //        }
            //    }
            //}
            string[] dizi2 = new string[Kisiler.Count];
           // dizi2[0] = Kisiler[0].Ad;
            for (int i = 0; i < Kisiler.Count; i++)
            {
                for (int j = i; j < Kisiler.Count; j++)
                {
                     if (Kisiler[i].Ad!=Kisiler[j].Ad//&&
                     //    dizi2[0]!=Kisiler[i].Ad
                       //  && dizi2[1] != Kisiler[i].Ad 
                        // && dizi2[2] != Kisiler[i].Ad 
                       //  && dizi2[3] != Kisiler[i].Ad 
                          
                         //dizi2[4] != Kisiler[i].Ad 
                         //&& dizi2[5] != Kisiler[i].Ad 
                         )
                     {
                         dizi++;
                     }
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
            {
                return ad;
            }
            set
            {
                ad = value;
            }
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


