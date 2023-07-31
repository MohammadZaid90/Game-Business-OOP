using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using EZInput;

namespace PoliceManPlayer_GUI.GameGL
{
    public partial class Maze3Frm : Form
    {
        Game3 game;
        GameCollisionDetector collider;
        GameDirection d = GameDirection.Right;
        public Maze3Frm()
        {
            InitializeComponent();
            game = new Game3(this);
            collider = new GameCollisionDetector();
        }

        private void Maze3Frm_Load(object sender, EventArgs e)
        {
            GameGhostVertical gv1 = new GameGhostVertical(game.getUpDown(), game.getCell(3, 6));
            GameGhostVertical gv11 = new GameGhostVertical(game.getUpDown(), game.getCell(6, 55));

            GameGhostChaser gv2 = new GameGhostChaser(game.getChaser(), game.getCell(1, 12), game.getpolicemanPlayer());
            GameGhostHorizontal gv3 = new GameGhostHorizontal(game.getRightLeft(), game.getCell(10, 15));
            GameGhostHorizontal gv4 = new GameGhostHorizontal(game.getRightLeft(), game.getCell(7, 17));
            GameGhostHorizontal gv5 = new GameGhostHorizontal(game.getRightLeft(), game.getCell(11, 25));
            GameGhostHorizontal gv7 = new GameGhostHorizontal(game.getRightLeft(), game.getCell(14, 20));
            GameGhostHorizontal gv8 = new GameGhostHorizontal(game.getRightLeft(), game.getCell(3, 5));
            GameGhostHorizontal gv9 = new GameGhostHorizontal(game.getRightLeft(), game.getCell(17, 20));
            GameGhostHorizontal gv10 = new GameGhostHorizontal(game.getRightLeft(), game.getCell(17, 31));
            GameGhostChaser gv6 = new GameGhostChaser(game.getChaser(), game.getCell(20, 24), game.getpolicemanPlayer());

            game.addGhost(gv1);
            game.addGhost(gv2);
            game.addGhost(gv3);
            game.addGhost(gv4);
            game.addGhost(gv5);
            game.addGhost(gv6);
            game.addGhost(gv7);
            game.addGhost(gv8);
            game.addGhost(gv9);
            game.addGhost(gv10);
            game.addGhost(gv11);
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
                MessageBox.Show("Congratulations... YOU WIN ALL STAGES !!!");
                this.Hide();
                StartScreenFrm f = new StartScreenFrm();
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
