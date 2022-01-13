namespace MineSweeperConSara
{
    public struct Coordinates
    {
        public readonly int X;
        public readonly int Y;
        public Coordinates(int x, int y)
            => (X, Y) = (x, y);
    }

    public class Matrix
    {
        public int Width { get; }
        public int Height { get; }

        private Cell[,] _matrix;

        public Matrix(int width, int height)
        {
            (Width, Height) = (width, height);
            _matrix = new Cell[width, height];
            Initialize();
        }

        private void Initialize()
        {
            for(int x = 0; x < Width; x++)
                for (int y = 0; y < Height; y++)
                    _matrix[x, y] = new Cell(false, false);
        }

        public Cell At(Coordinates coordinates) 
            => _matrix[coordinates.X, coordinates.Y];

        public void SetMine(Coordinates coordinates) 
            => _matrix[coordinates.X, coordinates.Y] = new Cell(false,true);
    }
}