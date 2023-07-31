using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PoliceManPlayer_GUI.GameGL;
using System.Threading;
using EZInput;

namespace PoliceManPlayer_GUI
{
    public partial class Maze1Frm : Form
    {
        Game game;
        GameCollisionDetector collider;
        GameDirection d = GameDirection.Right;
        public Maze1Frm()
        {
            InitializeComponent();
            game = new Game(this);
            collider = new GameCollisionDetector();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GameGhostVertical gv1 = new GameGhostVertical(game.getUpDown(), game.getCell(3, 6));

            GameGhostChaser gv2 = new GameGhostChaser(game.getChaser(), game.getCell(3, 22), game.getpolicemanPlayer());
            GameGhostHorizontal gv3 = new GameGhostHorizontal(game.getRightLeft(), game.getCell(8, 41));
            GameGhostHorizontal gv4 = new GameGhostHorizontal(game.getRightLeft(), game.getCell(12, 48));
            GameGhostHorizontal gv5 = new GameGhostHorizontal(game.getRightLeft(), game.getCell(3, 53));
            GameGhostChaser gv6 = new GameGhostChaser(game.getChaser(), game.getCell(19, 53), game.getpolicemanPlayer());

            game.addGhost(gv1);
            game.addGhost(gv2);
            game.addGhost(gv3);
            game.addGhost(gv4);
            game.addGhost(gv5);
            game.addGhost(gv6);
        }

        public void moveGhosts()
        {
            foreach (GameGhost g in game.ghosts)
            {
                if (collider.isGhostCollideWithpoliceman(g))
                {
                    game.DecreaseHealth(-1);
                }
                g.move(g.nextCell());
            }
        }

        public void moveBullets()
        {
            for (int i = 0; i < game.Bullets1.Count; i++)
            {
                if (collider.isBulletCollideWithGhost(game.Bullets1[i]) != null)
                {
                    game.RemoveGhost(collider.isBulletCollideWithGhost(game.Bullets1[i]));

                }
                game.Bullets1[i].move(game.Bullets1[i].nextCell());
            }
        }

        public void RemoveBullets()
        {
            for (int i = 0; i < game.Bullets1.Count; i++)
            {
                if (game.Bullets1[i].nextCell() == game.Bullets1[i].CurrentCell)
                {
                    game.Bullets1[i].Image = Properties.Resources.simplebox;
                }
            }
        }

        public void GhostProduceBullet()
        {
            if (game.ghosts[1].CurrentCell.X == game.getpolicemanPlayer().CurrentCell.X)
            {
                game.ProduceBullet(game.ghosts[1].CurrentCell.nextCell(d), d);
            }
        }

        private void showScore()
        {

            lblScoreValue.Text = game.getScore().ToString();
            if (int.Parse(lblScoreValue.Text) == 3)
            {
                timer1.Stop();
                timer2.Stop();
                MessageBox.Show("YOU WIN... NEXT STAGE !!!");
                this.Hide();
                Maze2Frm f = new Maze2Frm();
                f.Show();
            }
        }

        private void showHealth()
        {

            label1.Text = game.Health.ToString();
            if (int.Parse(label1.Text) <= 0)
            {
                timer1.Stop();
                timer2.Stop();
                MessageBox.Show("YOU LOOSE...  GAME IS ENDED !!!");
                Thread.Sleep(1000);
                this.Hide();
                StartScreenFrm f = new StartScreenFrm();
                f.Show();
            }

        }

        private void movepoliceman()
        {
            GamePolicePlayer policeman = game.getpolicemanPlayer();
            GameCell potentialNewCell = policeman.CurrentCell;

            if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                potentialNewCell = policeman.CurrentCell.nextCell(GameDirection.Left);
                d = GameDirection.Left;
                if (collider.ispolicemanCollideWithPallet(potentialNewCell, GameDirection.Left))
                {
                    game.addScorePoints(1);
                }
            }
            if (Keyboard.IsKeyPressed(Key.RightArrow))
            {
                potentialNewCell = policeman.CurrentCell.nextCell(GameDirection.Right);
                if (collider.ispolicemanCollideWithPallet(potentialNewCell, GameDirection.Right))
                {
                    game.addScorePoints(1);
                }
                d = GameDirection.Right;
            }
            if (Keyboard.IsKeyPressed(Key.UpArrow))
            {
                potentialNewCell = policeman.CurrentCell.nextCell(GameDirection.Up);
                if (collider.ispolicemanCollideWithPallet(potentialNewCell, GameDirection.Up))
                {
                    game.addScorePoints(1);
                }
            }
            if (Keyboard.IsKeyPressed(Key.DownArrow))
            {
                potentialNewCell = policeman.CurrentCell.nextCell(GameDirection.Down);
                if (collider.ispolicemanCollideWithPallet(potentialNewCell, GameDirection.Down))
                {
                    game.addScorePoints(1);
                }
            }
            if (Keyboard.IsKeyPressed(Key.Space))
            {
                game.ProduceBullet(policeman.CurrentCell.nextCell(d), d);
            }


            GameCell currentCell = policeman.CurrentCell;
            currentCell.setGameObject(Game.getBlankGameObject());

            policeman.move(potentialNewCell);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            movepoliceman();
            showScore();
            showHealth();
            GhostProduceBullet();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            moveGhosts();
            RemoveBullets();
            moveBullets();
        }
    }
}
