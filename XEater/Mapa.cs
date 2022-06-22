using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XEater
{
    internal class Mapa
    {
        private static int wielkoscMapy = 16;
        
        public static int WielkoscMapy { get { return wielkoscMapy; } set { wielkoscMapy = value; } }

        public int OwocX;
        public int OwocY;
        //Mapa
        public string[,] mapa = new string[WielkoscMapy, WielkoscMapy];

        public int szerokoscMapy()
        {
            return WielkoscMapy-1;
        }
        public string owocz = "o";
        public string waz = "#";
        

        public Mapa()
        {
            wypelnijMape();
        }

        public void wypelnijMape()
        {
            for (int y = 0; y < WielkoscMapy; y++)
            {
                for (int x = 0; x < WielkoscMapy; x++)
                {
                    if(y == 0)
                    {
                        mapa[y, x] = "_";  
                    }
                    else if(x == 0)
                    {
                        mapa[y, x] = "|";
                    }
                    else if(y == szerokoscMapy())
                    {
                        mapa[y, x] = "_";
                    }
                    else if (x == szerokoscMapy())
                    {
                        mapa[y, x] = "|";
                    }
                    else
                    {
                        mapa[y, x] = " ";
                    }
                    
                }
            }
            dodajOwoc();
        }

        public void dodajOwoc()
        {
            
            mapa[OwocY, OwocX] = "o";
        }

        public int losuj()
        {
            Random r = new Random();
            int losowy = r.Next(2, WielkoscMapy - 2);
            return losowy;
        }
        public void losujKolor()
        {
            Random r = new Random();
            int losowy = r.Next(0, 8);
            switch (losowy)
            {
                case 0:
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    }
                case 1:
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    }
                case 2:
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    }
                case 3:
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    }
                case 4:
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        break;
                    }
                case 5:
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        break;
                    }
                case 6:
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        break;
                    }
                case 7:
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                case 8:
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    }
            }
        }
        
        public void owoc()
        {
            OwocX = losuj();
            OwocY = losuj();
        }
        public void wyświetlMape()
        {
            for (int y = 0; y < WielkoscMapy; y++)
            {
                for (int x = 0; x < WielkoscMapy; x++)
                {
                    Console.Write(mapa[y, x] + " ");
                }
                Console.WriteLine();
            }
        }

       
        public void zmienPole(Postac p1,Gra g1)
        {
            for (int y = 0; y < WielkoscMapy; y++)
            {
                for (int x = 0; x < WielkoscMapy; x++)
                {
                    for(int i = 0; i < p1.Punkty; i++)
                    {
                        if (p1.tabPozX[i] == x && p1.tabPozY[i] == y)
                        {
                            mapa[y, x] = "#";
                        }
                        if(p1.tabPozX[0] == OwocX && p1.tabPozY[0] == OwocY)
                        {
                            losujKolor();
                            owoc();
                            mapa[p1.tabPozY[0], p1.tabPozY[0]] = " ";
                            p1.Punkty++;
                        }
                        for(int j = 1; j < p1.Punkty; j++)
                        {
                            if(p1.tabPozX[0] == p1.tabPozX[j]  && p1.tabPozY[0] == p1.tabPozY[j])
                            {
                                mapa[5,5] ="Koniec Gry";
                                g1.GameOver = true;
                            }
                        }

                    }
                }
                Console.WriteLine();
            }
        }

    }
}
