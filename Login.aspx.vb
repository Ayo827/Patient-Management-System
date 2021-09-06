Imports System.Data
Imports System.Data.SqlClient
Public Class _Login
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load



    End Sub

    Protected Sub Submit()
        ' Dim Query As String = String.Empty
        'Query = "SELECT * FROM registration;"
        Dim email2 As String = email.Text
        Dim password2 As String = password.Text
        Dim email1 As Object
        Dim password1 As Object
        Dim tableuser As DataTable = New DataTable()
        Using conn As New SqlConnection("Data Source=DESKTOP-UOES1FR; Database=Hospital_Management; trusted_connection=true;")
            Using cmd As New SqlCommand("login")
                cmd.CommandType = CommandType.StoredProcedure
                email1 = cmd.Parameters("@email")
                password1 = cmd.Parameters("@password")
                tableuser.Load(cmd.ExecuteReader())
            End Using
            Console.WriteLine("the email and password from table is", {0}, {1}, email1, password1)

        End Using
        Dim AdmID = tableuser.Rows(0)("ID")
        'create cookie
        If email2 = AdmID.email1 And password2 = AdmID.password1 Then
            Response.Redirect("default.aspx")
        End If
    End Sub
End Class

