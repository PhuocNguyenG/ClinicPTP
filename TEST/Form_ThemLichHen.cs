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
    public partial class Form_ThemLichHen : Form
    {
        DentalClinicDataContext dataContext = new DentalClinicDataContext();
        public Form_ThemLichHen()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public event EventHandler click_CloseForm = null;
        private void bnt_OkThemLichHen_Click(object sender, EventArgs e)
        {
            try
            {
                Appointment appointment = new Appointment();
                appointment.AppointmentId = ranDomId();
                appointment.nameAppointment = txt_TenLichHen.Text;
                appointment.scheduleDate = dtp_NgayHen.Value;
                appointment.timeBegin = new TimeSpan(dtp_GioHen.Value.Hour, dtp_GioHen.Value.Minute, dtp_GioHen.Value.Second);
                appointment.timeEnd = new TimeSpan(dtp_GioHen.Value.Hour, dtp_GioHen.Value.Minute, dtp_GioHen.Value.Second);
                appointment.note = txt_Note.Text;
                appointment.PatientId = cmbMaBenhNhan.SelectedValue.ToString(); 
                dataContext.Appointments.InsertOnSubmit(appointment);
                dataContext.SubmitChanges();
                
                Cons.temp = "";
                click_CloseForm(sender, e);
                this.Close();
            }
            catch 
            {
                MessageBox.Show("Lỗi yêu cầu nhập đúng !");
                
            }
            

        }

        private void Form_ThemLichHen_Load(object sender, EventArgs e)
        {
            //Patient patient = new Patient();
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

        /// <summary>
        /// Tự sinh mã lịch hẹn.
        /// </summary>
        /// <returns></returns>
        public string ranDomId()
        {
            string id = "";
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                if(random.Next(0,2) == 1)
                {
                    int num = random.Next(65, 91);
                    id += (char)num;
                }
                else
                {
                    int num = random.Next(48, 58);
                    id += (char)num;

                }
                
            }
            return id;
            
        }

        private void cmbMaBenhNhan_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
