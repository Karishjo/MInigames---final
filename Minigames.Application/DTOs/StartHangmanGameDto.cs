public record StartHangmanGameDto(
    string PlayerName,
    string CurrentWord,
    int RemainingAttempts,
    IEnumerable<char> GuessedLetters
);