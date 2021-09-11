Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.Common

Public Class DataAccess

    ''' <summary>
    ''' Create a Command and connection Object from a select connectionstring and provider name
    ''' </summary>
    ''' <returns>Returns Created command object</returns>
    ''' <remarks></remarks>
    Public Shared Function CreateCommand() As DbCommand
        'get the connectionstring
        Dim conStr As String = Config.DbConnectionString
        'get the provider name
        Dim provider As String = Config.DbProviderName

        Dim _factory As DbProviderFactory = DbProviderFactories.GetFactory(provider)
        'Get the command from supplied provider name e.g sqlconnection if provider name is System.Data.SqlClient
        Dim _conn As DbConnection = _factory.CreateConnection()
        _conn.ConnectionString = conStr
        'Get the command from supplied provider name
        Dim cmd As DbCommand = _conn.CreateCommand()
        cmd.CommandType = Data.CommandType.StoredProcedure

        Return cmd
    End Function

    ''' <summary>
    ''' Create a Command and connection Object from a select connectionstring and provider name. It takes command as parameter
    ''' </summary>
    ''' <param name="cmdText"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function CreateCommand(ByVal cmdText As String) As DbCommand
        'get the connectionstring
        Dim conStr As String = Config.DbConnectionString
        'get the provider name
        Dim provider As String = Config.DbProviderName

        Dim _factory As DbProviderFactory = DbProviderFactories.GetFactory(provider)
        'Get the command from supplied provider name e.g sqlconnection if provider name is System.Data.SqlClient
        Dim _conn As DbConnection = _factory.CreateConnection()
        _conn.ConnectionString = conStr
        'Get the command from supplied provider name
        Dim cmd As DbCommand = _conn.CreateCommand()
        cmd.CommandType = Data.CommandType.Text
        cmd.CommandText = cmdText
        Return cmd
    End Function

    Public Shared Function ExecuteSelectCommand(ByVal _command As DbCommand) As DataTable
        Dim table As DataTable = New DataTable()
        _command.Connection.Open()
        Try
            Dim reader As DbDataReader = _command.ExecuteReader()
            table.Load(reader)
            reader.Close()
        Catch ex As Exception
            Throw
        Finally
            _command.Connection.Close()
        End Try
        Return table
    End Function

    ''' <summary>
    ''' ExecuteNonQuery as the name suggests insert data into the database
    ''' </summary>
    ''' <param name="_command"></param>
    ''' <returns>Returns an integer as no of affected rows</returns>
    ''' <remarks></remarks>
    Public Shared Function ExecuteNonQuery(ByVal _command As DbCommand) As Int32
        Dim affectedRows As Int32 = -1
        Try
            _command.Connection.Open()
            Dim trans As DbTransaction = _command.Connection.BeginTransaction()
            Try
                _command.Transaction = trans
                affectedRows = _command.ExecuteNonQuery
                trans.Commit()
            Catch ex As Exception
                trans.Rollback()
            End Try
        Catch ex As Exception
            Throw
        Finally
            _command.Connection.Close()
        End Try
        Return affectedRows
    End Function

    ''' <summary>
    ''' For parameter without size
    ''' </summary>
    ''' <param name="comm"></param>
    ''' <param name="parameterName"></param>
    ''' <param name="parameterValue"></param>
    ''' <param name="parameterDbType"></param>
    ''' <remarks></remarks>
    Public Shared Sub AddParameter(ByVal comm As DbCommand, ByVal parameterName As String,
                                   ByVal parameterValue As Object, ByVal parameterDbType As DbType)
        Dim param As DbParameter = comm.CreateParameter()

        With param
            .ParameterName = parameterName
            .Value = parameterValue
            .DbType = parameterDbType
        End With

        comm.Parameters.Add(param)
    End Sub
    ''' <summary>
    ''' For parameter with size
    ''' </summary>
    ''' <param name="comm"></param>
    ''' <param name="parameterName"></param>
    ''' <param name="parameterValue"></param>
    ''' <param name="parameterDbType"></param>
    ''' <param name="size"></param>
    ''' <remarks></remarks>
    Public Shared Sub AddParameter(ByVal comm As DbCommand, ByVal parameterName As String,
                                  ByVal parameterValue As Object, ByVal parameterDbType As DbType, ByVal size As Int32)
        Dim param As DbParameter = comm.CreateParameter()

        With param
            .ParameterName = parameterName
            .Value = parameterValue
            .DbType = parameterDbType
        End With

        comm.Parameters.Add(param)
    End Sub

    ''' <summary>
    ''' For Output parameter
    ''' </summary>
    ''' <param name="comm"></param>
    ''' <param name="parameterName"></param>
    ''' <param name="parameterDbType"></param>
    ''' <param name="_parameterDirection"></param>
    ''' <param name="size"></param>
    ''' <remarks></remarks>
    Public Shared Sub AddParameter(ByVal comm As DbCommand, ByVal parameterName As String,
                                   ByVal parameterDbType As DbType, ByVal _parameterDirection As ParameterDirection, ByVal size As Int32)
        Dim param As DbParameter = comm.CreateParameter()

        With param
            .ParameterName = parameterName
            .DbType = parameterDbType
            .Direction = _parameterDirection
            .Size = size
        End With

        comm.Parameters.Add(param)
    End Sub

    Public Shared Function ExecuteScalarCommand(ByVal _command As DbCommand) As Int32
        Dim result As Int32
        _command.Connection.Open()
        Try
            result = _command.ExecuteScalar

        Catch ex As Exception
            Throw
        Finally
            _command.Connection.Close()
        End Try
        Return result
    End Function

End Class

