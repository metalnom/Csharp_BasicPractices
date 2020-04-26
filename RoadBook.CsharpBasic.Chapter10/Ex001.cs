using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using RoadBook.CsharpBasic.Chapter10.Manager;
using RoadBook.CsharpBasic.Chapter10.Model;

namespace RoadBook.CsharpBasic.Chapter10
{
    public class Ex001
    {
        public void Run()
        {
            DatabaseInfo dbInfo = new DatabaseInfo();
            dbInfo.Name = "RoadBookDB";
            dbInfo.Ip = "127.0.0.1";
            dbInfo.Port = 1433;
            dbInfo.UserId = "sa";
            dbInfo.UserPassword = "821105";

            MsSqlManger ms = new MsSqlManger();
            ms.Open(dbInfo);

            StringBuilder sbMessage = new StringBuilder();
            sbMessage.AppendLine("*****************************");
            sbMessage.AppendLine("1. select");
            sbMessage.AppendLine("2. insert");
            sbMessage.AppendLine("3. update");
            sbMessage.AppendLine("4. delete");
            sbMessage.AppendLine("0. quit");
            sbMessage.AppendLine("*****************************");

            while (true)
            {
                Console.WriteLine(sbMessage.ToString());
                string input = Console.ReadLine();

                if (input == "0")
                {
                    ms.Close();
                    Console.WriteLine("Bye!!");
                    break;
                }
                else
                {
                    string index = string.Empty;
                    string title = string.Empty;
                    string summary = string.Empty;
                    string createUserNm = string.Empty;
                    string tags = string.Empty;
                    string createDate = string.Empty;

                    StringBuilder sbSQL = new StringBuilder();

                    switch (input)
                    {
                        case "1":
                            DataTable dt = ms.Select("Select idx, title, summary, create_dt, create_user_nm, tags, like_cnt, category_idx from tb_contents");
                            if (dt.Rows.Count > 0)
                            {
                                string[] columns = new string[dt.Columns.Count];

                                for (int idx = 0; idx < dt.Columns.Count; idx++)
                                {
                                    columns[idx] = dt.Columns[idx].ToString();
                                    Console.Write(dt.Columns[idx] + "\t");
                                }

                                Console.WriteLine();

                                for (int idx = 0; idx < dt.Rows.Count; idx++)
                                {
                                    for (int idx_j = 0; idx_j < dt.Columns.Count; idx_j++)
                                    {
                                        Console.Write(dt.Rows[idx][columns[idx_j]] + "\t");
                                    }
                                    Console.WriteLine();
                                }
                            }
                            else
                            {
                                Console.WriteLine("No data!!");
                            }
                            break;

                        case "2":
                            Console.Write("TITLE: ");
                            title = Console.ReadLine();
                            Console.Write("SUMMARY: ");
                            summary = Console.ReadLine();
                            Console.Write("CREATE_USER_NM: ");
                            createUserNm = Console.ReadLine();
                            Console.Write("TAGS: ");
                            tags = Console.ReadLine();

                            createDate = DateTime.Now.ToString("yyyy-MM-dd");

                            sbSQL.Append("insert into tb_contents (title, summary, create_dt, create_user_nm, tags, category_idx)");
                            sbSQL.Append(string.Format(" values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",
                                title, summary, createDate, createUserNm, tags, 2));
                            ms.Insert(sbSQL.ToString());
                            break;

                        case "3":
                            ms.Open(dbInfo);

                            Console.Write("Changed IDX: ");
                            index = Console.ReadLine();
                            Console.Write("TITLE: ");
                            title = Console.ReadLine();
                            Console.Write("SUMMARY: ");
                            summary = Console.ReadLine();

                            sbSQL.Append(" update tb_contents set ");
                            sbSQL.Append(string.Format(" title = '{0}', summary = '{1}'", title, summary));
                            sbSQL.Append(string.Format(" where idx = {0}", index));

                            ms.Update(sbSQL.ToString());
                            break;

                        case "4":
                            ms.Open(dbInfo);

                            Console.Write("DELETED IDX: ");
                            index = Console.ReadLine();
                            sbSQL.Append(" delete from tb_contents ");
                            sbSQL.Append(string.Format(" where idx = {0}", index));
                            ms.Update(sbSQL.ToString());
                            break;

                        default:
                            Console.WriteLine("Invalid");
                            break;
                    }
                }
            }
        }
    }
}
