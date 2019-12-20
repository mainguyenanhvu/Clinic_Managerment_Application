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
    public partial class InsertForm : Form
    {
        public InsertForm()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            // Get current date
            DateTime today = DateTime.Today;
            string day = Convert.ToString(today.Day);
            string month = Convert.ToString(today.Month);
            string year = Convert.ToString(today.Year);
            
            string reason = combo_major.GetItemText(combo_major.SelectedItem);
            if(reason == "")
            {
                MessageBox.Show("Cần có chuyên khoa khám!", "Lỗi");
                return;
            }
            string id = tb_id.Text;
            if (id == "")
            {
                MessageBox.Show("Cần có mã hồ sơ!", "Lỗi");
                return;
            }
            string name = tb_name.Text;
            string birth_year = tb_birth_year.Text;
            string gender = combo_gender.GetItemText(combo_gender.SelectedItem);
            string addr = tb_addr.Text;
            string phone = tb_phone.Text;
            string note = tb_note.Text;
            string date = year + "-" + month + "-" + day;

            //Console.WriteLine("check: " + checkNumber(birth_year).ToString());
            //Console.WriteLine("Year " + birth_year.ToString());
            if (!checkNumber(birth_year) || int.Parse(birth_year) > DateTime.Today.Year)
            {
                //MessageBox.Show("Vui lòng nhập năm sinh thỏa mãn là số và không lớn hơn năm hiện tại!", "Lỗi");
                //return;
                birth_year = "0";
            }
            
            using (SqlConnection Con = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["QLPKConnectionString"].ToString()))
            {
                Con.Open();
                string query = "select * from CodeExamination where profileCode = '" + id + "' and yearCheckup = " + year;
                SqlCommand command = new SqlCommand(query, Con);
                var rowE = command.ExecuteScalar();
                if (rowE != null)
                {
                    MessageBox.Show("Trùng mã hồ sơ!", "Lỗi");
                    Con.Close();
                    return;
                }
                else
                {

                }
                Con.Close();
            }

            using (SqlConnection Con = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["QLPKConnectionString"].ToString()))
            {
                Con.Open();
                string query = "insert into PatientInformation(name,birthyear,gender,address1,phonenumber,note) values(N'" + name + "'," + birth_year + ",N'" + gender + "',N'" + addr + "','" + phone + "',N'" + note + "')" + "SELECT CAST(scope_identity() AS int)";
                SqlCommand command = new SqlCommand(query, Con);
                var rowE = command.ExecuteScalar();
                if (rowE != null)
                {
                    //Console.WriteLine("ID patient: " + rowE.ToString());
                    string q = "insert into MedicalExamination(idPatient,dateCheckup,typeCheckup) values(" + rowE.ToString() + ",'" + date + "',N'" + reason + "')" + "SELECT CAST(scope_identity() AS int)";
                    SqlCommand cmd = new SqlCommand(q, Con);
                
                    var rowEffect = cmd.ExecuteScalar();

                    if (rowEffect != null)
                    {
                        string qE = "insert into CodeExamination(profileCode,idPatient,typeCheckup,yearCheckup) values(N'" + id + "'," + rowE.ToString() + ",N'" + reason + "'," + year + "); " + "SELECT CAST(scope_identity() AS int)";
                        SqlCommand cm = new SqlCommand(qE, Con);
                        var rowe = cm.ExecuteScalar();
                        if (rowe != null)
                        {
                            MessageBox.Show("Lưu thành công!", "Lưu");
                        }
                        else
                        {
                            MessageBox.Show("Không thể lưu dữ liệu!", "Lưu");
                        }
                    }
                    else
                        // To-do xóa thằng ngoài: Vũ viết
                        MessageBox.Show("Không thể lưu dữ liệu!", "Lưu");

                }
                else
                    MessageBox.Show("Không thể lưu dữ liệu!", "Lưu");
                Con.Close(); 
            }
            this.Close();

        }
        
        private bool checkNumber(string str)
        {
            if (str == null || str =="")
            {
                return false;
            }
            int n;
            bool isNumeric = int.TryParse(str, out n);
            return isNumeric;
        }

        private void combo_major_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                //SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tb_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                // SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tb_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                //SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tb_birth_year_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                //SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void combo_gender_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                //SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tb_addr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                //SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tb_phone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                //SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tb_note_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void InsertForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }

}
