<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="MARKETINGWEB.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
               <div class="form-group">
      <label for="email" >ID:</label>
                   <asp:TextBox ID="txtid" runat="server" Cssclass="form-control"></asp:TextBox>
   
    </div>
    <div class="form-group">
      <label for="pwd">NAME:</label>
     <asp:TextBox ID="txtname" runat="server" Cssclass="form-control"></asp:TextBox>
    </div>
             <div class="form-group">
      <label for="pwd">DESCRIPTION:</label>
     <asp:TextBox ID="txtdescription" runat="server" Cssclass="form-control"></asp:TextBox>
    </div>
             <div class="form-group">
      <label for="pwd">PRICE:</label>
     <asp:TextBox ID="txtprice" runat="server" Cssclass="form-control"></asp:TextBox>
    </div>
                <div class="form-group">
      <label for="pwd">COST:</label>
     <asp:TextBox ID="txtcost" runat="server" Cssclass="form-control"></asp:TextBox>
    </div>
                <div class="form-group">
      <label for="pwd">SALES_PRICE:</label>
     <asp:TextBox ID="txtsales" runat="server" Cssclass="form-control"></asp:TextBox>
    </div>
                      <div class="form-group">
      <label for="pwd">TAX:</label>
     <asp:TextBox ID="txttax" runat="server" Cssclass="form-control"></asp:TextBox>
    </div>
   <div Cssclass="p-5">    
       
       <asp:Button ID="btninsert" runat="server" Text="INSERT"   Cssclass="btn btn-primary p-3" OnClick="btninsert_Click" />
             <asp:Button ID="Button1" runat="server" Text="UPDATE"  Cssclass="btn btn-primary p-3" OnClick="Button1_Click" />
             <asp:Button ID="Button2" runat="server" Text="SEARCH"  Cssclass="btn btn-primary p-3" OnClick="Button2_Click" />
             <asp:Button ID="Button3" runat="server" Text="DELETE"  Cssclass="btn btn-primary p-3" />
        <asp:Button ID="Button4" runat="server" Text="EMPLOYEE"  Cssclass="btn btn-primary p-3" OnClick="Button4_Click" />
       <asp:Button ID="Button5" runat="server" Text="SUPPLIERS"  Cssclass="btn btn-primary p-3" OnClick="Button4_Click" />
   </div>
            <div>


                <asp:GridView ID="GridView1" runat="server"></asp:GridView>

            </div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
   </div>
    </form>
</body>
</html>
