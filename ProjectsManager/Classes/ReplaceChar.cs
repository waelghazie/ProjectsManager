using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace ProjectsManager
{
    class ReplaceChar
    {
        [DebuggerStepThrough]

        public static string ReplaceAChar(string InputString)
        {
            return InputString.Replace('أ', 'ا').Replace('إ', 'ا').Replace('آ', 'ا');
        }
    }
}
