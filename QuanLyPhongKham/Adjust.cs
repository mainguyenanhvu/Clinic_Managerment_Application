using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace QuanLyPhongKham
{
    public partial class AdjustForm : Form
    {
        string _index;
        string _idm;
        string _ide;
        public AdjustForm(string[] infor)
        {
            InitializeComponent();
            initialize(infor);

        }

        private void initialize(string[] infor)
        {
            _index = infor[0];
            _idm = infor[10];
            _ide = infor[11];
            combo_major.Text = infor[1];
            tb_id.Text = infor[2];
            tb_name.Text = infor[3];
            tb_birth_year.Text = infor[4];
            combo_gender.Text = infor[5];
            tb_addr.Text = infor[6];
            tb_phone.Text = infor[7];
            tb_date.Text = infor[8];
            tb_note.Text = infor[9];
        }



        private void AdjustForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string executeStringDate(string date)
        {
                        
            if(date.Length < 10)
            {
                if(date.IndexOf("/") == 1)
                {
                    char day_c = date[0];
                    char check_month = date[3];
                    if(check_month == '/')
                    {
                        char month_c = date[2];
                        char[] year_c = date.ToCharArray(4, 4);
                        return convertToCharArray_1(day_c, month_c, year_c); 
                        
                    }
                    else
                    {
                        char[] month_c = date.ToCharArray(2, 2);
                        char[] year_c = date.ToCharArray(5, 4);
                        return convertToCharArray_2(day_c, month_c, year_c);
                    }
                        
                }
                else
                {
                    char[] day_c = date.ToCharArray(0, 2);
                    char month_c = date[3];
                    char[] year_c = date.ToCharArray(5, 4);
                    return convertToCharArray_3(day_c, month_c, year_c);
                }
            }
            else
            {
                return date;               
            }
        }

        private string convertToCharArray_1(char day, char month, char[] year)
        {
            char[] standard_c = new char[10];
            standard_c[0] = '0';
            standard_c[1] = day;
            standard_c[2] = '/';
            standard_c[3] = '0';
            standard_c[4] = month;
            standard_c[5] = '/';
            standard_c[6] = year[0];
            standard_c[7] = year[1];
            standard_c[8] = year[2];
            standard_c[9] = year[3];
            string str_date = new string(standard_c);
            return str_date;
        }

        private string convertToCharArray_2(char day, char[] month, char[] year)
        {
            char[] standard_c = new char[10];
            standard_c[0] = '0';
            standard_c[1] = day;
            standard_c[2] = '/';
            standard_c[3] = month[0];
            standard_c[4] = month[1];
            standard_c[5] = '/';
            standard_c[6] = year[0];
            standard_c[7] = year[1];
            standard_c[8] = year[2];
            standard_c[9] = year[3];
            string str_date = new string(standard_c);
            return str_date;
        }

        private string convertToCharArray_3(char[] day, char month, char[] year)
        {
            char[] standard_c = new char[10];
            standard_c[0] = day[0];
            standard_c[1] = day[1];
            standard_c[2] = '/';
            standard_c[3] = '0';
            standard_c[4] = month;
            standard_c[5] = '/';
            standard_c[6] = year[0];
            standard_c[7] = year[1];
            standard_c[8] = year[2];
            standard_c[9] = year[3];
            string str_date = new string(standard_c);
            return str_date;
        }
        private void btn_adjust_Click(object sender, EventArgs e)
        {
            // Get value 
            string id = _index;
            string idm = _idm;
            string ide = _ide;
            string major = combo_major.GetItemText(combo_major.SelectedItem);
            string idhs = tb_id.Text;
            string name = tb_name.Text;
            string birthyear = tb_birth_year.Text;
            string gender = combo_gender.GetItemText(combo_gender.SelectedItem);
            string addr = tb_addr.Text;
            string phone = tb_phone.Text;
            //string temp_date = tb_date.Text;
            if(idhs == "")
            {
                MessageBox.Show("Cần có mã hồ sơ!", "Lỗi");
                return;
            }
            if (tb_date.Text == "" || tb_date.Text.IndexOf("/") == -1)
            {
                MessageBox.Show("Cần nhập đúng ngày khám: dd/MM/yyyy!", "Lỗi");
                return;
            }
            string standard_date = executeStringDate(tb_date.Text);
            string date = DateTime.ParseExact(standard_date, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy");
            
            string year = Convert.ToString(DateTime.Today.Year);
            char o = date[6];
            char t = date[7];
            char th = date[8];
            char f = date[9];
            char[] ch = new char[4];
            ch[0] = o;
            ch[1] = t;
            ch[2] = th;
            ch[3] = f;
            string yearc = new string(ch);
            string note = tb_note.Text;

            int isDate = DateTime.Compare(DateTime.ParseExact(standard_date, "dd/MM/yyyy", CultureInfo.InvariantCulture), DateTime.Today);
            if (isDate > 0)
            {
                MessageBox.Show("Ngày khám phải nhỏ hơn ngày hiện tại!", "Lỗi");
                return;
            }
            
            if (birthyear == "" || !checkNumber(birthyear))
            {
                birthyear = Convert.ToString(0);
            }

            if(Convert.ToInt32(birthyear) > DateTime.Today.Year)
            {
                MessageBox.Show("Năm sinh phải nhỏ hơn năm hiện hành!", "Lỗi");
                return;
            }

            using (SqlConnection Con = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["QLPKConnectionString"].ToString()))
            {
                Con.Open();
                string query = "select idPatient from CodeExamination where (profileCode = N'" + idhs + "' and idPatient <>" + id + " and yearCheckup = " + year + ") or (profileCode = N'" + idhs + "' and idPatient =" + id + " and typeCheckup <> N'"+ major + "')";
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
                string query = "update PatientInformation set name = N'" + name + "', birthyear = " + birthyear + ", gender = N'" + gender + "', address1 = N'" + addr + "', phonenumber = '" + phone + "', note = N'" + note + "' where ID = " + id;
                Console.WriteLine(query);

                SqlCommand cmdP = new SqlCommand(query, Con);
                var resP = cmdP.ExecuteNonQuery();
                if (resP != null && (int)resP == 1)
                {
                    Console.WriteLine("update P: " + ((Int32)resP).ToString());
                    string q = "update MedicalExamination set dateCheckup = '" + date + "', typeCheckup = N'" + major + "' where idPatient = " + id + " and ID = " + idm;
                    SqlCommand cmdM = new SqlCommand(q, Con);
                    var resM = cmdM.ExecuteNonQuery();
                    if (resM != null && (int)resM == 1)
                    {
                        string qe = "update CodeExamination set profileCode = N'" + idhs + "',idPatient = " + id + ",typeCheckup = N'" + major + "',yearCheckup = " + yearc + " where ID = "  + ide ;
                        SqlCommand cmdE = new SqlCommand(qe, Con);
                        var resE = cmdE.ExecuteNonQuery();
                        if (resE != null && (int)resE == 1)
                        {
                            MessageBox.Show("Cập nhật thành công!", "Cập nhật");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thất bại!", "Cập nhật");
                        }
                    }     
                    else
                        MessageBox.Show("Cập nhật thất bại!", "Cập nhật");
                }
                else
                    MessageBox.Show("Cập nhật thất bại!", "Cập nhật");
                Con.Close();
            }
            this.Close();
         }

        private void combo_major_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
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
                //SendKeys.Send("{TAB}");
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
                e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tb_date_KeyDown(object sender, KeyEventArgs e)
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
                //SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private bool checkNumber(string str)
        {
            int n;
            bool isNumeric = int.TryParse(str, out n);
            return isNumeric;
        }
    }
}
