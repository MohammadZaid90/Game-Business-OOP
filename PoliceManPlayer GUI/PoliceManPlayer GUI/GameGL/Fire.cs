using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PoliceManPlayer_GUI.GameGL
{
    public class Fire : GameObject
    {
        GameDirection direction;
        public Fire(Image ghostImage, GameCell startCell, GameDirection D) : base(GameObjectType.FIRE, ghostImage)
        {
            this.CurrentCell = startCell;
            direction = D;
        }

        public void move(GameCell gameCell)
        {
            if (this.CurrentCell != null)
            {
                this.CurrentCell.setGameObject(Game.getBlankGameObject());

            }

            CurrentCell = gameCell;

        }

        public GameCell nextCell()
        {

            GameCell nextCell = this.CurrentCell;

            GameCell potentialNextCell = this.CurrentCell.nextCell(direction);

            if (potentialNextCell == nextCell)
            {
                return nextCell;
            }
            else
            {
                nextCell = potentialNextCell;
            }
            return nextCell;
        }
    }
}
