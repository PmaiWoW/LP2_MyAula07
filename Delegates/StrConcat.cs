using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    public struct StrConcat
    {
        private string myStr;

        public StrConcat(string str)
        {
            myStr = str;
        }

        public void ConcatAndPrint(string str)
        {
            Console.WriteLine(str + myStr);
        }
    }
}
