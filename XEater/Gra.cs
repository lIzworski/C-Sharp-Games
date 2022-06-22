using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XEater
{
    internal class Gra
    {
        private static bool gameOver = false;
        public bool GameOver { get { return gameOver; } set { gameOver = value; } }
        Postac p1 = new Postac(10, 10);
        Mapa m1 = new Mapa();
        PoruszanieSie r1 = new PoruszanieSie();
        public void petlaGry(Gra g1)
        {
            Console.Clear();
            m1.owoc();
            while(GameOver == false)
            {
                //TimeSpan Slepp =  new TimeSpan(0,0,1);
                
                m1.wypelnijMape();
                m1.zmienPole(p1,g1);
                m1.wyświetlMape();
                r1.przenos(p1);
                r1.poruszajSie(p1, m1);
                
            }
        } 
        public static void Main(String[] args)
        {

            Gra game = new Gra();
            game.petlaGry(game);

        }
    }
}
