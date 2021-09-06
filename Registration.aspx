<%@ Page EnableEventValidation="false" Language="VB" MasterPageFile="hospital.Master"  AutoEventWireup="true" CodeFile="Registration.aspx.vb" Inherits="_Registration" Title="Registration"  %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<div class="registration">
     <div class="registration__Header">
        <h2>Register New Patients Information</h2>
     </div>
     <div class="registration__form">
        <div  id="form1">
            <label class="reg__label">First Name:</label><br>
            <input type="text" id="first_name" class="registration__input" name="first_name" runat="server" placeholder="Enter patient first name"/>
            <br><br>
              <label class="reg__label">Last Name:</label><br>
            <input type="text" id="last_name" class="registration__input" name="last_name" runat="server" placeholder="Enter patient last name"/>
            <br><br>
              <label class="reg__label">Date of birth:</label><br>
            <input type="date" id="birthday" class="registration__input" runat="server" name="birthday"/>
            <br><br>
            <label class="reg__label">Gender:</label><br>
            <div class="gender">
            <span>
            <asp:RadioButton id="male"  GroupName="Gender" runat="server" Text="Male"/>
            </span>
            <span>
             <asp:RadioButton GroupName="Gender" id="female"  runat="server" Text="Female"/>
            </span>
            </div>
            <br><br>
            <label class="reg__label">Mobile Number:</label><br>
            <input type="number" class="registration__input" maxlength=11 id="phone" name="phone" runat="server"/>
            <br><br>
            <label class="reg__label">Email:</label><br>
            <input type="email" class="registration__input"   id="email" name="email" runat="server"/>
            <br><br>
            
            <label class="reg__label">Patient Address:</label><br>
            <input type="text" class="registration__input"   id="address" name="address" runat="server"/>
            <br><br>
            <label class="reg__label">Photo:</label><br>
            <asp:FileUpload accept="image/*" class="photo"  id="photo" runat="server" />
             <asp:LinkButton ClientIDMode="Static" onclick="Submit" class="submit" id="submit_"  runat="server">SUBMIT</asp:LinkButton>
            <asp:Label ID = "lblMessage" Text="File uploaded successfully." runat="server" ForeColor="Green" Visible="false" />
            <br><br>
            
                 <script>
                     function getPath() {
                         var inputName = document.getElementById('photo');
                         var imgPath;

                         imgPath = inputName.value;
                         alert(imgPath);
                     }
                 </script> 
        </div>
     </div>
    </div>
</asp:Content>
 