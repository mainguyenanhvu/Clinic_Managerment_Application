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
    public partial class ReaddForm : Form
    {
        string _index;
        string _idm;
        string _ide;
        public ReaddForm(string[] infor)
        {
            InitializeComponent();
            initialize(infor);
        }
        private void initialize(string[] infor)
        {
            _index = infor[0];
            _idm = infor[10];
            _ide = infor[11];
            tb_name.Text = infor[3];
            tb_birth_year.Text = infor[4];
            combo_gender.Text = infor[5];
            tb_addr.Text = infor[6];
            tb_phone.Text = infor[7];
            tb_note.Text = infor[9];
            initializeDatabase();
        }

        private void initializeDatabase()
        {
            using (SqlConnection Con = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["QLPKConnectionString"].ToString()))
            {
                Con.Open();
                string query = "select convert(varchar,m.dateCheckup,103) as 'Ngày khám', m.typeCheckup as 'Chuyên khoa', e.profileCode as 'Mã hồ sơ' from MedicalExamination as m left join CodeExamination as e on (m.idPatient = e.idPatient and m.typeCheckup = e.typeCheckup and year(m.dateCheckup) = e.yearCheckup) where m.idPatient = " + _index;
                Console.WriteLine("query read: " + query);
                SqlDataAdapter sqlDa = new SqlDataAdapter(query, Con);
                if (sqlDa == null)
                {
                    //Khong co du lieu theo yeu cau tim kiem
                    MessageBox.Show("Không có dữ liệu để xem!", "Xem");
                    return;
                }
                Con.Close();
                DataTable dttb = new DataTable();
                sqlDa.Fill(dttb);

                dataGridView_Ex.DataSource = dttb;
                //dataGridView_Ex.Columns["ID"].Visible = false;
                //dataGridView_Ex.Columns["idm"].Visible = false;
                setColumnWidth();
                //dataGridView_Ex.AutoResizeColumns();
                if ((int)dataGridView_Ex.RowCount == 0)
                {
                    MessageBox.Show("Không có dữ liệu", "Thông báo");
                    return;
                }

            }
        }

        private void setColumnWidth()
        {
            //Console.WriteLine(this.dataGridView_Ex.Columns.Count);
            
            this.dataGridView_Ex.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView_Ex.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void ReaddForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            disableEdit();
        }

        private void disableEdit()
        {
            tb_name.ReadOnly = true;
            tb_birth_year.ReadOnly = true;
            tb_addr.ReadOnly = true;
            tb_note.ReadOnly = true;
            tb_phone.ReadOnly = true;
            combo_gender.Enabled = false;
        }

        private void btn_readd_Click(object sender, EventArgs e)
        {
            Console.WriteLine("id: " + _index.ToString());
            Form readdForm = new TimesForm(this, _index,_idm,_ide);
            readdForm.TopMost = true;
            readdForm.Show();
        }
        

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            initializeDatabase();
        }
    }
}
