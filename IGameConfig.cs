namespace GuessNumber;

public interface IGameConfig
{
    int MaxAttempts { get; }
    
    int MinNumber { get; }
    
    int MaxNumber { get; }
}