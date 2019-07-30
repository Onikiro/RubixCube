using RubixCubes.Core.Enums;
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

        public bool IsSolved => Green.IsSolved && Red.IsSolved && White.IsSolved && Blue.IsSolved && Yellow.IsSolved && Orange.IsSolved;

        public void Rotate(Turn turn, bool clockwise = true, int count = 1)
        {
            for (int i = 0; i < count; i++)
            {
                var whiteCopy = White.Copy();
                var redCopy = Red.Copy();
                var orangeCopy = Orange.Copy();
                var yellowCopy = Yellow.Copy();
                var blueCopy = Blue.Copy();
                var greenCopy = Green.Copy();

                switch (turn)
                {
                    case Turn.Left:
                        if (clockwise)
                        {
                            White[0, 0] = redCopy[0, 0];
                            White[1, 0] = redCopy[1, 0];
                            White[2, 0] = redCopy[2, 0];

                            Orange[2, 2] = whiteCopy[0, 0];
                            Orange[1, 2] = whiteCopy[1, 0];
                            Orange[0, 2] = whiteCopy[2, 0];

                            Yellow[0, 0] = orangeCopy[2, 2];
                            Yellow[1, 0] = orangeCopy[1, 2];
                            Yellow[2, 0] = orangeCopy[0, 2];

                            Red[0, 0] = yellowCopy[0, 0];
                            Red[1, 0] = yellowCopy[1, 0];
                            Red[2, 0] = yellowCopy[2, 0];

                            Blue[0, 0] = blueCopy[2, 0];
                            Blue[1, 0] = blueCopy[2, 1];
                            Blue[2, 0] = blueCopy[2, 2];

                            Blue[2, 1] = blueCopy[1, 2];
                            Blue[2, 2] = blueCopy[0, 2];

                            Blue[1, 2] = blueCopy[0, 1];
                            Blue[0, 2] = blueCopy[0, 0];
                            Blue[0, 1] = blueCopy[1, 0];
                        }
                        else
                        {
                            Yellow[0, 0] = redCopy[0, 0];
                            Yellow[1, 0] = redCopy[1, 0];
                            Yellow[2, 0] = redCopy[2, 0];

                            Orange[0, 2] = yellowCopy[2, 0];
                            Orange[1, 2] = yellowCopy[1, 0];
                            Orange[2, 2] = yellowCopy[0, 0];

                            White[2, 0] = orangeCopy[0, 2];
                            White[1, 0] = orangeCopy[1, 2];
                            White[0, 0] = orangeCopy[2, 2];

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
                            Blue[1, 0] = blueCopy[0, 1];
                        }

                        break;

                    case Turn.Right:
                        if (clockwise)
                        {
                            Yellow[0, 2] = redCopy[0, 2];
                            Yellow[1, 2] = redCopy[1, 2];
                            Yellow[2, 2] = redCopy[2, 2];

                            Orange[2, 0] = yellowCopy[0, 2];
                            Orange[1, 0] = yellowCopy[1, 2];
                            Orange[0, 0] = yellowCopy[2, 2];

                            White[0, 2] = orangeCopy[2, 0];
                            White[1, 2] = orangeCopy[1, 0];
                            White[2, 2] = orangeCopy[0, 0];

                            Red[0, 2] = whiteCopy[0, 2];
                            Red[1, 2] = whiteCopy[1, 2];
                            Red[2, 2] = whiteCopy[2, 2];

                            Green[0, 0] = greenCopy[2, 0];
                            Green[1, 0] = greenCopy[2, 1];
                            Green[2, 0] = greenCopy[2, 2];

                            Green[2, 1] = greenCopy[1, 2];
                            Green[2, 2] = greenCopy[0, 2];

                            Green[1, 2] = greenCopy[0, 1];
                            Green[0, 2] = greenCopy[0, 0];
                            Green[0, 1] = greenCopy[1, 0];
                        }
                        else
                        {
                            White[0, 2] = redCopy[0, 2];
                            White[1, 2] = redCopy[1, 2];
                            White[2, 2] = redCopy[2, 2];

                            Orange[0, 0] = whiteCopy[2, 2];
                            Orange[1, 0] = whiteCopy[1, 2];
                            Orange[2, 0] = whiteCopy[0, 2];

                            Yellow[0, 2] = orangeCopy[2, 0];
                            Yellow[1, 2] = orangeCopy[1, 0];
                            Yellow[2, 2] = orangeCopy[0, 0];

                            Red[0, 2] = yellowCopy[0, 2];
                            Red[1, 2] = yellowCopy[1, 2];
                            Red[2, 2] = yellowCopy[2, 2];

                            Green[0, 0] = greenCopy[0, 2];
                            Green[0, 1] = greenCopy[1, 2];
                            Green[0, 2] = greenCopy[2, 2];

                            Green[1, 2] = greenCopy[2, 1];
                            Green[2, 2] = greenCopy[2, 0];

                            Green[2, 1] = greenCopy[1, 0];
                            Green[2, 0] = greenCopy[0, 0];
                            Green[1, 0] = greenCopy[0, 1];
                        }

                        break;

                    case Turn.Up:
                        if (clockwise)
                        {
                            Blue[0, 0] = redCopy[0, 0];
                            Blue[0, 1] = redCopy[0, 1];
                            Blue[0, 2] = redCopy[0, 2];

                            Orange[0, 0] = blueCopy[0, 0];
                            Orange[0, 1] = blueCopy[0, 1];
                            Orange[0, 2] = blueCopy[0, 2];

                            Green[0, 0] = orangeCopy[0, 0];
                            Green[0, 1] = orangeCopy[0, 1];
                            Green[0, 2] = orangeCopy[0, 2];

                            Red[0, 0] = greenCopy[0, 0];
                            Red[0, 1] = greenCopy[0, 1];
                            Red[0, 2] = greenCopy[0, 2];

                            Yellow[0, 0] = yellowCopy[2, 0];
                            Yellow[1, 0] = yellowCopy[2, 1];
                            Yellow[2, 0] = yellowCopy[2, 2];

                            Yellow[2, 1] = yellowCopy[1, 2];
                            Yellow[2, 2] = yellowCopy[0, 2];

                            Yellow[1, 2] = yellowCopy[0, 1];
                            Yellow[0, 2] = yellowCopy[0, 0];
                            Yellow[0, 1] = yellowCopy[1, 0];
                        }
                        else
                        {
                            Blue[0, 0] = orangeCopy[0, 0];
                            Blue[0, 1] = orangeCopy[0, 1];
                            Blue[0, 2] = orangeCopy[0, 2];

                            Red[0, 0] = blueCopy[0, 0];
                            Red[0, 1] = blueCopy[0, 1];
                            Red[0, 2] = blueCopy[0, 2];

                            Green[0, 0] = redCopy[0, 0];
                            Green[0, 1] = redCopy[0, 1];
                            Green[0, 2] = redCopy[0, 2];

                            Orange[0, 0] = greenCopy[0, 0];
                            Orange[0, 1] = greenCopy[0, 1];
                            Orange[0, 2] = greenCopy[0, 2];

                            Yellow[0, 0] = yellowCopy[0, 2];
                            Yellow[0, 1] = yellowCopy[1, 2];
                            Yellow[0, 2] = yellowCopy[2, 2];

                            Yellow[1, 2] = yellowCopy[2, 1];
                            Yellow[2, 2] = yellowCopy[2, 0];

                            Yellow[2, 1] = yellowCopy[1, 0];
                            Yellow[2, 0] = yellowCopy[0, 0];
                            Yellow[1, 0] = yellowCopy[0, 1];
                        }

                        break;

                    case Turn.Down:
                        if (clockwise)
                        {
                            Blue[2, 0] = orangeCopy[2, 0];
                            Blue[2, 1] = orangeCopy[2, 1];
                            Blue[2, 2] = orangeCopy[2, 2];

                            Red[2, 0] = blueCopy[2, 0];
                            Red[2, 1] = blueCopy[2, 1];
                            Red[2, 2] = blueCopy[2, 2];

                            Green[2, 0] = redCopy[2, 0];
                            Green[2, 1] = redCopy[2, 1];
                            Green[2, 2] = redCopy[2, 2];

                            Orange[2, 0] = greenCopy[2, 0];
                            Orange[2, 1] = greenCopy[2, 1];
                            Orange[2, 2] = greenCopy[2, 2];

                            White[0, 0] = whiteCopy[2, 0];
                            White[1, 0] = whiteCopy[2, 1];
                            White[2, 0] = whiteCopy[2, 2];

                            White[2, 1] = whiteCopy[1, 2];
                            White[2, 2] = whiteCopy[0, 2];

                            White[1, 2] = whiteCopy[0, 1];
                            White[0, 2] = whiteCopy[0, 0];
                            White[0, 1] = whiteCopy[1, 0];
                        }
                        else
                        {
                            Blue[2, 0] = redCopy[2, 0];
                            Blue[2, 1] = redCopy[2, 1];
                            Blue[2, 2] = redCopy[2, 2];

                            Orange[2, 0] = blueCopy[2, 0];
                            Orange[2, 1] = blueCopy[2, 1];
                            Orange[2, 2] = blueCopy[2, 2];

                            Green[2, 0] = orangeCopy[2, 0];
                            Green[2, 1] = orangeCopy[2, 1];
                            Green[2, 2] = orangeCopy[2, 2];

                            Red[2, 0] = greenCopy[2, 0];
                            Red[2, 1] = greenCopy[2, 1];
                            Red[2, 2] = greenCopy[2, 2];

                            White[0, 0] = whiteCopy[0, 2];
                            White[0, 1] = whiteCopy[1, 2];
                            White[0, 2] = whiteCopy[2, 2];

                            White[1, 2] = whiteCopy[2, 1];
                            White[2, 2] = whiteCopy[2, 0];

                            White[2, 1] = whiteCopy[1, 0];
                            White[2, 0] = whiteCopy[0, 0];
                            White[1, 0] = whiteCopy[0, 1];
                        }

                        break;

                    case Turn.Front:
                        if (clockwise)
                        {
                            Red[0, 0] = redCopy[2, 0];
                            Red[1, 0] = redCopy[2, 1];
                            Red[2, 0] = redCopy[2, 2];

                            Red[2, 1] = redCopy[1, 2];
                            Red[2, 2] = redCopy[0, 2];

                            Red[1, 2] = redCopy[0, 1];
                            Red[0, 2] = redCopy[0, 0];
                            Red[0, 1] = redCopy[1, 0];

                            Yellow[2, 0] = blueCopy[2, 2];
                            Yellow[2, 1] = blueCopy[1, 2];
                            Yellow[2, 2] = blueCopy[0, 2];

                            Green[0, 0] = yellowCopy[2, 0];
                            Green[1, 0] = yellowCopy[2, 1];
                            Green[2, 0] = yellowCopy[2, 2];

                            White[0, 0] = greenCopy[2, 0];
                            White[0, 1] = greenCopy[1, 0];
                            White[0, 2] = greenCopy[0, 0];

                            Blue[0, 2] = whiteCopy[0, 0];
                            Blue[1, 2] = whiteCopy[0, 1];
                            Blue[2, 2] = whiteCopy[0, 2];
                        }
                        else
                        {
                            Red[0, 0] = redCopy[0, 2];
                            Red[0, 1] = redCopy[1, 2];
                            Red[0, 2] = redCopy[2, 2];

                            Red[1, 2] = redCopy[2, 1];
                            Red[2, 2] = redCopy[2, 0];

                            Red[2, 1] = redCopy[1, 0];
                            Red[2, 0] = redCopy[0, 0];
                            Red[1, 0] = redCopy[0, 1];

                            Yellow[2, 0] = greenCopy[0, 0];
                            Yellow[2, 1] = greenCopy[1, 0];
                            Yellow[2, 2] = greenCopy[2, 0];

                            Green[0, 0] = whiteCopy[0, 2];
                            Green[1, 0] = whiteCopy[0, 1];
                            Green[2, 0] = whiteCopy[0, 0];

                            White[0, 0] = blueCopy[0, 2];
                            White[0, 1] = blueCopy[1, 2];
                            White[0, 2] = blueCopy[2, 2];

                            Blue[0, 2] = yellowCopy[2, 2];
                            Blue[1, 2] = yellowCopy[2, 1];
                            Blue[2, 2] = yellowCopy[2, 0];
                        }

                        break;

                    case Turn.Back:
                        if (clockwise)
                        {
                            Orange[0, 0] = orangeCopy[2, 0];
                            Orange[1, 0] = orangeCopy[2, 1];
                            Orange[2, 0] = orangeCopy[2, 2];

                            Orange[2, 1] = orangeCopy[1, 2];
                            Orange[2, 2] = orangeCopy[0, 2];

                            Orange[1, 2] = orangeCopy[0, 1];
                            Orange[0, 2] = orangeCopy[0, 0];
                            Orange[0, 1] = orangeCopy[1, 0];

                            Yellow[0, 0] = greenCopy[0, 2];
                            Yellow[0, 1] = greenCopy[1, 2];
                            Yellow[0, 2] = greenCopy[2, 2];

                            Blue[2, 0] = yellowCopy[0, 0];
                            Blue[1, 0] = yellowCopy[0, 1];
                            Blue[0, 0] = yellowCopy[0, 2];

                            White[2, 2] = blueCopy[2, 0];
                            White[2, 1] = blueCopy[1, 0];
                            White[2, 0] = blueCopy[0, 0];

                            Green[0, 2] = whiteCopy[2, 2];
                            Green[1, 2] = whiteCopy[2, 1];
                            Green[2, 2] = whiteCopy[2, 0];
                        }
                        else
                        {
                            Orange[0, 0] = orangeCopy[0, 2];
                            Orange[0, 1] = orangeCopy[1, 2];
                            Orange[0, 2] = orangeCopy[2, 2];

                            Orange[1, 2] = orangeCopy[2, 1];
                            Orange[2, 2] = orangeCopy[2, 0];

                            Orange[2, 1] = orangeCopy[1, 0];
                            Orange[2, 0] = orangeCopy[0, 0];
                            Orange[1, 0] = orangeCopy[0, 1];

                            Yellow[0, 2] = blueCopy[0, 0];
                            Yellow[0, 1] = blueCopy[1, 0];
                            Yellow[0, 0] = blueCopy[2, 0];

                            Green[0, 2] = yellowCopy[0, 0];
                            Green[1, 2] = yellowCopy[0, 1];
                            Green[2, 2] = yellowCopy[0, 2];

                            White[2, 2] = greenCopy[0, 2];
                            White[2, 1] = greenCopy[1, 2];
                            White[2, 0] = greenCopy[2, 2];

                            Blue[2, 0] = whiteCopy[2, 2];
                            Blue[1, 0] = whiteCopy[2, 1];
                            Blue[0, 0] = whiteCopy[2, 0];
                        }

                        break;
                }
            }
        }
    }

    public class Side : IEnumerable
    {
        private readonly Color _color;

        public bool IsSolved
        {
            get
            {
                var isSolved = true;
                foreach (Color el in _sideMatrix)
                {
                    if (el != _color)
                    {
                        isSolved = false;
                        break;
                    }
                }

                return isSolved;
            }
        }

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
}
