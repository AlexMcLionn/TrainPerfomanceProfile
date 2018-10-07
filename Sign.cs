using System.Drawing;

namespace TPProfil
{
    public enum SignType { W0=0, W4=4, W54=54, W55=55};
    public class Sign
    {
        private double p;
        private string type;

        /*

        //Рисовалка
        public void DrawAt(int x, int y, Graphics g)
        {
            Image image = new Image();

            switch (this.type)
            {
                case 0:
                     image = ProfilResorces.W0x32;
                    break;

                case 4:
                     image = ProfilResorces.W4x32;
                    break;
            }

            g.DrawImage(image, x - 16, y - 32);

        }*/
    }
}
