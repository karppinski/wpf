

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private string conn = "Data Source=DESKTOP-P0QENFT;Initial Catalog=Characters;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
        private CharacterService characterService;

        public Form1()
        {
            InitializeComponent();
            characterService = new CharacterService(conn);

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

        private void Update_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter the ID of the character to update", "Update Character", "1", -1, -1);

            if (int.TryParse(input, out int characterId))
            {
                Character characterToUpdate = characterService.GetCharacterById(characterId);
                if (characterToUpdate != null)
                {
                    UpdateAccountForm updateAccountForm = new UpdateAccountForm(characterToUpdate);
                    updateAccountForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Character not found.");
                }
            }
            else
            {
                MessageBox.Show("Invalid ID entered.");
            }



        }

        private void Search_Click(object sender, EventArgs e)
        {
            BrowseAccountForm browseAccountForm = new BrowseAccountForm();
            browseAccountForm.Show();
            this.Hide();
        }
    }
}
