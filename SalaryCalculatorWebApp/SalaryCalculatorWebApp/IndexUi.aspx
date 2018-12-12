<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IndexUi.aspx.cs" Inherits="SalaryCalculatorWebApp.IndexUi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Basic Salary"></asp:Label>
        <asp:TextBox ID="basicSalaryTextBox" runat="server"></asp:TextBox>
        <br/>
        <asp:Label ID="Label2" runat="server" Text="Medical Allowance"></asp:Label>
        <asp:TextBox ID="medicalAllowanceTextBox" runat="server"></asp:TextBox>
        <asp:Label ID="Label4" runat="server" Text="%"></asp:Label>

        <br/>
        <asp:Label ID="Label3" runat="server" Text="Conveyance"></asp:Label>
        <asp:TextBox ID="conveyanceTextBox" runat="server"></asp:TextBox>
        <asp:Label ID="Label5" runat="server" Text="%"></asp:Label>

        <br/>
        <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" />
        <asp:Button ID="calculateSalaryButton" runat="server" Text="Calculate Salary" OnClick="calculateSalaryButton_Click" />
        <br/>
        <asp:Label ID="outputLabel" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
