<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MobilePage.aspx.cs" Inherits="MobileClient.MobilePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Testing our Mobile Web Service</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 152px;
        }
    </style>
</head>
<body style="height: 130px">
    <form id="form1" runat="server">
        <div>
            Mobile display size Web Service<br />
            <br />
            Call the SOAP Web service with addition the Web Reference<br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">Inches</td>
                    <td>Сentimeters</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:TextBox ID="inches_tb" runat="server" Width="149px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label ID="centimeters_label" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
            <asp:Button ID="convert_button" runat="server" OnClick="convert_button_Click" Text="Convert" />
            <asp:Button ID="clear_btn" runat="server" OnClick="clear_btn_Click" Text="Clear" />
        </div>
        <div>
&nbsp;<br />
            Call the SOAP Web service with request<br />
            <br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">Inches</td>
                    <td>Сentimeters</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:TextBox ID="inches_tb_1" runat="server" Width="149px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label ID="centimeters_label_1" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
            <asp:Button ID="convert_button_1" runat="server" OnClick="convert_button_1_Click" Text="Convert" />
            <asp:Button ID="clear_btn_1" runat="server" OnClick="clear_btn_1_Click" Text="Clear" />
        </div>
    </form>
</body>
</html>
