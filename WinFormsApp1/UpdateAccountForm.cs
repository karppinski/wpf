using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class UpdateAccountForm : Form
    {
        private string conn = "Data Source=DESKTOP-P0QENFT;Initial Catalog=Characters;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
        private CharacterService characterService;
        public int AccountId { get; set; }
        private Character character;
        public UpdateAccountForm(Character character)
        {
            InitializeComponent();
            this.character = character;

            characterService = new CharacterService(conn);


            txtCharacterName.Text = character.CharacterName;
            txtCity.Text = character.City;
            txtVocation.Text = character.Vocation;
            txtSex.Text = character.Sex;
            txtLevel.Text = character.Level;
            txtCreated.Text = character.Created;

        }
        public void SetAccountId(int id)
        {
            AccountId = id;
            LoadCharacterDetails(id);
        }

        private void LoadCharacterDetails(int id)
        {


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UpdateAccountForm_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            character.CharacterName = txtCharacterName.Text;
            character.City = txtCity.Text;
            character.Vocation = txtVocation.Text;
            character.Sex = txtSex.Text;
            character.Level = txtLevel.Text;
            character.Created = txtCreated.Text;

            characterService.UpdateCharacter(character);

            MessageBox.Show("Character updated successfully");
            this.Close();
        }
    }
}
