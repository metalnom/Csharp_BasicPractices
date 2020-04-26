using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data;
using RoadBook.CsharpBasic.Chapter10.Manager;
using RoadBook.CsharpBasic.Chapter10.Model;

namespace RoadBook.CsharpBasic.Chapter12.Manager
{
    public class CrawlManager
    {
        DatabaseInfo _dbInfo;
        MsSqlManger _ms;

        public CrawlManager()
        {
            SetDatabaseInfo();
            SetMsSqlManager();
        }

        public void Run()
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();

            List<Model.Contents> contents = Scan();

            WriteToDocs(contents);
            sw.Stop();

            Console.WriteLine("총 " + contents.Count + "건 수집 / 소요시간: " +
                sw.Elapsed.ToString()); 
        }

        private List<Model.Contents> Scan()
        {
            _ms.Open(_dbInfo);
            DataTable dt = _ms.Select("select idx, title, summary, create_dt, create_user_nm, tags, like_cnt, category_idx from tb_contents");

            var contents =
                from dr in dt.AsEnumerable()
                select new Model.Contents()
                {
                    Idx = Convert.ToInt32(dr["IDX"]),
                    Title = dr["TITLE"].ToString(),
                    Summary = dr["SUMMARY"].ToString(),
                    CreateDt = Convert.ToDateTime(dr["CREATE_DT"]),
                    CreateUserNm = dr["CREATE_USER_NM"].ToString(),
                    Tags = dr["TAGS"].ToString()
                };
            _ms.Close();

            return contents.ToList();
        }

        private void WriteToDocs(List<Model.Contents> contents)
        {
            XmlManager _xmlManager = new XmlManager(XmlManager.USE_TYPE.WRITE);

            contents.ForEach(c =>
           {
               _xmlManager.Write(c);
           });
            _xmlManager.Save();
        }

        private void SetDatabaseInfo()
        {
            _dbInfo = new DatabaseInfo();
            _dbInfo.Name = "RoadbookDB";
            _dbInfo.Ip = "127.0.0.1";
            _dbInfo.Port = 1433;
            _dbInfo.UserId = "sa";
            _dbInfo.UserPassword = "821105";
        }

        private void SetMsSqlManager()
        {
            _ms = new MsSqlManger();
        }
    }
}
