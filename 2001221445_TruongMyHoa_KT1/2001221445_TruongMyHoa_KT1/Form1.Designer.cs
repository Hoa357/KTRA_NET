namespace _2001221445_TruongMyHoa_KT1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTT = new System.Windows.Forms.TextBox();
            this.bttTinhTien = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxTen = new System.Windows.Forms.TextBox();
            this.checkBoxBM = new System.Windows.Forms.CheckBox();
            this.checkBoxCa = new System.Windows.Forms.CheckBox();
            this.checkBoxMY = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(226, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "HỘI QUÁN SINH VIÊN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên KH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Khách";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxMY);
            this.groupBox1.Controls.Add(this.checkBoxCa);
            this.groupBox1.Controls.Add(this.checkBoxBM);
            this.groupBox1.Location = new System.Drawing.Point(155, 285);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 174);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đồ ăn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(450, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tổng tiền";
            // 
            // textBoxTT
            // 
            this.textBoxTT.Location = new System.Drawing.Point(590, 209);
            this.textBoxTT.Name = "textBoxTT";
            this.textBoxTT.Size = new System.Drawing.Size(100, 26);
            this.textBoxTT.TabIndex = 5;
            // 
            // bttTinhTien
            // 
            this.bttTinhTien.Location = new System.Drawing.Point(454, 285);
            this.bttTinhTien.Name = "bttTinhTien";
            this.bttTinhTien.Size = new System.Drawing.Size(101, 42);
            this.bttTinhTien.TabIndex = 6;
            this.bttTinhTien.Text = "Tính Tiền";
            this.bttTinhTien.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(615, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "->";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBoxTen
            // 
            this.textBoxTen.Location = new System.Drawing.Point(253, 127);
            this.textBoxTen.Name = "textBoxTen";
            this.textBoxTen.Size = new System.Drawing.Size(162, 26);
            this.textBoxTen.TabIndex = 8;
            this.textBoxTen.TextChanged += new System.EventHandler(this.textBoxTen_TextChanged);
            // 
            // checkBoxBM
            // 
            this.checkBoxBM.AutoSize = true;
            this.checkBoxBM.Location = new System.Drawing.Point(37, 43);
            this.checkBoxBM.Name = "checkBoxBM";
            this.checkBoxBM.Size = new System.Drawing.Size(93, 24);
            this.checkBoxBM.TabIndex = 0;
            this.checkBoxBM.Text = "Bánh mì";
            this.checkBoxBM.UseVisualStyleBackColor = true;
            // 
            // checkBoxCa
            // 
            this.checkBoxCa.AutoSize = true;
            this.checkBoxCa.Location = new System.Drawing.Point(37, 89);
            this.checkBoxCa.Name = "checkBoxCa";
            this.checkBoxCa.Size = new System.Drawing.Size(129, 24);
            this.checkBoxCa.TabIndex = 1;
            this.checkBoxCa.Text = "Cá viên chiên";
            this.checkBoxCa.UseVisualStyleBackColor = true;
            // 
            // checkBoxMY
            // 
            this.checkBoxMY.AutoSize = true;
            this.checkBoxMY.Location = new System.Drawing.Point(37, 129);
            this.checkBoxMY.Name = "checkBoxMY";
            this.checkBoxMY.Size = new System.Drawing.Size(75, 24);
            this.checkBoxMY.TabIndex = 2;
            this.checkBoxMY.Text = "Mỳ Ly";
            this.checkBoxMY.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(253, 194);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(162, 28);
            this.comboBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBoxTen);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bttTinhTien);
            this.Controls.Add(this.textBoxTT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTT;
        private System.Windows.Forms.Button bttTinhTien;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxTen;
        private System.Windows.Forms.CheckBox checkBoxMY;
        private System.Windows.Forms.CheckBox checkBoxCa;
        private System.Windows.Forms.CheckBox checkBoxBM;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

