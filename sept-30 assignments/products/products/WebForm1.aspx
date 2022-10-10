<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="producs.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
         <asp:Label ID="lblProductid" runat="server" Text="Enter Product ID" BackColor="White"></asp:Label>
        <asp:TextBox ID="txtprodid" runat="server" BorderColor="#CC9900"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtprodid" ErrorMessage="enter product id" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label ID="lblProdname" runat="server" Text="Enter Product Name"></asp:Label>
        <asp:TextBox ID="txtprodname" runat="server" BorderColor="#CC9900"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtprodname" ErrorMessage="enter product name" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label ID="lblprice" runat="server" Text="Enter Price"></asp:Label>
        <asp:TextBox ID="txtprice" runat="server" BorderColor="#CCCC00"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtprice" ErrorMessage="enter price" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add Cookies" />
       
        <br />
        <asp:Label ID="Label1" runat="server" Text="add cookies in the list" BackColor="Yellow" BorderColor="#CC0000"></asp:Label>
        <br />
        <asp:ListBox ID="ListBox1" runat="server" BackColor="#66CCFF" Height="240px" Width="245px"></asp:ListBox>
         <br /> <br />


        <asp:Label ID="Label2" runat="server" Text="inserting products" BackColor="Lime"></asp:Label>
        <p>
         <asp:Label ID="lblProductid0" runat="server" Text="Enter Product ID" BackColor="White"></asp:Label>
        <asp:TextBox ID="txtprodid0" runat="server" BorderColor="#CC9900"></asp:TextBox>
        </p>
        <p>
        <asp:Label ID="lblProdname0" runat="server" Text="Enter Product Name"></asp:Label>
        <asp:TextBox ID="txtprodname0" runat="server" BorderColor="#CC9900"></asp:TextBox>
        </p>
        <p>
        <asp:Label ID="lblprice0" runat="server" Text="Enter Price"></asp:Label>
        <asp:TextBox ID="txtprice0" runat="server" BorderColor="#CCCC00"></asp:TextBox>
        </p>
        <p>
       
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="insert" />
        <asp:Label ID="lbl0" runat="server" Text="status"></asp:Label>
       
        </p>



        <p>


        <asp:Label ID="Label3" runat="server" Text="delete products" BackColor="Lime"></asp:Label>
        </p>
        <p>
         <asp:Label ID="lblProductid1" runat="server" Text="Enter Product ID" BackColor="White"></asp:Label>
        <asp:TextBox ID="txtprodid1" runat="server" BorderColor="#CC9900"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="delete" />
        <asp:Label ID="lbl1" runat="server" Text="status"></asp:Label>
       
        </p>
        <p>


        <asp:Label ID="Label4" runat="server" Text="update products" BackColor="Lime"></asp:Label>
        </p>
        <p>
         <asp:Label ID="lblProductid2" runat="server" Text="Enter Product ID" BackColor="White"></asp:Label>
        <asp:TextBox ID="txtprodid2" runat="server" BorderColor="#CC9900"></asp:TextBox>
        </p>
        <p>
        <asp:Label ID="lblProdname1" runat="server" Text="Enter Product Name"></asp:Label>
        <asp:TextBox ID="txtprodname2" runat="server" BorderColor="#CC9900"></asp:TextBox>
        </p>
        <p>
        <asp:Label ID="lblprice1" runat="server" Text="Enter Price"></asp:Label>
        <asp:TextBox ID="txtprice2" runat="server" BorderColor="#CCCC00"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="update" runat="server" OnClick="Button6_Click" Text="update" />
        <asp:Label ID="lbl2" runat="server" Text="status"></asp:Label>
       
        </p>
        <p>


        <asp:Label ID="Label5" runat="server" Text="view products" BackColor="Lime"></asp:Label>
           
            <table>
                <tr>
                    <td>
                         <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>

                    </td>
                </tr>
            </table>
        </p>
        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click1" Text="click to view products" />



        <asp:Label ID="lbl3" runat="server" Text="status"></asp:Label>
       
        <p>


        <asp:Label ID="Label6" runat="server" Text="view particular products" BackColor="Lime"></asp:Label>
           
            </p>
        <p>
         <asp:Label ID="lblProductid3" runat="server" Text="Enter Product ID" BackColor="White"></asp:Label>
        <asp:TextBox ID="txtprodid3" runat="server" BorderColor="#CC9900"></asp:TextBox>
        </p>
                         <asp:GridView ID="GridView2" runat="server">
            </asp:GridView>

                    <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="get particular product detail" />
        <asp:Label ID="lbl4" runat="server" Text="status"></asp:Label>
       
        <p>
            &nbsp;</p>



    </form>
</body>
</html>
