using System;

namespace RubixCubes.Core.Enums
{
    [Flags]
    public enum Turn
    {
        Left,
        Right,
        Up,
        Down,
        Front,
        Back
    }

    [Flags]
    public enum RotatingCoordinate
    {
        x,
        y,
        z
    }
}
