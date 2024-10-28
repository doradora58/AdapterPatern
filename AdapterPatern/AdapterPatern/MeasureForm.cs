using AdapterPatern.CSSeries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdapterPatern
{
    public partial class MeasureForm : Form
    {



        private CSSeriesBase _csSeries;
        public MeasureForm(CSSeriesBase csSeries)
        {
            _csSeries = csSeries;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = _csSeries.GetValue().ToString() + "m/s2";
        }
    }
}
