namespace conways_game_of_life
{
    public interface IBoard
    {
        int Row { get; }
        int Column { get; }
        Cell GetCell(int x, int y);
    }
}