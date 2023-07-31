using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceManPlayer_GUI.GameGL
{
    class GameCollisionDetector
    {
        public bool isGhostCollideWithpoliceman(GameGhost ghost)
        {
            bool flag = false;
            if (ghost is GameGhostVertical)
            {
                GameCell Cell = ghost.nextCell();
                if (Cell.CurrentGameObject.GameObjectType == GameObjectType.PLAYER)
                {
                    flag = true;
                    return flag;
                }
            }
            if (ghost is GameGhostHorizontal)
            {
                GameCell Cell = ghost.nextCell();
                if (Cell.CurrentGameObject.GameObjectType == GameObjectType.PLAYER)
                {
                    flag = true;
                    return flag;
                }
            }
            if (ghost is GameGhostChaser)
            {
                GameCell Cell = ghost.nextCell();
                if (Cell.CurrentGameObject.GameObjectType == GameObjectType.PLAYER)
                {
                    flag = true;
                    return flag;
                }
            }
            return flag;
        }
        public GameGhost isBulletCollideWithGhost(Fire fire)
        {
            GameCell Cell = fire.nextCell();
            if (Cell.CurrentGameObject.GameObjectType == GameObjectType.ENEMY)
            {
                return Cell.CurrentGameObject as GameGhost;
            }
            return null;
        }

        public bool ispolicemanCollideWithPallet(GameCell potentialCell, GameDirection direction)
        {
            bool flag = false;
            GameCell gameCell = potentialCell.nextCell(direction);
            if (gameCell.CurrentGameObject.GameObjectType == GameObjectType.REWARD)
            {
                flag = true;

            }
            return flag;
        }

    }
}
