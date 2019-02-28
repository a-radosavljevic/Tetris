using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Tetris : UserControl
    {
        #region Attributes
        Label[,] labele;
        
        private Shape currentShape;

        public Shape CurrentShape
        {
            get { return currentShape; }
            set { currentShape = value; }
        }

        private static int dimX = 20;

        public static int DimX
        {
            get { return dimX; }
            set { dimX = value; }
        }
        private static int dimY = 20;

        public static int DimY
        {
            get { return dimY; }
            set { dimY = value; }
        }

        private int points;

        public int Points
        {
            get { return points; }
            set { points = value; }
        }
        #endregion

        #region Constructors
        public Tetris()
        {
            points = 0;

            InitializeComponent();
            createTable();

            //currentShape = new Shape();
            currentShape = nextFigure.NextShape;
            drawShape();
            
        }

        public Tetris(int x, int y)
        {
            dimX = x;
            dimY = y;
            InitializeComponent();
            createTable();
			
			currentShape = new Shape();
            drawShape();
        }
        #endregion

        private void createTable()
        {
            labele = new Label[dimX, dimY];

            pnlTable.Controls.Clear();
            pnlTable.Width = dimY * 25;
            pnlTable.Height = dimX * 25;

            for (int i = 0; i < dimX; i++)
                for (int j = 0; j < dimY; j++)
                {
                    Label l = new Label()
                    {
                        AutoSize = false,
                        Width = 25,
                        Height = 25,
                        BackColor = Color.LightGray,
                        Name = i.ToString() + " " + j.ToString(),
                        Text = "",
                        Left = j * 25,
                        Top = i * 25,
                        BorderStyle = BorderStyle.Fixed3D
                    };
                    pnlTable.Controls.Add(l);
                    labele[j, i] = l;
                }
        }

        private void CheckRows()
        {
            bool full;

            for (int i = dimY - 1; i > 0; i--)
            {
                full = true;
                for (int j = 0; j < dimX; j++)
                {
                    if (labele[j, i].Text == "")////////////////////////////////////////////////////
                    {
                        full = false;
                        break;
                    }
                }
                if (full)
                {
                    RemoveRow(i);
                    points += 1;
                }
            }

        }

        private void RemoveRow(int row)
        {
            for (int i = dimY-1; i > 2; i--)
            {
                for (int j = 0; j < dimX; j++)
                {
                    labele[j, i].BackColor = labele[j, i-1].BackColor;////////////////////////////////////////////////
                    labele[j, i].Text = labele[j, i-1].Text;
                }


            }

        }

        internal void moveShapeDown()
        {
            Point position = currentShape.CurrentPosition;
            Point[] Shape = currentShape.CurrentShape;
            bool move = true;
            deleteShape();
            foreach (Point S in Shape)
            {
                if (((S.Y + position.Y) + 2 + 1) >= dimY)
                {
                    move = false;
                }
                else if (labele[((S.X + position.X) + ((dimX / 2) - 1)), (S.Y + position.Y) + 2 + 1].BackColor != Color.LightGray)
                {
                    move = false;
                }

            }
            if (move)
            {
                currentShape.moveDown();
                drawShape();
            }
            else
            {
                drawShape();
                CheckRows();


                currentShape = nextFigure.NextShape;
                //currentShape = new Shape();
                nextFigure.refresh();
            }
        }

        internal void rotateShape()
        {
            Point position = currentShape.CurrentPosition;
            Point[] Shape = currentShape.CurrentShape;
            Point[] S = new Point[9];
            bool move = true;

            Shape.CopyTo(S, 0);

            deleteShape();

            for (int i = 0; i < S.Length; i++)
            {
                int x = S[i].X;
                S[i].X = S[i].Y * -1;
                S[i].Y = x;

                if (((S[i].Y + position.Y) + 2 >= dimY))
                {
                    move = false;
                }
                else if ((S[i].X + position.X) + ((dimX / 2) - 1) < 0)
                {
                    move = false;
                }
                else if ((S[i].X + position.X) + ((dimX / 2) - 1) > dimY)
                {
                    move = false;
                }
                else if (labele[(S[i].X + position.X) + ((dimX / 2) - 1), (S[i].Y + position.Y) + 2].BackColor != Color.LightGray)
                {
                    move = false;
                }
            }
            if (move)
            {
                currentShape.rotate();
                drawShape();
            }
            else
            {
                drawShape();
            }
        }

        internal void moveShapeRight()
        {
            Point position = currentShape.CurrentPosition;
            Point[] Shape = currentShape.CurrentShape;
            bool move = true;
            deleteShape();
            foreach (Point S in Shape)
            {
                if (((S.X + position.X) + ((dimX / 2) - 1) + 1) >= dimX)
                {
                    move = false;
                }
                else if (labele[((S.X + position.X) + ((dimX / 2) - 1) + 1), (S.Y + position.Y) + 2].BackColor != Color.LightGray)
                {
                    move = false;
                }

            }
            if (move)
            {
                currentShape.moveRight();
                drawShape();
            }
            else { drawShape(); }
        }

        internal void moveShapeLeft()
        {
            Point position = currentShape.CurrentPosition;
            Point[] Shape = currentShape.CurrentShape;
            bool move = true;
            deleteShape();
            foreach (Point S in Shape)
            {
                if (((S.X + position.X) + ((dimX / 2) - 1) - 1) < 0)
                {
                    move = false;
                }
                else if (labele[((S.X + position.X) + ((dimX / 2) - 1) - 1), (S.Y + position.Y) + 2].BackColor != Color.LightGray)
                {
                    move = false;
                }

            }
            if (move)
            {
                currentShape.moveLeft();
                drawShape();
            }
            else { drawShape(); }
        }

        private void deleteShape()
        {
            Point position = currentShape.CurrentPosition;
            Point[] Shape = currentShape.CurrentShape;
            Color color = currentShape.CurrentColor;

            foreach (Point S in Shape)
            {
                labele[(S.X + position.X) + ((dimX / 2) - 1), (S.Y + position.Y) + 2].BackColor = Color.LightGray;
                labele[(S.X + position.X) + ((dimX / 2) - 1), (S.Y + position.Y) + 2].Text = "";
            }
        }

        private void drawShape()
        {
            Point position = currentShape.CurrentPosition;
            Point[] Shape = currentShape.CurrentShape;
            Color color = currentShape.CurrentColor;

            foreach (Point S in Shape)
            {
                labele[(S.X + position.X) + ((dimX / 2) - 1), (S.Y + position.Y) + 2].BackColor = color;
                labele[(S.X + position.X) + ((dimX / 2) - 1), (S.Y + position.Y) + 2].Text = " ";
            }
        }

        private void Tetris_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up) || e.KeyCode.Equals(Keys.W))
                this.rotateShape();
            else if (e.KeyCode.Equals(Keys.Down) || e.KeyCode.Equals(Keys.S))
                this.moveShapeDown();
            else if (e.KeyCode.Equals(Keys.Right) || e.KeyCode.Equals(Keys.D))
                this.moveShapeRight();
            else if (e.KeyCode.Equals(Keys.Left) || e.KeyCode.Equals(Keys.A))
                this.moveShapeLeft();
            else return;
        }
    }
}
