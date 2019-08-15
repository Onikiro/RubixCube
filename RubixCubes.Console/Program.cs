﻿using RubixCubes.Core.Enums;
using RubixCubes.Core;
using System;

namespace RubixCubes.Console
{
    class Program
    {
        static void Main()
        {
            var Result = Scrumbler.ScrumbleCube();
            var cube = Result.Cube;

            foreach (var el in Result.Turns)
            {
                System.Console.Write(el.Item1.Ltr() + "" + (el.Item2 == false ? "'" : "") + "" + el.Item3 + ",");
            }
            System.Console.WriteLine();
            System.Console.WriteLine($"\t{cube.Yellow[0, 0].Ltr()} {cube.Yellow[0, 1].Ltr()} {cube.Yellow[0, 2].Ltr()}");
            System.Console.WriteLine($"\t{cube.Yellow[1, 0].Ltr()} {cube.Yellow[1, 1].Ltr()} {cube.Yellow[1, 2].Ltr()}");
            System.Console.WriteLine($"\t{cube.Yellow[2, 0].Ltr()} {cube.Yellow[2, 1].Ltr()} {cube.Yellow[2, 2].Ltr()}");

            System.Console.Write("\n");

            System.Console.WriteLine($"{cube.Blue[0, 0].Ltr()} {cube.Blue[0, 1].Ltr()} {cube.Blue[0, 2].Ltr()}\t{cube.Red[0, 0].Ltr()} {cube.Red[0, 1].Ltr()} {cube.Red[0, 2].Ltr()}\t{cube.Green[0, 0].Ltr()} {cube.Green[0, 1].Ltr()} {cube.Green[0, 2].Ltr()}\t{cube.Orange[0, 0].Ltr()} {cube.Orange[0, 1].Ltr()} {cube.Orange[0, 2].Ltr()}");
            System.Console.WriteLine($"{cube.Blue[1, 0].Ltr()} {cube.Blue[1, 1].Ltr()} {cube.Blue[1, 2].Ltr()}\t{cube.Red[1, 0].Ltr()} {cube.Red[1, 1].Ltr()} {cube.Red[1, 2].Ltr()}\t{cube.Green[1, 0].Ltr()} {cube.Green[1, 1].Ltr()} {cube.Green[1, 2].Ltr()}\t{cube.Orange[1, 0].Ltr()} {cube.Orange[1, 1].Ltr()} {cube.Orange[1, 2].Ltr()}");
            System.Console.WriteLine($"{cube.Blue[2, 0].Ltr()} {cube.Blue[2, 1].Ltr()} {cube.Blue[2, 2].Ltr()}\t{cube.Red[2, 0].Ltr()} {cube.Red[2, 1].Ltr()} {cube.Red[2, 2].Ltr()}\t{cube.Green[2, 0].Ltr()} {cube.Green[2, 1].Ltr()} {cube.Green[2, 2].Ltr()}\t{cube.Orange[2, 0].Ltr()} {cube.Orange[2, 1].Ltr()} {cube.Orange[2, 2].Ltr()}");

            System.Console.Write("\n");

            System.Console.WriteLine($"\t{cube.White[0, 0].Ltr()} {cube.White[0, 1].Ltr()} {cube.White[0, 2].Ltr()}");
            System.Console.WriteLine($"\t{cube.White[1, 0].Ltr()} {cube.White[1, 1].Ltr()} {cube.White[1, 2].Ltr()}");
            System.Console.WriteLine($"\t{cube.White[2, 0].Ltr()} {cube.White[2, 1].Ltr()} {cube.White[2, 2].Ltr()}");
        }
    }

    static class EnumExtensions
    {
        public static char Ltr(this Color color)
        {
            return color.ToString()[0];
        }
        public static char Ltr(this Turn color)
        {
            return color.ToString()[0];
        }
    }
}
