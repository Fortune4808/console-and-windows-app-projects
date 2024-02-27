Module Module1

    Sub Main()
        Dim firstno, secondno, result As Double
        Console.WriteLine("THIS SOFTWARE CALCULATE THE DIFFERENCE BETWEEN TWO NUMBERS")
        Console.WriteLine("*******************************************")

        Console.WriteLine("ENTER FIRST NUMBER")
        firstno = Console.ReadLine()
        Console.WriteLine("*******************************************")

        Console.WriteLine("ENTER SECOND NUMBER")
        secondno = Console.ReadLine()
        Console.WriteLine("*******************************************")

        result = firstno - secondno
        Console.WriteLine("RESULT = " + result.ToString("N0"))








        Console.ReadLine()
    End Sub

End Module
