using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RoadBook.CsharpBasic.Chapter10.Model;
using RoadBook.CsharpBasic.Chapter10.Manager;

namespace RoadBook.CsharpBasic.Chapter10.Web.Board
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DatabaseInfo dbInfo = new DatabaseInfo();
            dbInfo.Name = "RoadBookDB";
            dbInfo.Ip = "127.0.0.1";
            dbInfo.Port = 1433;
            dbInfo.UserId = "sa";
            dbInfo.UserPassword = "821105";

            MsSqlManager ms = new MsSqlManager();
            ms.Open(dbInfo);

            DataTable dt = ms.Select("select idx, title, summary, create_dt, create_user_nm, tags, like_cnt, category_idx from tb_contents");
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}