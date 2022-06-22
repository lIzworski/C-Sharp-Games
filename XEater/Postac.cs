using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XEater
{
    internal class Postac
    {

        private int punkty = 1;

        public int[] tabPozX = new int [Mapa.WielkoscMapy * Mapa.WielkoscMapy];
        public int[] tabPozY = new int [Mapa.WielkoscMapy * Mapa.WielkoscMapy];
        
        public int Punkty { get { return punkty; } set { punkty = value; } }

        public Postac(int pozycjaX, int pozycjaY)
        {
            tabPozX[0]=pozycjaX;
            tabPozY[0]=pozycjaY;
            
        }



    }
}
