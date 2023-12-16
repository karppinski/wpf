using static WinFormsApp1.counters;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        private counters.CreateCounter CreateCounter = new counters.CreateCounter();
        private counters.SearchCounter SearchCounter = new counters.SearchCounter();
        private counters.DeleteCounter DeleteCounter = new counters.DeleteCounter();
        private counters.UpdateCounter UpdateCounter = new counters.UpdateCounter();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Create_Click(object sender, EventArgs e)
        {
            CreateAccountForm createAccountForm = new CreateAccountForm();
            createAccountForm.Show();
            this.Hide();
        }



    }
}
