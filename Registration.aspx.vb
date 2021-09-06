Imports System.IO
Imports System.Drawing
Imports System.Data.SqlClient
Public Class _Registration
    Inherits Page

    '   Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-UOES1FR; Database=Hospital_Management; trusted_connection=true;")
    '  Dim cmd As SqlCommand
    ' Dim da As SqlDataAdapter
    ' Dim dt As DataTable
    'Dim sql As String
    '  Dim result As Integer

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load



    End Sub
    ' Private Sub saveData(sql As String)
    'Try
    '       con.Open()
    '      cmd = New SqlCommand()

    ' With cmd
    '.Connection = con
    '.CommandText = sql
    '           result = .ExecuteNonQuery()
    'End With

    'If result > 0 Then
    '           MsgBox("Data has been saved in the database!")
    'Else
    '           MsgBox("Error to execute the query!")
    'End If
    'Catch ex As Exception
    '       MsgBox(ex.Message)
    'Finally
    '       con.Close()
    'End Try
    ' End Sub
    'Private Sub loadData(sql As String) 'dtg As DataGridView
    'Try
    '       con.Open()
    '      cmd = New SqlCommand()
    '     da = New SqlDataAdapter
    ' dt = New DataTable

    'With cmd
    '.Connection = con
    '.CommandText = sql
    'End With
    'With da
    '.SelectCommand = cmd
    ' .Fill(dt)
    'End With
    '   dtg.DataSource = dt

    'Catch ex As Exception
    '       MsgBox(ex.Message)
    'Finally
    '       con.Close()
    '      da.Dispose()
    'End Try
    ' End Sub
    Protected Sub Submit(sender As Object, e As EventArgs)

        Dim firstName As String = first_name.Value
        Dim lastName As String = last_name.Value
        Dim _birthday As String = birthday.Value
        Dim _male As String = male.Text
        Dim _female As String = female.Text
        Dim _phone As String = phone.Value
        Dim _email As String = email.Value
        Dim _address As String = address.Value
        Dim temp As String = "~/uploads/"

        'Dim filePath As String = Server.MapPath("~/uploads/") + photo.PostedFile.FileName
        'Path.GetFileName(photo.PostedFile.FileName)
        ' Dim filePath As String = Directory.
        Dim filePath As String = Server.MapPath(temp + photo.PostedFile.FileName)

        photo.SaveAs(filePath)

        Dim gender As String
        If male.Checked = True Then
            gender = _male
        ElseIf male.Checked = False Then
            gender = _female
        End If
        '  Dim filePath As String = Server.MapPath("~/uploads/") + photo.PostedFile.FileName
        ' Dim filePath As HttpPostedFile = Path.GetFullPath(photo)
        'Dim PostedFile As Image = Image.FromFile("photo", False)
        ' Dim filePath As String = Path.GetFullPath(photo.PostedFile.FileName)




        Dim query As String = String.Empty
        query &= "INSERT INTO registration (FirstName, LastName, Birthday, "
        query &= "                     Gender, Phone,  "
        query &= "                     Email, Address_, Picture) "
        query &= "VALUES (@FirstName, @LastName, @Birthday, @Gender, @Phone, @Email, @Address_, @Picture)"


        Using conn As New SqlConnection("Data Source=DESKTOP-UOES1FR; Database=Hospital_Management; trusted_connection=true;")
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    ' .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@FirstName", firstName)
                    .Parameters.AddWithValue("@LastName", lastName)
                    .Parameters.AddWithValue("@Birthday", _birthday)
                    .Parameters.AddWithValue("@Gender", gender)
                    '.Parameters.AddWithValue("@Gender", _female)
                    .Parameters.AddWithValue("@Phone", _phone)
                    .Parameters.AddWithValue("@Email", _email)
                    .Parameters.AddWithValue("@Address_", _address)
                    .Parameters.AddWithValue("@Picture", temp + photo.PostedFile.FileName)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message)

                End Try
            End Using
        End Using

        ' sql = "INSERT INTO registration (FirstName, LastName, Birthday, Male, Female, Phone, Email, Address_, Picture) values ('" & firstName & " ', ' " & lastName & " ', '" & _birthday & " ', '" & _male & "', '" & _female & "', '" & _phone & "', '" & _email & "', '" & _address & "', ' " & filePath & "')"
        ' saveData(sql)


        ' sql = "SELECT * FROM registration"
        ' loadData(sql) 'dtgList






        'Access the File using the Name of HTML INPUT File.
        '   Dim postedFile As HttpPostedFile = Request.Files("photo")
        ' Dim postedFile As Image = Image.FromFile("photo", False)
        ' Dim postedFile = Get
        'Check if File is available.
        '  If postedFile IsNot Nothing And postedFile.ContentLength > 0 Then
        'Save the File.
        '   Dim filePath As String = Server.MapPath("~/uploads/") + Path.GetFileName(photo.PostedFile.FileName)
        ' Dim image As String = Path.GetTempFileName(photo.PostedFile.FileName)
        ' Dim filePath As String = 
        ' Path.GetFullPath(photo.PostedFile.FileName)

        '  submit_.Text = filePath

        'postedFile.SaveAs(filePath)
        'lblMessage.Visible = True 
        '  End If

        ' Dim ofd As New OpenFileDialog
        'ofd.FileName = ""
        'ofd.Filter = "PNG & JPG Supported Files Only(*.png,*jpg)|*.png;*.jpg"
        'If ofd.ShowDialog() = Windows.Forms.DialogResult.OK Then
        '    pbimage.Image = Image.FromFile(ofd.FileName)
        'End If

    End Sub

End Class