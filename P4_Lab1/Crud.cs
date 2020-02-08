using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace P4_Lab1
{
    class Crud
    {
        public void Create(int id,string regionDescription,SqlConnection conn)
        {
            string sql = "INSERT INTO Region(RegionID,RegionDescription) VALUES(@id,@regionName)";
            var command = new SqlCommand(sql, conn);
            command.Parameters.AddWithValue("@regionName", regionDescription);
            command.Parameters.AddWithValue("@id", id);

            int x=command.ExecuteNonQuery();

            if (x > 0)
            {
                Console.WriteLine("Wpisano");
            }
        }

        public void Read(SqlConnection conn)
        {
            SqlCommand command = new SqlCommand
            {
                CommandText = "SELECT * FROM Customers",
                Connection = conn
            };

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine(reader["Stanowisko"]);
            }
            reader.Close();
        }
        public void Update(int id, string newName,SqlConnection conn)
        {
            string sql = "UPDATE Region SET RegionDescription=@regionName WHERE RegionID=@id ";
            var command = new SqlCommand(sql, conn);
            command.Parameters.AddWithValue("id", id);
            command.Parameters.AddWithValue("regionName", newName);

            int x = command.ExecuteNonQuery();

            if (x > 0)
            {
                Console.WriteLine("Zmieniono");
            }
        }

        public void Delete(int id,SqlConnection conn)
        {
            string sql = "DELETE FROM Region Wjere RegionID=@id";
            var command = new SqlCommand(sql, conn);
            command.Parameters.AddWithValue("id", id);
            int x = command.ExecuteNonQuery();
            if (x > 0)
            {
                Console.WriteLine("Usunieto");
            }

        }
    }
}
