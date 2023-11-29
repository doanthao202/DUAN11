namespace C_PRL.Forms1
{
    partial class Theloai
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
            thoat = new Button();
            xoa = new Button();
            sua = new Button();
            them = new Button();
            txtVitri = new TextBox();
            label3 = new Label();
            txtTentl = new TextBox();
            label2 = new Label();
            label1 = new Label();
            luoi = new DataGridView();
            groupBox1 = new GroupBox();
            label4 = new Label();
            cbxTrangthai = new ComboBox();
            textBox1 = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)luoi).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // thoat
            // 
            thoat.Location = new Point(399, 193);
            thoat.Margin = new Padding(4, 3, 4, 3);
            thoat.Name = "thoat";
            thoat.Size = new Size(88, 27);
            thoat.TabIndex = 20;
            thoat.Text = "Thoát";
            thoat.UseVisualStyleBackColor = true;
            // 
            // xoa
            // 
            xoa.Location = new Point(399, 160);
            xoa.Margin = new Padding(4, 3, 4, 3);
            xoa.Name = "xoa";
            xoa.Size = new Size(88, 27);
            xoa.TabIndex = 19;
            xoa.Text = "Xóa";
            xoa.UseVisualStyleBackColor = true;
            // 
            // sua
            // 
            sua.Location = new Point(399, 127);
            sua.Margin = new Padding(4, 3, 4, 3);
            sua.Name = "sua";
            sua.Size = new Size(88, 27);
            sua.TabIndex = 18;
            sua.Text = "Sửa";
            sua.UseVisualStyleBackColor = true;
            // 
            // them
            // 
            them.Location = new Point(399, 94);
            them.Margin = new Padding(4, 3, 4, 3);
            them.Name = "them";
            them.Size = new Size(88, 27);
            them.TabIndex = 17;
            them.Text = "Thêm";
            them.UseVisualStyleBackColor = true;
            // 
            // txtVitri
            // 
            txtVitri.Location = new Point(95, 61);
            txtVitri.Margin = new Padding(4, 3, 4, 3);
            txtVitri.Name = "txtVitri";
            txtVitri.Size = new Size(264, 23);
            txtVitri.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(10, 68);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(39, 16);
            label3.TabIndex = 15;
            label3.Text = "Vị trí:";
            // 
            // txtTentl
            // 
            txtTentl.Location = new Point(95, 25);
            txtTentl.Margin = new Padding(4, 3, 4, 3);
            txtTentl.Name = "txtTentl";
            txtTentl.Size = new Size(264, 23);
            txtTentl.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(7, 32);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(80, 16);
            label2.TabIndex = 13;
            label2.Text = "Tên thể loại:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(138, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(166, 26);
            label1.TabIndex = 12;
            label1.Text = "THỂ LOẠI SÁCH";
            label1.Click += label1_Click;
            // 
            // luoi
            // 
            luoi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            luoi.Location = new Point(13, 246);
            luoi.Margin = new Padding(4, 3, 4, 3);
            luoi.Name = "luoi";
            luoi.Size = new Size(485, 197);
            luoi.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cbxTrangthai);
            groupBox1.Controls.Add(txtTentl);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtVitri);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(26, 85);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(366, 144);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(10, 107);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(66, 16);
            label4.TabIndex = 18;
            label4.Text = "Trạng thái";
            // 
            // cbxTrangthai
            // 
            cbxTrangthai.FormattingEnabled = true;
            cbxTrangthai.Items.AddRange(new object[] { "Hoạt động", "Dừng hoạt động" });
            cbxTrangthai.Location = new Point(95, 100);
            cbxTrangthai.Name = "cbxTrangthai";
            cbxTrangthai.Size = new Size(111, 23);
            cbxTrangthai.TabIndex = 17;
            cbxTrangthai.SelectedIndexChanged += cbxTrangthai_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(106, 49);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Nhập tên thể loại";
            textBox1.Size = new Size(328, 23);
            textBox1.TabIndex = 23;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(33, 51);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(65, 16);
            label5.TabIndex = 24;
            label5.Text = "Tìm kiếm:";
            // 
            // Theloai
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 450);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Controls.Add(thoat);
            Controls.Add(xoa);
            Controls.Add(sua);
            Controls.Add(them);
            Controls.Add(label1);
            Controls.Add(luoi);
            Name = "Theloai";
            Text = "Theloai";
            ((System.ComponentModel.ISupportInitialize)luoi).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button thoat;
        private Button xoa;
        private Button sua;
        private Button them;
        private TextBox txtVitri;
        private Label label3;
        private TextBox txtTentl;
        private Label label2;
        private Label label1;
        private DataGridView luoi;
        private GroupBox groupBox1;
        private Label label4;
        private ComboBox cbxTrangthai;
        private TextBox textBox1;
        private Label label5;
    }
}