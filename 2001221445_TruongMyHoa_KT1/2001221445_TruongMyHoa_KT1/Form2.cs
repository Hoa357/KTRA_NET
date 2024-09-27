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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSO_TextChanged(object sender, EventArgs e)
        {
          
           
        }

        private void textBoxXMANG_TextChanged(object sender, EventArgs e)
        {
            string[] input = textBoxSAP.Text.Split(' ');
        }

        private void textBoxSAP_TextChanged(object sender, EventArgs e)
        {
           
                string[] input = textBoxXMANG.Text.Split(' ');
                Array.Sort(input);
                textBoxSAP.Text = string.Join(" ", input);
            
        }

        private void textBoxSUMCHAN_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
