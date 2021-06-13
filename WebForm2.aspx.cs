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
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
               
                if (RadioButtonList1.SelectedValue == "Pending")
                {
                    GridView1.DataSource = "";
                    GridView1.DataBind();
                    string dbname = " _tours_ireland";
                    string dbinstance = "";
                    dbinstance = " -tourplan";
                    string connetionString = "Server=" + dbinstance + ";Database=" + dbname + ";User ID=tpwebuser;Password= ";

                    System.Data.SqlClient.SqlConnection cnn = new SqlConnection(connetionString);

                    string query = "select jobtitle, newhire, department, signature1,sigsign1 as 'date1',signature2,sigsign2, counter from Employee_requisition_form where counter <= 2";

                    cnn.Open();
                   
                    SqlCommand queryCommand = new SqlCommand(query, cnn);
                    SqlDataReader queryCommandReader = queryCommand.ExecuteReader();
                    DataTable dataTable = new DataTable("AgentDetails");
                    dataTable.Load(queryCommandReader);
                    string counter = Convert.ToString(dataTable.Rows[0]["counter"].ToString().Trim());

                    if (counter == "1" ||counter == "2")
                    {
                        
                        counter = "pending";
                    }
                    else if (counter == "3")
                    {
                        counter = "completed";
                    }
                    GridView1.DataSource = dataTable;
                    GridView1.DataBind();
                GridView1.Columns[5].Visible = false;

            }
                else if (RadioButtonList1.SelectedValue == "Completed")
                {
                    GridView1.DataSource = "";
                    GridView1.DataBind();
                    string dbname = " _tours_ireland";
                    string dbinstance = "";
                    dbinstance = " -tourplan";
                    string connetionString = "Server=" + dbinstance + ";Database=" + dbname + ";User ID=tpwebuser;Password= ";

                    System.Data.SqlClient.SqlConnection cnn = new SqlConnection(connetionString);

                    string query = "select jobtitle, newhire, department, signature1,signature2,sigsign1,sigsign2, counter from Employee_requisition_form where counter = 3";

                    cnn.Open();

                    SqlCommand queryCommand = new SqlCommand(query, cnn);
                    SqlDataReader queryCommandReader = queryCommand.ExecuteReader();
                    DataTable dataTable = new DataTable("AgentDetails");
              //      string counter = Convert.ToString(dataTable.Rows[0]["counter"].ToString().Trim());
                    dataTable.Load(queryCommandReader);
               

                  //  if (counter == "1" || counter == "2")
                  //  {
                  ////  GridView1.Rows["counter"].ToString() = "pending";
                  //  }
                  //  else if (counter == "3")
                  //  {
                  //      counter = "completed";
                  //  }
                    GridView1.DataSource = dataTable;
                    GridView1.DataBind();
              
                }
            
                if(!IsPostBack)
            fullLoad();
           
        }

        private void fullLoad()
        {
            string dbname = " _tours_ireland";
            string dbinstance = "";
            dbinstance = " -tourplan";
            string connetionString = "Server=" + dbinstance + ";Database=" + dbname + ";User ID=tpwebuser;Password= ";

            System.Data.SqlClient.SqlConnection cnn = new SqlConnection(connetionString);

            string query = "select jobtitle, newhire, department, signature1,signature2,sigsign1,sigsign2, counter from Employee_requisition_form";

            cnn.Open();

            SqlCommand queryCommand = new SqlCommand(query, cnn);
            SqlDataReader queryCommandReader = queryCommand.ExecuteReader();
            DataTable dataTable = new DataTable("AgentDetails");
            dataTable.Load(queryCommandReader);
            string counter = Convert.ToString(dataTable.Rows[0]["counter"].ToString().Trim());
            
            if (counter == "1" || counter == "2")
            {

                counter = "pending";
            }
            else if (counter == "3")
            {
                counter = "completed";
            }
            GridView1.DataSource = dataTable;
            GridView1.DataBind();
            GridView1.Columns[5].Visible = false;
        }
    }
}