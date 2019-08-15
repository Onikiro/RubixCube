using RubixCubes.Core.DTOs;
using RubixCubes.Core.Enums;
using System;
using System.Collections.Generic;

namespace RubixCubes.Core
{
    public static class Scrumbler
    {
        public static ScrumblerDto ScrumbleCube()
        {
            var cube = new Cube();
            List<Tuple<Turn, bool, int>> turns = new List<Tuple<Turn, bool, int>>();



            Random rand = new Random();

            var direction = (Turn)rand.Next(0, 6);
            var quantity = rand.Next(1, 3);
            var forClockwise = rand.Next(0, 2);
            bool clockwise;

            if (forClockwise == 1) clockwise = true;
            else clockwise = false;

            if (quantity == 2)
            {
                clockwise = true;
            }
            turns.Add(Tuple.Create(direction, clockwise, quantity));

            for (int i = 1; i < 20;)
            {
                direction = (Turn)rand.Next(0, 6);
                quantity = rand.Next(1, 3);
                forClockwise = rand.Next(0, 2);
                if (forClockwise == 1) clockwise = true;
                else clockwise = false;
                switch (direction)
                {
                    case Turn.Left:
                        {

                            if (turns[i - 1].Item1 == Turn.Left)
                            {

                            }
                            else
                            {
                                if (quantity == 2)
                                {
                                    clockwise = true;
                                }
                                turns.Add(Tuple.Create(direction, clockwise, quantity));
                                i++;
                            }

                            break;
                        }
                    case Turn.Right:
                        {
                            if (turns[i - 1].Item1 == Turn.Right)
                            {

                            }
                            else
                            {
                                if (quantity == 2)
                                {
                                    clockwise = true;
                                }
                                turns.Add(Tuple.Create(direction, clockwise, quantity));
                                i++;
                            }
                            break;
                        }
                    case Turn.Up:
                        {
                            if (turns[i - 1].Item1 == Turn.Up)
                            {

                            }
                            else
                            {
                                if (quantity == 2)
                                {
                                    clockwise = true;
                                }
                                turns.Add(Tuple.Create(direction, clockwise, quantity));
                                i++;
                            }
                            break;
                        }
                    case Turn.Down:
                        {
                            if (turns[i - 1].Item1 == Turn.Down)
                            {

                            }
                            else
                            {
                                if (quantity == 2)
                                {
                                    clockwise = true;
                                }
                                turns.Add(Tuple.Create(direction, clockwise, quantity));
                                i++;
                            }
                            break;
                        }
                    case Turn.Front:
                        {
                            if (turns[i - 1].Item1 == Turn.Front)
                            {

                            }
                            else
                            {
                                if (quantity == 2)
                                {
                                    clockwise = true;
                                }
                                turns.Add(Tuple.Create(direction, clockwise, quantity));
                                i++;
                            }
                            break;
                        }
                    case Turn.Back:
                        {
                            if (turns[i - 1].Item1 == Turn.Back)
                            {

                            }
                            else
                            {
                                if (quantity == 2)
                                {
                                    clockwise = true;
                                }
                                turns.Add(Tuple.Create(direction, clockwise, quantity));
                                i++;
                            }
                            break;
                        }
                }
            }
            foreach (var element in turns)
            {
                cube.Rotate(element.Item1, element.Item2, element.Item3);
            }

            return new ScrumblerDto
            {
                Cube = cube,
                Turns = turns,
            };
        }
    }
}