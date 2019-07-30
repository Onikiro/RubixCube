using RubixCubes.Core.Enums;
using RubixCubes.Core;

namespace RubixCubes.Console
{
    class Program
    {
        static void Main()
        {
            var cube = new Cube();

            cube.Rotate(Turn.Front, false, 1);
            cube.Rotate(Turn.Down, false, 1);
            cube.Rotate(Turn.Front, true, 2);
            cube.Rotate(Turn.Back, false, 1);
            cube.Rotate(Turn.Down, false, 1);
            cube.Rotate(Turn.Up, true, 1);
            cube.Rotate(Turn.Front, true, 2);
            cube.Rotate(Turn.Down, true, 1);
            cube.Rotate(Turn.Up, true, 2);
            cube.Rotate(Turn.Left, true, 2);
            cube.Rotate(Turn.Down, false, 1);
            cube.Rotate(Turn.Up, true, 2);
            cube.Rotate(Turn.Back, false, 1);
            cube.Rotate(Turn.Up, true, 2);
            cube.Rotate(Turn.Front, true, 2);
            cube.Rotate(Turn.Back, false, 1);
            cube.Rotate(Turn.Right, true, 1);
            cube.Rotate(Turn.Front, false, 1);
            cube.Rotate(Turn.Down, true, 1);
            cube.Rotate(Turn.Front, true, 2);

            System.Console.WriteLine($"\t\t{cube.Yellow[0, 0]} {cube.Yellow[0, 1]} {cube.Yellow[0, 2]}");
            System.Console.WriteLine($"\t\t{cube.Yellow[1, 0]} {cube.Yellow[1, 1]} {cube.Yellow[1, 2]}");
            System.Console.WriteLine($"\t\t{cube.Yellow[2, 0]} {cube.Yellow[2, 1]} {cube.Yellow[2, 2]}");

            System.Console.Write("\n");

            System.Console.WriteLine($"{cube.Blue[0, 0]} {cube.Blue[0, 1]} {cube.Blue[0, 2]}\t{cube.Red[0, 0]} {cube.Red[0, 1]} {cube.Red[0, 2]}\t\t{cube.Green[0, 0]} {cube.Green[0, 1]} {cube.Green[0, 2]}\t\t{cube.Orange[0, 0]} {cube.Orange[0, 1]} {cube.Orange[0, 2]}");
            System.Console.WriteLine($"{cube.Blue[1, 0]} {cube.Blue[1, 1]} {cube.Blue[1, 2]}\t{cube.Red[1, 0]} {cube.Red[1, 1]} {cube.Red[1, 2]}\t\t{cube.Green[1, 0]} {cube.Green[1, 1]} {cube.Green[1, 2]}\t\t{cube.Orange[1, 0]} {cube.Orange[1, 1]} {cube.Orange[1, 2]}");
            System.Console.WriteLine($"{cube.Blue[2, 0]} {cube.Blue[2, 1]} {cube.Blue[2, 2]}\t{cube.Red[2, 0]} {cube.Red[2, 1]} {cube.Red[2, 2]}\t\t{cube.Green[2, 0]} {cube.Green[2, 1]} {cube.Green[2, 2]}\t\t{cube.Orange[2, 0]} {cube.Orange[2, 1]} {cube.Orange[2, 2]}");

            System.Console.Write("\n");

            System.Console.WriteLine($"\t\t{cube.White[0, 0]} {cube.White[0, 1]} {cube.White[0, 2]}");
            System.Console.WriteLine($"\t\t{cube.White[1, 0]} {cube.White[1, 1]} {cube.White[1, 2]}");
            System.Console.WriteLine($"\t\t{cube.White[2, 0]} {cube.White[2, 1]} {cube.White[2, 2]}");
        }
    }
}
