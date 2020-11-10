namespace conways_game_of_life
{
    public interface IBoard
    {
        int Row { get; }
        int Column { get; }
        string GetCellValue(int x, int y);
    }
}