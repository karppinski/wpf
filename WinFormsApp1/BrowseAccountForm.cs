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
    public partial class BrowseAccountForm : Form
    {
        private List<Character> characters;
        private int currentIndex = 0;
        private string conn = "Data Source=DESKTOP-P0QENFT;Initial Catalog=Characters;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
        private CharacterService characterService;


        public BrowseAccountForm()
        {
            InitializeComponent();
            characterService = new CharacterService(conn);
            LoadCharacters();
            DisplayCurrentCharacter();
        }

        public void LoadCharacters()
        {
            characters = characterService.GetAllCharacters();
        }

        public void DisplayCurrentCharacter()
        {
            if (characters.Count > 0 && currentIndex < characters.Count)
            {
                Character currentCharacter = characters[currentIndex];

                CharacterNameLabel.Text = currentCharacter.CharacterName;
                CityLabel.Text = currentCharacter.City;
                VocationLabel.Text = currentCharacter.Vocation;
                SexLabel.Text = currentCharacter.Sex;
                LevelLabel.Text = currentCharacter.Level;
                CreatedLabel.Text = currentCharacter.Created;
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                DisplayCurrentCharacter();
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (currentIndex < characters.Count - 1)
            {
                currentIndex++;
                DisplayCurrentCharacter();
            }
        }
    }
}
