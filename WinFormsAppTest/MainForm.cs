using WinFormsAppTest.FormAddNumber;

namespace WinFormsAppTest
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void filleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNumber addNumber = new AddNumber();
            addNumber.Owner = this;
            addNumber.ShowDialog();
            //About aboutUsForm = new About();
            //aboutUsForm.Owner = this;
            //aboutUsForm.ShowDialog();
        }
    }
}
