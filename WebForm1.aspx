<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="digitalSignatures.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>Employee requisition form</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">
    <link rel="stylesheet" href="bootstap.min.css">
    <script type="text/javascript" src="js.js"></script>
    <link rel="stylesheet" href="css.css">
    <style type="text/css">
        p.MsoNormal
	{margin-bottom:.0001pt;
	font-size:11.0pt;
	font-family:"Calibri",sans-serif;
	        margin-left: 0cm;
            margin-right: 0cm;
            margin-top: 0cm;
        }
        #Button3 {
            height: 64px;
            width: 343px;
        }
        .auto-style2 {
            color: #FF5050;
        }
        .auto-style3 {
            text-decoration: underline;
        }
        .auto-style4 {
            display: block;
            width: 100%;
            height: 34px;
            padding: 6px 12px;
            font-size: 14px;
            line-height: 1.42857143;
            color: #555;
            background-color: #fff;
            background-image: none;
            border: 1px solid #ccc;
            border-radius: 4px;
            -webkit-box-shadow: inset 0 1px 1px rgba(0,0,0,.075);
            box-shadow: inset 0 1px 1px rgba(0,0,0,.075);
            -webkit-transition: border-color ease-in-out .15s,-webkit-box-shadow ease-in-out .15s;
            -o-transition: border-color ease-in-out .15s,box-shadow ease-in-out .15s;
            transition: border-color ease-in-out .15s,box-shadow ease-in-out .15s;
            margin-top: 0;
        }
    </style>
</head>

<body>
    <form id="form1" runat="server">
               <nav class="navbar navbar-inverse">
    <div class="container">
      <!-- Brand and toggle get grouped for better mobile display -->
      <div class="navbar-header">
        <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1" aria-expanded="false">
          <span class="sr-only">Toggle navigation</span>
          <span class="icon-bar"></span>
          <span class="icon-bar"></span>
          <span class="icon-bar"></span>
        </button>
        <a class="navbar-brand" href="http://atintranet/default.aspx">Atintranet</a>
      </div>

      <!-- Collect the nav links, forms, and other content for toggling -->
      <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
        <ul class="nav navbar-nav">
         <li class="active"><a href="https://web. .ie/erf/webform2.aspx">Status</a></li>
   </ul>
 </div><!-- /.navbar-collapse -->
</div><!-- /.container-fluid -->
</nav>
        <div class="container">
            <div class="jumbotron">
            <h1>Employee requisition form </h1><div>
 Replacement or new staff must be authorized by the and by the relevant director as outlined below.<br />
                <span class="auto-style3"><strong>Directors to approve</strong></span><br />
                 &amp; Kelly,   Conferences &amp; Events <br />
&nbsp–   Ireland<br />
                &nbsp; Scotland and London offices 
                <br />
                <br />
&nbsp;<span class="auto-style2">Note to signatories listed</span>: Additional staff to the budget, to be approved by the Remuneration Committee () – details can be sent to Darren to secure approval from the Remuneration Committee<br />
                <span>HR automatically receives the form once both signatories are filled.
                <br />
                </span> </div>
         </div>
                <div class="row form-group">
                    <div class="col">
                        Date:
                <asp:Label ID="Label1" runat="server" Text="Label" CssClass="form-control"></asp:Label>
                    </div>
                </div>
            Please complete the following: 

            <div class="row form-group">
                <div class="col-md-6">
                    Date new hire required :<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="*"></asp:RequiredFieldValidator>
