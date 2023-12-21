using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class CharacterService
    {
        private CharacterRepository repository;

        public CharacterService(string connectionString)
        {
            repository = new CharacterRepository(connectionString);
        }


        public void CreateCharacter(Character character)
        {
            repository.InsertCharacter(character);
        }

        public void UpdateCharacter(Character character)
        {
            repository.UpdateCharacter(character);
        }
        public Character GetCharacterById(int id)
        {
            return repository.GetCharacterById(id);
        }
    }
}
