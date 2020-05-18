Imports System
Module Program
    Sub Main()

        Dim tamanio As Integer
        Dim nota As Integer

        Console.WriteLine("Bienvenidos el registro de alumnos.")
        Console.WriteLine("Por favor, introduce el número de alumnos añadir: ")

        tamanio = Console.ReadLine


        While tamanio = 0

            Console.WriteLine("El número de alumnos deber ser mayor que 0.")
            Console.WriteLine("Por favor, introduce el número de alumnos añadir: ")

            tamanio = Console.ReadLine

        End While


        Dim calificaciones(tamanio - 1) As Integer

        For i = 0 To tamanio - 1


            Console.WriteLine("Por favor, introduce la nota del alumno: " & i)

            nota = Console.ReadLine
            While nota < 0 Or nota > 10

                Console.WriteLine("La nota debe estar comprendida entre 0 y 10.")
                nota = Console.ReadLine
            End While
            calificaciones(i) = nota
        Next i


        For j = 0 To tamanio - 1

            Console.WriteLine("Alumno({0}) = {1}", j, calificaciones(j))

        Next j


        Dim largest As Integer = Integer.MinValue
        Dim smallest As Integer = Integer.MaxValue

        For Each element As Integer In calificaciones

            largest = Math.Max(largest, element)
            smallest = Math.Min(smallest, element)
        Next
        Console.WriteLine("La nota máxima del curso es: ")
        Console.WriteLine(largest)
        Console.WriteLine("La nota mínima del curso es: ")
        Console.WriteLine(smallest)


        Dim suma As Decimal
        Dim promedio As Decimal


        suma = 0
        promedio = 0
        For i = 0 To (tamanio - 1)
            suma = suma + calificaciones(i)
        Next i

        promedio = suma / tamanio
        Console.WriteLine("La nota media del curso es: ")
        Console.WriteLine(promedio)


    End Sub

End Module