using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace PoliceManPlayer_GUI.GameGL
{
    public class Game2
    {
        GamePolicePlayer policeman;
        GameGrid grid;
        public List<GameGhost> ghosts;
        int score = 0;
        int health = 100;
        List<Fire> Bullets = new List<Fire>();
        Form gameGUI;

        public List<Fire> Bullets1 { get => Bullets; set => Bullets = value; }
        public int Health { get => health; set => health = value; }

        public Game2(Form gameGUI)
        {
            this.gameGUI = gameGUI;
            grid = new GameGrid("Maze2.txt", 24, 70);
            Image policemanImage = Game.getGameObjectImage('P');
            ghosts = new List<GameGhost>();
            GameCell startCell = grid.getCell(8, 10);
            policeman = new GamePolicePlayer(policemanImage, startCell);
            printMaze(grid);

        }
        public void ProduceBullet(GameCell gameCell, GameDirection D)
        {
            if (gameCell.CurrentGameObject.GameObjectType == GameObjectType.NONE)
            {
                Fire f = new Fire(Properties.Resources.bullet, gameCell, D);
                addBullet(f);
            }
        }
        public GameCell getCell(int x, int y)
        {
            return grid.getCell(x, y);
        }
        public void addBullet(Fire F)
        {
            Bullets1.Add(F);
        }
        public void addGhost(GameGhost ghost)
        {
            ghosts.Add(ghost);
        }
        public void RemoveGhost(GameGhost ghost)
        {
            ghosts.Remove(ghost);
        }
        public GamePolicePlayer getpolicemanPlayer()
        {
            return policeman;
        }
        public void addScorePoints(int points)
        {
            this.score = score + points;
        }
        public void DecreaseHealth(int points)
        {

            this.Health = Health + points;


        }
        public int getScore()
        {
            return score;
        }
        void printMaze(GameGrid grid)
        {
            for (int x = 0; x < grid.Rows; x++)
            {

                for (int y = 0; y < grid.Cols; y++)
                {
                    GameCell cell = grid.getCell(x, y);
                    gameGUI.Controls.Add(cell.PictureBox);

                }

            }
        }

        public static GameObject getBlankGameObject()
        {
            GameObject blankGameObject = new GameObject(GameObjectType.NONE, Properties.Resources.simplebox);
            return blankGameObject;
        }
        public Image getUpDown()
        {
            return Properties.Resources.upDownThief;
        }

        public Image getRightLeft()
        {
            return Properties.Resources.thief;
        }
        public Image getChaser()
        {
            return Properties.Resources.smart;
        }

        public static Image getGameObjectImage(char displayCharacter)
        {

            Image img = Properties.Resources.simplebox;


            if (displayCharacter == '|')
            {
                img = Properties.Resources.bricks;
            }

            if (displayCharacter == '#')
            {
                img = Properties.Resources.grass;
            }

            if (displayCharacter == '%')
            {
                img = Properties.Resources.zamin1;
            }

            if (displayCharacter == '.')
            {
                img = Properties.Resources.pallet;
            }
            if (displayCharacter == 'P' || displayCharacter == 'p')
            {
                img = Properties.Resources.pngegg__1_;
            }

            return img;
        }
    }
}
