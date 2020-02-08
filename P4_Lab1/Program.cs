using System;
using System.Data.SqlClient;


namespace P4_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString =
                @"Data Source=DESKTOP-647LNP9\MSSQLSERVER01;Initial Catalog=BD1z_so_1A;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            SqlCommand command = new SqlCommand
            {
                CommandText = "SELECT * FROM Pracownicy",
                Connection = conn
            };

           
            Crud crud = new Crud();
            crud.Create(5,"Slask", conn);
            crud.Update(5, "Slask", conn);
            crud.Delete(5, conn);

            conn.Close();
        }
    }
}
