namespace GuessNumber;

  public class GuessNumberGame : IGame
    {
        private readonly IGameConfig _config;
        private readonly IRandomNumberGenerator _numberGenerator;
        
        public GuessNumberGame(IGameConfig config, IRandomNumberGenerator numberGenerator)
        {
            _config = config;
            _numberGenerator = numberGenerator;
        }

        public void Play()
        {
            int targetNumber = _numberGenerator.GenerateNumber(_config.MinNumber, _config.MaxNumber);
            int attemptsLeft = _config.MaxAttempts;
            
            Console.WriteLine("Добро пожаловать в игру \"Угадай число\"!");
            Console.WriteLine($"Я загадал число от {_config.MinNumber} до {_config.MaxNumber}. У вас {attemptsLeft} попыток.");

            while (attemptsLeft > 0)
            {
                Console.Write("Введите вашу догадку: ");
                string input = Console.ReadLine();
                int guess;
                if (!int.TryParse(input, out guess))
                {
                    Console.WriteLine("Неверный ввод. Пожалуйста, введите число.");
                    continue;
                }

                if (guess == targetNumber)
                {
                    Console.WriteLine("Поздравляем! Вы угадали число!");
                    return; 
                }
                else if (guess < targetNumber)
                {
                    Console.WriteLine("Загаданное число больше.");
                }
                else 
                {
                    Console.WriteLine("Загаданное число меньше.");
                }

                attemptsLeft--;
                if (attemptsLeft > 0)
                {
                    Console.WriteLine($"Осталось {attemptsLeft} попыток.");
                }
            }

            Console.WriteLine($"Вы проиграли! Загаданное число было: {targetNumber}");
        }
    }