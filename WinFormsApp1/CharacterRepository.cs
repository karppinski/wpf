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
                try
                {
                    connection.Open();
                    string sql = "INSERT INTO CharactersList ([CharacterName], [City], [Vocation], [Sex], [Level], [Created]) VALUES (@CharacterName, @City, @Vocation, @Sex, @Level, @Created)";

                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@CharacterName", character.CharacterName);
                        cmd.Parameters.AddWithValue("@City", character.City);
                        cmd.Parameters.AddWithValue("@Vocation", character.Vocation);
                        cmd.Parameters.AddWithValue("@Sex", character.Sex);
                        cmd.Parameters.AddWithValue("@Level", character.Level);
                        cmd.Parameters.AddWithValue("@Created", character.Created);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("SQL Exception: " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception: " + ex.Message);
                }
            }
        }
        public Character GetCharacterById(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string sql = "SELECT * FROM CharactersList WHERE Id = @Id";

                    using(SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);

                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()){ 
                                return new Character
                                {
                                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                    CharacterName = reader.GetString(reader.GetOrdinal("CharacterName")),
                                    City = reader.GetString(reader.GetOrdinal("City")),
                                    Vocation = reader.GetString(reader.GetOrdinal("Vocation")),
                                    Sex = reader.GetString(reader.GetOrdinal("Sex")),
                                    Level = reader.GetString(reader.GetOrdinal("Level")),
                                    Created = reader.GetString(reader.GetOrdinal("Created")),


                                };
                            }


                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("SQL Exception: " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception: " + ex.Message);
                }
            }
            return null;

        }
       public void UpdateCharacter(Character character)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "UPDATE CharactersList SET [CharacterName] = @CharacterName, [Vocation] = @Vocation, [Sex] = @Sex, [Level] = @Level, [Created] = @Created WHERE [Id] = @Id";

                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@CharacterName", character.CharacterName);
                        cmd.Parameters.AddWithValue("@City", character.City);
                        cmd.Parameters.AddWithValue("@Vocation", character.Vocation);
                        cmd.Parameters.AddWithValue("@Sex", character.Sex);
                        cmd.Parameters.AddWithValue("@Level", character.Level);
                        cmd.Parameters.AddWithValue("@Created", character.Created);
                        cmd.Parameters.AddWithValue("@Id", character.Id);

                        cmd.ExecuteNonQuery();

                    }


                }
                catch (SqlException ex)
                {
                    Console.WriteLine("SQL Exception: " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception: " + ex.Message);
                }
            }
        }
    }
}
