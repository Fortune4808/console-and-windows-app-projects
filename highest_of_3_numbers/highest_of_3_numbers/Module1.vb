Module Module1

    Sub Main()
        Dim a, b, c As Integer
        Console.WriteLine("THIS SOFTWARE FIND THE HIGHEST NUMBER BETWEEN THREE NUMBERS")
        Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>")
        Console.WriteLine("ENTER FIRST NUMBER")
        a = Console.ReadLine()
        Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>")
        Console.WriteLine("ENTER SECOND NUMBER")
        b = Console.ReadLine()
        Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>")
        Console.WriteLine("ENTER THIRD NUMBER")
        c = Console.ReadLine()
        Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>")
        If (a > b) Then
            Console.WriteLine(a.ToString + " IS THE BIGGEST NUMBER")
        ElseIf (b > c) Then
            Console.WriteLine(b.ToString + " IS THE BIGGEST NUMBER")
        Else
            Console.WriteLine(c.ToString + " IS THE BIGGEST NUMBER")

        End If
        Console.ReadLine()
    End Sub

End Module
