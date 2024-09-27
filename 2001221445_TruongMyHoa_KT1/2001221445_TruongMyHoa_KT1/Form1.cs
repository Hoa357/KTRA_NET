using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001221445_TruongMyHoa_KT1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] s = { "Sinh viên", "Vãng lai", "VIP" };
            comboBox1.Items.AddRange(s);
        }

        decimal tongTien = 0;
        void tinhtien()
        {
            tongTien = 0; // Khởi tạo tổng tiền

            
            // Kiểm tra các checkbox
            if (checkBoxBM.Checked)
            {
                tongTien += 20000; // Bánh mì trứng
            }
            if (checkBoxCa.Checked)
            {
                tongTien += 20000; // Bánh mì cá
            }
            if (checkBoxMY.Checked)
            {
                tongTien += 20000; // Món trứng
            }
            
            if(comboBox1.Items)


        }

    }
}
