using GuessNumber.Abstractions;
using GuessNumber.Implementations;

IGameConfig config = new GameConfig(maxAttempts: 5, minNumber: 1, maxNumber: 100);
IRandomNumberGenerator randomGenerator = new RandomNumberGenerator();

IGame game = new GuessNumberGame(config, randomGenerator);

game.Play();

Console.WriteLine("Нажмите любую клавишу для выхода...");
Console.ReadKey();