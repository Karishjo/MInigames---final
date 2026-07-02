using Minigames.Application.DTOs;
using Minigames.Application.Interfaces;
using static Minigames.Application.DTOs.HangmanGameResultDto;

namespace Minigames.Application.Services;

public class HangmanService : IHangmanGameService
{
    private const int MaxAttempts = 15;

    private readonly List<char> _guessedLetters = new();
    private int _remainingAttempts = MaxAttempts;
    private string _word = "COMPUTER";

    public StartHangmanGameDto StartGame(string playerName)
    {
        _guessedLetters.Clear();
        _remainingAttempts = MaxAttempts;

        return new StartHangmanGameDto(
            playerName,
            GetCurrentWord(),
            _remainingAttempts,
            _guessedLetters
        );
    }

    public HangmanAnswerResultDto SubmitGuess(SubmitHangmanGuessDto guess)
    {
        if (guess.Letter == null)
        {
            return new HangmanAnswerResultDto(
                GetCurrentWord(),
                _remainingAttempts,
                "Letter is required."
            );
        }

        char letter = char.ToUpper(guess.Letter.Value);

        if (!_guessedLetters.Contains(letter))
        {
            _guessedLetters.Add(letter);

            if (!_word.Contains(letter))
            {
                _remainingAttempts--;
            }
        }

        string currentWord = GetCurrentWord();
        bool isWon = !currentWord.Contains('_');
        bool isGameOver = isWon || _remainingAttempts <= 0;

        string message = isWon
            ? "Congratulations! You guessed the word."
            : isGameOver
                ? $"Game over. The word was {_word}."
                : _word.Contains(letter)
                    ? "Correct guess."
                    : "Wrong guess.";

        return new HangmanAnswerResultDto(
            currentWord,
            _remainingAttempts,
            message
        );
    }

    private string GetCurrentWord()
    {
        return string.Join(" ", _word.Select(c =>
            _guessedLetters.Contains(c) ? c : '_'
        ));
    }
}