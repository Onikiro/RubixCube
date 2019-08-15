﻿using RubixCubes.Core.Enums;
using System.Collections;

namespace RubixCubes.Core
{
    public class Cube
    {
        public Side Right { get; private set; } = new Side(Color.Green);
        public Side Front { get; private set; } = new Side(Color.Red);
        public Side Down { get; private set; } = new Side(Color.White);
        public Side Left { get; private set; } = new Side(Color.Blue);
        public Side Up { get; private set; } = new Side(Color.Yellow);
        public Side Back { get; private set; } = new Side(Color.Orange);

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
                    case RotatingCoordinate.x:
                        {
                            if (clockwise)
                            {
                                Front = downCopy;
                                Down = backCopy;
                                Back = upCopy;
                                Up = frontCopy;

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
                                Up = backCopy;
                                Back = downCopy;
                                Down = frontCopy;

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

                    case RotatingCoordinate.y:
                        {
                            if (clockwise)
                            {
                                Front = rightCopy;
                                Right = backCopy;
                                Left = frontCopy;
                                Back = leftCopy;

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
                                Right = frontCopy;
                                Back = rightCopy;
                                Left = backCopy;

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

                    case RotatingCoordinate.z:
                        {
                            if (clockwise)
                            {
                                Left = downCopy;
                                Down = rightCopy;
                                Right = upCopy;
                                Up = leftCopy;

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
                                Up = rightCopy;
                                Right = downCopy;
                                Down = leftCopy;

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