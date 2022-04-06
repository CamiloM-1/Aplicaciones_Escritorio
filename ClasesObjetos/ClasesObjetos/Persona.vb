Public Class Persona

    'Atributos

    Private _edad As Integer
    Private _genero As String
    Private _nombre As String
    Private _apellido As String
    Public response As String = ""
    Public Shared contador As Integer = 0

    'Constructor
    Public Sub New()
        'this = Me
        Me._nombre = ""
        Me._apellido = ""
        Me._edad = 0
        Me._genero = ""
    End Sub

    Public Sub New(nombre As String, apellido As String, edad As Integer, genero As String)
        'this = Me
        Me._nombre = nombre
        Me._apellido = apellido
        Me._edad = edad
        Me._genero = genero
    End Sub

    Public Sub New(edad As Integer)
        Me._edad = edad
    End Sub

    'Metodos get y set
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    'Metodos 

    Public Sub imprimiendo() 'Tipo procedimiento
        Console.WriteLine("Datos personales")
        Console.WriteLine("Nombre: {0} Apellido {1}", Me._nombre, Me._apellido)
    End Sub

    Public Function age() As String
        Dim response As String = If(Me._edad >= 18, "Mayor de edad", "Menos de edad")
        Return response
    End Function

    Public Function age(otraEdad As Integer) As String
        Dim response As String = If(otraEdad >= 18, "Mayor de edad", "Menos de edad")
        Return response
    End Function

    Shared Sub Contando()
        contador += 3
    End Sub


End Class
