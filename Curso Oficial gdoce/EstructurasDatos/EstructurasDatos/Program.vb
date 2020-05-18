Imports System

'Module Program

'    Sub Main()

'        ' Crear una lista de cadenas

'        Dim salmons As New List(Of String)

'        salmons.Add("chinook")

'        salmons.Add("coho")

'        salmons.Add("pink")

'        salmons.Add("sockeye")

'        ' Iterar a lo largo de la lista

'        For Each salmon As String In salmons

'            Console.Write(salmon & " ")

'        Next

'        Console.ReadKey()

'    End Sub

'End Module

'Module Program

'    Sub Main()

'        Dim salmons As New List(Of String) From
'{"chinook", "coho", "pink", "sockeye"}

'        For index = 0 To salmons.Count - 1
'            Console.Write(salmons(index) & " ")

'        Next

'        Console.ReadKey()

'    End Sub

'End Module


Module Program
    Sub Main()

        ' Crear una lista of strings mediante un inicializador de colección

        Dim salmons As New List(Of String) From
{"chinook", "coho", "pink", "sockeye"}

        ' Eliminar un elemento de la lista especificando el objeto.

        salmons.Remove("coho")

        For Each salmon As String In salmons

            Console.Write(salmon & " ")

        Next

        Console.ReadKey()

    End Sub

End Module