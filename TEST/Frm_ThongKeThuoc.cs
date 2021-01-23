using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST
{
    public partial class Frm_ThongKeThuoc : Form
    {
        public Frm_ThongKeThuoc()
        {
            InitializeComponent();
        }

        private void Frm_ThongKeThuoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.Medicine' table. You can move, or remove it, as needed.
            this.MedicineTableAdapter.Fill(this.DataSet1.Medicine);

            this.reportViewer1.RefreshReport();
        }

        private void MedicineBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
