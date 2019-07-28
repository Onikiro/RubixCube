namespace RubixCubes.Core
{
    public class Cube
    {
        Side Green = new Side();
        Side Red = new Side();
        Side White = new Side();
        Side Blue = new Side();
        Side Yellow = new Side();
        Side Orange = new Side();

        public Cube()
        {

        }

        public void Rotate(Turn turn, int count)
        {

        }

        public class Side
        {
            readonly Color[,] _sideMatrix = new Color[3, 3];

            public Color this[int column, int row] { get => _sideMatrix[column, row]; set => _sideMatrix[column, row] = value; };
        }

        public enum Turn
        {
            Left,
            Right,
            Up,
            Down,
            Front,
            Back
        }

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
}