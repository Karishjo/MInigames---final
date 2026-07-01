namespace Minigames.Domain.Entities;

public class PlayerGameSummary
{
   public HangmanGameResult HangmanGameResult { get; private set; }

   public FormulaGameResult FormulaGameResult { get; private set; }

    public PlayerGameSummary()
    {
        HangmanGameResult = new HangmanGameResult();
        FormulaGameResult = new FormulaGameResult();
    }

    public int TotalScore => HangmanGameResult.TimesWon * 10 + FormulaGameResult.TimesPlayed;
}