using System;
using Generators;

namespace KeypadConsole
{
    class Program
    {
        // ReSharper disable once UnusedParameter.Local
        static void Main(string[] args)
        {
            var generator = new KeyPadGenerator();
            var keypad = generator.GenerateKeypad(6);
            foreach (var row in keypad)
            {
                Console.WriteLine(row);
            }
        }
    }
}
