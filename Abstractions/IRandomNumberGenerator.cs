namespace GuessNumber.Abstractions;

public interface IRandomNumberGenerator
{
    int GenerateNumber(int min, int max);
}