<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Vendors.aspx.cs" Inherits="ITAssetManagementSystem.UI.Vendors" %>

<%@ Import Namespace="ITAssetManagementSystem.Model" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <h3>
                <asp:Label ID="lblVendors" runat="server"></asp:Label>
            </h3>
            <br />
            <h4>
                <asp:Label ID="lblVendorsInsert" runat="server" Text="Insert New Vendor" />
            </h4>
            <br />
            <asp:TextBox ID="txtVendortName" runat="server" class="form-control" type="text" Text="Name"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtVendorEmail" runat="server" class="form-control" type="text" Text="Email"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtVendorAddress" runat="server" class="form-control" type="text" Text="Address"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtVendorPhone" runat="server" class="form-control" type="text" Text="Phone"></asp:TextBox>
            <br />
            <asp:Button ID="btnSaveVendor" runat="server" Text="Save" class="btn btn-success" OnClick="btnSaveVendor_onclick" />
            <asp:Button ID="btnUpdate" runat="server" Text="Update" class="btn btn-success" OnClick="btnUpdateVendor_onclick" />
            <br />
            <br/>
        </div>

        <div class="row">
            <asp:GridView ID="grdVendor" runat="server" AutoGenerateColumns="False" BackColor="White"
                BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="VendorId" 
                OnRowDeleting="grdVendor_RowDeleting" OnSelectedIndexChanged="grdVendor_SelectedIndexChanged">
                <Columns>
                    <asp:TemplateField HeaderText="Sr. no" ItemStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                            <%#Container.DataItemIndex+1 %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" ItemStyle-HorizontalAlign="Center"/>
                    <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" ItemStyle-HorizontalAlign="Center"/>
                    <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" ItemStyle-HorizontalAlign="Center"/>
                    <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone" ItemStyle-HorizontalAlign="Center"/>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:CommandField ShowDeleteButton="True"/>
                </Columns>
                <EditRowStyle HorizontalAlign="Center" />
                <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                <RowStyle BackColor="White" ForeColor="#003399" VerticalAlign="Middle" />
                <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                <SortedAscendingCellStyle BackColor="#EDF6F6" />
                <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                <SortedDescendingCellStyle BackColor="#D6DFDF" />
                <SortedDescendingHeaderStyle BackColor="#002876" />
            </asp:GridView>

        </div>


    </div>
</asp:Content>
