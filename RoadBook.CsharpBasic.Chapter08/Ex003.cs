using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace RoadBook.CsharpBasic.Chapter08
{
    class Ex003
    {
        private readonly string connectionStr =
            string.Format("Data Source={0}, {1}; Initial Catalog={2}; User ID={3}; Password={4}",
                "127.0.0.1", 1433, "testdb", "sa", "821105");

        public void Run()
        {
            string selectSQL = "select id, name, age, job from tb_user";

            using(SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                using(SqlCommand command = new SqlCommand(selectSQL, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Console.WriteLine("회원 ID: {0}", reader["id"]);
                        Console.WriteLine("회원 이름: {0}", reader["name"]);
                        Console.WriteLine("회원 아니: {0}", reader["age"]);
                        Console.WriteLine("회원 직업: {0}", reader["job"]);
                        Console.WriteLine("=========");
                    }
                }
                connection.Close();
            }
        }
    }
}
