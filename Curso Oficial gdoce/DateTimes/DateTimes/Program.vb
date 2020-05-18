Imports System

'Module Program

'    Sub Main()

'        'Constructor DateTime: year, month, day, hour, min, sec

'        Dim date1 As New Date(2012, 12, 16, 12, 0, 0)

'        'Inicializa un nuevo DateTime

'        Dim date2 As Date = #12/16/2012 12:00:52 AM#

'        'Usando propiedades

'        Dim date3 As Date = Date.Now

'        Dim date4 As Date = Date.UtcNow

'        Dim date5 As Date = Date.Today

'        Console.WriteLine(date1)

'        Console.WriteLine(date2)

'        Console.WriteLine(date3)

'        Console.WriteLine(date4)

'        Console.WriteLine(date5)

'        Console.ReadKey()

'    End Sub

'End Module

'Module Program

'    Sub Main()

'        Console.Write("Hora actual: ")

'        Console.WriteLine(DateTime.Now.ToLongTimeString)

'    End Sub

'End Module



'Module Program

'    Sub Main()

'        Console.WriteLine("Descubrimiento de América: ")

'        Dim descubrimiento As New Date(1492, 10, 12, 0, 0, 0)

'        ' Uso de Format para especificar cómo se muestra la fecha.

'        Console.WriteLine(" Format 'd:' " & descubrimiento.ToString("d"))

'        Console.WriteLine(" Format 'D:' " & descubrimiento.ToString("D"))

'        Console.WriteLine(" Format 't:' " & descubrimiento.ToString("t"))

'        Console.WriteLine(" Format 'T:' " & descubrimiento.ToString("T"))

'        Console.WriteLine(" Format 'f:' " & descubrimiento.ToString("f"))

'        Console.WriteLine(" Format 'F:' " & descubrimiento.ToString("F"))

'        Console.WriteLine(" Format 'g:' " & descubrimiento.ToString("g"))

'        Console.WriteLine(" Format 'G:' " & descubrimiento.ToString("G"))

'        Console.WriteLine(" Format 'M:' " & descubrimiento.ToString("M"))

'        Console.WriteLine(" Format 'R:' " & descubrimiento.ToString("R"))

'        Console.WriteLine(" Format 'y:' " & descubrimiento.ToString("y"))

'        Console.ReadKey()

'    End Sub

'End Module


Module Program

    Sub Main()

        Dim cumple As Date

        Dim dia As Integer

        Dim mes As Integer

        Dim nombreMes As String

        ' Asignar una fecha utilizando el formato corto estándar.

        cumple = #7/27/1998#

        dia = Microsoft.VisualBasic.DateAndTime.Day(cumple)

        mes = Microsoft.VisualBasic.DateAndTime.Month(cumple)

        nombreMes = Microsoft.VisualBasic.DateAndTime.MonthName(mes)

        Console.WriteLine(cumple)

        Console.WriteLine(dia)

        Console.WriteLine(mes)

        Console.WriteLine(nombreMes)

        Console.ReadKey()

    End Sub

End Module