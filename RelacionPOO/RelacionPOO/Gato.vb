Public Class Gato
    Inherits Mascota

    Private _life As Integer

    Public Sub New(namePet As String, edadPet As Integer, owner As Persona, life As Integer)
        MyBase.New(namePet, edadPet, owner)
        _life = life
    End Sub

    Public Property Life As Integer
        Get
            Return _life
        End Get
        Set(value As Integer)
            _life = value
        End Set
    End Property
End Class
