Module Module1

    Sub Main()
        Dim firstno, secondno, result As Double
        Console.WriteLine("THIS SOFTWARE CALCULATE THE FRACTION OF TWO NUMBERS")
        Console.WriteLine("*********************************************")

        Console.WriteLine("INPUT NUMERATOR")
        firstno = Console.ReadLine()
        Console.WriteLine("*********************************************")

        Console.WriteLine("INPUT DENOMERATOR")
        secondno = Console.ReadLine()

        result = firstno / secondno
        Console.WriteLine("*********************************************")

        If (secondno = 0) Then
            Console.WriteLine("CAN'T BE DIVIDE BY 0")
        Else : result = firstno / secondno
            Console.WriteLine("RESULT = " + result.ToString("N0"))
        End If


        Console.ReadLine()


    End Sub

End Module
