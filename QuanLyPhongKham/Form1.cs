using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongKham
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int index = -1;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            setCurrentDate();
            
        }
        

        private void setCurrentDate()
        {
            DateTime today = DateTime.Today;
            
            string day = Convert.ToString(today.Day);
            string month = Convert.ToString(today.Month);
            string year = Convert.ToString(today.Year);
            tb_day.Text = day;
            tb_month.Text = month;
            tb_year.Text = year;
            
        }
        
        private Point scalePoint(int x, int y)
        {
            Size st = this.Size;
            int height = st.Height;
            int width = st.Width;

            double x_ratio = this.Width*1.0 / 755;
            double y_ratio = this.Height*1.0 / 480;
            int new_x = (int)((double)x * x_ratio);
            int new_y = (int)((double)y * y_ratio);
            //Console.WriteLine(x*x_ratio);
            //Console.WriteLine(new_x.ToString());
            return new Point(new_x, new_y);
        }

        private void btn_load_Click_1(object sender, EventArgs e)
        {
            string[] date = getDateFromTextBox(this.tb_day, this.tb_month, this.tb_year);
            SearchManagement searchManagement = new SearchManagement();
            showResult(dataView, searchManagement.find(date));
        }

        private void showResult(DataGridView dataView, DataTable dttb)
        {
            dataView.DataSource = dttb;
            adjustDataView(dataView);
            if ((int)dataView.RowCount == 0)
            {
               MessageBox.Show("Không có dữ liệu!", "Thông báo");
               return;
            }
        }

        private void adjustDataView(DataGridView dataView)
        {
            dataView.Columns["ID"].Visible = false;
            dataView.Columns["idm"].Visible = false;
            dataView.Columns["ide"].Visible = false;
            setDataViewColumnWidth(dataView);
        }

        private void setDataViewColumnWidth(DataGridView dataView)
        {
            dataView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //this.data_view.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataView.Columns[4].Width = 50;
            //this.data_view.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataView.Columns[5].Width = 50;
            //this.data_view.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataView.Columns[6].Width = 300;
            dataView.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataView.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataView.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private string[] getDateFromTextBox(TextBox tbDay, TextBox tbMonth, TextBox tbYear)
        {
            return new string[]
            {
                tbDay.Text,
                tbMonth.Text,
                tbYear.Text
            };
        }

        
        private int getIntDay(string strday)
        {
            bool day_check = checkNumber(strday);
            
            if(day_check == true && strday.Length <= 2)
            {
                return Convert.ToInt32(strday);
            }
            return -1;
        }

        private int getIntMonth(string strmonth)
        {
            bool month_check = checkNumber(strmonth);
            if (month_check == true && strmonth.Length <= 2)
            {
                return Convert.ToInt32(strmonth);
            }
            //MessageBox.Show("Tháng phải là giá trị số và có 2 giá trị!!!", "Lỗi");
            return -1;
        }

        private int getIntYear(string stryear)
        {
            bool year_check = checkNumber(stryear);
            if (year_check == true && stryear.Length == 4)
            {
                return Convert.ToInt32(stryear);
            }
            return -1;
        }

        private bool checkNumber(string str)
        {
            int n;
            bool isNumeric = int.TryParse(str, out n);
            return isNumeric;
        }

        private void btn_insert_Click_1(object sender, EventArgs e)
        {
           
            Form insertForm = new InsertForm();
            insertForm.TopMost = true;
            insertForm.Show();

        }
        
        private void data_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            btn_update.Enabled = true;
            index = e.RowIndex;
            if (index < 0)
            {
                tb_id.Text = "";
                tb_name.Text = "";
                tb_birthyear.Text = "";
                combo_gender.Text = "";
                tb_addr.Text = "";
                tb_phone.Text = "";
                tb_date.Text = "";
                combo_major.Text = "";
                return;
            }

            DataGridViewRow row = data_view.Rows[index];

            tb_id.Text = row.Cells[1].Value.ToString();
            tb_name.Text = row.Cells[2].Value.ToString();
            int temp_birthyear = (int)row.Cells[3].Value;
            tb_birthyear.Text = temp_birthyear.ToString();
            combo_gender.Text = row.Cells[4].Value.ToString();
            tb_addr.Text = row.Cells[5].Value.ToString();
            tb_phone.Text = row.Cells[6].Value.ToString();
            tb_date.Text = Convert.ToString(row.Cells[7].Value);
            //date = DateTime.ParseExact(date, "MM/dd/yyyy", CultureInfo.InvariantCulture).ToString("dd/MM/yyyy");
            //tb_date.Text = date;
            //Console.WriteLine(date);
            combo_major.Text = row.Cells[8].Value.ToString();
            */
        }
        
        private void btn_search_Click(object sender, EventArgs e)
        {
            SearchManagement searchManagement = new SearchManagement();
            showResult(dataView, searchManagement.find(new string[] { tb_search.Text }));
        }
        

        bool searchString(string pat, string txt)
        {
            int M = pat.Length;
            int N = txt.Length;

            // create lps[] that will hold the longest 
            // prefix suffix values for pattern 
            int[] lps = new int[M];
            int j = 0; // index for pat[] 

            // Preprocess the pattern (calculate lps[] 
            // array) 
            computeLPSArray(pat, M, lps);

            int i = 0; // index for txt[] 
            while (i < N)
            {
                if (pat[j] == txt[i])
                {
                    j++;
                    i++;
                }
                if (j == M)
                {
                    //Console.Write("Found pattern "+ "at index " + (i - j));
                    return true;
                    j = lps[j - 1];
                }

                // mismatch after j matches 
                else if (i < N && pat[j] != txt[i])
                {
                    // Do not match lps[0..lps[j-1]] characters, 
                    // they will match anyway 
                    if (j != 0)
                        j = lps[j - 1];
                    else
                        i = i + 1;
                }
            }
            return false;
        }

        void computeLPSArray(string pat, int M, int[] lps)
        {
            // length of the previous longest prefix suffix 
            int len = 0;
            int i = 1;
            lps[0] = 0; // lps[0] is always 0 

            // the loop calculates lps[i] for i = 1 to M-1 
            while (i < M)
            {
                if (pat[i] == pat[len])
                {
                    len++;
                    lps[i] = len;
                    i++;
                }
                else // (pat[i] != pat[len]) 
                {
                    // This is tricky. Consider the example. 
                    // AAACAAAA and i = 7. The idea is similar 
                    // to search step. 
                    if (len != 0)
                    {
                        len = lps[len - 1];

                        // Also, note that we do not increment 
                        // i here 
                    }
                    else // if (len == 0) 
                    {
                        lps[i] = len;
                        i++;
                    }
                }
            }
        }
        /*
        private void btn_del_all_Click(object sender, EventArgs e)
        {
            string query = "";
            int day = getIntDay(this.tb_day.Text);
            int month = getIntMonth(this.tb_month.Text);
            int year = getIntYear(this.tb_year.Text);

            bool checkDay = day != -1;
            bool checkMon = month != -1;
            bool checkYear = year != -1;


            if (checkYear)
            {
                if (checkMon)
                {
                    if (checkDay)
                    {
                        query = "delete  from MedicalExamination  where year(dateCheckup) = " + year.ToString() + " and month(dateCheckup) = " + month.ToString() + " and day(dateCheckup) = " + day.ToString() + "; delete  from PatientInformation  where ID not in (select idPatient from MedicalExamination) ";
                    }
                    else
                    {
                        //Show data follow Year, Month
                        query = "delete  from MedicalExamination  where year(dateCheckup) = " + year.ToString() + " and month(dateCheckup) = " + month.ToString() +  "; delete  from PatientInformation  where ID not in (select idPatient from MedicalExamination) ";
                    }
                }
                else
                {
                    query = "delete from MedicalExamination where year(dateCheckup) = " + year.ToString() + "; delete  from PatientInformation where ID not in (select idPatient from MedicalExamination) ";

                }
            }
            else
            {
                MessageBox.Show("Cần nhập giá trị số ngày tháng năm để xóa!", "Lỗi");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu này?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                using (SqlConnection Con = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["QLPKConnectionString"].ToString()))
                {
                    Con.Open();
                    //string query = "delete from MedicalExamination; delete from PatientInformation";
                    Console.WriteLine(query);
                    SqlCommand cmdP = new SqlCommand(query, Con);
                    var resP = cmdP.ExecuteNonQuery();
                    if (resP != null & (int)resP > 0)
                    {
                        index = -1;
                        
                        removeDataGridViewRow();
                        MessageBox.Show("Xóa dữ liệu thành công!", "Xóa");

                    }
                    else
                        MessageBox.Show("Xóa dữ liệu thất bại!", "Xóa");
                    Con.Close();
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }

            
        }*/

        private void removeDataGridViewRow()
        {
            for (int i = 0; i < dataView.RowCount; i++)
                dataView.Rows.RemoveAt(i);
            //data_view.Refresh();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn xóa dữ liệu này?", "Thông báo", MessageBoxButtons.YesNo);
            index = dataView.CurrentCell.RowIndex;
            //Console.WriteLine("Index del: " + index.ToString());
            if (dialogResult == DialogResult.Yes && index >= 0)
            {
                DataGridViewRow newDataRow = dataView.Rows[index];

                string id = newDataRow.Cells[0].Value.ToString();
                string idm = newDataRow.Cells[10].Value.ToString();
                char[] ch = new char[5];
                ch[0] = newDataRow.Cells[8].Value.ToString()[6];
                ch[1] = newDataRow.Cells[8].Value.ToString()[7];
                ch[2] = newDataRow.Cells[8].Value.ToString()[8];
                ch[3] = newDataRow.Cells[8].Value.ToString()[9];
                string year = new string(ch);
                using (SqlConnection Con = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["QLPKConnectionString"].ToString()))
                {
                    Con.Open();
                    string query = "delete from MedicalExamination where ID = " + idm + "; delete  from PatientInformation  where ID not in (select idPatient from MedicalExamination); delete from CodeExamination where idPatient not in (select ID from PatientInformation) or (typeCheckup not in (select typeCheckup from MedicalExamination where idPatient = " + id + " and year(dateCheckup) = " + year + ") and idPatient = " + id + " and yearCheckup = " + year + "); delete  from MedicalExamination  where idPatient not in (select ID from PatientInformation);";
                    Console.WriteLine(query);
                    SqlCommand cmdP = new SqlCommand(query, Con);
                    var resP = cmdP.ExecuteNonQuery();
                    if (resP != null & (int)resP >= 1)
                    {
                        MessageBox.Show("Đã xóa thành công!", "Thông báo");
                        dataView.Rows.RemoveAt(index);
                        index = -1;
                    }
                    else
                        MessageBox.Show("Yêu cầu xóa thất bại!", "Thông báo");
                    Con.Close();
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }
        
        private void data_view_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewCell currentCell = (sender as DataGridView).CurrentCell;
            if (e.Button == MouseButtons.Right)
            {
                var relativeMousePosition = this.dataView.PointToClient(Cursor.Position);
                this.menu_adjust_readd.Show(this.dataView, relativeMousePosition);
                index = e.RowIndex;
            }
            
        }

        private void AdjustToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            string[] information;
            /*Format of the array: id, chuyên khoa, số hs, họ tên, năm sinh, giới tính, địa chỉ, sđt, ngày khám, ghi chú */
            information = getCurrentRow();
            //Console.WriteLine(information[10]);
            
            Form adjustForm = new AdjustForm(information);
            adjustForm.TopMost = true;
            adjustForm.Show();
            
            
        }

        private bool isFormOpen(Type formType)
        {
            foreach (Form form in Application.OpenForms)
                if (form.GetType().Name == form.Name)
                    return true;
            return false;
        }

        private string[] getCurrentRow()
        {
            string[] arr = new string[12];
            DataGridViewRow row = dataView.Rows[index];
            string id = row.Cells[0].Value.ToString();
            arr[0] = id;
            string major = row.Cells[1].Value.ToString();
            arr[1] = major;
            string idhs = row.Cells[2].Value.ToString();
            arr[2] = idhs;
            string name = row.Cells[3].Value.ToString();
            arr[3] = name;
            int temp_birthyear = (int)row.Cells[4].Value;
            string birth_year = temp_birthyear.ToString();
            arr[4] = birth_year;
            string gender = row.Cells[5].Value.ToString();
            arr[5] = gender;
            string addr = row.Cells[6].Value.ToString();
            arr[6] = addr;
            string phone = row.Cells[7].Value.ToString();
            arr[7] = phone;
            string medi_date = Convert.ToString(row.Cells[8].Value);
            arr[8] = medi_date;
            string note = row.Cells[9].Value.ToString();
            arr[9] = note;
            string idm = row.Cells[10].Value.ToString();
            arr[10] = idm;
            string ide = row.Cells[11].Value.ToString();
            arr[11] = ide;
            return arr;
        }
        
        private void readdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] information;
            /*Format of the array: id, chuyên khoa, số hs, họ tên, năm sinh, giới tính, địa chỉ, sđt, ngày khám, ghi chú */
            information = getCurrentRow();
            //Console.WriteLine(information[10]);

            Form readdForm = new ReaddForm(information);
            readdForm.TopMost = true;
            readdForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] date = getDateFromTextBox(this.tb_del_day, this.tb_del_month, this.tb_del_year);
            SearchManagement searchManagement = new SearchManagement();
            showResult(dataGridView_del, searchManagement.find(date));
        }


        private void btn_del_all_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn xóa dữ liệu này?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow newDataRow in dataGridView_del.Rows)
                {
                    string id = newDataRow.Cells[0].Value.ToString();
                    string idm = newDataRow.Cells[10].Value.ToString();
                    string year = tb_del_year.Text.ToString();
                    using (SqlConnection Con = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["QLPKConnectionString"].ToString()))
                    {
                        Con.Open();
                        string query = "delete from MedicalExamination where ID = " + idm + "; delete  from PatientInformation where ID not in (select idPatient from MedicalExamination); delete from CodeExamination where idPatient not in (select ID from PatientInformation) or (typeCheckup not in (select typeCheckup from MedicalExamination where idPatient = " + id +" and year(dateCheckup) = " + year + ") and idPatient = " + id +" and yearCheckup = "+ year+"); delete  from MedicalExamination  where idPatient not in (select ID from PatientInformation);";// or (yearCheckup = " + year + ");";
                        //Console.WriteLine(query);
                        SqlCommand cmdP = new SqlCommand(query, Con);
                        var resP = cmdP.ExecuteNonQuery();
                        if (resP != null & (int)resP >= 1)
                        {
                            //MessageBox.Show("Đã xóa thành công!", "Thông báo");
                            //data_view.Rows.RemoveAt(index);
                        }
                        else
                            //MessageBox.Show("Yêu cầu xóa thất bại!", "Thông báo");
                        Con.Close();
                    }

                }
                dataGridView_del.DataSource = null;
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void tb_del_day_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                //SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tb_del_month_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                //SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tb_del_year_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                //SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tb_day_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                //SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tb_month_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                //SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tb_year_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                //SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
    }
}
