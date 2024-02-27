Module Module1

    Sub Main()
        Dim radius, a, b, c As Double
        Console.WriteLine("THIS SOFTWARE CALCULATE THE AREA OF A CIRCLE")
        Console.WriteLine("------------------------------------------------")
        Console.WriteLine("ENTER RADIUS")
        radius = Console.ReadLine()
        Console.WriteLine("------------------------------------------------")
        a = 22 / 7
        b = radius * radius
        c = 22 / 7 * b
        Console.WriteLine("THE RESULT IS = " + c.ToString)


        Console.ReadLine()
    End Sub

End Module