&nbsp;<asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style4"></asp:TextBox>
                </div>
                 
                <div class="col-md-6">
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox2" ErrorMessage="*"></asp:RequiredFieldValidator>
                    Job title of the new hire:
                    <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>

            <div class="row form-group">
                <div class="col-md-6">
                    Location/Department:
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox3" ErrorMessage="*"></asp:RequiredFieldValidator>

                <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                   <div class="col-md-6">
                   <asp:Label ID="Label10" runat="server" Text=" Payment Country:"></asp:Label>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="TextBox3" ErrorMessage="*"></asp:RequiredFieldValidator>
                       <asp:DropDownList ID="DropDownList2" CssClass="form-control" runat="server">
                           <asp:ListItem>Please Select....</asp:ListItem>
                           <asp:ListItem>Ireland</asp:ListItem>
                           <asp:ListItem>UK</asp:ListItem>
                       </asp:DropDownList>
                </div>
                <div class="col-md-6">
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox4" ErrorMessage="*"></asp:RequiredFieldValidator>
                    Number of staff required:
                <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>

            <div class="row form-group">
                <div class="col">
                    Name of the hiring manager:
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox5" ErrorMessage="*"></asp:RequiredFieldValidator>

                <asp:TextBox ID="TextBox5" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            

        
                <div class="col">
                    Please indicate whether you require a permanent or a fixed term employee by ticking a box below:
                </div>
                <div class="col">
                  <%--  <asp:CheckBoxList ID="CheckBoxList1" runat="server" CssClass="radio-inline">
                        <asp:ListItem>Permanent</asp:ListItem>
                        <asp:ListItem>Fixed term</asp:ListItem>
                    </asp:CheckBoxList>--%>
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" CssClass="radio-inline">
            <asp:ListItem Value="Permanent">Permanent</asp:ListItem>
            <asp:ListItem Value="Fixed term">Fixed term</asp:ListItem>
        </asp:RadioButtonList>
                    <br />
                    <br />
                    <asp:Label ID="fixedTermLabel" runat="server" Text="Contract Duration (months)" Visible="false"></asp:Label>
                    <asp:DropDownList ID="FixedTermDropDown" runat="server" Visible="false" AutoPostBack="true">
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        <asp:ListItem>5</asp:ListItem>
                        <asp:ListItem>6</asp:ListItem>
                        <asp:ListItem>7</asp:ListItem>
                        <asp:ListItem>8</asp:ListItem>
                        <asp:ListItem>9</asp:ListItem>
                        <asp:ListItem>10</asp:ListItem>
                        <asp:ListItem>11</asp:ListItem>
                        <asp:ListItem>12</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>

            <div class="row form-group">
                <div class="col-md-6">
                   
                </div>
                <div class="col-md-6">
                </div>
                 </div>
          <div class="row form-group">
                <div class="col">

                 <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="TextArea1" ErrorMessage="*"></asp:RequiredFieldValidator>--%>
                    Is this position a replacement position? </div>
              <div>

             <asp:RadioButtonList ID="RadioButtonList2" runat="server" AutoPostBack="True" CssClass="radio-inline">
            <asp:ListItem Value="Yes">Yes</asp:ListItem>
            <asp:ListItem Value="No">No</asp:ListItem>
        </asp:RadioButtonList>
                  </div>
              <div>

                    Is this within current staffing budgeted levels?</div>
     <asp:RadioButtonList ID="RadioButtonList3" runat="server" CssClass="radio-inline">
            <asp:ListItem Value="Yes">Yes</asp:ListItem>
            <asp:ListItem Value="No">No</asp:ListItem>
        </asp:RadioButtonList>
                <div class="col">
                    &nbsp;<br />
                    <br /><asp:Label ID="Label6" runat="server" Text=" Please provide a justification for the vacancy" Visible="false"></asp:Label>
                </div>
                <div class="col">
                    <textarea id="TextArea2" runat="server" class=" form-control"  name="S2" rows="2" visible="false"></textarea>
                </div>
             </div>

            <div class="row form-group">
                <div class="col-md-6">
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="TextBox7" ErrorMessage="*"></asp:RequiredFieldValidator>

                    Proposed salary:
                </div>
                <div class="col-md-6">
                    <asp:TextBox ID="TextBox7" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:Label ID="FixedTermSalAdd" runat="server" Text="" Visible="false"></asp:Label>
                </div>
            </div>

            <div class="row form-group">
                <div class="col">
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="TextArea3" ErrorMessage="*"></asp:RequiredFieldValidator>

                    Please advise: 1. If the current staffing levels in the dept have been looked at and deemed not sufficient to cover the workload
                within the dept.
                </div>
           
                <div class="col">
                    <textarea id="TextArea3" runat="server" class=" form-control" cols="20" name="S3" rows="2"></textarea>
                </div>
            </div>

            <div class="row form-group">
                <div class="col">
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="TextArea4" ErrorMessage="*"></asp:RequiredFieldValidator>

                    2. If you have explored /considered other internal support to fulfill your staff requirements.
                </div>
           
                <div class="col">
                    <textarea id="TextArea4" runat="server" class=" form-control" cols="20" name="S4" rows="2"></textarea>
                </div>
            </div>

            <div class="row form-group">
                <div class="col-md-6">
                    <asp:Label ID="Label2" runat="server" Text="Choose Signatures"></asp:Label>
                </div>

                <div class="col-md-6">
                    <asp:DropDownList ID="DropDownList1" runat="server" CssClass=" form-control" >
                        <asp:ListItem>Please Select...</asp:ListItem>
                        <asp:ListItem Value="d"> – </asp:ListItem>
                        <asp:ListItem Value="">– Conference &amp; Events and</asp:ListItem>
                       <%-- <asp:ListItem Value=" –  IT Gods"> –  IT Gods</asp:ListItem>--%>
                        <%--<asp:ListItem Value="HR Gods"> –  HR Gods</asp:ListItem>--%>
                        <asp:ListItem Value=" –  UK" – UK</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="DropDownList1" ErrorMessage="*Please choose your department" InitialValue="Please Select..."></asp:RequiredFieldValidator>
            </div>

            <div class="row form-group">
                <div class="col">
                    <asp:Label ID="Label3" runat="server" Text="1st Signed by:" Visible="False"></asp:Label>
                </div>
                <div class="col">
                    <asp:TextBox ID="TextBox8" runat="server" Visible="false"></asp:TextBox>
                </div>
                <div class="col">
                    <asp:Label ID="Label7" runat="server" Text="Label" Visible="false"></asp:Label>
                </div>
            </div>

            <div class="row form-group">
                <div class="col">
                    <asp:Label ID="Label4" runat="server" Text="2nd Signed by:" Visible="False"></asp:Label>
                </div>
                     <div class="col">
                    <asp:TextBox ID="TextBox9" runat="server" Visible="false"></asp:TextBox>
                </div>
                   <div class="col">
                    <asp:Label ID="Label8" runat="server" Text="Label" Visible="false"></asp:Label>
                </div>
            </div>

            <div class="row form-group">
                     </div>
                <div class="col">
                    <asp:Label ID="Label5" runat="server" Text="3rd Signed by:" Visible="False"></asp:Label>             
                <div class="col>
                    <asp:TextBox ID="TextBox10" runat="server" Visible="false"></asp:TextBox>           
                     </div>
                <div class="col">
                    <asp:Label ID="Label9" runat="server" Text="Label" Visible="false"></asp:Label>
                </div>
            </div>


            <div class="row form-group">
                <div class="col">
                     <asp:Button ID="Button1" runat="server" Height="65px" OnClick="Button1_Click" Text="Submit" Width="555px" CssClass=" btn-block center-block" />
            <asp:Button ID="Button2" runat="server" Height="65px" Text="Sign" Width="555px " Visible="false" OnClick="Button2_Click" CssClass="btn-default center-block" />
                      <button id="Button3" runat="server" class="btn btn-primary hidden-print" onclick="myFunction()" visible="False"><span class="glyphicon glyphicon-print" aria-hidden="true"></span>Print</button>
                     <br />
                     <br />
                     <br />
                     <br />
                     <br />
                     <br />
                </div>
            </div>
           
          
        </div>
    </form>
</body>

</html>
