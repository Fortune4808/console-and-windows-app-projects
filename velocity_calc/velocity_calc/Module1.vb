Module Module1

    Sub Main()
        Dim u, a, t, b, c As Double
        Console.WriteLine("THIS SOFTWARE CALCULATE VELOCITY")
        Console.WriteLine("**************************************")
        Console.WriteLine("ENTER COEFFICIENT u")
        u = Console.ReadLine()
        Console.WriteLine("**************************************")
        Console.WriteLine("ENTER COEFFICIENT a")
        a = Console.ReadLine()
        Console.WriteLine("**************************************")
        Console.WriteLine("ENTER COEFFICIENT t")
        t = Console.ReadLine()
        Console.WriteLine("**************************************")
        b = a * t
        c = u + b
        Console.WriteLine("THE RESULT IS = " + c.ToString)



        Console.ReadLine()
    End Sub

End Module
