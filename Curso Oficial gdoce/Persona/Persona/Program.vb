Imports System

Module Program
    Sub Main()
        Dim P As Persona = New Persona("Juan", 6)
        Console.WriteLine("Se ha creado la persona")

        Dim a As Integer = P.GetEdad()
        Console.WriteLine(a)
        P.CumplirAños()
        Dim b As Integer = P.GetEdad()
        Console.WriteLine(b)
        Dim c As Boolean = P.EsMayorDeEdad()
        Console.WriteLine(c)
        Dim d As String = P.GetDatos()
        Console.WriteLine(d)
    End Sub


    Public Class Persona

        Private edad As Integer

        Private nombre As String

        Public Sub New(nombre As String, edad As Integer)

            Me.nombre = nombre

            If edad < 0 Then
                Me.edad = 18
            Else
                Me.edad = edad
            End If
        End Sub

        Public Sub SetEdad(ByVal e As Integer)
            edad = e
        End Sub

        Public Function GetEdad() As Integer

            Return edad

        End Function

        Public Sub SetName(ByVal n As String)
            nombre = n
        End Sub

        Public Function GetName() As String

            Return nombre

        End Function

        Public Sub CumplirAños()
            edad += 1
        End Sub

        Public Function EsMayorDeEdad()
            If (GetEdad() >= 18) Then
                Return True
            Else
                Return False
            End If
        End Function

        Public Function GetDatos()

            Dim edad As String
            Dim nombre As String
            Dim todo As String

            edad = GetEdad()
            nombre = GetName()

            todo = "Nombre de la persona: " + nombre + ". " + "Edad de la persona: " + edad + " Años"
            Return todo

        End Function

    End Class
End Module
