Public Class Mascota
    Private _namePet As String
    Private _edadPet As Integer
    Private _owner As Persona

    Public Sub New(namePet As String, edadPet As Integer, owner As Persona)
        Me.NamePet = namePet
        _edadPet = edadPet
        _owner = owner
    End Sub

    Public Property NamePet As String
        Get
            Return _namePet
        End Get
        Set(value As String)
            _namePet = value
        End Set
    End Property

    Public Property EdadPet As Integer
        Get
            Return _edadPet
        End Get
        Set(value As Integer)
            _edadPet = value
        End Set
    End Property

    Public Property Owner As Persona
        Get
            Return _owner
        End Get
        Set(value As Persona)
            _owner = value
        End Set
    End Property
End Class
