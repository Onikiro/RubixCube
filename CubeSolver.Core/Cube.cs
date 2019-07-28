using System;
using System.Collections;

namespace RubixCubes.Core
{
    public class Cube
    {
        public Side Green { get; } = new Side(Color.Green);
        public Side Red { get; } = new Side(Color.Red);
        public Side White { get; } = new Side(Color.White);
        public Side Blue { get; } = new Side(Color.Blue);
        public Side Yellow { get; } = new Side(Color.Yellow);
        public Side Orange { get; } = new Side(Color.Orange);

        public void Rotate(Turn turn, bool clockwise, int count)
        {
            for (int i = 0; i < count; i++)
            {
                var whiteCopy = White.Copy();
                var redCopy = Red.Copy();
                var orangeCopy = Orange.Copy();
                var yellowCopy = Yellow.Copy();
                var blueCopy = Blue.Copy();

                switch (turn)
                {
                    case Turn.Left:
                        if (clockwise)
                        {
                            White[0, 0] = redCopy[0, 0];
                            White[1, 0] = redCopy[1, 0];
                            White[2, 0] = redCopy[2, 0];

                            Orange[0, 2] = whiteCopy[0, 0];
                            Orange[1, 2] = whiteCopy[1, 0];
                            Orange[2, 2] = whiteCopy[2, 0];

                            Yellow[0, 0] = orangeCopy[0, 2];
                            Yellow[1, 0] = orangeCopy[1, 2];
                            Yellow[2, 0] = orangeCopy[2, 2];

                            Red[0, 0] = yellowCopy[0, 0];
                            Red[1, 0] = yellowCopy[1, 0];
                            Red[2, 0] = yellowCopy[2, 0];

                            Blue[0, 0] = blueCopy[0, 2];
                            Blue[0, 1] = blueCopy[1, 2];
                            Blue[0, 2] = blueCopy[2, 2];

                            Blue[1, 2] = blueCopy[2, 1];
                            Blue[2, 2] = blueCopy[2, 0];

                            Blue[2, 1] = blueCopy[1, 0];
                            Blue[2, 0] = blueCopy[0, 0];
                        }
                        else
                        {
                            Yellow[0, 0] = redCopy[0, 0];
                            Yellow[1, 0] = redCopy[1, 0];
                            Yellow[2, 0] = redCopy[2, 0];

                            Orange[0, 2] = yellowCopy[0, 0];
                            Orange[1, 2] = yellowCopy[1, 0];
                            Orange[2, 2] = yellowCopy[2, 0];

                            White[0, 0] = orangeCopy[0, 2];
                            White[1, 0] = orangeCopy[1, 2];
                            White[2, 0] = orangeCopy[2, 2];

                            Red[0, 0] = whiteCopy[0, 0];
                            Red[1, 0] = whiteCopy[1, 0];
                            Red[2, 0] = whiteCopy[2, 0];

                            Blue[0, 0] = blueCopy[0, 2];
                            Blue[0, 1] = blueCopy[1, 2];
                            Blue[0, 2] = blueCopy[2, 2];

                            Blue[1, 2] = blueCopy[2, 1];
                            Blue[2, 2] = blueCopy[2, 0];

                            Blue[2, 1] = blueCopy[1, 0];
                            Blue[2, 0] = blueCopy[0, 0];
                        }

                        break;

                    case Turn.Right:
                        if (clockwise)
                        {
                            White[0, 2] = Color.Red;
                            White[1, 2] = Color.Red;
                            White[2, 2] = Color.Red;

                            Orange[0, 0] = Color.White;
                            Orange[1, 0] = Color.White;
                            Orange[2, 0] = Color.White;

                            Yellow[0, 2] = Color.Orange;
                            Yellow[1, 2] = Color.Orange;
                            Yellow[2, 2] = Color.Orange;

                            Red[0, 2] = Color.Yellow;
                            Red[1, 2] = Color.Yellow;
                            Red[2, 2] = Color.Yellow;
                        }
                        else
                        {
                            Yellow[0, 2] = Color.Red;
                            Yellow[1, 2] = Color.Red;
                            Yellow[2, 2] = Color.Red;

                            Orange[0, 0] = Color.Yellow;
                            Orange[1, 0] = Color.Yellow;
                            Orange[2, 0] = Color.Yellow;

                            White[0, 2] = Color.Orange;
                            White[1, 2] = Color.Orange;
                            White[2, 2] = Color.Orange;

                            Red[0, 2] = Color.White;
                            Red[1, 2] = Color.White;
                            Red[2, 2] = Color.White;
                        }

                        break;
                    case Turn.Up:
                        if (clockwise)
                        {
                            Blue[0, 0] = Color.Red;
                            Blue[0, 1] = Color.Red;
                            Blue[0, 2] = Color.Red;

                            Orange[0, 0] = Color.Blue;
                            Orange[0, 1] = Color.Blue;
                            Orange[0, 2] = Color.Blue;

                            Green[0, 0] = Color.Orange;
                            Green[0, 1] = Color.Orange;
                            Green[0, 2] = Color.Orange;

                            Red[0, 0] = Color.Green;
                            Red[0, 1] = Color.Green;
                            Red[0, 2] = Color.Green;
                        }
                        else
                        {
                            Blue[0, 0] = Color.Orange;
                            Blue[0, 1] = Color.Orange;
                            Blue[0, 2] = Color.Orange;

                            Red[0, 0] = Color.Blue;
                            Red[0, 1] = Color.Blue;
                            Red[0, 2] = Color.Blue;

                            Green[0, 0] = Color.Red;
                            Green[0, 1] = Color.Red;
                            Green[0, 2] = Color.Red;

                            Orange[0, 0] = Color.Green;
                            Orange[0, 1] = Color.Green;
                            Orange[0, 2] = Color.Green;
                        }

                        break;
                    case Turn.Down:
                        if (clockwise)
                        {
                            Blue[2, 0] = Color.Red;
                            Blue[2, 1] = Color.Red;
                            Blue[2, 2] = Color.Red;

                            Orange[2, 0] = Color.Blue;
                            Orange[2, 1] = Color.Blue;
                            Orange[2, 2] = Color.Blue;

                            Green[2, 0] = Color.Orange;
                            Green[2, 1] = Color.Orange;
                            Green[2, 2] = Color.Orange;

                            Red[2, 0] = Color.Green;
                            Red[2, 1] = Color.Green;
                            Red[2, 2] = Color.Green;
                        }
                        else
                        {
                            Blue[2, 0] = Color.Orange;
                            Blue[2, 1] = Color.Orange;
                            Blue[2, 2] = Color.Orange;

                            Red[2, 0] = Color.Blue;
                            Red[2, 1] = Color.Blue;
                            Red[2, 2] = Color.Blue;

                            Green[2, 0] = Color.Red;
                            Green[2, 1] = Color.Red;
                            Green[2, 2] = Color.Red;

                            Orange[2, 0] = Color.Green;
                            Orange[2, 1] = Color.Green;
                            Orange[2, 2] = Color.Green;
                        }

                        break;
                    case Turn.Front:
                        if (clockwise)
                        {

                        }
                        else
                        {

                        }

                        break;
                    case Turn.Back:
                        if (clockwise)
                        {

                        }
                        else
                        {

                        }

                        break;
                }
            }
        }
    }

    public class Side : IEnumerable
    {
        private readonly Color _color;

        public Side(Color color)
        {
            _color = color;
            for (int i = 0; i < _sideMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < _sideMatrix.GetLength(1); j++)
                {
                    _sideMatrix[i, j] = _color;
                }
            }
        }

        private readonly Color[,] _sideMatrix = new Color[3, 3];

        public Color this[int column, int row] { get => _sideMatrix[column, row]; set => _sideMatrix[column, row] = value; }

        public Side Copy()
        {
            var sideCopy = new Side(_color);

            for (int i = 0; i < _sideMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < _sideMatrix.GetLength(1); j++)
                {
                    sideCopy[i, j] = _sideMatrix[i, j];
                }
            }

            return sideCopy;
        }

        public IEnumerator GetEnumerator()
        {
            return _sideMatrix.GetEnumerator();
        }
    }

    [Flags]
    public enum Turn
    {
        Left,
        Right,
        Up,
        Down,
        Front,
        Back
    }

    [Flags]
    public enum Color
    {
        Red,
        Green,
        White,
        Blue,
        Yellow,
        Orange
    }
}
