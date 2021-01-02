Imports System.Data.OleDb
Imports System.Configuration
Imports System.Data.SqlClient

Public Class DataProvider
    Private Shared inst As DataProvider
    'Private Shared ReadOnly inst As New Lazy(Of DataProvider)(Function() New DataProvider(),
    '     System.Threading.LazyThreadSafetyMode.ExecutionAndPublication)

    Private Sub New()

    End Sub
    Public Shared Property Instance As DataProvider
        Get
            If (inst Is Nothing) Then
                inst = New DataProvider
            End If

            Return DataProvider.inst
        End Get
        Private Set(ByVal value As DataProvider)
            inst = value
        End Set
    End Property




    Public Function executeQuery1(query As String) As DataTable
        Dim data As DataTable
        Using connection As New OleDbConnection(My.Settings.Restaurant_DatabaseVer12002_03ConnectionString)

            connection.Open()

            Dim cmd As OleDbCommand = New OleDbCommand(query, connection)

            Dim adapter As New OleDbDataAdapter()
            adapter.SelectCommand = cmd

            Dim ds As New DataSet()
            adapter.Fill(ds)
            data = ds.Tables(0)

            connection.Close()
            Return data
        End Using
    End Function


    Public Function executeQuery(query As String, Optional parameter As Object() = Nothing) As DataTable
        Dim data As DataTable
        Using connection As New OleDbConnection(My.Settings.Restaurant_DatabaseVer12002_03ConnectionString)

            connection.Open()

            Dim cmd As OleDbCommand = New OleDbCommand(query, connection)

            If parameter IsNot Nothing Then
                Dim listPara As String() = query.Split(" ")
                Dim i = 0
                For Each element In listPara
                    If element.Contains("@") Then
                        cmd.Parameters.AddWithValue(element, parameter(i))
                        i += 1
                    End If

                Next
            End If

            Dim adapter As New OleDbDataAdapter()
            adapter.SelectCommand = cmd

            Dim ds As New DataSet()
            adapter.Fill(ds)
            data = ds.Tables(0)

            connection.Close()
            Return data
        End Using
    End Function

    Public Function executeNonQuery(query As String, Optional parameter As Object() = Nothing) As Integer
        Dim rows As Integer
        Using connection As New OleDbConnection(My.Settings.Restaurant_DatabaseVer12002_03ConnectionString)

            connection.Open()

            Dim cmd As OleDbCommand = New OleDbCommand(query, connection)

            If parameter IsNot Nothing Then
                Dim listPara As String() = query.Split(" ")
                Dim i = 0
                For Each element In listPara
                    If element.Contains("@") Then
                        cmd.Parameters.AddWithValue(element, parameter(i))
                        i += 1
                    End If

                Next
            End If
            Try
                rows = cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Please try again!")

            End Try


            connection.Close()
            Return rows
        End Using
    End Function

    Public Function executeScalar(query As String, Optional parameter As Object() = Nothing) As Object
        Dim data As Object = 0
        Using connection As New OleDbConnection(My.Settings.Restaurant_DatabaseVer12002_03ConnectionString)

            connection.Open()

            Dim cmd As OleDbCommand = New OleDbCommand(query, connection)

            If parameter IsNot Nothing Then
                Dim listPara As String() = query.Split(" ")
                Dim i = 0
                For Each element In listPara
                    If element.Contains("@") Then
                        cmd.Parameters.AddWithValue(element, parameter(i))
                        i += 1
                    End If

                Next
            End If

            data = cmd.ExecuteScalar()

            connection.Close()
            Return data
        End Using
    End Function

    Public Function excuteReader(query As String, para As String, Optional parameter As Object() = Nothing) As Object
        Dim list As List(Of String) = New List(Of String)()
        Using connection As New OleDbConnection(My.Settings.Restaurant_DatabaseVer12002_03ConnectionString)

            connection.Open()

            Using cmd As OleDbCommand = New OleDbCommand(query, connection)

                If parameter IsNot Nothing Then
                    Dim listPara As String() = query.Split(" ")
                    Dim i = 0
                    For Each element In listPara
                        If element.Contains("@") Then
                            cmd.Parameters.AddWithValue(element, parameter(i))
                            i += 1
                        End If

                    Next
                End If
                Dim data = cmd.ExecuteReader()
                While data.Read()
                    If Not list.Contains(data(para)) Then
                        list.Add(data(para).ToString())
                    End If

                End While
                connection.Close()
                Return list
            End Using
        End Using
    End Function

    Public Function executeReader1(query As String, Optional parameter As Object() = Nothing) As Object
        Dim data
        Using connection As New OleDbConnection(My.Settings.Restaurant_DatabaseVer12002_03ConnectionString)

            connection.Open()

            Dim cmd As OleDbCommand = New OleDbCommand(query, connection)

            If parameter IsNot Nothing Then
                Dim listPara As String() = query.Split(" ")
                Dim i = 0
                For Each element In listPara
                    If element.Contains("@") Then
                        cmd.Parameters.AddWithValue(element, parameter(i))
                        i += 1
                    End If

                Next
            End If

            Dim reader = cmd.ExecuteReader()
            reader.Read()
            data = reader.ToString(2)
            connection.Close()
            Return data
        End Using
    End Function

End Class
