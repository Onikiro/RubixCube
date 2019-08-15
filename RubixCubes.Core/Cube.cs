using RubixCubes.Core.Enums;

namespace RubixCubes.Core
{
    public class Cube
    {
        public Side Right { get; private set; } = new Side(Color.Green,Turn.Right);
        public Side Front { get; private set; } = new Side(Color.Red, Turn.Front);
        public Side Down { get; private set; } = new Side(Color.White, Turn.Down);
        public Side Left { get; private set; } = new Side(Color.Blue, Turn.Left);
        public Side Up { get; private set; } = new Side(Color.Yellow, Turn.Up);
        public Side Back { get; private set; } = new Side(Color.Orange, Turn.Back);

        public bool IsSolved => Right.IsSolved && Front.IsSolved && Down.IsSolved && Left.IsSolved && Up.IsSolved && Back.IsSolved;

        public void Move(Turn turn, bool clockwise = true, int count = 1)
        {
            for (var i = 0; i < count; i++)
            {
                var downCopy = Down.Copy();
                var frontCopy = Front.Copy();
                var backCopy = Back.Copy();
                var upCopy = Up.Copy();
                var leftCopy = Left.Copy();
                var rightCopy = Right.Copy();

                switch (turn)
                {
                    case Turn.Left:
                        if (clockwise)
                        {
                            Down[0, 0] = frontCopy[0, 0];
                            Down[1, 0] = frontCopy[1, 0];
                            Down[2, 0] = frontCopy[2, 0];

                            Back[2, 2] = downCopy[0, 0];
                            Back[1, 2] = downCopy[1, 0];
                            Back[0, 2] = downCopy[2, 0];

                            Up[0, 0] = backCopy[2, 2];
                            Up[1, 0] = backCopy[1, 2];
                            Up[2, 0] = backCopy[0, 2];

                            Front[0, 0] = upCopy[0, 0];
                            Front[1, 0] = upCopy[1, 0];
                            Front[2, 0] = upCopy[2, 0];

                            Left[0, 0] = leftCopy[2, 0];
                            Left[1, 0] = leftCopy[2, 1];
                            Left[2, 0] = leftCopy[2, 2];

                            Left[2, 1] = leftCopy[1, 2];
                            Left[2, 2] = leftCopy[0, 2];

                            Left[1, 2] = leftCopy[0, 1];
                            Left[0, 2] = leftCopy[0, 0];
                            Left[0, 1] = leftCopy[1, 0];
                        }
                        else
                        {
                            Up[0, 0] = frontCopy[0, 0];
                            Up[1, 0] = frontCopy[1, 0];
                            Up[2, 0] = frontCopy[2, 0];

                            Back[0, 2] = upCopy[2, 0];
                            Back[1, 2] = upCopy[1, 0];
                            Back[2, 2] = upCopy[0, 0];

                            Down[2, 0] = backCopy[0, 2];
                            Down[1, 0] = backCopy[1, 2];
                            Down[0, 0] = backCopy[2, 2];

                            Front[0, 0] = downCopy[0, 0];
                            Front[1, 0] = downCopy[1, 0];
                            Front[2, 0] = downCopy[2, 0];

                            Left[0, 0] = leftCopy[0, 2];
                            Left[0, 1] = leftCopy[1, 2];
                            Left[0, 2] = leftCopy[2, 2];

                            Left[1, 2] = leftCopy[2, 1];
                            Left[2, 2] = leftCopy[2, 0];

                            Left[2, 1] = leftCopy[1, 0];
                            Left[2, 0] = leftCopy[0, 0];
                            Left[1, 0] = leftCopy[0, 1];
                        }

                        break;

                    case Turn.Right:
                        if (clockwise)
                        {
                            Up[0, 2] = frontCopy[0, 2];
                            Up[1, 2] = frontCopy[1, 2];
                            Up[2, 2] = frontCopy[2, 2];

                            Back[2, 0] = upCopy[0, 2];
                            Back[1, 0] = upCopy[1, 2];
                            Back[0, 0] = upCopy[2, 2];

                            Down[0, 2] = backCopy[2, 0];
                            Down[1, 2] = backCopy[1, 0];
                            Down[2, 2] = backCopy[0, 0];

                            Front[0, 2] = downCopy[0, 2];
                            Front[1, 2] = downCopy[1, 2];
                            Front[2, 2] = downCopy[2, 2];

                            Right[0, 0] = rightCopy[2, 0];
                            Right[1, 0] = rightCopy[2, 1];
                            Right[2, 0] = rightCopy[2, 2];

                            Right[2, 1] = rightCopy[1, 2];
                            Right[2, 2] = rightCopy[0, 2];

                            Right[1, 2] = rightCopy[0, 1];
                            Right[0, 2] = rightCopy[0, 0];
                            Right[0, 1] = rightCopy[1, 0];
                        }
                        else
                        {
                            Down[0, 2] = frontCopy[0, 2];
                            Down[1, 2] = frontCopy[1, 2];
                            Down[2, 2] = frontCopy[2, 2];

                            Back[0, 0] = downCopy[2, 2];
                            Back[1, 0] = downCopy[1, 2];
                            Back[2, 0] = downCopy[0, 2];

                            Up[0, 2] = backCopy[2, 0];
                            Up[1, 2] = backCopy[1, 0];
                            Up[2, 2] = backCopy[0, 0];

                            Front[0, 2] = upCopy[0, 2];
                            Front[1, 2] = upCopy[1, 2];
                            Front[2, 2] = upCopy[2, 2];

                            Right[0, 0] = rightCopy[0, 2];
                            Right[0, 1] = rightCopy[1, 2];
                            Right[0, 2] = rightCopy[2, 2];

                            Right[1, 2] = rightCopy[2, 1];
                            Right[2, 2] = rightCopy[2, 0];

                            Right[2, 1] = rightCopy[1, 0];
                            Right[2, 0] = rightCopy[0, 0];
                            Right[1, 0] = rightCopy[0, 1];
                        }

                        break;

                    case Turn.Up:
                        if (clockwise)
                        {
                            Left[0, 0] = frontCopy[0, 0];
                            Left[0, 1] = frontCopy[0, 1];
                            Left[0, 2] = frontCopy[0, 2];

                            Back[0, 0] = leftCopy[0, 0];
                            Back[0, 1] = leftCopy[0, 1];
                            Back[0, 2] = leftCopy[0, 2];

                            Right[0, 0] = backCopy[0, 0];
                            Right[0, 1] = backCopy[0, 1];
                            Right[0, 2] = backCopy[0, 2];

                            Front[0, 0] = rightCopy[0, 0];
                            Front[0, 1] = rightCopy[0, 1];
                            Front[0, 2] = rightCopy[0, 2];

                            Up[0, 0] = upCopy[2, 0];
                            Up[1, 0] = upCopy[2, 1];
                            Up[2, 0] = upCopy[2, 2];

                            Up[2, 1] = upCopy[1, 2];
                            Up[2, 2] = upCopy[0, 2];

                            Up[1, 2] = upCopy[0, 1];
                            Up[0, 2] = upCopy[0, 0];
                            Up[0, 1] = upCopy[1, 0];
                        }
                        else
                        {
                            Left[0, 0] = backCopy[0, 0];
                            Left[0, 1] = backCopy[0, 1];
                            Left[0, 2] = backCopy[0, 2];

                            Front[0, 0] = leftCopy[0, 0];
                            Front[0, 1] = leftCopy[0, 1];
                            Front[0, 2] = leftCopy[0, 2];

                            Right[0, 0] = frontCopy[0, 0];
                            Right[0, 1] = frontCopy[0, 1];
                            Right[0, 2] = frontCopy[0, 2];

                            Back[0, 0] = rightCopy[0, 0];
                            Back[0, 1] = rightCopy[0, 1];
                            Back[0, 2] = rightCopy[0, 2];

                            Up[0, 0] = upCopy[0, 2];
                            Up[0, 1] = upCopy[1, 2];
                            Up[0, 2] = upCopy[2, 2];

                            Up[1, 2] = upCopy[2, 1];
                            Up[2, 2] = upCopy[2, 0];

                            Up[2, 1] = upCopy[1, 0];
                            Up[2, 0] = upCopy[0, 0];
                            Up[1, 0] = upCopy[0, 1];
                        }

                        break;

                    case Turn.Down:
                        if (clockwise)
                        {
                            Left[2, 0] = backCopy[2, 0];
                            Left[2, 1] = backCopy[2, 1];
                            Left[2, 2] = backCopy[2, 2];

                            Front[2, 0] = leftCopy[2, 0];
                            Front[2, 1] = leftCopy[2, 1];
                            Front[2, 2] = leftCopy[2, 2];

                            Right[2, 0] = frontCopy[2, 0];
                            Right[2, 1] = frontCopy[2, 1];
                            Right[2, 2] = frontCopy[2, 2];

                            Back[2, 0] = rightCopy[2, 0];
                            Back[2, 1] = rightCopy[2, 1];
                            Back[2, 2] = rightCopy[2, 2];

                            Down[0, 0] = downCopy[2, 0];
                            Down[1, 0] = downCopy[2, 1];
                            Down[2, 0] = downCopy[2, 2];

                            Down[2, 1] = downCopy[1, 2];
                            Down[2, 2] = downCopy[0, 2];

                            Down[1, 2] = downCopy[0, 1];
                            Down[0, 2] = downCopy[0, 0];
                            Down[0, 1] = downCopy[1, 0];
                        }
                        else
                        {
                            Left[2, 0] = frontCopy[2, 0];
                            Left[2, 1] = frontCopy[2, 1];
                            Left[2, 2] = frontCopy[2, 2];

                            Back[2, 0] = leftCopy[2, 0];
                            Back[2, 1] = leftCopy[2, 1];
                            Back[2, 2] = leftCopy[2, 2];

                            Right[2, 0] = backCopy[2, 0];
                            Right[2, 1] = backCopy[2, 1];
                            Right[2, 2] = backCopy[2, 2];

                            Front[2, 0] = rightCopy[2, 0];
                            Front[2, 1] = rightCopy[2, 1];
                            Front[2, 2] = rightCopy[2, 2];

                            Down[0, 0] = downCopy[0, 2];
                            Down[0, 1] = downCopy[1, 2];
                            Down[0, 2] = downCopy[2, 2];

                            Down[1, 2] = downCopy[2, 1];
                            Down[2, 2] = downCopy[2, 0];

                            Down[2, 1] = downCopy[1, 0];
                            Down[2, 0] = downCopy[0, 0];
                            Down[1, 0] = downCopy[0, 1];
                        }

                        break;

                    case Turn.Front:
                        if (clockwise)
                        {
                            Front[0, 0] = frontCopy[2, 0];
                            Front[1, 0] = frontCopy[2, 1];
                            Front[2, 0] = frontCopy[2, 2];

                            Front[2, 1] = frontCopy[1, 2];
                            Front[2, 2] = frontCopy[0, 2];

                            Front[1, 2] = frontCopy[0, 1];
                            Front[0, 2] = frontCopy[0, 0];
                            Front[0, 1] = frontCopy[1, 0];

                            Up[2, 0] = leftCopy[2, 2];
                            Up[2, 1] = leftCopy[1, 2];
                            Up[2, 2] = leftCopy[0, 2];

                            Right[0, 0] = upCopy[2, 0];
                            Right[1, 0] = upCopy[2, 1];
                            Right[2, 0] = upCopy[2, 2];

                            Down[0, 0] = rightCopy[2, 0];
                            Down[0, 1] = rightCopy[1, 0];
                            Down[0, 2] = rightCopy[0, 0];

                            Left[0, 2] = downCopy[0, 0];
                            Left[1, 2] = downCopy[0, 1];
                            Left[2, 2] = downCopy[0, 2];
                        }
                        else
                        {
                            Front[0, 0] = frontCopy[0, 2];
                            Front[0, 1] = frontCopy[1, 2];
                            Front[0, 2] = frontCopy[2, 2];

                            Front[1, 2] = frontCopy[2, 1];
                            Front[2, 2] = frontCopy[2, 0];

                            Front[2, 1] = frontCopy[1, 0];
                            Front[2, 0] = frontCopy[0, 0];
                            Front[1, 0] = frontCopy[0, 1];

                            Up[2, 0] = rightCopy[0, 0];
                            Up[2, 1] = rightCopy[1, 0];
                            Up[2, 2] = rightCopy[2, 0];

                            Right[0, 0] = downCopy[0, 2];
                            Right[1, 0] = downCopy[0, 1];
                            Right[2, 0] = downCopy[0, 0];

                            Down[0, 0] = leftCopy[0, 2];
                            Down[0, 1] = leftCopy[1, 2];
                            Down[0, 2] = leftCopy[2, 2];

                            Left[0, 2] = upCopy[2, 2];
                            Left[1, 2] = upCopy[2, 1];
                            Left[2, 2] = upCopy[2, 0];
                        }

                        break;

                    case Turn.Back:
                        if (clockwise)
                        {
                            Back[0, 0] = backCopy[2, 0];
                            Back[1, 0] = backCopy[2, 1];
                            Back[2, 0] = backCopy[2, 2];

                            Back[2, 1] = backCopy[1, 2];
                            Back[2, 2] = backCopy[0, 2];

                            Back[1, 2] = backCopy[0, 1];
                            Back[0, 2] = backCopy[0, 0];
                            Back[0, 1] = backCopy[1, 0];

                            Up[0, 0] = rightCopy[0, 2];
                            Up[0, 1] = rightCopy[1, 2];
                            Up[0, 2] = rightCopy[2, 2];

                            Left[2, 0] = upCopy[0, 0];
                            Left[1, 0] = upCopy[0, 1];
                            Left[0, 0] = upCopy[0, 2];

                            Down[2, 2] = leftCopy[2, 0];
                            Down[2, 1] = leftCopy[1, 0];
                            Down[2, 0] = leftCopy[0, 0];

                            Right[0, 2] = downCopy[2, 2];
                            Right[1, 2] = downCopy[2, 1];
                            Right[2, 2] = downCopy[2, 0];
                        }
                        else
                        {
                            Back[0, 0] = backCopy[0, 2];
                            Back[0, 1] = backCopy[1, 2];
                            Back[0, 2] = backCopy[2, 2];

                            Back[1, 2] = backCopy[2, 1];
                            Back[2, 2] = backCopy[2, 0];

                            Back[2, 1] = backCopy[1, 0];
                            Back[2, 0] = backCopy[0, 0];
                            Back[1, 0] = backCopy[0, 1];

                            Up[0, 2] = leftCopy[0, 0];
                            Up[0, 1] = leftCopy[1, 0];
                            Up[0, 0] = leftCopy[2, 0];

                            Right[0, 2] = upCopy[0, 0];
                            Right[1, 2] = upCopy[0, 1];
                            Right[2, 2] = upCopy[0, 2];

                            Down[2, 2] = rightCopy[0, 2];
                            Down[2, 1] = rightCopy[1, 2];
                            Down[2, 0] = rightCopy[2, 2];

                            Left[2, 0] = downCopy[2, 2];
                            Left[1, 0] = downCopy[2, 1];
                            Left[0, 0] = downCopy[2, 0];
                        }

                        break;
                }
            }
        }

