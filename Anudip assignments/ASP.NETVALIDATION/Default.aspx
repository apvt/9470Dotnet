<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ASP.NETVALIDATION.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table style="width:66%;">
        <h1>ASP.NET Validation Controls</h1>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
        <tr>
            <td>
            First Name :
                </td>
            <td>
 <asp:TextBox ID="txtFirstName" runat="server" CausesValidation="True">
 </asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please Provide First Name" ControlToValidate="txtFirstName"> Required
            </asp:RequiredFieldValidator>
                </td>
        </tr>
        
        <tr>
            <td>
            Last Name:
                </td>
            <td>
 <asp:TextBox ID="txtLastName" runat="server">
 </asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please Provide Last Name" ControlToValidate="txtLastName"> Required
            </asp:RequiredFieldValidator>
                </td>
        </tr>
        <br />
       <tr>
         <td>
           Education:
         </td>

        <td>
            <asp:DropDownList ID="ddlEducation" runat="server"  style="width:239px">
               <asp:ListItem>Please Choose a Education</asp:ListItem>
               <asp:ListItem>SSC</asp:ListItem>
               <asp:ListItem>Diploma</asp:ListItem>
               <asp:ListItem>Graduate</asp:ListItem>
               <asp:ListItem>Post Graduate</asp:ListItem>
            </asp:DropDownList>
         </td>
           </tr>
        
        <tr>
            <td>
            Password :
                </td>
            <td>
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Please Provide Password" ControlToValidate="txtpassword"> Required
            </asp:RequiredFieldValidator>
        </td>
        </tr>
        
        <tr>
            <td>
            Confirm Password :   
                </td>
            <td>
        <asp:TextBox ID="txtConfirmtxtPassword" runat="server"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Please ensure the password and confirm password is same" ControlToValidate="txtConfirmtxtPassword" ControlToCompare="txtPassword">*
        </asp:CompareValidator>
                </td>
        </tr>

        <tr>
            <td>
            Age :
                </td>
            <td>
            <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Age must be between 18 and 50 " ControlToValidate="txtAge" MaximumValue="50" MinimumValue="18" Type="Integer">
            </asp:RangeValidator>
                </td>
        </tr>
        
        <tr>
            <td>
            Email Id :
                </td>
            <td>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" runat="server" ErrorMessage="Please enter valid email" ControlToValidate="txtEmail">
            </asp:RegularExpressionValidator>
                </td>
        </tr>
        
        <tr>
            <td>
            Mobile Number : 
                </td>
            <td>
           <asp:TextBox ID="txtph_no" runat="server"></asp:TextBox>
             <asp:RequiredFieldValidator ID="txtphno" ValidationExpression="^(\d\d\d\d\d\d\d\d\d\d)?$"  runat="server" ErrorMessage="Please Provide Password" ControlToValidate="txtph_no"> Required
            </asp:RequiredFieldValidator>
                </td>
        </tr>

        <tr>
            <td>
            Message :
                </td>
            <td>
            <asp:TextBox ID="txtMessage" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Text must be 10 Characters long!" ControlToValidate="txtMessage"> Required
            </asp:RequiredFieldValidator>
                </td>
       </tr>
            <tr>
                <td>
            <asp:Button ID="BtnSubmit" runat="server" Text="Submit" OnClick="BtnSubmit_Click"></asp:Button>
                    </td>
             </tr>
            </table>
    </form>
</body>
</html>


