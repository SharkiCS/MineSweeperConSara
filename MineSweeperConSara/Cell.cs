namespace MineSweeperConSara
{
    public struct Cell
    {
        public readonly bool Visibility;
        public readonly bool Mines;
        public Cell(bool visibility, bool mines) 
            => (Visibility, Mines) = (visibility, mines);
    }
}