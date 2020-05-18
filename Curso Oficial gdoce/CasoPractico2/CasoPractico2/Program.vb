Imports System

Module Program
    Sub Main()
        Dim C As Curso = New Curso("VB.NET", 150)
        Console.WriteLine("Se ha creado el curso")

        Dim A As Alumno = New Alumno("Pepe", C, 8)
        Console.WriteLine("Se ha creado el alumno")

        Dim nombCurso As String = C.GetNombreCurso()
        Console.WriteLine(nombCurso)

        Dim dur As Double = C.GetDuracion()
        Console.WriteLine(dur)

        Dim nombAlu As String = A.GetNombreAlumno()
        Console.WriteLine(nombAlu)

        Dim tipo As String = C.GetTipo()
        Console.WriteLine(tipo)



        Dim aprobado As Boolean = A.IsAprobado()
        If (aprobado) Then
            Console.WriteLine("El alumno ha aprobado")
        Else
            Console.WriteLine("El alumno ha suspendido")
        End If

        Console.WriteLine(A.ToString())

    End Sub


    Public Class Curso

        Private duracion As Integer

        Private nombre As String

        Public Sub New(nombre As String)

            Me.nombre = nombre

        End Sub

        Public Sub New(nombre As String, duracion As Integer)

            Me.nombre = nombre

            If duracion < 0 Then
                Me.duracion = vbNull
            Else
                Me.duracion = duracion
            End If
        End Sub

        Public Sub SetDuracion(ByVal d As Integer)


            If d < 0 Then
                Me.duracion = vbNull
            Else
                Me.duracion = d
            End If

        End Sub

        Public Function GetDuracion() As Integer

            Return duracion

        End Function

        Public Function GetNombreCurso() As String

            Return nombre

        End Function

        Public Function GetTipo() As String

            Dim corto As String
            Dim largo As String
            Dim intermedio As String

            corto = "corto"
            largo = "largo"
            intermedio = "intermedio"

            If duracion < 100 Then

                Return corto

            ElseIf duracion > 500 Then

                Return largo

            Else

                Return intermedio

            End If

        End Function




    End Class


    Public Class Alumno

        Private nombreAlumno As String
        Private CursoMatriculado As Curso
        Private notaFinal As Double

        Public Sub New(nombre As String, CursoMatriculado As Curso, notaF As Double)
            Me.CursoMatriculado = CursoMatriculado
            Me.nombreAlumno = nombre
            Me.notaFinal = notaF
        End Sub

        Public Sub SetNombreAlumno(ByVal n As String)
            nombreAlumno = n
        End Sub

        Public Function GetNombreAlumno() As String

            Return nombreAlumno

        End Function

        Public Function GetCurso() As String

            Return CursoMatriculado.GetNombreCurso()

        End Function


        Public Function GetNota() As String

            Return notaFinal

        End Function

        Public Function Calificar(n As Double)

            If (n >= 0 And n <= 10) Then
                notaFinal = n
                Return True
            Else
                Return False
            End If
        End Function

        Public Function IsAprobado()

            If (GetNota() >= 5) Then
                Return True
            Else
                Return False
            End If
        End Function

        Public Overrides Function ToString() As String

            Dim nombreAlumno As String
            Dim nombreCurso As String
            Dim duracionCurso As String
            Dim nF As String
            Dim todo As String

            nombreAlumno = GetNombreAlumno()
            nombreCurso = CursoMatriculado.GetNombreCurso()
            duracionCurso = CursoMatriculado.GetDuracion()
            nF = GetNota()

            todo = "Nombre del Alumno: " + nombreAlumno + ". " + "Nombre del curso: " + nombreCurso + " Duración del curso: " + duracionCurso + " horas " + "Nota final del curso: " + nF

            Return todo

        End Function

    End Class




End Module
