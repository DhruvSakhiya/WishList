using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace WishList
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Random CustNumber = new Random();
            int custNum = CustNumber.Next(0,200);
            Response.Write(custNum.ToString()); //to generate random number
            int itemNumber = CustNumber.Next(0,200);
            SqlConnection conn=new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Jolly InfoTech\documents\visual studio 2017\Projects\WishList\WishList\App_Data\test.mdf Integrated Security = True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into wishlist values('" + custNum + "','"+itemNumber+"')return id");
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}