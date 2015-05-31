<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="ITAssetManagementSystem.UI.Employee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
     <asp:Label ID="lblEmployee" runat="server"></asp:Label>
     <br />
     <table class="table-responsive">
         <tr>
             <td style="width: 119px">First Name</td>
             <td style="width: 207px">
                 <asp:TextBox ID="txtEmpFirstName" runat="server" Width="205px"></asp:TextBox>
             </td>
         </tr>
         <tr>
             <td style="width: 119px">Last Name</td>
             <td style="width: 207px">
                 <asp:TextBox ID="txtEmpLastName" runat="server" Width="205px"></asp:TextBox>
             </td>
         </tr>
         <tr>
             <td style="width: 119px">Email</td>
             <td style="width: 207px">
                 <asp:TextBox ID="txtEmpEmail" runat="server" Width="205px"></asp:TextBox>
             </td>
         </tr>
         <tr>
             <td style="width: 119px">Mobile Number</td>
             <td style="width: 207px">
                 <asp:TextBox ID="txtEmpMobileNo" runat="server" Width="205px"></asp:TextBox>
             </td>
         </tr>
         <tr>
             <td style="width: 119px">Designation</td>
             <td style="width: 207px">
                 <asp:TextBox ID="txtEmpDesignation" runat="server" Width="205px"></asp:TextBox>
             </td>
         </tr>
         <tr>
             <td style="width: 119px">Department</td>
             <td style="width: 207px">
                 <asp:DropDownList ID="DropDownList1" runat="server">
                     <asp:ListItem Value="0">Select Department</asp:ListItem>
                     <asp:ListItem Value="1">ABCD1</asp:ListItem>
                     <asp:ListItem Value="2">ABCD2</asp:ListItem>
                     <asp:ListItem Value="3">ABCD3</asp:ListItem>
                 </asp:DropDownList>
             </td>
         </tr>
         <tr>
             <td style="width: 119px">Extention Number</td>
             <td style="width: 207px">
                 <asp:TextBox ID="txtEmpExtenNo" runat="server" Width="205px"></asp:TextBox>
             </td>
         </tr>
         <tr>
             <td style="width: 119px">&nbsp;</td>
             <td style="width: 207px">
                 <asp:Button ID="btnUsrSave" runat="server" Text="Save" Width="205px" OnClick="btnUsrSave_Click"  />
             </td>
         </tr>
     </table>
     <h2 class="lead"> Employee List </h2>
     
     <asp:GridView ID="EmployeeGrid" runat="server" BackColor="White" AllowPaging="True" AutoGenerateColumns="False" BorderColor="#333300" BorderStyle="Dashed" BorderWidth="2px" CellPadding="4" GridLines="Vertical" OnRowDeleting="GridUsers_RowDeleting" DataKeyNames="EmployeeId" AllowSorting="True" ForeColor="Black">
         <AlternatingRowStyle BackColor="White" />
         <Columns>
             <asp:TemplateField  HeaderText="Sr. no">
                <ItemTemplate>
                    <%#Container.DataItemIndex+1 %>
                </ItemTemplate>
                 <ItemStyle HorizontalAlign="Justify" VerticalAlign="Middle" />
            </asp:TemplateField>
             <asp:BoundField DataField="FirstName" HeaderText="First Name" SortExpression="FirstName" />
             <asp:BoundField DataField="LastName" HeaderText="Last Name" SortExpression="LastName" />
             <asp:BoundField DataField="UserEmail" HeaderText="Email" SortExpression="UserEmail" >
             <HeaderStyle HorizontalAlign="Center" />
             </asp:BoundField>
             <asp:BoundField DataField="MobileNumber" HeaderText="Mobile" SortExpression="MobileNumber" />
             <asp:BoundField DataField="Designation" HeaderText="Designation" SortExpression="Designation" />
             <asp:BoundField DataField="ExtentionNumber" HeaderText="Exten No" SortExpression="ExtentionNumber" />
             <asp:CommandField ShowSelectButton="True" />
             <asp:CommandField ShowDeleteButton="True" />
         </Columns>
         <FooterStyle BackColor="#CCCC99" />
         <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
         <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
         <RowStyle BackColor="#F7F7DE" />
         <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
         <SortedAscendingCellStyle BackColor="#FBFBF2" />
         <SortedAscendingHeaderStyle BackColor="#848384" />
         <SortedDescendingCellStyle BackColor="#EAEAD3" />
         <SortedDescendingHeaderStyle BackColor="#575357" />
         
     </asp:GridView>
 </div>   
</asp:Content>

