<%@ Page Language="VB" MasterPageFile="hospital.Master" AutoEventWireup="true"  CodeFile="Profile.aspx.vb" Inherits="_Profile" Title="Profile"   %>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div class="Profile">
        <div class="Profile__Image">
           <img src="#" alt="profile-image" />
        </div>
        <div class="Profile__Details">
            <div enctype ="multipart/form-data" runat="server">
                <label>
                    First Name
                </label><br>
                <input type="text" class="Profile__Input" id="f_name" placeholder="Enter your first name" runat="server"/>
                <br><br>
                <label>
                    Last Name
                </label><br>
                <input type="text" class="Profile__Input" id="l_name" placeholder="Enter your Last name" runat="server"/>
                <br><br>
                <label>
                    Email
                </label><br>
                <input type="email" class="Profile__Input" id="email" placeholder="Enter your email" runat="server"/>
                <br><br>
                 <label >Photo:</label><br>
                <input type="file" accept="image/*" class="photo"  id="photo" name="photo" runat="server"/>
            <br><br>
                <input type="submit" class="submit" runat="server"/>
            </div>
        </div>
    </div>
</asp:Content>