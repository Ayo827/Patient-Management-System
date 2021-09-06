<%@ Page EnableEventValidation="false" Language="VB" AutoEventWireup="true" CodeFile="Login.aspx.vb" Inherits="_Login" Title="Login-Page"  %>
<!DOCTYPE html>
<html>
    <head>
        <title>Login Page</title>
        <link href="Login.css" type="text/CSS" rel="stylesheet"/>
    </head>
    <body>
        <div class="Login">
            <div class="Login__Image">
                <img src="images/download.png" class="image" alt="Logo-image"/>
            </div>
            <div class="Login__Page">
                <div class="Login__PageHead">
                    <h2>Livewire Hospital Patient Management System</h2>
                </div>
                <div class ="Login__PageForm">
                    <form runat="server">
                    <label class="Login__label">Email</label><br>
                        <asp:TextBox TextMode="Email" id="email" class="Login__Input" name="email" placeholder="Enter your Email" runat="server" />
                    <br><br>
                    <label class="Login__label">Password</label><br>
                        <asp:TextBox TextMode="password" id="password" class="Login__Input" name="password" placeholder="Enter your password" runat="server" />
                    <br><br>
                     
                   <center> <asp:LinkButton ClientIDMode="Static" onclick="Submit" cssClass="submit" id="submit_"  runat="server">SUBMIT</asp:LinkButton></center>
                        </form>
                </div>
            </div>
        </div>
    </body>
</html>