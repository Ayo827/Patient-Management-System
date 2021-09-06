<%@ Page Language="VB" MasterPageFile="hospital.Master" AutoEventWireup="true" CodeFile="Patients.aspx.vb" Inherits="_Patient" Title="Patient"   %>
<asp:Content ID="Content4" ContentPlaceHolderID="MainContent" runat="server">

<asp:GridView ID="GridView1"  AutoGenerateColumns="false" AllowPaging="true" OnPageIndexChanging="OnPageIndexChanging" PageSize="10" runat="server">
    <Columns>
        <asp:BoundField ItemStyle-Width="150px" DataField="ID" HeaderText="ID" />
        <%--<asp:BoundField ItemStyle-Width="150px" DataField="Picture" HeaderText="Picture" />--%>
        <asp:TemplateField HeaderText="Image" ItemStyle-Width="150px" >
            <ItemTemplate>
                <asp:Image ImageUrl='<% # Eval("Picture") %>' Height="150px" Width="150px" runat="server" />
            </ItemTemplate>
            </asp:TemplateField>
        <asp:BoundField ItemStyle-Width="150px" DataField="FirstName" HeaderText="First Name" />
        <asp:BoundField ItemStyle-Width="150px" DataField="LastName" HeaderText="Last Name" />
        <asp:BoundField ItemStyle-Width="150px" DataField="Birthday" HeaderText="Date Of Birth" />
         <asp:BoundField ItemStyle-Width="150px" DataField="Gender" HeaderText="Gender" />
         <%--<asp:BoundField ItemStyle-Width="150px" DataField="Female" HeaderText="Female" />--%>
        <asp:BoundField ItemStyle-Width="150px" DataField="Phone" HeaderText="Phone Number" />
        <asp:BoundField ItemStyle-Width="150px" DataField="Email" HeaderText="Email" />
        <asp:BoundField ItemStyle-Width="150px" DataField="Address_" HeaderText="Location" />
    </Columns>
</asp:GridView>
</asp:Content>