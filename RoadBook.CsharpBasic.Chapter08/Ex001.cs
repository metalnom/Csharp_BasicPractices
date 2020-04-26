using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Data.SqlClient;

namespace RoadBook.CsharpBasic.Chapter08
{
    class Ex001
    {
        private readonly string currentDirectory = Environment.CurrentDirectory;
        private readonly string connectionStr = String.Format(
            "Data Source={0}, {1}; Initial Catalog={2}; User ID={3}; Password={4}",
            "127.0.0.1", 1433, "testdb", "sa", "821105");

        public void Run()
        {
            CheckedDirectory();
            TryConnectToDatabase();
        }

        private void CheckedDirectory()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(currentDirectory + @"\data");
            if (!directoryInfo.Exists) { directoryInfo.Create(); }
        }

        private void TryConnectToDatabase()
        {
            SqlConnection connection = new SqlConnection(connectionStr);
            string filename = string.Format(@"\data\db{0}.log",
                DateTime.Now.ToString("yyyyMMddHHmmss"));

            using(StreamWriter sw = new StreamWriter(currentDirectory + filename, true))
            {
                sw.WriteLine("[{0}] 데이터베이스 연결 시도...", DateTime.Now);
                connection.Open();
                sw.WriteLine("[{0}] 데이터베이스 연결 OK...", DateTime.Now);
                sw.WriteLine("[{0}] 데이터베이스 연결 끊기 시도...", DateTime.Now);
                connection.Close();
                sw.WriteLine("[{0}] 데이터베이스 연결 끊기 OK...", DateTime.Now);
            }
        }
    }
}
