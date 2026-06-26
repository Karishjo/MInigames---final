namespace Minigames.Domain.Entities;

public class PlayerGameSummary
{
    public int Id { get; set; }
    public required string PlayerName { get; set; }
    public PlayerGameSummary GameResult { get; private set; }
}