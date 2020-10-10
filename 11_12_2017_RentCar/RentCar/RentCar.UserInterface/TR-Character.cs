using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RentCar.UserInterface
{
    public class TR_Character
    {
        public string karakterCevir(string metin)
        {
            string[] trHarf = { "Ç", "Ö", "Ş", "Ü", "Ğ", "İ", "ç", "ö", "ş", "ü", "ğ", "ı" };
            string[] enHarf = { "C", "O", "S", "U", "G", "I", "c", "o", "s", "u", "g", "i" };

            for (int i = 0; i <= trHarf.Length - 1; i++)
            {
                Regex regex = new Regex(trHarf[i]);
                metin = regex.Replace(metin, enHarf[i]);
            }

            return metin;
        }
    }
}
