using System;
namespace Age_problems
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                try
                {

                    Console.WriteLine("Dogum yılınızı giriniz");
                    int y = int.Parse(Console.ReadLine());
                    if (y > DateTime.Now.Year|| y<0) { Console.WriteLine("Doğum yılınızı yanlış girdiniz Tekrar giriş yapınız"); throw new ApplicationException(); }
                    Console.WriteLine(y + " yılının hangi ayında doğdunuzu sayı olarak giriniz");
                    int m = int.Parse(Console.ReadLine());
                    if (m < 1 || m > 12)
                    {
                        Console.WriteLine("yanlış bir Ay girdiniz Tekrar giriş yapınız");  throw new ApplicationException();
                    }
                    Console.WriteLine(y + " yılının  " + m + " . ayının hangi gününde doğdunuz");
                    int d = int.Parse(Console.ReadLine());
                    DateTime a = new DateTime(y, m, d);
                    if (70 < DateTime.Now.Year - y) { Console.WriteLine(    "yaşınız 70'den büyük olamaz Tekrar giriş yapınız"); throw new ApplicationException("Yaş 70'den büyük olamaz"); }
                    if (DateTime.Now.Year-y < 18) { y += 18; DateTime Ehliyet = new DateTime(y, 0, 0); TimeSpan fark = Ehliyet-a; Console.WriteLine("ehliyetinizi almanıza kalan süre = "+ fark.Days); }
                    else Console.WriteLine("Tebrikler Ehliyet alabilirsiniz");

                }
                
                catch (ApplicationException)
                {
                     continue;
                }
                break;
                
            }
        }
    }
}
