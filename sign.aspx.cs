using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace digitalSignatures
{
    public partial class sign : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string type = Request.QueryString["type"];


            string dbname = " _tours_ireland";
            string dbinstance = "";
            dbinstance = " -tourplan";
            string connetionString = "Server=" + dbinstance + ";Database=" + dbname + ";User ID=tpwebuser;Password=cf5&web22";

            SqlConnection cnn = new SqlConnection(connetionString);

            string query = "select * from Employee_requisition_form where Guid_ID ='"
                + type + "'";

            cnn.Open();

            SqlCommand queryCommand = new SqlCommand(query, cnn);
            SqlDataReader queryCommandReader = queryCommand.ExecuteReader();
            DataTable dataTable = new DataTable("AgentDetails");
            dataTable.Load(queryCommandReader);

            string sig2 = dataTable.Rows[0]["signature2"].ToString().ToLower();
            string manager = dataTable.Rows[0]["hiring_manager"].ToString().ToLower();

            int counter = Convert.ToInt32(dataTable.Rows[0]["counter"].ToString());

            if (counter == 1)
            {
                Label1.Text = "Thank you for signing this document for "+ manager +". It has now been sent to " + sig2 + ", to be signed." ; 
            }

        }
    }
}