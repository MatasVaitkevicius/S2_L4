<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="L4_WebPage.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <style>
        .Table {
            height: 20rem;
            width: 95rem
        }
        .Label {
            font-size: 1.5rem;
            font-weight: bold;
            font-family: 'Times New Roman';
        }
        .Button {
            height: 5rem;
            width: 15rem;
            background-color:cornsilk;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label" runat="server" Text="LD4_16" CssClass="Label"></asp:Label>
            <br />
            <br />
        </div>
        <div>
            <asp:Button ID="Button1" runat="server" Text="Skaityti ir Vykdyti" OnClick="Button1_Click" CssClass="Button" Font-Size="Medium"/>
        </div>
        <div>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Gyventojai" CssClass="Label"></asp:Label>
            <br />
            <asp:Table ID="Table1" runat="server" CssClass="Table">
            </asp:Table>
        </div>
        <div>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Teritorijos Valymas" CssClass="Label"></asp:Label>
            <asp:Table ID="Table2" runat="server" CssClass="Table"></asp:Table>
            <br />
            <br />
        </div>

        <br />
        <div>
           <asp:Label ID="Label4" runat="server" Text="Įveskite kainą pagal kurią šalinsite gyventojus" CssClass="Label"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
        </div>
        <div>
            <asp:Button ID="Button2" runat="server" Text="Pašalinti" OnClick="Button2_Click" CssClass="Button" Font-Size="Medium"/>
            <br />
            <br />
            <br />
            <br />
        </div>
        <asp:Label ID="Label5" runat="server" CssClass="Label">Šeimų sąrašas, kurie už teritorijos valymą moka daugiau, kaip įvestą suma</asp:Label>
        <br />
        <div>
            <asp:Table ID="Table3" runat="server" CssClass="Table">
            </asp:Table>
            <br />
            <br />
            <br />
        </div>
        <div>
            <asp:Label ID="Label6" runat="server" CssClass="Label">Pašalinti gyventojai, kurie už teritorijos valymą moka mokestį, mažesnį už vidutinį vienam žmogui</asp:Label>
            <asp:Table ID="Table4" runat="server" CssClass="Table">
            </asp:Table>
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>