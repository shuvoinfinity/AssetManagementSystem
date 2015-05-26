<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="ITAssetManagementSystem.UI.User" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
 <div class="row">
     <asp:Label ID="lblUser" runat="server"></asp:Label>
     <h2 class="lead"> Users List </h2>
     <asp:GridView ID="GridUsers" runat="server" BackColor="White" AllowPaging="True" AutoGenerateColumns="False" BorderColor="#DEDFDE" BorderStyle="Dashed" BorderWidth="1px" CellPadding="4" GridLines="Vertical" OnRowDeleting="GridUsers_RowDeleting" DataKeyNames="UserId" AllowSorting="True" ForeColor="Black">
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
             <asp:BoundField DataField="MobileNumber" HeaderText="Mobile Number" SortExpression="MobileNumber" />
             <asp:BoundField DataField="Designation" HeaderText="Designation" SortExpression="Designation" />
             <asp:BoundField DataField="ExtentionNumber" HeaderText="Extention No" SortExpression="ExtentionNumber" />
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
     <%--<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:FixAssetDBConnectionString %>" DeleteCommand="DELETE FROM [Users] WHERE [UserId] = @UserId" InsertCommand="INSERT INTO [Users] ([FirstName], [LastName], [UserEmail], [MobileNumber], [Designation], [ExtentionNumber]) VALUES (@FirstName, @LastName, @UserEmail, @MobileNumber, @Designation, @ExtentionNumber)" SelectCommand="SELECT [FirstName], [LastName], [UserEmail], [MobileNumber], [Designation], [ExtentionNumber], [UserId] FROM [Users]" UpdateCommand="UPDATE [Users] SET [FirstName] = @FirstName, [LastName] = @LastName, [UserEmail] = @UserEmail, [MobileNumber] = @MobileNumber, [Designation] = @Designation, [ExtentionNumber] = @ExtentionNumber WHERE [UserId] = @UserId">
         <DeleteParameters>
             <asp:Parameter Name="UserId" Type="Int32" />
         </DeleteParameters>
         <InsertParameters>
             <asp:Parameter Name="FirstName" Type="String" />
             <asp:Parameter Name="LastName" Type="String" />
             <asp:Parameter Name="UserEmail" Type="String" />
             <asp:Parameter Name="MobileNumber" Type="String" />
             <asp:Parameter Name="Designation" Type="String" />
             <asp:Parameter Name="ExtentionNumber" Type="String" />
         </InsertParameters>
         <UpdateParameters>
             <asp:Parameter Name="FirstName" Type="String" />
             <asp:Parameter Name="LastName" Type="String" />
             <asp:Parameter Name="UserEmail" Type="String" />
             <asp:Parameter Name="MobileNumber" Type="String" />
             <asp:Parameter Name="Designation" Type="String" />
             <asp:Parameter Name="ExtentionNumber" Type="String" />
             <asp:Parameter Name="UserId" Type="Int32" />
         </UpdateParameters>
     </asp:SqlDataSource>--%>
 </div>   
</asp:Content>
