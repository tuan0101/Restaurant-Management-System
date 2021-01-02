

Public Class Account
    Public Sub New(ID As Integer, firstName As String, lastName As String, empType As String)
        Me.EmployeeID = ID
        Me.firstName = firstName
        Me.lastName = lastName
        Me.empType = empType
    End Sub

    Public Sub New(ByVal row As DataRow)
        Me.EmployeeID = CInt(row("EmployeeID"))
        Me.EmployeeFName = row("EmployeeFName").ToString()
        Me.EmployeeLName = row("EmployeeLName").ToString()
        Me.Type = row("Type").ToString()

    End Sub


    Private id As Integer
    Private firstName As String
    Private lastName As String
    Private empType As String

    Public Property EmployeeID As Integer
        Get
            Return id
        End Get
        Set(ByVal value As Integer)
            id = value
        End Set
    End Property


    Public Property EmployeeFName As String
        Get
            Return firstName
        End Get
        Set(ByVal value As String)
            firstName = value
        End Set
    End Property

    Public Property EmployeeLName As String
        Get
            Return lastName
        End Get
        Set(ByVal value As String)
            lastName = value
        End Set
    End Property

    Public Property Type As String
        Get
            Return empType
        End Get
        Set(ByVal value As String)
            empType = value
        End Set
    End Property
End Class
