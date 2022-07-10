
namespace JuniorHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string symbolString = "()()()())))";
            int minStreak = 1;
            int maxStreak = 1;
            int streak = 1;
            char previousSymbol = ' ';
            int brackets = 0;

            foreach (char symbols in symbolString)
            {

                if (symbols == '(')
                {
                    brackets++;
                }
                else
                    brackets--;

                if (brackets < 0)
                {
                    Console.WriteLine("Закрывающих скобок больше, чем требуется! ");
                    break;
                }

                if (symbols == previousSymbol)
                {
                    streak++;
                }
                else
                    streak = minStreak;

                if (streak > maxStreak)
                {
                    maxStreak = streak;
                }

                previousSymbol = symbols;
            }

            if (brackets == 0)
            {
                Console.WriteLine("Выражение корректно, максимальная глубина вложенности составляет " + maxStreak);
            }
            else
                Console.WriteLine("Открывающих скобок больше, чем закрывающих");
        }
    }
}