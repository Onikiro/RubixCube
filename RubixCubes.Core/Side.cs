using RubixCubes.Core.Enums;
using System;
using System.Collections;
using System.Linq;

namespace RubixCubes.Core
{
    public class Side : IEnumerable
    {
        private readonly Color _color;
        public Turn Turn { get; set; }

        public bool IsSolved
        {
            get
            {
                return _sideMatrix.Cast<Color>().All(el => el == _color);
            }
        }

        public Side(Color color,Turn turn)
        {
            Turn = turn;
            _color = color;
            for (var i = 0; i < _sideMatrix.GetLength(0); i++)
            {
                for (var j = 0; j < _sideMatrix.GetLength(1); j++)
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

            for (var i = 0; i < _sideMatrix.GetLength(0); i++)
            {
                for (var j = 0; j < _sideMatrix.GetLength(1); j++)
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
        public Tuple<Side, Color, int[,], Side, Color, int[,]> GetEdge(int[,])
        {
            switch (this)
            {
                case Up:
                    {
                        
                        break;
                    }
            }
            //var yellow_orange = new Tuple<Side, Color, int[,], Side, Color, int[,]>(Cube.Up, Cube.Up[0, 1],);
            //Cube.Up[0, 1] =
            return;

        }
    }
}