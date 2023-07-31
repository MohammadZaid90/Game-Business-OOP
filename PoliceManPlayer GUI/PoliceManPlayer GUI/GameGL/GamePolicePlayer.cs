using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PoliceManPlayer_GUI.GameGL
{
    public class GamePolicePlayer : GameObject
    {
        public GamePolicePlayer(Image image, GameCell startCell) : base(GameObjectType.PLAYER, image)
        {
            this.CurrentCell = startCell;
        }

        public void move(GameCell gameCell)
        {
            CurrentCell = gameCell;
        }

    }
}
