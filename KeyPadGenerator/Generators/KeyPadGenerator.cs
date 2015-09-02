using System;
using System.Collections.Generic;
using System.Linq;

namespace Generators
{
    public class KeyPadGenerator
    {
        public IEnumerable<string> GenerateKeypad(int lineLength)
        {
            var chars = GenerateKeypadChar().ToList();
            var result = new List<string>();
            var amount = chars.Count;
            var line = new List<char>();
            for (var i = 0; i < amount; i++)
            {
                var charToAdd = chars[i];
                line.Add(charToAdd);
                if (line.Count % lineLength != 0 && i != amount - 1)
                {
                    continue;
                }
                result.Add(string.Join(",", line));
                line.Clear();
            }
            return result;
        }

        public IEnumerable<char> GenerateKeypadChar()
        {
            var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToCharArray().ToList();
            var usedChars = new List<char>();
            var result = new List<char>();
            var amount = characters.Count;
            var r = new Random();
            for (var i = 0; i < amount; i++)
            {
                var freechars = characters.Except(usedChars).ToList();
                var position = r.Next(freechars.Count());
                var charToAdd = freechars[position];
                result.Add(charToAdd);
            }
            return result;

        }
    }
}
