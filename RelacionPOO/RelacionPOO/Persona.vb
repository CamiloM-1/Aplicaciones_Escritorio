Public Class Persona
    Private _name As String
    Private _lastName As String
    Private _phone As String

    Public Sub New(name As String, lastName As String, phone As String)
        _name = name
        _lastName = lastName
        _phone = phone
    End Sub

    Public Property Phone As String
        Get
            Return _phone
        End Get
        Set(value As String)
            _phone = value
        End Set
    End Property

    Public Property LastName As String
        Get
            Return _lastName
        End Get
        Set(value As String)
            _lastName = value
        End Set
    End Property

    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property
End Class
