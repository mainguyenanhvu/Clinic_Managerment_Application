namespace QuanLyPhongKham
{
    partial class AdjustForm
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
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_adjust = new System.Windows.Forms.Button();
            this.combo_major = new System.Windows.Forms.ComboBox();
            this.lb_phone = new System.Windows.Forms.Label();
            this.tb_birth_year = new System.Windows.Forms.TextBox();
            this.lb_birth_year = new System.Windows.Forms.Label();
            this.tb_addr = new System.Windows.Forms.TextBox();
            this.lb_addr = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.combo_gender = new System.Windows.Forms.ComboBox();
            this.lb_gender = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.lb_id = new System.Windows.Forms.Label();
            this.tb_note = new System.Windows.Forms.TextBox();
            this.lb_major = new System.Windows.Forms.Label();
            this.lb_date = new System.Windows.Forms.Label();
            this.tb_date = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_note
            // 
            this.lb_note.AutoSize = true;
            this.lb_note.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_note.Location = new System.Drawing.Point(15, 224);
            this.lb_note.Name = "lb_note";
            this.lb_note.Size = new System.Drawing.Size(71, 20);
            this.lb_note.TabIndex = 32;
            this.lb_note.Text = "Ghi chú";
            // 
            // tb_phone
            // 
            this.tb_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_phone.Location = new System.Drawing.Point(544, 170);
            this.tb_phone.Multiline = true;
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(148, 30);
            this.tb_phone.TabIndex = 8;
            this.tb_phone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_phone_KeyDown);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(403, 272);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(126, 46);
            this.btn_cancel.TabIndex = 11;
            this.btn_cancel.Text = "Thoát";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_adjust
            // 
            this.btn_adjust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adjust.Location = new System.Drawing.Point(183, 272);
            this.btn_adjust.Name = "btn_adjust";
            this.btn_adjust.Size = new System.Drawing.Size(126, 46);
            this.btn_adjust.TabIndex = 10;
            this.btn_adjust.Text = "Cập nhật";
            this.btn_adjust.UseVisualStyleBackColor = true;
            this.btn_adjust.Click += new System.EventHandler(this.btn_adjust_Click);
            // 
            // combo_major
            // 
            this.combo_major.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combo_major.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_major.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_major.FormattingEnabled = true;
            this.combo_major.Items.AddRange(new object[] {
            "Mắt",
            "Cột sống"});
            this.combo_major.Location = new System.Drawing.Point(126, 24);
            this.combo_major.MaxDropDownItems = 3;
            this.combo_major.Name = "combo_major";
            this.combo_major.Size = new System.Drawing.Size(147, 28);
            this.combo_major.TabIndex = 1;
            this.combo_major.KeyDown += new System.Windows.Forms.KeyEventHandler(this.combo_major_KeyDown);
            // 
            // lb_phone
            // 
            this.lb_phone.AutoSize = true;
            this.lb_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_phone.Location = new System.Drawing.Point(446, 173);
            this.lb_phone.Name = "lb_phone";
            this.lb_phone.Size = new System.Drawing.Size(44, 20);
            this.lb_phone.TabIndex = 29;
            this.lb_phone.Text = "SĐT";
            // 
            // tb_birth_year
            // 
            this.tb_birth_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_birth_year.Location = new System.Drawing.Point(544, 69);
            this.tb_birth_year.Multiline = true;
            this.tb_birth_year.Name = "tb_birth_year";
            this.tb_birth_year.Size = new System.Drawing.Size(148, 30);
            this.tb_birth_year.TabIndex = 4;
            this.tb_birth_year.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_birth_year_KeyDown);
            // 
            // lb_birth_year
            // 
            this.lb_birth_year.AutoSize = true;
            this.lb_birth_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_birth_year.Location = new System.Drawing.Point(446, 72);
            this.lb_birth_year.Name = "lb_birth_year";
            this.lb_birth_year.Size = new System.Drawing.Size(83, 20);
            this.lb_birth_year.TabIndex = 26;
            this.lb_birth_year.Text = "Năm sinh";
            // 
            // tb_addr
            // 
            this.tb_addr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_addr.Location = new System.Drawing.Point(126, 170);
            this.tb_addr.Multiline = true;
            this.tb_addr.Name = "tb_addr";
            this.tb_addr.Size = new System.Drawing.Size(297, 30);
            this.tb_addr.TabIndex = 7;
            this.tb_addr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_addr_KeyDown);
            // 
            // lb_addr
            // 
            this.lb_addr.AutoSize = true;
            this.lb_addr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_addr.Location = new System.Drawing.Point(15, 173);
            this.lb_addr.Name = "lb_addr";
            this.lb_addr.Size = new System.Drawing.Size(64, 20);
            this.lb_addr.TabIndex = 25;
            this.lb_addr.Text = "Địa chỉ";
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(126, 69);
            this.tb_name.Multiline = true;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(297, 30);
            this.tb_name.TabIndex = 3;
            this.tb_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_name_KeyDown);
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(15, 76);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(63, 20);
            this.lb_name.TabIndex = 23;
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
            this.combo_gender.Location = new System.Drawing.Point(126, 122);
            this.combo_gender.MaxDropDownItems = 3;
            this.combo_gender.Name = "combo_gender";
            this.combo_gender.Size = new System.Drawing.Size(89, 28);
            this.combo_gender.TabIndex = 5;
            this.combo_gender.KeyDown += new System.Windows.Forms.KeyEventHandler(this.combo_gender_KeyDown);
            // 
            // lb_gender
            // 
            this.lb_gender.AutoSize = true;
            this.lb_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gender.Location = new System.Drawing.Point(15, 125);
            this.lb_gender.Name = "lb_gender";
            this.lb_gender.Size = new System.Drawing.Size(76, 20);
            this.lb_gender.TabIndex = 20;
            this.lb_gender.Text = "Giới tính";
            // 
            // tb_id
            // 
            this.tb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id.Location = new System.Drawing.Point(544, 22);
            this.tb_id.Multiline = true;
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(148, 30);
            this.tb_id.TabIndex = 2;
            this.tb_id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_id_KeyDown);
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_id.Location = new System.Drawing.Point(446, 27);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(82, 20);
            this.lb_id.TabIndex = 17;
            this.lb_id.Text = "Mã hồ sơ";
            // 
            // tb_note
            // 
            this.tb_note.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_note.Location = new System.Drawing.Point(126, 221);
            this.tb_note.Multiline = true;
            this.tb_note.Name = "tb_note";
            this.tb_note.Size = new System.Drawing.Size(297, 30);
            this.tb_note.TabIndex = 9;
            this.tb_note.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_note_KeyDown);
            // 
            // lb_major
            // 
            this.lb_major.AutoSize = true;
            this.lb_major.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_major.Location = new System.Drawing.Point(12, 27);
            this.lb_major.Name = "lb_major";
            this.lb_major.Size = new System.Drawing.Size(113, 20);
            this.lb_major.TabIndex = 15;
            this.lb_major.Text = "Chuyên khoa";
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_date.Location = new System.Drawing.Point(446, 122);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(97, 20);
            this.lb_date.TabIndex = 33;
            this.lb_date.Text = "Ngày khám";
            // 
            // tb_date
            // 
            this.tb_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_date.Location = new System.Drawing.Point(544, 115);
            this.tb_date.Multiline = true;
            this.tb_date.Name = "tb_date";
            this.tb_date.Size = new System.Drawing.Size(148, 30);
            this.tb_date.TabIndex = 6;
            this.tb_date.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_date_KeyDown);
            // 
            // AdjustForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 341);
            this.Controls.Add(this.tb_date);
            this.Controls.Add(this.lb_date);
            this.Controls.Add(this.lb_note);
            this.Controls.Add(this.tb_phone);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_adjust);
            this.Controls.Add(this.combo_major);
            this.Controls.Add(this.lb_phone);
            this.Controls.Add(this.tb_birth_year);
            this.Controls.Add(this.lb_birth_year);
            this.Controls.Add(this.tb_addr);
            this.Controls.Add(this.lb_addr);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.combo_gender);
            this.Controls.Add(this.lb_gender);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.tb_note);
            this.Controls.Add(this.lb_major);
            this.Name = "AdjustForm";
            this.Text = "Adjust";
            this.Load += new System.EventHandler(this.AdjustForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_note;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_adjust;
        private System.Windows.Forms.ComboBox combo_major;
        private System.Windows.Forms.Label lb_phone;
        private System.Windows.Forms.TextBox tb_birth_year;
        private System.Windows.Forms.Label lb_birth_year;
        private System.Windows.Forms.TextBox tb_addr;
        private System.Windows.Forms.Label lb_addr;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.ComboBox combo_gender;
        private System.Windows.Forms.Label lb_gender;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.TextBox tb_note;
        private System.Windows.Forms.Label lb_major;
        private System.Windows.Forms.Label lb_date;
        private System.Windows.Forms.TextBox tb_date;
    }
}