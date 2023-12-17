using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class CharacterRepository
    {
        private string connectionString;

        public CharacterRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void InsertCharacter(Character character)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "INSERT INTO CharacterList ([CharacterName], [City], [Vocation], [Sex], [Level], [Created]) VALUES (@CharacterName, @City, @Vocation, @Sex, @Level, @Created)";
                
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@CharacterName", character.CharacterName);
                    cmd.Parameters.AddWithValue("@City", character.City);
                    cmd.Parameters.AddWithValue("@Vocation", character.Vocation);
                    cmd.Parameters.AddWithValue("@Sex", character.Sex);
                    cmd.Parameters.AddWithValue("@Level", character.Level);
                    cmd.Parameters.AddWithValue("@Created", DBNull.Value);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
