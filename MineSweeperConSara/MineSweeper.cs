using System.Text;

namespace MineSweeperConSara
{
    public class MineSweeper
    {
        private readonly Matrix _matrix;
        public bool IsLoser { get; private set; }

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
                    else
                    {
                        if (_matrix.At(new Coordinates(x, y)).Mines)
                        {
                            board.Append('*');
                        }
                    }
                }
                board.Append('\n');
            }

            return board.ToString().Substring(0, board.Length -1);
        }

        public void Open(Coordinates coordinates)
        {
            _matrix.
            if (_matrix.At(coordinates).Mines)
            {
                IsLoser = true;
            }
        }
    }
}