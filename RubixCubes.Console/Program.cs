using RubixCubes.Core;
using RubixCubes.Core.Enums;
using System;

namespace RubixCubes.Console
{
    internal class Program
    {
        private static void Main()
        {
            var cube = new Cube();
            cube.Rotate(RotatingCoordinate.Z);

            System.Console.WriteLine();
            System.Console.WriteLine($"\t{cube.Up[0, 0].Ltr()} {cube.Up[0, 1].Ltr()} {cube.Up[0, 2].Ltr()}");
            System.Console.WriteLine($"\t{cube.Up[1, 0].Ltr()} {cube.Up[1, 1].Ltr()} {cube.Up[1, 2].Ltr()}");
            System.Console.WriteLine($"\t{cube.Up[2, 0].Ltr()} {cube.Up[2, 1].Ltr()} {cube.Up[2, 2].Ltr()}");

            System.Console.Write("\n");

            System.Console.WriteLine($"{cube.Left[0, 0].Ltr()} {cube.Left[0, 1].Ltr()} {cube.Left[0, 2].Ltr()}\t{cube.Front[0, 0].Ltr()} {cube.Front[0, 1].Ltr()} {cube.Front[0, 2].Ltr()}\t{cube.Right[0, 0].Ltr()} {cube.Right[0, 1].Ltr()} {cube.Right[0, 2].Ltr()}\t{cube.Back[0, 0].Ltr()} {cube.Back[0, 1].Ltr()} {cube.Back[0, 2].Ltr()}");
            System.Console.WriteLine($"{cube.Left[1, 0].Ltr()} {cube.Left[1, 1].Ltr()} {cube.Left[1, 2].Ltr()}\t{cube.Front[1, 0].Ltr()} {cube.Front[1, 1].Ltr()} {cube.Front[1, 2].Ltr()}\t{cube.Right[1, 0].Ltr()} {cube.Right[1, 1].Ltr()} {cube.Right[1, 2].Ltr()}\t{cube.Back[1, 0].Ltr()} {cube.Back[1, 1].Ltr()} {cube.Back[1, 2].Ltr()}");
            System.Console.WriteLine($"{cube.Left[2, 0].Ltr()} {cube.Left[2, 1].Ltr()} {cube.Left[2, 2].Ltr()}\t{cube.Front[2, 0].Ltr()} {cube.Front[2, 1].Ltr()} {cube.Front[2, 2].Ltr()}\t{cube.Right[2, 0].Ltr()} {cube.Right[2, 1].Ltr()} {cube.Right[2, 2].Ltr()}\t{cube.Back[2, 0].Ltr()} {cube.Back[2, 1].Ltr()} {cube.Back[2, 2].Ltr()}");

            System.Console.Write("\n");

            System.Console.WriteLine($"\t{cube.Down[0, 0].Ltr()} {cube.Down[0, 1].Ltr()} {cube.Down[0, 2].Ltr()}");
            System.Console.WriteLine($"\t{cube.Down[1, 0].Ltr()} {cube.Down[1, 1].Ltr()} {cube.Down[1, 2].Ltr()}");
            System.Console.WriteLine($"\t{cube.Down[2, 0].Ltr()} {cube.Down[2, 1].Ltr()} {cube.Down[2, 2].Ltr()}");
        }
    }

    internal static class EnumExtensions
    {
        public static char Ltr(this Enum enumObj)
        {
            return enumObj.ToString()[0];
        }
    }
}
