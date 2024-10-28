using AdapterPatern.CSSeries;
using VB;

namespace AdapterPatern
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CS01Button_Click(object sender, EventArgs e)
        {

            using (MeasureForm f = new MeasureForm(new CS01()))
            {
                f.ShowDialog();
            }

        }

        private void CS02Button_Click(object sender, EventArgs e)
        {
            using (MeasureForm f = new MeasureForm(new CS02()))
            {
                f.ShowDialog();
            }
        }

        private void VB01Button_Click(object sender, EventArgs e)
        {
            using (MeasureForm f = new(new VBSeriesAdapter(new VB.VB01())))
            {
                f.ShowDialog();
            }
        }

        private void VB02Button_Click(object sender, EventArgs e)
        {
            using (MeasureForm f = new(new VBSeriesAdapter(new VB.VB02())))
            {
                f.ShowDialog();
            }
        }
    }
}
