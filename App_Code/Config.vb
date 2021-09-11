Imports Microsoft.VisualBasic

Public Class Config


#Region "Private Members"

    Private Shared _connectionString As String
    Private Shared _providerName As String
    ' Private Shared _connectionString2 As String
    ' Private Shared _providerName2 As String


#End Region

#Region "Constructor"
    Shared Sub New()

        _connectionString = ConfigurationManager.ConnectionStrings("Admins").ConnectionString
        _providerName = ConfigurationManager.ConnectionStrings("Admins").ProviderName

    End Sub

#End Region

#Region "Public Properties"
    Public Shared ReadOnly Property DbProviderName() As String
        Get
            Return _providerName
        End Get
    End Property




    Public Shared ReadOnly Property DbConnectionString() As String
        Get
            Return _connectionString
        End Get
    End Property


#End Region
End Class



