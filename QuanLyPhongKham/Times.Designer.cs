namespace QuanLyPhongKham
{
    partial class TimesForm
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
            this.combo_major = new System.Windows.Forms.ComboBox();
            this.lb_major = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_readd = new System.Windows.Forms.Button();
            this.lb_id = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
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
            this.combo_major.Location = new System.Drawing.Point(172, 12);
            this.combo_major.MaxDropDownItems = 3;
            this.combo_major.Name = "combo_major";
            this.combo_major.Size = new System.Drawing.Size(147, 28);
            this.combo_major.TabIndex = 1;
            this.combo_major.KeyDown += new System.Windows.Forms.KeyEventHandler(this.combo_major_KeyDown);
            // 
            // lb_major
            // 
            this.lb_major.AutoSize = true;
            this.lb_major.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_major.Location = new System.Drawing.Point(58, 15);
            this.lb_major.Name = "lb_major";
            this.lb_major.Size = new System.Drawing.Size(113, 20);
            this.lb_major.TabIndex = 28;
            this.lb_major.Text = "Chuyên khoa";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(228, 111);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(91, 34);
            this.btn_cancel.TabIndex = 58;
            this.btn_cancel.Text = "Thoát";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_readd
            // 
            this.btn_readd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_readd.Location = new System.Drawing.Point(80, 111);
            this.btn_readd.Name = "btn_readd";
            this.btn_readd.Size = new System.Drawing.Size(91, 34);
            this.btn_readd.TabIndex = 57;
            this.btn_readd.Text = "Thêm";
            this.btn_readd.UseVisualStyleBackColor = true;
            this.btn_readd.Click += new System.EventHandler(this.btn_readd_Click);
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_id.Location = new System.Drawing.Point(58, 59);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(63, 20);
            this.lb_id.TabIndex = 59;
            this.lb_id.Text = "Mã HS";
            // 
            // tb_id
            // 
            this.tb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id.Location = new System.Drawing.Point(172, 56);
            this.tb_id.Multiline = true;
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(147, 30);
            this.tb_id.TabIndex = 2;
            this.tb_id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_id_KeyDown);
            // 
            // TimesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 163);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_readd);
            this.Controls.Add(this.combo_major);
            this.Controls.Add(this.lb_major);
            this.Name = "TimesForm";
            this.Text = "Thêm lần khám";
            this.Load += new System.EventHandler(this.TimesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_major;
        private System.Windows.Forms.Label lb_major;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_readd;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.TextBox tb_id;
    }
}