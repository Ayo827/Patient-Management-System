Imports System.Drawing
Imports System.Data.SqlClient
Imports System.IO
Imports System.Web.UI.HtmlControls

Public Class _Profile
    Inherits Page



    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Dim firstName As String
        firstName = f_name.Value
        Dim lastName As String
        lastName = l_name.Value
        Dim Email_ As String
        Email_ = email.Value


        'Dim picture As Image = Image.FromFile(photo.Value, False)













    End Sub



End Class