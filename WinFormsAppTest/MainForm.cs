using WinFormsAppTest.FormAddNumber;

namespace WinFormsAppTest
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNumber addNumber = new AddNumber();
            addNumber.Owner = this;
            addNumber.ShowDialog();
        }
    }
}
