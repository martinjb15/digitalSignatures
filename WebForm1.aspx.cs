using System;
using System.IO;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace digitalSignatures
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                if (RadioButtonList2.SelectedValue  == "Yes")
                {
                    RadioButtonList3.Visible = true;
                }
                else
                {                    
                }
                //if (RadioButtonList4.SelectedValue ==  "No")
                //{
                //    Label6.Visible = true;
                //    TextArea2.Visible = true;

                //}
                //else
                //{

                //}

                if (DropDownList2.SelectedValue == "Ireland" && RadioButtonList1.SelectedValue == "Fixed term")
                {

                    if (FixedTermDropDown.SelectedValue == "1")
                    {
                        FixedTermSalAdd.Text = " + 167 " + "Fixed term bonus";
                    }
                    if (FixedTermDropDown.SelectedValue == "2")
                    {
                        FixedTermSalAdd.Text = " + 334 " + "Fixed term bonus";
                    }
                    if (FixedTermDropDown.SelectedValue == "3")
                    {
                        FixedTermSalAdd.Text = " + 500 " + "Fixed term bonus";
                    }
                    if (FixedTermDropDown.SelectedValue == "4")
                    {
                        FixedTermSalAdd.Text = " + 667 " + "Fixed term bonus";
                    }
                    if (FixedTermDropDown.SelectedValue == "5")
                    {
                        FixedTermSalAdd.Text = " + 834 " + "Fixed term bonus";
                    }
                    if (FixedTermDropDown.SelectedValue == "6")
                    {
                        FixedTermSalAdd.Text = " + 1000 " + "Fixed term bonus";
                    }
                    if (FixedTermDropDown.SelectedValue == "7")
                    {
                        FixedTermSalAdd.Text = " + 1167 " + "Fixed term bonus";
                    }
                    if (FixedTermDropDown.SelectedValue == "8")
                    {
                        FixedTermSalAdd.Text = " + 1334 " + "Fixed term bonus";
                    }
                    if (FixedTermDropDown.SelectedValue == "9")
                    {
                        FixedTermSalAdd.Text = " + 1500 " + "Fixed term bonus";
                    }
                    if (FixedTermDropDown.SelectedValue == "10")
                    {
                        FixedTermSalAdd.Text = " + 1667 " + "Fixed term bonus";
                    }
                    if (FixedTermDropDown.SelectedValue == "11")
                    {
                        FixedTermSalAdd.Text = " + 1834 " + "Fixed term bonus";
                    }
                    if (FixedTermDropDown.SelectedValue == "12")
                    {
                        FixedTermSalAdd.Text = " + 2000 " + "Fixed term bonus";
                    }
                }

                if (DropDownList2.SelectedValue == "UK" && RadioButtonList1.SelectedValue == "Fixed term")
                {

                    if (FixedTermDropDown.SelectedValue == "1")
                    {
                        FixedTermSalAdd.Text = " + 105 " + "Fixed term bonus";
                    }
                    if (FixedTermDropDown.SelectedValue == "2")
                    {
                        FixedTermSalAdd.Text = " + 209 " + "Fixed term bonus";
                    }
                    if (FixedTermDropDown.SelectedValue == "3")
                    {
                        FixedTermSalAdd.Text = " + 313 " + "Fixed term bonus";
                    }
                    if (FixedTermDropDown.SelectedValue == "4")
                    {
                        FixedTermSalAdd.Text = " + 417 " + "Fixed term bonus";
                    }
                    if (FixedTermDropDown.SelectedValue == "5")
                    {
                        FixedTermSalAdd.Text = " + 521 " + "Fixed term bonus";
                    }
                    if (FixedTermDropDown.SelectedValue == "6")
                    {
                        FixedTermSalAdd.Text = " + 625 " + "Fixed term bonus";
                    }
                    if (FixedTermDropDown.SelectedValue == "6")
                    {
                        FixedTermSalAdd.Text = " + 730 " + "Fixed term bonus";
                    }
                    if (FixedTermDropDown.SelectedValue == "8")
                    {
                        FixedTermSalAdd.Text = " + 834 " + "Fixed term bonus";
                    }
                    if (FixedTermDropDown.SelectedValue == "9")
                    {
                        FixedTermSalAdd.Text = " + 938 " + "Fixed term bonus";
                    }
                    if (FixedTermDropDown.SelectedValue == "10")
                    {
                        FixedTermSalAdd.Text = " + 1042 " + "Fixed term bonus";
                    }
                    if (FixedTermDropDown.SelectedValue == "11")
                    {
                        FixedTermSalAdd.Text = " + 1146 " + "Fixed term bonus";
                    }
                    if (FixedTermDropDown.SelectedValue == "12")
                    {
                        FixedTermSalAdd.Text = " + 1250 " + "Fixed term bonus";
                    }

                }

                if (RadioButtonList1.SelectedValue == "Fixed term")
                {
                    fixedTermLabel.Visible = true;
                    FixedTermDropDown.Visible = true;
                    FixedTermSalAdd.Visible = true;
                    RadioButtonList1.Focus();
                    fixedTermLabel.Visible = true;
                    FixedTermDropDown.Visible = true;
                }
                else
                {
                    fixedTermLabel.Visible = false;
                    FixedTermDropDown.Visible = false;
                    RadioButtonList1.Focus();
                    fixedTermLabel.Visible = false;
                    FixedTermDropDown.Visible = false;
                    FixedTermSalAdd.Visible = false;

                }
            }
            Label1.Text = DateTime.Now.ToString();

            if (Request.QueryString["type"] != null)
            {
                string type = Request.QueryString["type"];

                WithID();
            }
        }

        // load data if there is a type and authenticate 

        public void WithID()
        {
            // read data from database 
            string type = Request.QueryString["type"];


            string dbname = "_tours_ireland";
            string dbinstance = "";
            dbinstance = "-tourplan";
            string connetionString = "Server=" + dbinstance + ";Database=" + dbname + ";User ID=tpwebuser;Password=";

            SqlConnection cnn = new SqlConnection(connetionString);

            string query = "select * from Employee_requisition_form where Guid_ID ='"
                + type + "'";

            cnn.Open();

            SqlCommand queryCommand = new SqlCommand(query, cnn);
            SqlDataReader queryCommandReader = queryCommand.ExecuteReader();
            DataTable dataTable = new DataTable("AgentDetails");
            dataTable.Load(queryCommandReader);

            cnn.Close();
            //
            string tmp = "";
            string tmp2 = "";
            string tmp5 = "";


            string sig = dataTable.Rows[0]["signature1"].ToString().ToLower();
            string sig2 = dataTable.Rows[0]["signature2"].ToString().ToLower();

            if (dataTable.Rows[0]["signature1"].ToString().ToLower() == "@ .ie".ToLower())
            {
                tmp = " tours\\".ToLower();

            }
            if (dataTable.Rows[0]["signature2"].ToString().ToLower() == "@ .ie".ToLower())
            {
                tmp2 = " tours\\".ToLower();

            }
            if (dataTable.Rows[0]["signature1"].ToString().ToLower() == "@ .ie".ToLower())
            {
                tmp = " tours\\".ToLower();
                tmp5 = " tours\\".ToLower();


            }
            if (dataTable.Rows[0]["signature2"].ToString().ToLower() == "@ .ie".ToLower())
            {
                tmp2 = " tours\\".ToLower();
                tmp5 = " tours\\".ToLower();

            }
            if (dataTable.Rows[0]["signature1"].ToString().ToLower() == "@ .ie".ToLower())
            {
                tmp = " tours\\".ToLower();

            }
            if (dataTable.Rows[0]["signature2"].ToString().ToLower() == "@ .ie".ToLower())
            {
                tmp2 = " tours\\".ToLower();

            }
            if (dataTable.Rows[0]["signature1"].ToString().ToLower() == "@ uk.com".ToLower())
            {
                tmp = " tours\\".ToLower();

            }
            if (dataTable.Rows[0]["signature2"].ToString().ToLower() == "@ uk.com".ToLower())
            {
                tmp2 = " tours\\".ToLower();

            }
            //if (dataTable.Rows[0]["signature1"].ToString().ToLower() == "@ .ie")
            //{
            //    tmp = " tours\\".ToLower();

            //}
            //if (dataTable.Rows[0]["signature2"].ToString().ToLower() == "@ .ie")
            //{
            //    tmp2 = " tours\\".ToLower();

            //}
            if (dataTable.Rows[0]["signature1"].ToString().ToLower() == "@ .ie".ToLower())
            {
                tmp = " tours\\".ToLower();

            }
            if (dataTable.Rows[0]["signature2"].ToString().ToLower() == "@ .ie".ToLower())
            {
                tmp2 = " tours\\".ToLower();

            }
            string y = dataTable.Rows[0]["signature1"].ToString().ToLower();
            if (dataTable.Rows[0]["signature1"].ToString().ToLower() == "@ .ie".ToLower())

            {
                tmp = " tours\\".ToLower();

            }
            if (dataTable.Rows[0]["signature2"].ToString().ToLower() == "@ .ie".ToLower())
            {
                tmp2 = " tours\\".ToLower();

            }
            String tmp3 = " tours\\";
            String temp4 = " tours\\";

            if (HttpContext.Current.User.Identity.Name.ToString().ToLower() == tmp || HttpContext.Current.User.Identity.Name.ToString().ToLower() == tmp2 || HttpContext.Current.User.Identity.Name.ToString().ToLower() == tmp3 || HttpContext.Current.User.Identity.Name.ToString().ToLower() == temp4 || HttpContext.Current.User.Identity.Name.ToString().ToLower() == tmp5)
            {



                Label1.Text = dataTable.Rows[0]["dateTime"].ToString();
                TextBox1.Text = dataTable.Rows[0]["NewHire"].ToString();
                TextBox2.Text = dataTable.Rows[0]["JobTitle"].ToString();
                TextBox3.Text = dataTable.Rows[0]["Department"].ToString();
                TextBox4.Text = dataTable.Rows[0]["No_of_staff"].ToString();
                TextBox5.Text = dataTable.Rows[0]["hiring_manager"].ToString();
                RadioButtonList1.SelectedValue = dataTable.Rows[0]["term"].ToString();
                FixedTermDropDown.Text = dataTable.Rows[0]["duration"].ToString();
                //  TextArea1.InnerText = dataTable.Rows[0]["replacement_position"].ToString();
                TextArea2.InnerText = dataTable.Rows[0]["new_vacancy"].ToString();
                TextBox7.Text = Encrypt.DecryptString(dataTable.Rows[0]["Proposed_salary"].ToString(), "1234");

                //System.Text.Encoding.UTF8.GetString(decodedText);
                //TextBox7.Text = decodedText.ToString();
                TextArea3.InnerText = dataTable.Rows[0]["staffing_levels"].ToString();
                TextArea4.InnerText = dataTable.Rows[0]["other"].ToString();
                Label1.Text = dataTable.Rows[0]["dateTime"].ToString();
                TextBox8.Text = dataTable.Rows[0]["signature1"].ToString();
                TextBox9.Text = dataTable.Rows[0]["signature2"].ToString();




                int counter = Convert.ToInt32(dataTable.Rows[0]["counter"].ToString());

                // counter to show sign fields

                if (counter == 1 || counter == 2)
                {
                    Button1.Visible = false;
                    Button2.Visible = true;
                    Button3.Visible = false;
                    TextBox8.ReadOnly = true;
                    TextBox9.ReadOnly = true;
                    Label10.Visible = false;
                    DropDownList2.Visible = false;
                }
                if (counter == 1)
                {
                    Label3.Visible = true;
                    TextBox8.Visible = true;
                    Label7.Text = DateTime.Now.ToString();
                    Label7.Visible = true;
                    TextBox8.ReadOnly = true;


                }
                if (counter == 2)
                {
                    if (HttpContext.Current.User.Identity.Name.ToString().ToLower() == tmp || HttpContext.Current.User.Identity.Name.ToString().ToLower() == tmp5)
                    {
                        Button2.Visible = false;
                    }
                    Label3.Visible = true;
                    TextBox8.Visible = true;

                    Label4.Visible = true;
                    TextBox9.Visible = true;
                    Label8.Visible = true;
                    Label8.Text = DateTime.Now.ToString();
                    Label7.Text = dataTable.Rows[0]["sigSign1"].ToString();

                    Label7.Visible = true;
                    Label8.Visible = true;
                    TextBox8.ReadOnly = true;
                    TextBox9.ReadOnly = true;
                    Button2.Visible = true;
                }
                if (counter == 3)
                {
                    Label10.Visible = false;
                    DropDownList2.Visible = false;
                    Button3.Visible = true;
                    Button2.Visible = false;
                    Label3.Visible = true;
                    TextBox8.Visible = true;
                    Button1.Visible = false;
                    Label4.Visible = true;
                    TextBox9.Visible = true;
                    Label7.Visible = true;
                    Label8.Visible = true;

                    Label5.Visible = true;
                    TextBox10.Visible = true;


                    Label7.Text = dataTable.Rows[0]["sigSign1"].ToString();

                    Label8.Text = dataTable.Rows[0]["sigSign2"].ToString();
                    TextBox8.ReadOnly = true;
                    TextBox9.ReadOnly = true;

                }
                if (counter == 1 || counter == 2 || counter == 3)
                {
                    TextBox1.ReadOnly = true;
                    TextBox2.ReadOnly = true;
                    TextBox3.ReadOnly = true;
                    TextBox4.ReadOnly = true;
                    TextBox5.ReadOnly = true;
                    TextBox7.ReadOnly = true;


                    Label2.Visible = false;
                    DropDownList1.Visible = false;
                }

                // page load everything to read only

            }
        }

        // write into the sql and send a message
        protected void Button1_Click(object sender, EventArgs e)
        {
            string fixterm = TextBox7.Text.ToString() + FixedTermSalAdd.Text.ToString();


            string encodedText = Encrypt.EncryptString(fixterm, "1234");
            
            
            int counter = 1;
            // update to database
            string send1 = "@ .ie";

            string send2 = "";
            string send3 = "";
            //list 1

            if (DropDownList1.SelectedValue == " and  –   HR Gods")
            {
                send2 = "@ .ie";
            }
            if (DropDownList1.SelectedValue == " and  or  –   Ireland")
            {
                send2 = "@ .ie";
                send3 = "@ .ie";
            }
            //if (DropDownList1.SelectedValue == " and  –   IT Gods")
            //{
            //    send2 = "@ .ie";
            //}
            if (DropDownList1.SelectedValue == " and  – ")
            {
                send2 = "@ .ie";
            }

            if (DropDownList1.SelectedValue == " –   UK")
            {
                send2 = "@ uk.com";
            }

            string url = "https://web. .ie/erf/webform1.aspx";
            string type = "?type=";
            Guid newGuid = Guid.NewGuid();
            string full = url + type + newGuid;


            SmtpClient client = new SmtpClient("mailhost");
            MailAddress from = new MailAddress("NoReply@ .ie");
            MailAddress to = new MailAddress(send1);
            MailMessage message = new MailMessage(from, to);
            message.Body = "<br /> <h3>You have received a request from " + TextBox5.Text.ToString() + ", for the Employee requisition form, this is to be signed by " + send1 + " " + send2 +
                ". <br/> <br/> Please click on the following link to review the form and sign : " + full;
            message.IsBodyHtml = true;
            message.Subject = "Employee requisition form " + TextBox2.Text.ToString();
            client.Send(message);

            string dbname = "";
            dbname = " _tours_ireland";
            string dbinstance = "";
            dbinstance = " -tourplan";
            string connetionString = "Server=" + dbinstance + ";Database=" + dbname + ";User ID=tpwebuser;Password= ";
            SqlConnection cnn = new SqlConnection(connetionString);
            cnn.Open();
            string query1 = "select * from Employee_requisition_form";

            SqlCommand queryCommand = new SqlCommand(query1, cnn);



            string query = "insert into Employee_requisition_form (Guid_ID, dateTime, NewHire, JobTitle, Department, No_of_staff,"
             + "hiring_manager, term, duration, new_vacancy, Proposed_salary, "
              + "signature1, signature2, staffing_levels, other, counter)"

             + "values (@Guid_ID, @dateTime, @NewHire, @JobTitle, @Department, @No_of_staff, @hiring_manager, @term," +
             "@duration, @new_vacancy, @Proposed_salary, @signature1, @signature2, " +
             "@staffing_levels, @other, @counter )";

            queryCommand.CommandText = query;
            queryCommand.Parameters.AddWithValue("@Guid_ID", newGuid);
            queryCommand.Parameters.AddWithValue("@dateTime", Label1.Text.ToString());
            queryCommand.Parameters.AddWithValue("@NewHire", TextBox1.Text.ToString());
            queryCommand.Parameters.AddWithValue("@JobTitle", TextBox2.Text.ToString());
            queryCommand.Parameters.AddWithValue("@Department", TextBox3.Text.ToString());
            queryCommand.Parameters.AddWithValue("@No_of_staff", TextBox4.Text.ToString());
            queryCommand.Parameters.AddWithValue("@hiring_manager", TextBox5.Text.ToString());
            queryCommand.Parameters.AddWithValue("@term", RadioButtonList1.Text.ToString());
            queryCommand.Parameters.AddWithValue("@duration", FixedTermDropDown.Text.ToString());
            //  queryCommand.Parameters.AddWithValue("@replacement_position", TextArea1.InnerText.ToString());
            queryCommand.Parameters.AddWithValue("@new_vacancy", TextArea2.InnerText.ToString());
            queryCommand.Parameters.AddWithValue("@Proposed_salary", encodedText);
            queryCommand.Parameters.AddWithValue("@staffing_levels", TextArea3.InnerText.ToString());
            queryCommand.Parameters.AddWithValue("@other", TextArea4.InnerText.ToString());
            queryCommand.Parameters.AddWithValue("@signature1", send1);
            queryCommand.Parameters.AddWithValue("@signature2", send2);
            queryCommand.Parameters.AddWithValue("@counter", counter);
            queryCommand.ExecuteNonQuery();
            cnn.Close();
            Server.Transfer("HtmlPage1.html");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            // read data from database 
            string type = Request.QueryString["type"];


            string dbname = " _tours_ireland";
            string dbinstance = "";
            dbinstance = " -tourplan";
            string connetionString = "Server=" + dbinstance + ";Database=" + dbname + ";User ID=tpwebuser;Password= ";

            System.Data.SqlClient.SqlConnection cnn = new SqlConnection(connetionString);

            string query = "select * from Employee_requisition_form where Guid_ID ='"
                + type + "'";

            cnn.Open();

            SqlCommand queryCommand = new SqlCommand(query, cnn);
            SqlDataReader queryCommandReader = queryCommand.ExecuteReader();
            DataTable dataTable = new DataTable("AgentDetails");
            dataTable.Load(queryCommandReader);

            cnn.Close();
            int counter = Convert.ToInt32(dataTable.Rows[0]["counter"].ToString());

            if (counter == 1)
            {
                string connetionString1 = "Server=" + dbinstance + ";Database=" + dbname + ";User ID=tpwebuser;Password= ";
                SqlConnection cnn1 = new SqlConnection(connetionString);
                cnn.Open();
                string query3 = "select * from Employee_requisition_form";

                SqlCommand queryCommand3 = new SqlCommand(query3, cnn);

                string query4 = "update Employee_requisition_form set counter = @counter, sigsign1 = @sigsign1 where guid_id ='" + type + "'";
                queryCommand.CommandText = query4;
                counter++;
                queryCommand.Parameters.AddWithValue("@counter", counter);
                queryCommand.Parameters.AddWithValue("@sigsign1", DateTime.Now);

                queryCommand.ExecuteNonQuery();
                string guid1 = Request.QueryString["type"];
                string url = "https://web. .ie/erf/webform1.aspx";
                type = "?type=";
                string full = url + type + guid1;


                SmtpClient client = new SmtpClient("mailhost");
                MailAddress from = new MailAddress("NoReply@ .ie");
                MailAddress to = new MailAddress(TextBox9.Text.ToString().Trim());
                MailMessage message = new MailMessage(from, to);

                message.Body = "<br /> <h3>You have received a request for the Employee requisition form. " +
                    ". <br/> <br/> Please click on the following link to review the form and sign : " + full;
                message.IsBodyHtml = true;
                message.Subject = "Employee requisition form " + TextBox2.Text.ToString();
                client.Send(message);

                Server.Transfer("HtmlPage2.html");
            }

            else if (counter == 2)
            {

                string connetionString1 = "Server=" + dbinstance + ";Database=" + dbname + ";User ID=tpwebuser;Password= ";
                SqlConnection cnn1 = new SqlConnection(connetionString);
                cnn.Open();
                string query3 = "select * from Employee_requisition_form";

                SqlCommand queryCommand3 = new SqlCommand(query3, cnn);

                string query4 = "update Employee_requisition_form set counter = @counter, sigsign2 = @sigsign2  where guid_id ='" + type + "'";
                queryCommand.CommandText = query4;
                counter++;
                queryCommand.Parameters.AddWithValue("@counter", counter);
                queryCommand.Parameters.AddWithValue("@sigsign2", DateTime.Now);

                queryCommand.ExecuteNonQuery();

                if (counter == 3)
                {
                    string guid1 = Request.QueryString["type"];
                    string url = "https://web. .ie/erf/webform1.aspx";
                    type = "?type=";
                    string full = url + type + guid1;


                    SmtpClient client = new SmtpClient("mailhost");
                    MailAddress from = new MailAddress("NoReply@ .ie");
                    MailAddress to = new MailAddress("anita@ .ie");

                    MailMessage message = new MailMessage(from, to);
                    message.To.Add("linda@ .ie");
                    message.Body = "<br /> <h3>You have received a request for the Employee requisition form. For " + TextBox2.Text.ToString() + " and from " + TextBox5.Text.ToString() +
                        ". <br/> <br/> Please click on the following link to review the form, sign and print : " + full +
                        "   Approved by " + TextBox8.Text.ToString() + " and " + TextBox9.Text.ToString();
                    message.IsBodyHtml = true;
                    message.Subject = "Employee requisition form " + TextBox2.Text.ToString();
                    client.Send(message);

                }
                Server.Transfer("HtmlPage2.html");
            }

        }
        public static class Encrypt
        {
            // This size of the IV (in bytes) must = (keysize / 8).  Default keysize is 256, so the IV must be
            // 32 bytes long.  Using a 16 character string here gives us 32 bytes when converted to a byte array.
            private const string initVector = "pemgail9uzpgzl88";
            // This constant is used to determine the keysize of the encryption algorithm
            private const int keysize = 256;
            //Encrypt
            public static string EncryptString(string plainText, string passPhrase)
            {
                byte[] initVectorBytes = Encoding.UTF8.GetBytes(initVector);
                byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
                PasswordDeriveBytes password = new PasswordDeriveBytes(passPhrase, null);
                byte[] keyBytes = password.GetBytes(keysize / 8);
                RijndaelManaged symmetricKey = new RijndaelManaged();
                symmetricKey.Padding = PaddingMode.Zeros;
                symmetricKey.Mode = CipherMode.CBC;
                ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes);
                MemoryStream memoryStream = new MemoryStream();
                CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);
                cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                cryptoStream.FlushFinalBlock();
                byte[] cipherTextBytes = memoryStream.ToArray();
                memoryStream.Close();
                cryptoStream.Close();

                return Convert.ToBase64String(cipherTextBytes);
            }
            //Decrypt
            public static string DecryptString(string cipherText, string passPhrase)
            {

                byte[] initVectorBytes = Encoding.UTF8.GetBytes(initVector);
                byte[] cipherTextBytes = Convert.FromBase64String(cipherText);
                PasswordDeriveBytes password = new PasswordDeriveBytes(passPhrase, null);
                byte[] keyBytes = password.GetBytes(keysize / 8);



                RijndaelManaged symmetricKey = new RijndaelManaged();
                symmetricKey.Padding = PaddingMode.Zeros;
                symmetricKey.Mode = CipherMode.CBC;

                ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes);
                MemoryStream memoryStream = new MemoryStream(cipherTextBytes);
                CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
                byte[] plainTextBytes = new byte[cipherTextBytes.Length];

                cryptoStream.FlushFinalBlock();
                int decryptedByteCount = cryptoStream.Read(cipherTextBytes, 0, plainTextBytes.Length);

                memoryStream.Close();
                cryptoStream.Close();
                string text = "";
                using (var msDecrypt = new MemoryStream(cipherTextBytes))
                {
                    using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (var srDecrypt = new StreamReader(csDecrypt))
                        {
                            text = srDecrypt.ReadLine();
                        }
                    }
                }
                //string tt = Encoding.UTF8.GetString(cryptoStream, 0, decryptedByteCount);
                //string[] words = text.Split('\\');
                text = text.Replace("\0", "");
                return text;

                return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
            }
        }
    }
}