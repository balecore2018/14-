using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _14.Classes.Common
{
    public class CheckRegex
    {
        public static bool Match(string Input, string Pattern)
        {
            Match m = Regex.Match(Input, Pattern);
            return m.Success;
        }
    }
}
