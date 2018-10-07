using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TPProfil
{

    public enum StType {NoType=0, Station=1, PassingLoop=2, Halt=3, BlockPost=4, LevelCrossing=5};

    public class Station
    {
        private double p;
        private StType type;
        private string name;

        public double P { get => p; set => p = value; }
        public string Name { get => name; set => name = value; }
        public StType Type { get => type; set => type = value; }

        public Station (double P, string N, StType t)
        {
            p = P;
            name = N;
            type = t;
        }

        public string getAcronym ()
        {
            switch ((int)this.type)
            {
                case 0: return "--";
                case 1: return "ст.";
                case 2: return "рзд.";
                case 3: return "о.п.";
                case 4: return "б-п.";
                case 5: return "пер.";
            }

            return "uns.";
        }

        /*
        public void DrawAt(int x, int h, Graphics g, Font font)
        {
            SizeF nameSize = new SizeF();
            SizeF mileSize = new SizeF();
            int miles = (int)p / 1000;
            int meters = (int)p % 1000;
            string piquette = "ПК " + Convert.ToString(miles) + "+" + Convert.ToString(meters);

            nameSize = g.MeasureString(name, font);
            mileSize = g.MeasureString(piquette, font);

            g.DrawString(name, font, x - nameSize.Width / 2, mileSize.Height / 2);
            g.DrawString(piquette, font, x - mileSize.Width / 2, nameSize.Height + mileSize.Height);

            int signatureHeight = nameSize.Height + 2.5 * mileSize.Height;
            int hs = h - signatureHeight;
            int m = hs / 20;

            g.DrawLine(x, h, x, h - 10m);
            
        }*/
    }
}
