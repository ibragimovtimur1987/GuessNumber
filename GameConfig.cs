namespace GuessNumber;

public class GameConfig : IGameConfig
{
    public int MaxAttempts { get; }
    public int MinNumber { get; }
    public int MaxNumber { get; }
        
    public GameConfig(int maxAttempts, int minNumber, int maxNumber)
    {
        MaxAttempts = maxAttempts;
        MinNumber = minNumber;
        MaxNumber = maxNumber;
    }
}