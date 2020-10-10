using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Yılan_oyunu
{
    class Class1
    {
        YilanGovdesi[] yilan;
        Yon Yonumuz;

        public void Yılan()
        {
            int YılanBuyuklugu = 3;
            yilan = new YilanGovdesi[3];
            yilan[0] = new YilanGovdesi(150, 150);
            yilan[1] = new YilanGovdesi(160, 160);
            yilan[2] = new YilanGovdesi(170, 170);
        }
        public int YılanBuyuklugu
        { get { return YılanBuyuklugu;  }
            set { YılanBuyuklugu = value; }
        }
        public void İlerle(Yon yon)
        {
            Yonumuz = yon;
            if (yon != null)
            {
                for (int i = yilan.Length - 1; i < 0; i++)
                {
                    yilan[i] = new YilanGovdesi(yilan[i - 1].x_yon, yilan[i - 1].y_yon);

                }
                yilan[0] = new YilanGovdesi(yilan[0].x_yon + yon._x, yilan[0].y_yon + yon._y);
            }
        }
        public void Buyu()
        {
            Array.Resize(ref yilan, yilan.Length + 1);
            yilan[yilan.Length - 1] = new YilanGovdesi(yilan[yilan.Length - 2].x_yon-Yonumuz._x, yilan[yilan.Length - 2].y_yon - Yonumuz._y);
            YılanBuyuklugu++;
        }
        public Point GetPos(int sayı)
        {
                return new Point(yilan[sayı].x_yon , yilan[sayı].y_yon);
        }
    }
    class Yon
    {
        public readonly int _x;
        public readonly int _y;
        public Yon(int x, int y)
        {
            _x = x; _y = y;

        }

    }
    class YilanGovdesi

    {
        public readonly int xx; public readonly int yy;
        public  int x_yon; public int y_yon;
        public YilanGovdesi(int x, int y)
        {
           x_yon = x;   y_yon=y;
            xx = 10; yy = 10;
        }
    }
}
