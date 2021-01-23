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
    public partial class Frm_DichVuDieuTri : Form
    {
        public Frm_DichVuDieuTri()
        {
            InitializeComponent();
            var query = from s in Cons.dataContext.Services select new { s.ServiceId , s.nameService};
            comboBox_DichVu.DataSource = query;
            comboBox_DichVu.DisplayMember = "nameService";
            comboBox_DichVu.ValueMember = "ServiceId";

        }
        
        List<int> luuID = new List<int>();
       
        private void btnChon_Click(object sender, EventArgs e)
        {
            ServiceTreatment serviceTreatment = new ServiceTreatment();
            listBox1.Items.Add(comboBox_DichVu.Text);
            
            serviceTreatment.TreatmentId = txtMaDieuTri.Text;
            serviceTreatment.ServiceId = comboBox_DichVu.SelectedValue.ToString();
            Cons.dataContext.ServiceTreatments.InsertOnSubmit(serviceTreatment);
            
            Cons.dataContext.SubmitChanges();

            
            luuID.Add(serviceTreatment.ServiceTreatmentId);
            MessageBox.Show(luuID[0].ToString());
        }
        string tam = "";
        private void btnXoa_Click(object sender, EventArgs e)
        {
            ServiceTreatment serviceTreatment = new ServiceTreatment();
            tam = listBox1.GetItemText(listBox1.SelectedItem);
            serviceTreatment = Cons.dataContext.ServiceTreatments.Where(ma => ma.ServiceTreatmentId == luuID[listBox1.SelectedIndex] ).Single();
            Cons.dataContext.ServiceTreatments.DeleteOnSubmit(serviceTreatment);
            Cons.dataContext.SubmitChanges();
            luuID.RemoveAt(listBox1.SelectedIndex);
         
            listBox1.Items.Remove(listBox1.SelectedItem);
            

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_DichVuDieuTri_Load(object sender, EventArgs e)
        {
            luuID.Clear();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMaDieuTri_TextChanged(object sender, EventArgs e)
        {
            txtMaDieuTri.CharacterCasing = CharacterCasing.Upper;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
