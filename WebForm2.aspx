<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="digitalSignatures.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">
    <link rel="stylesheet" href="bootstap.min.css" />
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
         <li class="active"><a href="http://web. .ie/erf/">Employee Requisition Form</a></li>
   </ul>
 </div><!-- /.navbar-collapse -->
</div><!-- /.container-fluid -->
</nav>
    <div class="container">
    
   
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" CssClass="radio-inline">
            <asp:ListItem Value="Pending">Pending</asp:ListItem>
            <asp:ListItem Value="Completed">Completed</asp:ListItem>
        </asp:RadioButtonList>
        <asp:GridView ID="GridView1" runat="server" CssClass="table table-striped" AutoGenerateColumns="false">
             <Columns>
                           
                            <asp:BoundField HeaderText="jobtitle" DataField="jobtitle" Visible="false" />
                            <asp:BoundField HeaderText="newhire" DataField="newhire" />
                            <asp:BoundField HeaderText="department" DataField="department" />
                            <asp:BoundField HeaderText="signature1" DataField="signature1"/>
                            <asp:BoundField HeaderText="sigsign1" DataField="sigsign1" />
                            <asp:BoundField HeaderText="signature2" DataField="signature2"/>
                            <asp:BoundField HeaderText="sigsign2" DataField="sigsign2" />
                            <asp:BoundField HeaderText="counter" DataField="counter" Visible="false"/>
                        </Columns>
        </asp:GridView>
         </div>
    </form>
</body>
</html>
