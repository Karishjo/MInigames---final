using Minigames.Application.DTOs;

namespace Minigames.Application.Interfaces;

public interface IHangmanGameService
{
    StartHangmanGameDto StartGame(string playerName);
    HangmanAnswerResultDto SubmitGuess(SubmitHangmanGuessDto guess);
}
