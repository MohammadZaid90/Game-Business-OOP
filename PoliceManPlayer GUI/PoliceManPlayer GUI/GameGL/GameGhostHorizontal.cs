using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PoliceManPlayer_GUI.GameGL
{
    class GameGhostHorizontal : GameGhost
    {
        GameDirection direction = GameDirection.Left;

        public GameGhostHorizontal(Image ghostImage, GameCell startCell) : base(ghostImage)
        {
            this.CurrentCell = startCell;
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

            if (potentialNextCell == nextCell)
            {
                if (direction == GameDirection.Left)
                {
                    direction = GameDirection.Right;
                }
                else if (direction == GameDirection.Right)
                {
                    direction = GameDirection.Left;
                }
            }
            else
            {
                nextCell = potentialNextCell;
            }
            return nextCell;
        }
    }
}
