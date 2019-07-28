namespace RubixCubes.Core
{
    public static class CubeGenerator
    {
        public static Cube GenerateRandomUnsolvedCube()
        {
            var cube = new Cube();
            var cubeIsSolved = true;

            do
            {
                
            }
            while (cubeIsSolved) ;

            return cube;
        }

        public static bool IsSideSolved(Side side, Color color)
        {
            var isSolved = true;
            foreach (Color el in side)
            {
                if (el != color)
                {
                    isSolved = false;
                    break;
                }
            }

            return isSolved;
        }
    }
}