using RubixCubes.Core.DTOs;
using RubixCubes.Core.Enums;
using System;
using System.Collections.Generic;

namespace RubixCubes.Core
{
    public class Scrambler
    {
        private readonly Random _random = new Random();

        public ScramblerDto ScrambleCube(int countOfSteps = 25)
        {
            var cube = new Cube();
            var turns = new List<Tuple<TurnType, bool, int>>();
            var i = 0;
            while (i < countOfSteps)
            {
                var direction = (TurnType)_random.Next(0, 6);
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
                    case TurnType.Left:
                        {
                            if (turns[i - 1].Item1 != TurnType.Left)
                            {
                                turns.Add(Tuple.Create(direction, clockwise, quantity));
                                i++;
                            }

                            break;
                        }
                    case TurnType.Right:
                        {
                            if (turns[i - 1].Item1 != TurnType.Right)
                            {
                                turns.Add(Tuple.Create(direction, clockwise, quantity));
                                i++;
                            }

                            break;
                        }
                    case TurnType.Up:
                        {
                            if (turns[i - 1].Item1 != TurnType.Up)
                            {
                                turns.Add(Tuple.Create(direction, clockwise, quantity));
                                i++;
                            }

                            break;
                        }
                    case TurnType.Down:
                        {
                            if (turns[i - 1].Item1 != TurnType.Down)
                            {
                                turns.Add(Tuple.Create(direction, clockwise, quantity));
                                i++;
                            }

                            break;
                        }
                    case TurnType.Front:
                        {
                            if (turns[i - 1].Item1 != TurnType.Front)
                            {
                                turns.Add(Tuple.Create(direction, clockwise, quantity));
                                i++;
                            }

                            break;
                        }
                    case TurnType.Back:
                        {
                            if (turns[i - 1].Item1 != TurnType.Back)
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

            return new ScramblerDto
            {
                Cube = cube,
                Turns = turns
            };
        }
    }
}