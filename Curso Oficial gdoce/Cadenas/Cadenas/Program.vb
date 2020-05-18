Imports System


'Comparar cadenas
''Module Program

''    Sub Main()

'        Dim str1, str2 As String

'        str1 = "Esto es una prueba"

'        str2 = "Otra cadena"

'        If (String.Compare(str1, str2) = 0) Then

'            Console.WriteLine(str1 + " y " + str2 + " son iguales.")

'        Else

'            Console.WriteLine(str1 + " y " + str2 + " no son iguales.")

'        End If
'    End Sub

'End Module

'Cadena contiene cadena

'Module Program

'    Sub Main()

'        Dim str1 As String

'        str1 = "Esto es una prueba"

'        If (str1.Contains("prueba")) Then

'            Console.WriteLine("Se ha encontrado la palabra 'prueba'.")

'        End If

'        Console.ReadLine()

'    End Sub
'End Module

'Obtener cadenas

'Module Program

'    Sub Main()

'        Dim str As String

'        str = "En un lugar de la Mancha, de cuyo nombre no quiero acordarme"

'        Console.WriteLine(str)

'        Dim substr As String = str.Substring(26)

'        Console.WriteLine(substr)

'        Console.ReadLine()
'    End Sub
'End Module


Module Program
    Sub Main()

        Dim strarray As String() = {
                                    "Una",
                                    "frase",
                                    "en",
                                    "un",
                                    "array"
                                    }

        Dim str As String = String.Join(“ - “, strarray)

        Console.WriteLine(str)

        Console.ReadLine()

    End Sub
End Module


