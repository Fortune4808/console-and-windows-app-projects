Module Module1

    Sub Main()
        Dim a, b, c, d, e, f, g, h, x1, x2 As Double
        Console.WriteLine("THIS SOFTWARE SOLVE QUADRATIC EQUATION")
        Console.WriteLine("---------------------------------------------")
        Console.WriteLine("INPUT COEFFICIENT a")
        a = Console.ReadLine()
        Console.WriteLine("---------------------------------------------")
        Console.WriteLine("INPUT COEFFICIENT b")
        b = Console.ReadLine()
        Console.WriteLine("---------------------------------------------")
        Console.WriteLine("INPUT COEFFICIENT c")
        c = Console.ReadLine()
        Console.WriteLine("---------------------------------------------")

        d = b * b
        e = 4 * a * c
        f = d - e
        g = Math.Sqrt(f)
        h = 2 * a
        x1 = (-b + g) / h
        x2 = (-b - g) / h

        Console.WriteLine("x1 = " + x1.ToString)

        Console.WriteLine("x2 = " + x2.ToString)


        Console.ReadLine()


    End Sub

End Module
