<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ViewState.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="lbl" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtname" runat="server" Height="38px" Width="268px"></asp:TextBox>
                    </td>
                    </tr>
                    <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Clear value" OnClick="Button1_Click" />
                    </td>
                    <td>
                        <asp:Button ID="Button2" runat="server" Text="Display Value" OnClick="Button2_Click" />

                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
