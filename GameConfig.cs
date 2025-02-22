namespace GuessNumber;

public class GameConfig : IGameConfig
{
    public int MaxAttempts { get; private set; }
    public int MinNumber { get; private set; }
    public int MaxNumber { get; private set; }
        
    public GameConfig(int maxAttempts, int minNumber, int maxNumber)
    {
        MaxAttempts = maxAttempts;
        MinNumber = minNumber;
        MaxNumber = maxNumber;
    }
}