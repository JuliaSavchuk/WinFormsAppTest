using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppTest.FormAddNumber
{
    public partial class AddNumber : Form
    {
        public AddNumber()
        {
            InitializeComponent();
        }

        private void button_Result_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int num1) && int.TryParse(textBox2.Text, out int num2))
            {
                int result = num1 + num2;
                label_result.Text = "Result: " + result.ToString();
            }
            else
            {
                label_result.Text = "Invalid input";
            }
        }
    }
}
