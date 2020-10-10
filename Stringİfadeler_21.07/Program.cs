using System;

namespace Stringİfadeler_21._07
{
    class Program
    {
        static void Main(string[] args)
        {

            mix();

        }

        static void mix ()
        {
            string a = "kimlirikimler var şimdi mixinde bak yine acıyor sol yanım";
            int sayac = 0;

            for (int i = 0; i < a.Length; i++)
            {
                char b =a[i] ;
                if (b =='a')
                {
                    sayac++;
                }
            }
            Console.WriteLine(sayac);
         
        }
        static void Farther()
        {
            int timer=0;
            int count=0;
            string[] sentence = {" en uzun ", "en kısası ", "bilmem ne","en enenenenn",
                "biliyorsun sana zayıftırbuyüreğim" , "#faruklabirliktediren" ,"sen bahçemsin"," bonjueHelloHallomerhaba","uzunmuenenmiuzun" };
            timer = sentence[0].Length;
            for (int i = 0 ; i < sentence.Length; i++)
            {
                if (timer< sentence[i].Length) 
                {
                    count = i;
                    timer = sentence[i].Length;
                } 
              
            }
            Console.WriteLine(  $"{timer} satırı ile en uzun cümle = {sentence[count]}  ");
        }
        static void Cut()
        {
            Console.WriteLine("bir cümle gir");
            string bosluk = Console.ReadLine();
            for (int i = 0; i < bosluk.Length; i++)
            {
                char a = bosluk[i];
                if (a == ' ')
                {
                    break;
                }
                else Console.Write(a);
            }
        }

    }
}

