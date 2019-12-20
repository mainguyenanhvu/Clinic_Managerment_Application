namespace QuanLyPhongKham
{
    partial class ReaddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_note = new System.Windows.Forms.Label();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.lb_phone = new System.Windows.Forms.Label();
            this.tb_birth_year = new System.Windows.Forms.TextBox();
            this.lb_birth_year = new System.Windows.Forms.Label();
            this.tb_addr = new System.Windows.Forms.TextBox();
            this.lb_addr = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.combo_gender = new System.Windows.Forms.ComboBox();
            this.lb_gender = new System.Windows.Forms.Label();
            this.tb_note = new System.Windows.Forms.TextBox();
            this.dataGridView_Ex = new System.Windows.Forms.DataGridView();
            this.lb_medi_times = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_readd = new System.Windows.Forms.Button();
            this.btn_reload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ex)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_note
            // 
            this.lb_note.AutoSize = true;
            this.lb_note.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_note.Location = new System.Drawing.Point(13, 181);
            this.lb_note.Name = "lb_note";
            this.lb_note.Size = new System.Drawing.Size(71, 20);
            this.lb_note.TabIndex = 50;
            this.lb_note.Text = "Ghi chú";
            // 
            // tb_phone
            // 
            this.tb_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_phone.Location = new System.Drawing.Point(542, 79);
            this.tb_phone.Multiline = true;
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(148, 30);
            this.tb_phone.TabIndex = 4;
            // 
            // lb_phone
            // 
            this.lb_phone.AutoSize = true;
            this.lb_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_phone.Location = new System.Drawing.Point(444, 79);
            this.lb_phone.Name = "lb_phone";
            this.lb_phone.Size = new System.Drawing.Size(44, 20);
            this.lb_phone.TabIndex = 48;
            this.lb_phone.Text = "SĐT";
            // 
            // tb_birth_year
            // 
            this.tb_birth_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_birth_year.Location = new System.Drawing.Point(542, 26);
            this.tb_birth_year.Multiline = true;
            this.tb_birth_year.Name = "tb_birth_year";
            this.tb_birth_year.Size = new System.Drawing.Size(99, 30);
            this.tb_birth_year.TabIndex = 2;
            // 
            // lb_birth_year
            // 
            this.lb_birth_year.AutoSize = true;
            this.lb_birth_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_birth_year.Location = new System.Drawing.Point(444, 29);
            this.lb_birth_year.Name = "lb_birth_year";
            this.lb_birth_year.Size = new System.Drawing.Size(83, 20);
            this.lb_birth_year.TabIndex = 46;
            this.lb_birth_year.Text = "Năm sinh";
            // 
            // tb_addr
            // 
            this.tb_addr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_addr.Location = new System.Drawing.Point(124, 127);
            this.tb_addr.Multiline = true;
            this.tb_addr.Name = "tb_addr";
            this.tb_addr.Size = new System.Drawing.Size(297, 30);
            this.tb_addr.TabIndex = 5;
            // 
            // lb_addr
            // 
            this.lb_addr.AutoSize = true;
            this.lb_addr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_addr.Location = new System.Drawing.Point(13, 130);
            this.lb_addr.Name = "lb_addr";
            this.lb_addr.Size = new System.Drawing.Size(64, 20);
            this.lb_addr.TabIndex = 45;
            this.lb_addr.Text = "Địa chỉ";
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(124, 26);
            this.tb_name.Multiline = true;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(297, 30);
            this.tb_name.TabIndex = 1;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(13, 33);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(63, 20);
            this.lb_name.TabIndex = 43;
            this.lb_name.Text = "Họ tên";
            // 
            // combo_gender
            // 
            this.combo_gender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combo_gender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_gender.FormattingEnabled = true;
            this.combo_gender.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.combo_gender.Location = new System.Drawing.Point(124, 79);
            this.combo_gender.MaxDropDownItems = 3;
            this.combo_gender.Name = "combo_gender";
            this.combo_gender.Size = new System.Drawing.Size(89, 28);
            this.combo_gender.TabIndex = 3;
            // 
            // lb_gender
            // 
            this.lb_gender.AutoSize = true;
            this.lb_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gender.Location = new System.Drawing.Point(13, 82);
            this.lb_gender.Name = "lb_gender";
            this.lb_gender.Size = new System.Drawing.Size(76, 20);
            this.lb_gender.TabIndex = 40;
            this.lb_gender.Text = "Giới tính";
            // 
            // tb_note
            // 
            this.tb_note.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_note.Location = new System.Drawing.Point(124, 178);
            this.tb_note.Multiline = true;
            this.tb_note.Name = "tb_note";
            this.tb_note.Size = new System.Drawing.Size(297, 30);
            this.tb_note.TabIndex = 6;
            // 
            // dataGridView_Ex
            // 
            this.dataGridView_Ex.AllowUserToAddRows = false;
            this.dataGridView_Ex.AllowUserToDeleteRows = false;
            this.dataGridView_Ex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Ex.Location = new System.Drawing.Point(124, 224);
            this.dataGridView_Ex.Name = "dataGridView_Ex";
            this.dataGridView_Ex.ReadOnly = true;
            this.dataGridView_Ex.Size = new System.Drawing.Size(468, 139);
            this.dataGridView_Ex.TabIndex = 7;
            // 
            // lb_medi_times
            // 
            this.lb_medi_times.AutoSize = true;
            this.lb_medi_times.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_medi_times.Location = new System.Drawing.Point(13, 224);
            this.lb_medi_times.Name = "lb_medi_times";
            this.lb_medi_times.Size = new System.Drawing.Size(108, 20);
            this.lb_medi_times.TabIndex = 54;
            this.lb_medi_times.Text = "Số lần khám";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(484, 383);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(126, 46);
            this.btn_cancel.TabIndex = 10;
            this.btn_cancel.Text = "Thoát";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_readd
            // 
            this.btn_readd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_readd.Location = new System.Drawing.Point(295, 383);
            this.btn_readd.Name = "btn_readd";
            this.btn_readd.Size = new System.Drawing.Size(126, 46);
            this.btn_readd.TabIndex = 9;
            this.btn_readd.Text = "Thêm";
            this.btn_readd.UseVisualStyleBackColor = true;
            this.btn_readd.Click += new System.EventHandler(this.btn_readd_Click);
            // 
            // btn_reload
            // 
            this.btn_reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reload.Location = new System.Drawing.Point(111, 383);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(126, 46);
            this.btn_reload.TabIndex = 8;
            this.btn_reload.Text = "Xem";
            this.btn_reload.UseVisualStyleBackColor = true;
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // ReaddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.btn_reload);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_readd);
            this.Controls.Add(this.lb_medi_times);
            this.Controls.Add(this.dataGridView_Ex);
            this.Controls.Add(this.lb_note);
            this.Controls.Add(this.tb_phone);
            this.Controls.Add(this.lb_phone);
            this.Controls.Add(this.tb_birth_year);
            this.Controls.Add(this.lb_birth_year);
            this.Controls.Add(this.tb_addr);
            this.Controls.Add(this.lb_addr);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.combo_gender);
            this.Controls.Add(this.lb_gender);
            this.Controls.Add(this.tb_note);
            this.Name = "ReaddForm";
            this.Text = "ReaddForm";
            this.Load += new System.EventHandler(this.ReaddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_note;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.Label lb_phone;
        private System.Windows.Forms.TextBox tb_birth_year;
        private System.Windows.Forms.Label lb_birth_year;
        private System.Windows.Forms.TextBox tb_addr;
        private System.Windows.Forms.Label lb_addr;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.ComboBox combo_gender;
        private System.Windows.Forms.Label lb_gender;
        private System.Windows.Forms.TextBox tb_note;
        private System.Windows.Forms.DataGridView dataGridView_Ex;
        private System.Windows.Forms.Label lb_medi_times;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_readd;
        private System.Windows.Forms.Button btn_reload;
    }
}