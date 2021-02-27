using System;
using System.Collections.Generic;
using System.Text;

namespace _25_12_2020
{
    public delegate double Delege(int text,int text2);
        
    class delegeler
    {
        Delege dlg;
        public delegeler(int text, int text2)
        {
            dlg = Message1;
            dlg += Message2;
            dlg += Message3;
            Console.WriteLine(dlg(text,text2));
        }

        private double Message1(int text,int text2) {return text+text2;}
        private double Message2(int text,int text2) {return text-text2;}
        private double Message3(int text,int text2) { return text / text2; }



    }
}
