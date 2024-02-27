Module Module1
    Sub Main()

        Dim a, b, c As Integer 'to declare varables a,b
        Console.WriteLine("THIS SOFTWARE CALCULATE SUM OF TWO NUMBERS")

        Console.WriteLine("ENTER FIRST NUMBER") 'console.writeLine gives comment to user
        a = Console.ReadLine() 'enter value for variable a

        Console.WriteLine("ENTER SECOND NUMBER") 'console.writeLine gives comment to user
        b = Console.ReadLine() 'enter value variable b
        c = a + b

        Console.WriteLine("RESULT = " + c.ToString)
        Console.ReadLine()
    End Sub
End Module