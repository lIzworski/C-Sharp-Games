using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XEater
{
    internal class PoruszanieSie
    {
        private bool blokowany= false;


        public bool Blokowany { get { return blokowany; } set { blokowany = value; } }
        public void przenos(Postac p1)
        {
            int[] tmpX = new int[p1.Punkty + 1];
            int[] tmpY = new int[p1.Punkty + 1];

            for (int i = 0; i < p1.Punkty; i++)
            {
                tmpX[i] = p1.tabPozX[i];
                tmpY[i] = p1.tabPozY[i];
            }
            for(int i = 0; i < p1.Punkty; i++)
            {
                p1.tabPozX[i+1] = tmpX[i];
                p1.tabPozY[i+1] = tmpY[i];
            }
        }     
        public void poruszajSie(Postac p1, Mapa m1)
        {
            ConsoleKeyInfo keyReaded = Console.ReadKey();
;            switch (keyReaded.KeyChar)
            {
                case 'w':
                    {
                        if(p1.tabPozY[0] != 1)
                        {
                            wGore(p1);
                        }
                        break;
                    }
                case 's':
                    {
                        if (p1.tabPozY[0] != m1.szerokoscMapy()-1)
                        {
                            wDol(p1);
                        }
                        break;
                    }
                case 'a':
                    {
                        if (p1.tabPozX[0] != 1)
                        {
                            wLewo(p1);
                        }
                        break;
                    }
                case 'd':
                    {
                        if (p1.tabPozX[0] != m1.szerokoscMapy()-1)
                        {
                            wPrawo(p1);
                        }
                        break;
                    }
            }
        }

        public void wPrawo(Postac p1)
        {
            if(Blokowany == false)
            {

                p1.tabPozX[0]++;
            }
            
        }
        public void wLewo(Postac p1)
        {
            if (Blokowany == false)
            {
                p1.tabPozX[0]--;
            }
            
        }
        public void wGore(Postac p1)
        {
            if (Blokowany == false)
            {
                p1.tabPozY[0]--;
            }
            
        }
        public void wDol(Postac p1)
        {
            if (Blokowany == false)
            {
                p1.tabPozY[0]++;
            }
            
        }
    }
}
