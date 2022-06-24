using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Start : Form
    {
        //#######################################---ZMIENNE---##########################################
        //***-Game-***
        private bool gameOver = false;
        private bool isHereGoodPlaceToPutFood = true;
        //***-Snake-***
        private int snakeHeadPositionX = 175;
        private int snakeHeadPositionY = 200;
        private int snakeStep = 25;
        private bool stepDown = false;
        private bool stepUp = false;
        private bool stepRight = false;
        private bool stepLeft = false;
        private int snakePoints = 0;
        //***-Board-***
        private int BoardPositionX = 100;
        private int BoardPositionY = 100;
        //***-Food-***
        private int foodPositionX;
        private int foodPositionY;
        //#######################################---TABLICE & LISTY---##########################################
        List<SnakePosition> snakePositionsList = new List<SnakePosition>();
        //#######################################---WŁAŚĆIWOŚCI---######################################
        public bool GameOver { get { return gameOver; } set { gameOver = value; } }
        //#######################################---KONSTRUKTORY---#####################################
        public Start()
        {
            InitializeComponent();
            newPositionOfFood();
        }
        //#######################################---RYSUJ---############################################
        private void drawBoard()  // Rysuj plansze
        {
            if (gameOver == false)
            {
                System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.LightSeaGreen);
                System.Drawing.Graphics formGraphics;
                formGraphics = this.CreateGraphics();
                formGraphics.FillRectangle(myBrush, new Rectangle(BoardPositionX, BoardPositionY, 250, 250));
                myBrush.Dispose();
                formGraphics.Dispose();
            }
        }
        private void drawFood()   // Rysuj jedzenie
        {
            if (gameOver == false)
            {
                isHereGoodPlaceToPutFood = true;
                System.Drawing.SolidBrush myFoodBrush = new System.Drawing.SolidBrush(System.Drawing.Color.OrangeRed);
                System.Drawing.Graphics formGraphics;
                formGraphics = this.CreateGraphics();
                foreach (SnakePosition snakePosition in snakePositionsList)  // Sprawdz czy w tym miejscu nie znajduje się wąż.
                {
                    if (snakePosition.PosX == RealfoodPositionX() && snakePosition.PosY == RealfoodPositionY())
                    {
                        isHereGoodPlaceToPutFood = false;
                        break;
                    }
                }
                if (isHereGoodPlaceToPutFood == false) //Jeśli się znajduje losuj jeszcze raz.
                {
                    newPositionOfFood();
                    drawFood();
                }
                formGraphics.FillRectangle(myFoodBrush, new Rectangle(RealfoodPositionX(), RealfoodPositionY(), 25, 25));
                myFoodBrush.Dispose();
                formGraphics.Dispose();
            }
        }
        private void drawSnake(int x, int y) // Rysuj element węża
        {
            if (gameOver == false)
            {
                System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.BlueViolet);
                System.Drawing.Graphics formGraphics;
                formGraphics = this.CreateGraphics();
                formGraphics.FillRectangle(myBrush, new Rectangle(x, y, 25, 25));
                myBrush.Dispose();
                formGraphics.Dispose();
            }
        }
        //#########---RYSUJ CAŁEGO WĘŻA NA PLANSZY---#############
        private void printSnakeOnBoard()
        {
            if (gameOver == false)
            {
                for (int i = 0; i < snakePositionsList.Count; i++)
                {
                    drawSnake(snakePositionsList[i].PosX, snakePositionsList[i].PosY);
                }

            }
        }
        //#######################################---FUNCKJE---##########################################
        //#############--POZYCJA JEDZENIA--################
        public int RealfoodPositionX()
        {
            return foodPositionX * snakeStep + BoardPositionX;
        }
        public int RealfoodPositionY()
        {
            return foodPositionY * snakeStep + BoardPositionY;
        }

        public void newPositionOfFood()
        {
            foodPositionX = drawFoodPosition();
            foodPositionY = drawFoodPosition();
        }
        //##############==USTAW JEDZENIE==#################
        public int drawFoodPosition()
        {
            Random rnd = new Random();
            return rnd.Next(0, 10);

        }
        //###########--CZY ZJADŁEM JEDZENIE?--#############
        public bool haveIEatenTheFood()
        {
            if (snakeHeadPositionX == RealfoodPositionX() && snakeHeadPositionY == RealfoodPositionY())
            {
                newPositionOfFood();
                AddNewPartOfASnake();
                return true;
            }
            else
            {
                return false;
            }
        }
        //#########--PORUSZANIE POSTACIĄ WĘŻA--############
        public void changeSnakePosition()
        {
            snakePositionsList.Insert(0, new SnakePosition(snakeHeadPositionX, snakeHeadPositionY)); // Wrzuć nową cześć weża na początek listy Tak by głowa była zawsze pod indexem 0, a kolejne elementy przesuwały sie do tyłu.

            if (stepDown == true)
            {
                if (snakeHeadPositionY == 100) // Jesli wyjdzie powyżej planszy
                {
                    snakeHeadPositionY = 325;
                }
                else
                {
                    snakeHeadPositionY -= snakeStep;
                }
                drawSnake(snakeHeadPositionX, snakeHeadPositionY);
                haveIEatenTheFood();
            }
            else if (stepUp == true)
            {
                if (snakeHeadPositionY == 325) //jeśli zejdzie poniżej planszy.
                {
                    snakeHeadPositionY = 100;
                }
                else
                {
                    snakeHeadPositionY += snakeStep;
                }
                drawSnake(snakeHeadPositionX, snakeHeadPositionY);
                haveIEatenTheFood();
            }
            else if (stepRight == true) // Jesli wyjdzie w prawo poza plansze.
            {
                if (snakeHeadPositionX == 325)
                {
                    snakeHeadPositionX = 100;
                }
                else
                {
                    snakeHeadPositionX += snakeStep;
                }
                drawSnake(snakeHeadPositionX, snakeHeadPositionY);
                haveIEatenTheFood();
            }
            else if (stepLeft == true)
            {
                if (snakeHeadPositionX == 100) // Jeśli wyjdzie w lewo poza plansze.
                {
                    snakeHeadPositionX = 325;
                }
                else
                {
                    snakeHeadPositionX -= snakeStep;
                }
                drawSnake(snakeHeadPositionX, snakeHeadPositionY);
                haveIEatenTheFood();
            }
            /*          Console.WriteLine(snakePositionsList.Count); <- Testy
                        Console.WriteLine();
                        Console.WriteLine(snakePoints);*/
            if (snakePositionsList.Count > snakePoints) // Jesli dłgosć cześći węża jest wieksza niż ilość punktów które pozwalają mu rosnąć.
            {
                snakePositionsList.RemoveAt(snakePositionsList.Count - 1); // ciachaj ogon.
            }
            drawBoard(); //       <-  Za każdym  ruchem pomaluj plansze od nowa.
            drawFood();  //<-   -||-
            drawSnake(snakeHeadPositionX, snakeHeadPositionY); //<-   -||-
            printSnakeOnBoard();  //<-   -||-
            isSnakeHeadHeatTheBody();
        }

        //#####--ZDARZENIA _CLICK PORUSZAJĄCE WĘŻEM--######
        private void goDown_Click(object sender, EventArgs e)
        {
            stepDown = true;
            changeSnakePosition();
            stepDown = false;

        }
        private void goLeft_Click(object sender, EventArgs e)
        {
            stepLeft = true;
            changeSnakePosition();
            stepLeft = false;
        }
        private void goRight_Click(object sender, EventArgs e)
        {
            stepRight = true;
            changeSnakePosition();
            stepRight = false;
        }
        private void goUp_Click(object sender, EventArgs e)
        {
            stepUp = true;
            changeSnakePosition();
            stepUp = false;
        }
        //#########---POWIEKSZANIE WĘŻA---#################

        private void AddNewPartOfASnake() // Doda nową cześć do weża, gdy wąż wejdzie w jedzenie.
        {
            snakePoints += 1;
        }

        //###################---URUCHAMIANIE GRY---#####################
        private void letsStart_Click(object sender, EventArgs e)
        {
            snakeHeadPositionX = 175;
            snakeHeadPositionY = 200;
            snakePoints = 0;
            gameOver = false;
            snakePositionsList.Clear();
            wDol.Visible = true;
            wLewo.Visible = true;
            wprawo.Visible = true;
            doGory.Visible = true;
            letsStart.Visible = false;
            TytulGry.Visible = false;
            Tytul2.Visible = false;
            TytulGry3.Visible = true;
            TytulGry4.Visible = true;
            Przegrales.Visible = false;
            drawBoard();

            drawSnake(snakeHeadPositionX, snakeHeadPositionY);
            drawFood();
        }
        //#####--SPRAWDZ CZY UDERZYŁEŚ W CIAŁO WĘŻA--######
        private void isSnakeHeadHeatTheBody()
        {
            for (int i = 1; i < snakePositionsList.Count; i++)
            {
                if (snakePositionsList[i].PosX == snakeHeadPositionX && snakePositionsList[i].PosY == snakeHeadPositionY)
                {
                    gameOver = true;
                    break;
                }
            }
            if (gameOver == true)
            {

                wDol.Visible = false;
                wLewo.Visible = false;
                wprawo.Visible = false;
                doGory.Visible = false;
                Przegrales.Visible = true;
                letsStart.Visible = true;
                
            }
        }
    }
}
