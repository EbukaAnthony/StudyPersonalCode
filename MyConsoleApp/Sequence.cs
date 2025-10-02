using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class Sequence
    {
        private static int CurrentValue = 0;

        private Sequence() { }

        public static int NextValue()
        {
            CurrentValue++;
            return CurrentValue;
        }
    }
}
