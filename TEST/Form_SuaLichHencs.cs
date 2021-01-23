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
    public partial class Form_SuaLichHencs : Form
    {
        DentalClinicDataContext dataContext = new DentalClinicDataContext();
        public Form_SuaLichHencs()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_SuaLichHencs_Load(object sender, EventArgs e)
        {
            var query = from p in dataContext.Patients
                        select new
                        {
                            p.PatientId,
                            p.fullName
                        };
            cmbMaBenhNhan.DataSource = query.ToList();
            cmbMaBenhNhan.DisplayMember = "fullName";
            cmbMaBenhNhan.ValueMember = "PatientId";
        }

        public event EventHandler click_CloseForm = null;
        private void bnt_OkThemLichHen_Click(object sender, EventArgs e)
        {
            try
            {
                Appointment appointment = new Appointment();
                appointment = dataContext.Appointments.Where(a => a.AppointmentId == Cons.temp).Single();
                
                appointment.nameAppointment = txt_TenLichHen.Text;
                appointment.scheduleDate = dtp_NgayHen.Value;
                appointment.timeBegin = new TimeSpan(int.Parse(nud_GioBatDau.Value.ToString()), int.Parse(nud_PhutBatDau.Value.ToString()),0);
                appointment.timeEnd = new TimeSpan(int.Parse(nud_GioKetThuc.Value.ToString()), int.Parse(nud_GioKetThuc.Value.ToString()), 0);
                appointment.note = txtNote.Text;
                appointment.PatientId = cmbMaBenhNhan.SelectedValue.ToString();
                
                dataContext.SubmitChanges();
                click_CloseForm(sender, e);
                this.Close();
                
            }
            catch
            {
                MessageBox.Show("Lỗi yêu cầu nhập đúng !");

            }

        }

        private void bnt_CancelThemLichHen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
