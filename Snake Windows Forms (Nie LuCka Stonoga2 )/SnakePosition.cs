using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class SnakePosition
    {
        private int posX;
        private int posY;
        public int PosX { get { return posX; } set { posX = value; } }
        public int PosY { get { return posY; } set { posY = value; } }
        
        public SnakePosition(int posX, int posY)
        {
            this.posX = posX;
            this.posY = posY;
        }
    }
}
