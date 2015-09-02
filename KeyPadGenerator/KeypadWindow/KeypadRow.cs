using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace KeypadWindow
{
    public class KeypadRow
    {
        public char C1 { get; set; }
        public char C2 { get; set; }
        public char C3 { get; set; }
        public char C4 { get; set; }
        public char C5 { get; set; }
        public char C6 { get; set; }

        public KeypadRow(string line)
        {
            var chars = line.ToCharArray().Where(c => c != ',').ToList();
            C1 = chars[0];
            C2 = chars[1];
            C3 = chars[2];
            C4 = chars[3];
            C5 = chars[4];
            C6 = chars[5];
        }
    }
}