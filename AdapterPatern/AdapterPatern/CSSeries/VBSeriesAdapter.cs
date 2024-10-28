using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatern.CSSeries
{
    internal class VBSeriesAdapter : ICSSeries
    {
        private VB.IVBSeries _vbSeries;
        public VBSeriesAdapter(VB.IVBSeries vbSeries)
        {
            _vbSeries = vbSeries;
        }
        public int GetValue()
        {
            return _vbSeries.GetValue();
        }
    }
}
