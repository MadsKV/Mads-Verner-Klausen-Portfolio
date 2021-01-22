using System;

namespace GuessANumber
{
    public class ColorPicker
    {
        //Creates a random color picker.
        private static Random _random = new Random();
        public static ConsoleColor GetRandomConsoleColor()
        {
            var consoleColors = Enum.GetValues(typeof(ConsoleColor));
            return (ConsoleColor)consoleColors.GetValue(_random.Next(consoleColors.Length));
        }
        public static void RandomColor()
        {
            Console.ForegroundColor = GetRandomConsoleColor();
        }
    }
}
