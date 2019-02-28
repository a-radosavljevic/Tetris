using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WindowsFormsApplication3
{
    public class Shape
    {
        #region Attributes
        private Point currentPosition;

        public Point CurrentPosition
        {
            get { return currentPosition; }
            set { currentPosition = value; }
        }

        private Point[] currentShape;

        public Point[] CurrentShape
        {
            get { return currentShape; }
            set { currentShape = value; }
        }

        private Color currentColor;

        public Color CurrentColor
        {
            get { return currentColor; }
            set { currentColor = value; }
        }

        private bool isRotatable;

        public bool IsRotatable
        {
            get { return isRotatable; }
            set { isRotatable = value; }
        }
        #endregion

        #region Methods
        public Shape()
        {
            currentPosition = new Point(0, 0);
            currentColor = Color.LightGray;
            currentShape = setRandomShape();
        }

        private Point[] setRandomShape()
        {
            Random rand = new Random();
            switch (rand.Next() % 5)
            {
                case 0:  //   .
                    isRotatable = false;
                    currentColor = Color.Yellow;

                    return new Point[] { new Point(0, 0) };
                case 1:  //  I
                    isRotatable = true;
                    currentColor = Color.Blue;

                    return new Point[] { new Point(0, 0), new Point(-1, 0), new Point(1, 0) };
                case 2: //  +
                    isRotatable = false;
                    currentColor = Color.Purple;

                    return new Point[]{new Point(0,0), new Point(1,0), new Point(-1,0), 
                                        new Point(0,1), new Point(0,-1) };
                case 3:  // []
                    isRotatable = false;
                    currentColor = Color.Green;

                    return new Point[] { new Point(-1, 1), new Point(0, 1), new Point(1, 1),
                                         new Point(-1,0),new Point(0,0),new Point(1,0),
                                         new Point(-1,-1),new Point(0,-1),new Point(1,-1)};
                case 4: // _|_
                    isRotatable = true;
                    currentColor = Color.Red;

                    return new Point[] { new Point(0, 0), new Point(-1, 0), new Point(1, 0), 
                                        new Point(0, 1), };

                default:
                    return null;

            }

        }

        public void moveLeft()
        {
            currentPosition.X -= 1;
        }

        public void moveRight()
        {
            currentPosition.X += 1;
        }

        public void moveDown()
        {
            currentPosition.Y += 1;
        }

        public void rotate()
        {
            if (isRotatable)
            {
                for (int i = 0; i < currentShape.Length; i++)
                {
                    int x = currentShape[i].X;
                    currentShape[i].X = currentShape[i].Y * -1;
                    currentShape[i].Y = x;
                }
            }
        }
        #endregion
    }
}
