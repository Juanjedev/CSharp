Imports System

Module Program
    Sub Main()

        Dim anio As Integer

        Console.WriteLine("Por favor introduce un año")

        anio = Console.ReadLine()



        While anio < 0 Or anio > 2100

            Console.WriteLine("El año debe estar comprendido enrte 0 y 2100")
            Console.WriteLine("Por favor, introduce el año de nuevo: ")
            anio = Console.ReadLine()

        End While


        If (anio Mod 4 = 0 And anio Mod 100 <> 0 Or anio Mod 400 = 0) Then
            Console.WriteLine("El año " + Trim(anio) + " Si es bisiesto")
        Else
            Console.WriteLine("El año " + Trim(anio) + " No es bisiesto")
        End If
    End Sub
End Module
