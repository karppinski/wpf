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
    public partial class CreateAccountForm : Form
    {
        private string conn = "Data Source=DESKTOP-P0QENFT\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
        private CharacterService characterService;
        public CreateAccountForm()
        {
            InitializeComponent();
            characterService = new CharacterService(conn);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnCreateCharacter_Click(object sender, EventArgs e)
        {
            Character newCharacter = new Character
            {
                CharacterName = txtCharacterName.Text,
                City = txtCity.Text,
                Vocation = txtVocation.Text,
                Sex = txtSex.Text,
                Level = txtLevel.Text,
            };

            characterService.CreateCharacter(newCharacter);
        }

        private void CreateAccountForm_Load(object sender, EventArgs e)
        {

        }
    }
}
