using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongKham
{
    public partial class TimesForm : Form
    {
        string index;
        string idm;
        string ide;
        ReaddForm readdForm;
        public TimesForm(ReaddForm readd, string _index, string _idm, string _ide)
        {
            InitializeComponent();
            index = _index;
            idm = _idm;
            ide = _ide;
            Console.WriteLine("id times: " + index.ToString());
            readdForm = readd;
        }

        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;

        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }
        private void TimesForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        protected void raiseUpdate()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler?.Invoke(this, args);
        }

        private void btn_readd_Click(object sender, EventArgs e)
        {
            string major = combo_major.GetItemText(combo_major.SelectedItem);
            string idhs = tb_id.Text.ToString();
            DateTime today = DateTime.Today;

            string day = Convert.ToString(today.Day);
            string month = Convert.ToString(today.Month);
            string year = Convert.ToString(today.Year);
            string date = year + "-" + month + "-" + day;

            using (SqlConnection Con = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["QLPKConnectionString"].ToString()))
            {
                Con.Open();
                string query = "select ID from CodeExamination where typeCheckup = N'" + major + "' and yearCheckup = " + year + " and idPatient = " + index + " and profileCode = N'" + idhs + "'";
                Console.WriteLine(query);
                SqlCommand cmdP = new SqlCommand(query, Con);
                var resP = cmdP.ExecuteScalar();
                //Console.WriteLine("res: " + resP.ToString());
                if (resP != null && (int)resP >= 1)
                {
                    MessageBox.Show("Mã hồ sơ bị trùng!", "Thêm");
                    Con.Close();
                    return;
                }
                else
                {
                    string q = "select * from CodeExamination where typeCheckup = N'" + major + "' and yearCheckup = " + year + " and idPatient = " + index;
                    SqlCommand cm = new SqlCommand(q, Con);
                    var resq = cm.ExecuteScalar();
                    if (resq!=null && (int)resq >= 1)
                    {
                        idhs = "";
                    }
                    else
                    {
                        if (idhs == "")
                        {
                            MessageBox.Show("Không được để trống mã hồ sơ!", "Lỗi!");
                            return;
                        }
                    }
                    //MessageBox.Show("Thêm thất bại!", "Thêm");
                }
                Con.Close();
            }

            using (SqlConnection Con = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["QLPKConnectionString"].ToString()))
            {
                Con.Open();
                string query;
                if (idhs != "")
                    query = "insert into MedicalExamination(idPatient,dateCheckup,typeCheckup) values(" + index + ",'" + date + "',N'" + major + "'); insert into CodeExamination(profileCode,idPatient,typeCheckup,yearCheckup) values(N'" + idhs + "'," + index + ",N'" + major + "'," + year + ")";
                else
                    query = "insert into MedicalExamination(idPatient,dateCheckup,typeCheckup) values(" + index + ",'" + date + "',N'" + major + "');";
                SqlCommand cmdP = new SqlCommand(query, Con);
                var resP = cmdP.ExecuteNonQuery();
                if (resP != null & (int)resP >= 1)
                {
                    MessageBox.Show("Thêm thành công!", "Thêm");
                }
                else
                    MessageBox.Show("Thêm thất bại!", "Thêm");
                Con.Close();
            }
            raiseUpdate();
            this.Close();
        } 
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void combo_major_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tb_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
    }
}