        public void Rotate(RotatingCoordinate coordinate, bool clockwise = true, int count = 1)
        {
            for (var i = 0; i < count; i++)
            {
                var downCopy = Down.Copy();
                var frontCopy = Front.Copy();
                var backCopy = Back.Copy();
                var upCopy = Up.Copy();
                var leftCopy = Left.Copy();
                var rightCopy = Right.Copy();

                switch (coordinate)
                {
                    case RotatingCoordinate.X:
                        {
                            if (clockwise)
                            {
                                Front = downCopy;
                                Front.Turn = downCopy.Turn;
                                Down = backCopy;
                                Down.Turn = backCopy.Turn;
                                Back = upCopy;
                                Back.Turn = upCopy.Turn;
                                Up = frontCopy;
                                Up.Turn = frontCopy.Turn;

                                Right[0, 0] = rightCopy[0, 2];
                                Right[0, 1] = rightCopy[1, 2];
                                Right[0, 2] = rightCopy[2, 2];

                                Right[1, 2] = rightCopy[2, 1];
                                Right[2, 2] = rightCopy[2, 0];

                                Right[2, 1] = rightCopy[1, 0];
                                Right[2, 0] = rightCopy[0, 0];
                                Right[1, 0] = rightCopy[0, 1];

                                Left[0, 0] = leftCopy[2, 0];
                                Left[1, 0] = leftCopy[2, 1];
                                Left[2, 0] = leftCopy[2, 2];

                                Left[2, 1] = leftCopy[1, 2];
                                Left[2, 2] = leftCopy[0, 2];

                                Left[1, 2] = leftCopy[0, 1];
                                Left[0, 2] = leftCopy[0, 0];
                                Left[0, 1] = leftCopy[1, 0];
                            }
                            else
                            {
                                Front = upCopy;
                                Front.Turn = upCopy.Turn;
                                Up = backCopy;
                                Up.Turn = backCopy.Turn;
                                Back = downCopy;
                                Back.Turn = downCopy.Turn;
                                Down = frontCopy;
                                Down.Turn = frontCopy.Turn;

                                Right[0, 0] = rightCopy[2, 0];
                                Right[1, 0] = rightCopy[2, 1];
                                Right[2, 0] = rightCopy[2, 2];

                                Right[2, 1] = rightCopy[1, 2];
                                Right[2, 2] = rightCopy[0, 2];

                                Right[1, 2] = rightCopy[0, 1];
                                Right[0, 2] = rightCopy[0, 0];
                                Right[0, 1] = rightCopy[1, 0];

                                Left[0, 0] = leftCopy[0, 2];
                                Left[0, 1] = leftCopy[1, 2];
                                Left[0, 2] = leftCopy[2, 2];

                                Left[1, 2] = leftCopy[2, 1];
                                Left[2, 2] = leftCopy[2, 0];

                                Left[2, 1] = leftCopy[1, 0];
                                Left[2, 0] = leftCopy[0, 0];
                                Left[1, 0] = leftCopy[0, 1];
                            }

                            break;
                        }

                    case RotatingCoordinate.Y:
                        {
                            if (clockwise)
                            {
                                Front = rightCopy;
                                Front.Turn = rightCopy.Turn;
                                Right = backCopy;
                                Right.Turn = backCopy.Turn;
                                Left = frontCopy;
                                Left.Turn = frontCopy.Turn;
                                Back = leftCopy;
                                Back.Turn = leftCopy.Turn;

                                Up[0, 0] = upCopy[0, 2];
                                Up[0, 1] = upCopy[1, 2];
                                Up[0, 2] = upCopy[2, 2];

                                Up[1, 2] = upCopy[2, 1];
                                Up[2, 2] = upCopy[2, 0];

                                Up[2, 1] = upCopy[1, 0];
                                Up[2, 0] = upCopy[0, 0];
                                Up[1, 0] = upCopy[0, 1];

                                Down[0, 0] = downCopy[2, 0];
                                Down[1, 0] = downCopy[2, 1];
                                Down[2, 0] = downCopy[2, 2];

                                Down[2, 1] = downCopy[1, 2];
                                Down[2, 2] = downCopy[0, 2];

                                Down[1, 2] = downCopy[0, 1];
                                Down[0, 2] = downCopy[0, 0];
                                Down[0, 1] = downCopy[1, 0];
                            }
                            else
                            {
                                Front = leftCopy;
                                Front.Turn = leftCopy.Turn;
                                Right = frontCopy;
                                Right.Turn = frontCopy.Turn;
                                Back = rightCopy;
                                Back.Turn = rightCopy.Turn;
                                Left = backCopy;
                                Left.Turn = backCopy.Turn;

                                Up[0, 0] = upCopy[2, 0];
                                Up[1, 0] = upCopy[2, 1];
                                Up[2, 0] = upCopy[2, 2];

                                Up[2, 1] = upCopy[1, 2];
                                Up[2, 2] = upCopy[0, 2];

                                Up[1, 2] = upCopy[0, 1];
                                Up[0, 2] = upCopy[0, 0];
                                Up[0, 1] = upCopy[1, 0];

                                Down[0, 0] = downCopy[0, 2];
                                Down[0, 1] = downCopy[1, 2];
                                Down[0, 2] = downCopy[2, 2];

                                Down[1, 2] = downCopy[2, 1];
                                Down[2, 2] = downCopy[2, 0];

                                Down[2, 1] = downCopy[1, 0];
                                Down[2, 0] = downCopy[0, 0];
                                Down[1, 0] = downCopy[0, 1];
                            }

                            break;
                        }

                    case RotatingCoordinate.Z:
                        {
                            if (clockwise)
                            {
                                Left = downCopy;
                                Left.Turn = downCopy.Turn;
                                Down = rightCopy;
                                Down.Turn = rightCopy.Turn;
                                Right = upCopy;
                                Right.Turn = upCopy.Turn;
                                Up = leftCopy;
                                Up.Turn = leftCopy.Turn;

                                Front[0, 0] = frontCopy[2, 0];
                                Front[1, 0] = frontCopy[2, 1];
                                Front[2, 0] = frontCopy[2, 2];

                                Front[2, 1] = frontCopy[1, 2];
                                Front[2, 2] = frontCopy[0, 2];

                                Front[1, 2] = frontCopy[0, 1];
                                Front[0, 2] = frontCopy[0, 0];
                                Front[0, 1] = frontCopy[1, 0];

                                Back[0, 0] = backCopy[0, 2];
                                Back[0, 1] = backCopy[1, 2];
                                Back[0, 2] = backCopy[2, 2];

                                Back[1, 2] = backCopy[2, 1];
                                Back[2, 2] = backCopy[2, 0];

                                Back[2, 1] = backCopy[1, 0];
                                Back[2, 0] = backCopy[0, 0];
                                Back[1, 0] = backCopy[0, 1];
                            }
                            else
                            {
                                Left = upCopy;
                                Left.Turn = upCopy.Turn;
                                Up = rightCopy;
                                Up.Turn = rightCopy.Turn;
                                Right = downCopy;
                                Right.Turn = downCopy.Turn;
                                Down = leftCopy;
                                Down.Turn = leftCopy.Turn;

                                Front[0, 0] = frontCopy[0, 2];
                                Front[0, 1] = frontCopy[1, 2];
                                Front[0, 2] = frontCopy[2, 2];

                                Front[1, 2] = frontCopy[2, 1];
                                Front[2, 2] = frontCopy[2, 0];

                                Front[2, 1] = frontCopy[1, 0];
                                Front[2, 0] = frontCopy[0, 0];
                                Front[1, 0] = frontCopy[0, 1];

                                Back[0, 0] = backCopy[2, 0];
                                Back[1, 0] = backCopy[2, 1];
                                Back[2, 0] = backCopy[2, 2];

                                Back[2, 1] = backCopy[1, 2];
                                Back[2, 2] = backCopy[0, 2];

                                Back[1, 2] = backCopy[0, 1];
                                Back[0, 2] = backCopy[0, 0];
                                Back[0, 1] = backCopy[1, 0];
                            }

                            break;
                        }
                }
            }
        }
    }
}