using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamKhanhAnExamples
{
    public class Func81
    {
        public int Func8(int a, bool b, bool c)
        {
            int result = 10;
            if ((a > 500) && (!b) && c)
                result = 70;
            if (a < 150 || b)
                while (result < 40)
                    result++;
            return result;
        }
    }
}
