using System;
using System.Collections.Generic;
using System.Text;

namespace Vize_Nyp
{

    public abstract class Canlılar
    {
        public string Canlı_Turu { get; set; }
       public string Beslenme_Turu { get; set; }
        public abstract void Feed();
    }
    public enum Beslenme { Hepcil, Etcil, Otcul };


}
