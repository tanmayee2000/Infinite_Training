<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Validator.aspx.cs" Inherits="Q1_ValidatorForm.Validator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 800px">
            Insert Your Details:<br />
            <br />
            Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Name" ControlToValidate="txtName" ForeColor="Red">*</asp:RequiredFieldValidator>
            <br />
            <br />
            Family Name:&nbsp;&nbsp; <asp:TextBox ID="txtFamName" runat="server"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtFamName" ErrorMessage="Family" ForeColor="Red">*</asp:RequiredFieldValidator>
            &nbsp;<asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtName" ControlToValidate="txtFamName" ErrorMessage="should differ from Name" ForeColor="Red" SetFocusOnError="True" Operator="NotEqual">Should differ from Name</asp:CompareValidator>
            &nbsp;<br />
            <br />
            Address:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtAddress" ErrorMessage="Address" ForeColor="Red">*</asp:RequiredFieldValidator>
            &nbsp;<asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtAddress" ErrorMessage="at least 2 chars" ForeColor="Red" MaximumValue="Max" MinimumValue="2">Should contain at least 2 chars</asp:RangeValidator>
            &nbsp;<br />
            <br />
            City:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtCity" ErrorMessage="City" ForeColor="Red">*</asp:RequiredFieldValidator>
            &nbsp;<asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="txtCity" ErrorMessage="at least 2 chars" ForeColor="Red" MaximumValue="Max" MinimumValue="2">at least 2 chars</asp:RangeValidator>
            &nbsp;<br />
            <br />
            Zip Code:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtZip" runat="server"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtZip" ErrorMessage="Zip Code" ForeColor="Red">*</asp:RequiredFieldValidator>
            &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtZip" ErrorMessage="(xxxxx)" ForeColor="Red" ValidationExpression="^\d{5}$">(xxxxx)</asp:RegularExpressionValidator>
            <br />
            <br />
            Phone:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtPhoneNo" runat="server"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtPhoneNo" ErrorMessage="Phone" ForeColor="Red">*</asp:RequiredFieldValidator>
            &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtPhoneNo" ErrorMessage="(xx-xxxxxxx/xxx-xxxxxxx)" ForeColor="Red" ValidationExpression="^\d{2,3}-\d{7}$">(xx-xxxxxxx/xxx-xxxxxxx)</asp:RegularExpressionValidator>
            <br />
            <br />
            E-Mail:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtEmail" ErrorMessage="E-Mail" ForeColor="Red">*</asp:RequiredFieldValidator>
            &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtEmail" ErrorMessage="example@example.com" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">example@example.com</asp:RegularExpressionValidator>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
            <br />
&nbsp;<asp:Button ID="Btn_Check" runat="server" Text="Check" Width="74px" />
            <br />
            <br />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" HeaderText="ValidationSum" ShowMessageBox="True" />
            <br />
      
        </div>
    </form>
</body>
</html>
