Public Class Persona
    Private nombres As String
    Private apellidos As String
    Private edad As Integer

    Public Sub New(nombres As String, apellidos As String, edad As Integer)
        Me.nombres = nombres
        Me.apellidos = apellidos
        Me.edad = edad
    End Sub

    Public Property Nombres1 As String
        Get
            Return nombres
        End Get
        Set(value As String)
            nombres = value
        End Set
    End Property

    Public Property Apellidos1 As String
        Get
            Return apellidos
        End Get
        Set(value As String)
            apellidos = value
        End Set
    End Property

    Public Property Edad1 As Integer
        Get
            Return edad
        End Get
        Set(value As Integer)
            edad = value
        End Set
    End Property
End Class
