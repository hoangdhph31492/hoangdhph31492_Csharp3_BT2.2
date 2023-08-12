namespace hoangdhph31492_Csharp3_BT2._2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox3 = new GroupBox();
            dtgSach = new DataGridView();
            txtTim = new TextBox();
            label5 = new Label();
            groupBox2 = new GroupBox();
            btnClear = new Button();
            btnTim = new Button();
            btnSua = new Button();
            btnThem = new Button();
            groupBox1 = new GroupBox();
            rbtHH = new RadioButton();
            rbtCH = new RadioButton();
            cmbNXB = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            txtMa = new TextBox();
            label2 = new Label();
            txtTen = new TextBox();
            label1 = new Label();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgSach).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dtgSach);
            groupBox3.Controls.Add(txtTim);
            groupBox3.Controls.Add(label5);
            groupBox3.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(1, 185);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(409, 199);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // dtgSach
            // 
            dtgSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgSach.Location = new Point(0, 43);
            dtgSach.Name = "dtgSach";
            dtgSach.RowTemplate.Height = 26;
            dtgSach.Size = new Size(409, 150);
            dtgSach.TabIndex = 11;
            dtgSach.CellClick += dtgSach_CellClick;
            // 
            // txtTim
            // 
            txtTim.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTim.Location = new Point(75, 17);
            txtTim.Name = "txtTim";
            txtTim.Size = new Size(334, 24);
            txtTim.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(7, 20);
            label5.Name = "label5";
            label5.Size = new Size(57, 16);
            label5.TabIndex = 9;
            label5.Text = "Tìm kiếm:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnClear);
            groupBox2.Controls.Add(btnTim);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(296, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(114, 177);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức Năng";
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Location = new Point(0, 128);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(114, 43);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnTim
            // 
            btnTim.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnTim.Location = new Point(0, 87);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(114, 39);
            btnTim.TabIndex = 4;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSua.Location = new Point(0, 49);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(114, 37);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnThem.Location = new Point(0, 11);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(114, 36);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtHH);
            groupBox1.Controls.Add(rbtCH);
            groupBox1.Controls.Add(cmbNXB);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtMa);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTen);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(1, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(299, 177);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin";
            // 
            // rbtHH
            // 
            rbtHH.AutoSize = true;
            rbtHH.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rbtHH.Location = new Point(170, 105);
            rbtHH.Name = "rbtHH";
            rbtHH.Size = new Size(76, 20);
            rbtHH.TabIndex = 12;
            rbtHH.TabStop = true;
            rbtHH.Text = "Hết Hàng";
            rbtHH.UseVisualStyleBackColor = true;
            // 
            // rbtCH
            // 
            rbtCH.AutoSize = true;
            rbtCH.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rbtCH.Location = new Point(94, 105);
            rbtCH.Name = "rbtCH";
            rbtCH.Size = new Size(78, 20);
            rbtCH.TabIndex = 11;
            rbtCH.TabStop = true;
            rbtCH.Text = "Còn Hàng";
            rbtCH.UseVisualStyleBackColor = true;
            // 
            // cmbNXB
            // 
            cmbNXB.DropDownHeight = 60;
            cmbNXB.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbNXB.FormattingEnabled = true;
            cmbNXB.IntegralHeight = false;
            cmbNXB.Location = new Point(94, 138);
            cmbNXB.Name = "cmbNXB";
            cmbNXB.Size = new Size(148, 24);
            cmbNXB.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(6, 141);
            label4.Name = "label4";
            label4.Size = new Size(82, 16);
            label4.TabIndex = 9;
            label4.Text = "Nhà Xuất Bản:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(23, 105);
            label3.Name = "label3";
            label3.Size = new Size(65, 16);
            label3.TabIndex = 7;
            label3.Text = "Trạng Thái:";
            // 
            // txtMa
            // 
            txtMa.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMa.Location = new Point(94, 62);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(148, 24);
            txtMa.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(61, 65);
            label2.Name = "label2";
            label2.Size = new Size(27, 16);
            label2.TabIndex = 5;
            label2.Text = "Mã:";
            // 
            // txtTen
            // 
            txtTen.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTen.Location = new Point(94, 23);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(148, 24);
            txtTen.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(31, 26);
            label1.Name = "label1";
            label1.Size = new Size(57, 16);
            label1.TabIndex = 0;
            label1.Text = "Tên Sách:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 395);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgSach).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private DataGridView dtgSach;
        private TextBox txtTim;
        private Label label5;
        private GroupBox groupBox2;
        private Button btnClear;
        private Button btnTim;
        private Button btnSua;
        private Button btnThem;
        private GroupBox groupBox1;
        private ComboBox cmbNXB;
        private Label label4;
        private Label label3;
        private TextBox txtMa;
        private Label label2;
        private TextBox txtTen;
        private Label label1;
        private RadioButton rbtHH;
        private RadioButton rbtCH;
    }
}