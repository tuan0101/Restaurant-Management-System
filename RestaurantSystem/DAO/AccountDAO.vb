
Public Class AccountDAO
    Private Shared inst As AccountDAO
    Private Sub New()

    End Sub
    Public Shared Property Instance As AccountDAO
        Get
            If (inst Is Nothing) Then
                inst = New AccountDAO
            End If

            Return AccountDAO.inst
        End Get
        Private Set(ByVal value As AccountDAO)
            inst = value
        End Set
    End Property

    Public Function getListAccount() As List(Of Account)
        Dim list As List(Of Account) = New List(Of Account)()
        Dim query As String = "select * from EmployeeInfo"
        Dim data As DataTable = DataProvider.Instance.executeQuery(query)

        For Each item As DataRow In data.Rows
            Dim foodItem As Account = New Account(item)
            list.Add(foodItem)
        Next

        Return list
    End Function

    Public Function insertEmp(id As Integer, firstName As String, lastName As String, type As String) As Boolean
        Dim query = "insert into EmployeeInfo (EmployeeID, EmployeeFName, EmployeeLName, Type) 
                        values (@1, @2, @3, @4)"
        Dim result = DataProvider.Instance.executeNonQuery(query, {id, firstName, lastName, type})
        Return result > 0
    End Function

    Public Function changeEmp(id As Integer, firstName As String, lastName As String, type As String) As Boolean
        Dim query = "update EmployeeInfo set EmployeeFName = @1, EmployeeLName = @2, Type = @3 
                        where EmployeeID = @4"
        Dim result = DataProvider.Instance.executeNonQuery(query, {firstName, lastName, type, id})
        Return result > 0
    End Function

    Public Function deleteEmp(id As Integer) As Boolean
        Dim query = "delete * from EmployeeInfo where EmployeeID = @1"
        Dim result = DataProvider.Instance.executeNonQuery(query, {id})
        Return result > 0
    End Function

    Public Function getEmpNameBy(empID As String) As String
        Dim query = "select EmployeeFName from EmployeeInfo where EmployeeID = @1"
        Dim data = DataProvider.Instance.executeScalar(query, {empID})
        Return data.ToString()
    End Function
End Class
