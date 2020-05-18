Imports System

'Module Program

'    Sub Main()

'        Dim a As Short

'        Dim b As Integer

'        Dim c As Double

'        a = 10

'        b = 20

'        c = a + b

'        Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c)

'        Console.ReadKey()

'    End Sub

'End Module


'Module Program

'    Sub Main()

'        Const PI = 3.14149

'        Dim radio, area As Single

'        radio = 7

'        area = PI * radio * radio

'        Console.WriteLine("Area = " & Str(area))

'        Console.ReadKey()

'    End Sub

'End Module


'Module Program

'    Enum Colores

'        red = 1

'        orange = 2

'        yellow = 3

'        green = 4

'        azure = 5

'        blue = 6

'        violet = 7

'    End Enum

'    Sub Main()

'        Console.WriteLine("El color rojo es: " & Colores.red)

'        Console.WriteLine("El color amarillo es: " & Colores.yellow)

'        Console.WriteLine("El color azul es: " & Colores.blue)

'        Console.WriteLine("El color verde es: " & Colores.green)

'        Console.ReadKey()

'    End Sub

'End Module

'Array invertidos

'Module Program

'    Sub Main()

'        Dim list As Integer() = {34, 72, 13, 44, 25, 30, 10}

'        Dim temp As Integer() = list

'        Dim i As Integer

'        Console.Write("Array original: ")

'        For Each i In list

'            Console.Write("{0} ", i)

'        Next i

'        Console.WriteLine()

'        ' reverse the array

'        Array.Reverse(temp)

'        Console.Write("Array invertido: ")

'        For Each i In temp

'            Console.Write("{0} ", i)

'        Next i

'        Console.WriteLine()

'        'sort the array

'        Array.Sort(list)

'        Console.Write("Array ordenado: ")

'        For Each i In list

'            Console.Write("{0} ", i)

'        Next i

'        Console.WriteLine()

'        Console.ReadKey()

'    End Sub

'End Module

Module Program

    Sub Main()

        Dim nombre, apellido, nombreCompleto, saludo As String

        nombre = "Carlos"

        apellido = "Pérez"

        nombreCompleto = nombre + " " + apellido
        Console.WriteLine("Nombre completo: {0}", nombreCompleto)

        'Utilizando el constructor de string

        Dim letras As Char() = {"H", "o", "l", "a"}

        saludo = New String(letras)

        Console.WriteLine("Saludos: {0}", saludo)

        'Utilizando métodos que retornan String

        Dim sarray() As String = {"Hola", "desde", "Visual", "Basic"}

        Dim mensaje As String = String.Join(" ", sarray)

        Console.WriteLine("Mensaje: {0}", mensaje)

        'Formateando métodos que convierten valores

        Dim esperar As DateTime = New DateTime(2012, 12, 12, 17, 58, 1)

        Dim chat As String = String.Format("Mensaje enviado el {0:t} el {0:D}", esperar)

        Console.WriteLine("Mensaje: {0}", chat)

        Console.ReadLine()

    End Sub

End Module