using System;

namespace Events
{
    class Program
    {
         
            delegate void OlayYoneticisi(); //Olay yöneticisi bildirimi  
            class Buton //Olayın içinde bulunacağı sınıf bildirimi  
        { public event OlayYoneticisi Click; //Olay bildirimi  
            public void Tiklandi() //Olayı meydana getirecek metot  
            { if(Click!=null) Click(); }  
        }  
        class AnaProgram 
        { static void Main() 
            { Buton buton1=new Buton(); 
                buton1.Click+=new OlayYoneticisi(Click); //Olay sonrası işletilecek metotların eklenmesi  
                buton1.Tiklandi(); //Olayın meydana getirilmesi.  
            } 
            //Olay sonrası işletilecek metot 
            static void Click()  // Olaydan sonra çalıştırılacak metot ya da metotların static olma zorunluluğu yoktur. 
            { Console.WriteLine("Butona tıklandı."); } 
        }
    }
}
