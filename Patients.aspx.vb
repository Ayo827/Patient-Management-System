Imports System.Data
Imports System.Data.SqlClient

Public Class _Patient
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then
            Me.BindGrid()
        End If


    End Sub
    Private Sub BindGrid()
        ' Dim Query As String = String.Empty
        'Query = "SELECT * FROM registration;"
        Using conn As New SqlConnection("Data Source=DESKTOP-UOES1FR; Database=Hospital_Management; trusted_connection=true;")
            Using cmd As New SqlCommand("SELECT * FROM registration")
                Using sda As New SqlDataAdapter()
                    cmd.Connection = conn
                    sda.SelectCommand = cmd
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        GridView1.DataSource = dt
                        GridView1.DataBind()
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Protected Sub OnPageIndexChanging(sender As Object, e As GridViewPageEventArgs)
        GridView1.PageIndex = e.NewPageIndex
        Me.BindGrid()
    End Sub
End Class