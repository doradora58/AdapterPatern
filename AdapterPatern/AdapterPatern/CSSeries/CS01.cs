using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatern.CSSeries
{
    internal sealed class CS01 : ICSSeries
    {
        public int GetValue()
        {
            return 1000;
        }
    }
}
