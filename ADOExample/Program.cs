using System;
using Npgsql;

namespace ADOExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString =
                "host=localhost;db=northwind;uid=bulskov;pwd=henrik";
            using var conn = new NpgsqlConnection(connectionString);
            conn.Open();

            using var cmd = new NpgsqlCommand();

            cmd.Connection = conn;
            cmd.CommandText = "select categoryid, categoryname from categories";

            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine($"Id={reader.GetInt32(0)}, Name={reader.GetString(1)}");
            }
        }
    }
}
