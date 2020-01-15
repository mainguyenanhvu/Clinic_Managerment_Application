namespace QuanLyPhongKham
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tab_manage = new System.Windows.Forms.TabPage();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.tb_year = new System.Windows.Forms.TextBox();
            this.tb_month = new System.Windows.Forms.TextBox();
            this.tb_day = new System.Windows.Forms.TextBox();
            this.btn_load = new System.Windows.Forms.Button();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.lb_year = new System.Windows.Forms.Label();
            this.lb_month = new System.Windows.Forms.Label();
            this.lb_day = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.lb_slash1 = new System.Windows.Forms.Label();
            this.lb_slash2 = new System.Windows.Forms.Label();
            this.tab = new System.Windows.Forms.TabControl();
            this.tab_del_all = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_del_all = new System.Windows.Forms.Button();
            this.dataGridView_del = new System.Windows.Forms.DataGridView();
            this.tb_del_year = new System.Windows.Forms.TextBox();
            this.tb_del_month = new System.Windows.Forms.TextBox();
            this.tb_del_day = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menu_adjust_readd = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AdjustToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tab_manage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.tab.SuspendLayout();
            this.tab_del_all.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_del)).BeginInit();
            this.menu_adjust_readd.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_manage
            // 
            this.tab_manage.Controls.Add(this.tb_search);
            this.tab_manage.Controls.Add(this.tb_year);
            this.tab_manage.Controls.Add(this.tb_month);
            this.tab_manage.Controls.Add(this.tb_day);
            this.tab_manage.Controls.Add(this.btn_load);
            this.tab_manage.Controls.Add(this.dataView);
            this.tab_manage.Controls.Add(this.lb_year);
            this.tab_manage.Controls.Add(this.lb_month);
            this.tab_manage.Controls.Add(this.lb_day);
            this.tab_manage.Controls.Add(this.btn_search);
            this.tab_manage.Controls.Add(this.btn_del);
            this.tab_manage.Controls.Add(this.btn_insert);
            this.tab_manage.Controls.Add(this.lb_slash1);
            this.tab_manage.Controls.Add(this.lb_slash2);
            this.tab_manage.Location = new System.Drawing.Point(4, 29);
            this.tab_manage.Name = "tab_manage";
            this.tab_manage.Padding = new System.Windows.Forms.Padding(3);
            this.tab_manage.Size = new System.Drawing.Size(835, 475);
            this.tab_manage.TabIndex = 0;
            this.tab_manage.Text = "Quản lý bệnh nhân";
            this.tab_manage.UseVisualStyleBackColor = true;
            // 
            // tb_search
            // 
            this.tb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search.Location = new System.Drawing.Point(389, 22);
            this.tb_search.Multiline = true;
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(255, 28);
            this.tb_search.TabIndex = 22;
            // 
            // tb_year
            // 
            this.tb_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_year.Location = new System.Drawing.Point(203, 24);
            this.tb_year.Multiline = true;
            this.tb_year.Name = "tb_year";
            this.tb_year.Size = new System.Drawing.Size(58, 28);
            this.tb_year.TabIndex = 3;
            this.tb_year.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_year_KeyDown);
            // 
            // tb_month
            // 
            this.tb_month.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_month.Location = new System.Drawing.Point(139, 24);
            this.tb_month.Multiline = true;
            this.tb_month.Name = "tb_month";
            this.tb_month.Size = new System.Drawing.Size(34, 28);
            this.tb_month.TabIndex = 2;
            this.tb_month.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_month_KeyDown);
            // 
            // tb_day
            // 
            this.tb_day.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_day.Location = new System.Drawing.Point(75, 24);
            this.tb_day.Multiline = true;
            this.tb_day.Name = "tb_day";
            this.tb_day.Size = new System.Drawing.Size(34, 28);
            this.tb_day.TabIndex = 1;
            this.tb_day.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_day_KeyDown);
            // 
            // btn_load
            // 
            this.btn_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load.Location = new System.Drawing.Point(354, 74);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(62, 38);
            this.btn_load.TabIndex = 4;
            this.btn_load.Text = "Xem";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click_1);
            // 
            // data_view
            // 
            this.dataView.AllowUserToAddRows = false;
            this.dataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Location = new System.Drawing.Point(0, 118);
            this.dataView.Name = "data_view";
            this.dataView.ReadOnly = true;
            this.dataView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataView.Size = new System.Drawing.Size(861, 357);
            this.dataView.TabIndex = 29;
            this.dataView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.data_view_CellMouseClick);
            // 
            // lb_year
            // 
            this.lb_year.AutoSize = true;
            this.lb_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_year.Location = new System.Drawing.Point(210, 5);
            this.lb_year.Name = "lb_year";
            this.lb_year.Size = new System.Drawing.Size(32, 13);
            this.lb_year.TabIndex = 28;
            this.lb_year.Text = "Năm";
            // 
            // lb_month
            // 
            this.lb_month.AutoSize = true;
            this.lb_month.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_month.Location = new System.Drawing.Point(134, 5);
            this.lb_month.Name = "lb_month";
            this.lb_month.Size = new System.Drawing.Size(43, 13);
            this.lb_month.TabIndex = 27;
            this.lb_month.Text = "Tháng";
            // 
            // lb_day
            // 
            this.lb_day.AutoSize = true;
            this.lb_day.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_day.Location = new System.Drawing.Point(75, 5);
            this.lb_day.Name = "lb_day";
            this.lb_day.Size = new System.Drawing.Size(36, 13);
            this.lb_day.TabIndex = 26;
            this.lb_day.Text = "Ngày";
            // 
            // btn_search
            // 
            this.btn_search.AutoSize = true;
            this.btn_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_search.BackgroundImage")));
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_search.Location = new System.Drawing.Point(673, 19);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(33, 33);
            this.btn_search.TabIndex = 25;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_del
            // 
            this.btn_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del.Location = new System.Drawing.Point(616, 74);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(68, 38);
            this.btn_del.TabIndex = 24;
            this.btn_del.Text = "Xóa";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert.Location = new System.Drawing.Point(446, 74);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(138, 38);
            this.btn_insert.TabIndex = 23;
            this.btn_insert.Text = "Thêm bệnh nhân ";
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click_1);
            // 
            // lb_slash1
            // 
            this.lb_slash1.AutoSize = true;
            this.lb_slash1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_slash1.Location = new System.Drawing.Point(115, 24);
            this.lb_slash1.Name = "lb_slash1";
            this.lb_slash1.Size = new System.Drawing.Size(18, 25);
            this.lb_slash1.TabIndex = 21;
            this.lb_slash1.Text = "/";
            // 
            // lb_slash2
            // 
            this.lb_slash2.AutoSize = true;
            this.lb_slash2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_slash2.Location = new System.Drawing.Point(179, 24);
            this.lb_slash2.Name = "lb_slash2";
            this.lb_slash2.Size = new System.Drawing.Size(18, 25);
            this.lb_slash2.TabIndex = 19;
            this.lb_slash2.Text = "/";
            // 
            // tab
            // 
            this.tab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab.Controls.Add(this.tab_manage);
            this.tab.Controls.Add(this.tab_del_all);
            this.tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab.Location = new System.Drawing.Point(2, 3);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(843, 508);
            this.tab.TabIndex = 0;
            // 
            // tab_del_all
            // 
            this.tab_del_all.Controls.Add(this.button1);
            this.tab_del_all.Controls.Add(this.btn_del_all);
            this.tab_del_all.Controls.Add(this.dataGridView_del);
            this.tab_del_all.Controls.Add(this.tb_del_year);
            this.tab_del_all.Controls.Add(this.tb_del_month);
            this.tab_del_all.Controls.Add(this.tb_del_day);
            this.tab_del_all.Controls.Add(this.label1);
            this.tab_del_all.Controls.Add(this.label2);
            this.tab_del_all.Controls.Add(this.label3);
            this.tab_del_all.Controls.Add(this.label4);
            this.tab_del_all.Controls.Add(this.label5);
            this.tab_del_all.Location = new System.Drawing.Point(4, 29);
            this.tab_del_all.Name = "tab_del_all";
            this.tab_del_all.Size = new System.Drawing.Size(835, 475);
            this.tab_del_all.TabIndex = 1;
            this.tab_del_all.Text = "Xóa tất cả";
            this.tab_del_all.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(338, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 38);
            this.button1.TabIndex = 32;
            this.button1.Text = "Xem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_del_all
            // 
            this.btn_del_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del_all.Location = new System.Drawing.Point(562, 20);
            this.btn_del_all.Name = "btn_del_all";
            this.btn_del_all.Size = new System.Drawing.Size(99, 38);
            this.btn_del_all.TabIndex = 33;
            this.btn_del_all.Text = "Xóa tất cả";
            this.btn_del_all.UseVisualStyleBackColor = true;
            this.btn_del_all.Click += new System.EventHandler(this.btn_del_all_Click);
            // 
            // dataGridView_del
            // 
            this.dataGridView_del.AllowUserToAddRows = false;
            this.dataGridView_del.AllowUserToDeleteRows = false;
            this.dataGridView_del.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_del.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_del.Location = new System.Drawing.Point(3, 83);
            this.dataGridView_del.Name = "dataGridView_del";
            this.dataGridView_del.ReadOnly = true;
            this.dataGridView_del.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView_del.Size = new System.Drawing.Size(832, 396);
            this.dataGridView_del.TabIndex = 37;
            // 
            // tb_del_year
            // 
            this.tb_del_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_del_year.Location = new System.Drawing.Point(201, 25);
            this.tb_del_year.Multiline = true;
            this.tb_del_year.Name = "tb_del_year";
            this.tb_del_year.Size = new System.Drawing.Size(58, 28);
            this.tb_del_year.TabIndex = 31;
            this.tb_del_year.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_del_year_KeyDown);
            // 
            // tb_del_month
            // 
            this.tb_del_month.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_del_month.Location = new System.Drawing.Point(137, 25);
            this.tb_del_month.Multiline = true;
            this.tb_del_month.Name = "tb_del_month";
            this.tb_del_month.Size = new System.Drawing.Size(34, 28);
            this.tb_del_month.TabIndex = 30;
            this.tb_del_month.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_del_month_KeyDown);
            // 
            // tb_del_day
            // 
            this.tb_del_day.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_del_day.Location = new System.Drawing.Point(73, 25);
            this.tb_del_day.Multiline = true;
            this.tb_del_day.Name = "tb_del_day";
            this.tb_del_day.Size = new System.Drawing.Size(34, 28);
            this.tb_del_day.TabIndex = 29;
            this.tb_del_day.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_del_day_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Năm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Tháng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Ngày";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(113, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "/";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(177, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "/";
            // 
            // menu_adjust_readd
            // 
            this.menu_adjust_readd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AdjustToolStripMenuItem,
            this.readdToolStripMenuItem});
            this.menu_adjust_readd.Name = "menu_adjust_readd";
            this.menu_adjust_readd.Size = new System.Drawing.Size(157, 48);
            // 
            // AdjustToolStripMenuItem
            // 
            this.AdjustToolStripMenuItem.Name = "AdjustToolStripMenuItem";
            this.AdjustToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.AdjustToolStripMenuItem.Text = "Chỉnh sửa";
            this.AdjustToolStripMenuItem.Click += new System.EventHandler(this.AdjustToolStripMenuItem_Click);
            // 
            // readdToolStripMenuItem
            // 
            this.readdToolStripMenuItem.Name = "readdToolStripMenuItem";
            this.readdToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.readdToolStripMenuItem.Text = "Thêm lần khám";
            this.readdToolStripMenuItem.Click += new System.EventHandler(this.readdToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 511);
            this.Controls.Add(this.tab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Quản lý hồ sơ bệnh nhân";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tab_manage.ResumeLayout(false);
            this.tab_manage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.tab.ResumeLayout(false);
            this.tab_del_all.ResumeLayout(false);
            this.tab_del_all.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_del)).EndInit();
            this.menu_adjust_readd.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tab_manage;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.TextBox tb_year;
        private System.Windows.Forms.TextBox tb_month;
        private System.Windows.Forms.TextBox tb_day;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Label lb_year;
        private System.Windows.Forms.Label lb_month;
        private System.Windows.Forms.Label lb_day;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Label lb_slash1;
        private System.Windows.Forms.Label lb_slash2;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.ContextMenuStrip menu_adjust_readd;
        private System.Windows.Forms.ToolStripMenuItem AdjustToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readdToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.TabPage tab_del_all;
        private System.Windows.Forms.Button btn_del_all;
        private System.Windows.Forms.DataGridView dataGridView_del;
        private System.Windows.Forms.TextBox tb_del_year;
        private System.Windows.Forms.TextBox tb_del_month;
        private System.Windows.Forms.TextBox tb_del_day;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}

