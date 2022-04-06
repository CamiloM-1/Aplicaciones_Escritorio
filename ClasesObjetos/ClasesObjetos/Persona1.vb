Public Class Persona1
    Implements Interface1

    Private _nombre As String
    Private _apellido As String
    Private _edad As Integer

    Public Sub New(nombre As String, apellido As String, edad As Integer)
        _nombre = nombre
        _apellido = apellido
        _edad = edad
    End Sub

    Public Property nombre As String Implements Interface1.nombre
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property apellido As String Implements Interface1.apellido
        Get
            Return _apellido
        End Get
        Set(value As String)
            _apellido = value
        End Set
    End Property

    Public Property edad As Integer Implements Interface1.edad
        Get
            Return _edad
        End Get
        Set(value As Integer)
            _edad = value
        End Set
    End Property

    Public Sub age(edad As Integer) Implements Interface1.age
        Dim response As String = If(edad >= 18, "Mayor de edad", "Menos de edad")
        Console.WriteLine(response)
    End Sub

    Public Sub printing() Implements Interface1.printing
        Console.WriteLine("Datos personales")
        Console.WriteLine("Nombre: {0} Apellido: {1}", _nombre, _apellido)
        Console.WriteLine("Edad: {0}", _edad)
    End Sub

    Public Function age() As String Implements Interface1.age
        Dim response As String = If(edad >= 18, "Mayor de edad", "Menos de edad")
        Return response
    End Function
End Class
