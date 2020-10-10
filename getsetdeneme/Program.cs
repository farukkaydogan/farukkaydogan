using System;

namespace getsetdeneme
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Sayilar sayi = new Sayilar(101);

            }
            catch (OverflowException excpt)
            {

                Console.WriteLine(excpt.Message);
            }
        }  
    }
    class Sayilar
    {
        int Mdeger;
        public Sayilar(int mdeger)
        {
            if (mdeger < 100)
            {
                this.Mdeger = mdeger;
            }
            else if (mdeger > 100)
            {
                throw new OverflowException("değer 100den büyük olamaz");
            }
        }
    }
}
