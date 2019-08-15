using RubixCubes.Core.DTOs;
using RubixCubes.Core.Enums;
using System;
using System.Collections.Generic;

namespace RubixCubes.Core
{
    public class Scrambler
    {
        private readonly Random _random = new Random();

        public ScrumblerDto ScrambleCube()
        {
            var cube = new Cube();
            var turns = new List<Tuple<Turn, bool, int>>();
            var i = 0;
            while (i < 20)
            {
                var direction = (Turn)_random.Next(0, 6);
                var quantity = _random.Next(1, 3);
                var forClockwise = _random.Next(0, 2);
                var clockwise = forClockwise == 1 || quantity == 2;

                if (i == 0)
                {
                    turns.Add(Tuple.Create(direction, clockwise, quantity));
                    i++;
                }

                switch (direction)
                {
                    case Turn.Left:
                        {
                            if (turns[i - 1].Item1 != Turn.Left)
                            {
                                turns.Add(Tuple.Create(direction, clockwise, quantity));
                                i++;
                            }

                            break;
                        }
                    case Turn.Right:
                        {
                            if (turns[i - 1].Item1 != Turn.Right)
                            {
                                turns.Add(Tuple.Create(direction, clockwise, quantity));
                                i++;
                            }

                            break;
                        }
                    case Turn.Up:
                        {
                            if (turns[i - 1].Item1 != Turn.Up)
                            {
                                turns.Add(Tuple.Create(direction, clockwise, quantity));
                                i++;
                            }

                            break;
                        }
                    case Turn.Down:
                        {
                            if (turns[i - 1].Item1 != Turn.Down)
                            {
                                turns.Add(Tuple.Create(direction, clockwise, quantity));
                                i++;
                            }

                            break;
                        }
                    case Turn.Front:
                        {
                            if (turns[i - 1].Item1 != Turn.Front)
                            {
                                turns.Add(Tuple.Create(direction, clockwise, quantity));
                                i++;
                            }

                            break;
                        }
                    case Turn.Back:
                        {
                            if (turns[i - 1].Item1 != Turn.Back)
                            {
                                turns.Add(Tuple.Create(direction, clockwise, quantity));
                                i++;
                            }

                            break;
                        }
                }
            }

            foreach (var (turn, clockwise, count) in turns)
            {
                cube.Move(turn, clockwise, count);
            }

            return new ScrumblerDto
            {
                Cube = cube,
                Turns = turns,
            };
        }
    }
}