using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PoliceManPlayer_GUI.GameGL
{
    public class GameGhostChaser : GameGhost
    {
        GameDirection direction = GameDirection.Left;
        GameObject Object;
        public GameGhostChaser(Image ghostImage, GameCell startCell, GameObject @object) : base(ghostImage)
        {
            this.CurrentCell = startCell;
            Object = @object;
        }

        public override void move(GameCell gameCell)
        {
            if (this.CurrentCell != null)
            {
                this.CurrentCell.setGameObject(Game.getBlankGameObject());

            }
            CurrentCell = gameCell;
        }

        public override GameCell nextCell()
        {

            GameCell nextCell = this.CurrentCell;

            GameCell potentialNextCell = this.CurrentCell.nextCell(direction);

            SetDirection();
            if (potentialNextCell != null)
            {

                nextCell = potentialNextCell;
            }
            return nextCell;
        }
        public void SetDirection()
        {
            double[] distancebf = new double[4] { 100000, 100000, 100000, 100000 };
            distancebf[0] = calculatedistancebf(Object.CurrentCell, CurrentCell.nextCell(GameDirection.Up));
            distancebf[1] = calculatedistancebf(Object.CurrentCell, CurrentCell.nextCell(GameDirection.Down));
            distancebf[2] = calculatedistancebf(Object.CurrentCell, CurrentCell.nextCell(GameDirection.Right));
            distancebf[3] = calculatedistancebf(Object.CurrentCell, CurrentCell.nextCell(GameDirection.Left));
            if (distancebf[0] == distancebf.Min())
            {
                direction = GameDirection.Up;
            }
            else if (distancebf[1] == distancebf.Min())
            {
                direction = GameDirection.Down;
            }
            else if (distancebf[2] == distancebf.Min())
            {
                direction = GameDirection.Right;
            }
            else if (distancebf[3] == distancebf.Min())
            {
                direction = GameDirection.Left;
            }
        }
        public double calculatedistancebf(GameCell cell1, GameCell cell2)
        {
            if (cell2 == null) { return 10000000; }
            return Math.Sqrt(Math.Pow(cell1.Y - cell2.Y, 2) + Math.Pow(cell1.X - cell2.X, 2));
        }
    }
}
