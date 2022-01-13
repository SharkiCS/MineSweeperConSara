using System.Text;

namespace MineSweeperConSara
{
    public class MineSweeper
    {
        private readonly Matrix _matrix;

        public MineSweeper(Matrix matrix) 
            => _matrix = matrix;

        public string Print()
        {
            StringBuilder board = new StringBuilder();

            for (int x = 0; x < _matrix.Width; x++)
            {
                for (int y = 0; y < _matrix.Height; y++)
                {
                    if (!_matrix.At(new Coordinates(x, y)).Visibility)
                        board.Append('.');
                }
                board.Append('\n');
            }

            return board.ToString().Substring(0, board.Length -1);
        }
    }
}