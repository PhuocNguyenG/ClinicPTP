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
    public partial class Form_XoaLichHen : Form
    {
        public Form_XoaLichHen()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        DentalClinicDataContext dataContext = new DentalClinicDataContext();
        public event EventHandler click_CloseForm = null;

        private void bnt_OkThemLichHen_Click(object sender, EventArgs e)
        {
            Appointment appointment = new Appointment();
            appointment = dataContext.Appointments.Where(a => a.AppointmentId == Cons.temp).Single();
            dataContext.Appointments.DeleteOnSubmit(appointment);
            dataContext.SubmitChanges();
            click_CloseForm(sender, e);
            this.Close();
        }

        private void bnt_CancelThemLichHen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
