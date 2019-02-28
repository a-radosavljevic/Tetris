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
    public partial class nextFigure : UserControl
    {
        static Label[,] labele;

        private static Shape nextShape;

        public static Shape NextShape
        {
            get { return nextShape; }
            set { nextShape = value; }
        }


        public nextFigure()
        {
            InitializeComponent();
            labele = new Label[6, 6];

            pnlTable.Controls.Clear();
            pnlTable.Width = 6 * 25;
            pnlTable.Height = 6 * 25;

            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 6; j++)
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

            nextShape = new Shape();
            drawShape();
        }

        private static void drawShape()
        {
            Point position = nextShape.CurrentPosition;
            Point[] Shape = nextShape.CurrentShape;
            Color color = nextShape.CurrentColor;

            foreach (Point S in Shape)
            {
                
         labele[(S.X + position.X) + ((6 / 2) - 1), (S.Y + position.Y) + 2].BackColor = color;
                labele[(S.X + position.X) + ((6 / 2) - 1), (S.Y + position.Y) + 2].Text = " ";
            }
        }

        public static void refresh()
        {
            deleteShape();
            nextShape = new Shape();
            drawShape();
        }

        private static void deleteShape()
        {
            Point position = nextShape.CurrentPosition;
            Point[] Shape = nextShape.CurrentShape;
            Color color = nextShape.CurrentColor;

            foreach (Point S in Shape)
            {
                labele[(S.X + position.X) + ((6 / 2) - 1), (S.Y + position.Y) + 2].BackColor = Color.LightGray;
                labele[(S.X + position.X) + ((6 / 2) - 1), (S.Y + position.Y) + 2].Text = "";
            }
        }
    }
}
