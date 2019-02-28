using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Player;

namespace WindowsFormsApplication3
{
    public partial class Main : Form
    {
        int time;
        playerList p;
        string name;
        string surname;
        bool gameStarted = false;
        private static int timerInterval=1000;

        public static int TimerInterval
        {
            get { return timerInterval; }
            set { timerInterval = value; }
        }
        

        public Main()
        {
            time = 0;
            InitializeComponent();
            p = new playerList();
            timer.Start();
            this.Focus();
            lblPlayer.Text = "UNKNOWN";

            this.name = "UNKNOWN";
            this.surname = "UNKNOWN";

            tetris1.TabIndex = 0;

            //lblPoints.Text = "0";
            setHighScore();
            gameStarted = true;

        }

        public Main(string name, string surname)
        {
            time = 0;
            InitializeComponent();
            //t = new Tetris();
            p = new playerList();
            timer.Start();
            this.Focus();
            lblPlayer.Text = name + " " + surname;

            this.name = name;
            this.surname = surname;

            tetris1.TabIndex = 0;
            //lblPoints.Text = "0";
            setHighScore();
            gameStarted = true;

        }

        private void setHighScore()
        {
            //lbxLista.DataSource = ListaOsoba.Lista.Osobe.ToList();
            listBox1.DataSource = playerList.List.Players.ToList();

            if (listBox1.Items.Count > 0)
                label4.Text = playerList.List.Players[0].Points.ToString();
            else
                label4.Text = "0";
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                this.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            time++;
            lblTime.Text = time + "s";
            this.tetris1.moveShapeDown();
            //nextFigure1.Refresh();

            lblPoints.Text = this.tetris1.Points.ToString();
        }

        //private void moveDown()
        //{
        //    throw new NotImplementedException();
        //}

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (timer.Enabled == true)
            {
                timer.Stop();
                btnStart.Text = "START";
            }
            else
            {
                timer.Start();
                btnStart.Text = "PAUSE";
            }
        }

        private void customizeTetrisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gameStarted == true && DialogResult.No == MessageBox.Show("This action will finish current game. Continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                return;
            timer.Stop();
            FormCustomize f2 = new FormCustomize();
            if (DialogResult.OK == f2.ShowDialog())
            {
                timer.Interval = TimerInterval;
                gameOver();
            }
            else
                timer.Start();
        }

        private void gameOver()
        {
            timer.Stop();
            Player.Player player = new Player.Player()
            {
                Name = name,
                Surname = surname,
                Points = int.Parse(lblPoints.Text),
                Date = DateTime.Now
            };
            playerList.List.add(player);
            btnExit.PerformClick();
        }

        private void startNewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameOver();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            gameOver();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();

            if (s.ShowDialog() == DialogResult.OK)
                p.save(s.FileName);
        }
        
    }
}
