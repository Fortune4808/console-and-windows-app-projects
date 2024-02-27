Module Module1

    Sub Main()
        Dim firstNo, SecondNo As Integer
        Console.WriteLine("THIS SOFTWARE CHECK HIGHEST OF TWO NUMBERS")
        Console.WriteLine("............................................")
        Console.WriteLine("ENTER FIRST NUMBER")
        firstNo = Console.ReadLine()
        Console.WriteLine("............................................")

        Console.WriteLine("ENTER SECOND NUMBER")
        SecondNo = Console.ReadLine()
        Console.WriteLine("............................................")

        If (firstNo > SecondNo) Then
            Console.WriteLine(firstNo.ToString + " IS THE HIGHEST NUMBER")
        Else
            Console.WriteLine(SecondNo.ToString + " IS THE HIGHEST NUMBER")
        End If

        Console.ReadLine()

    End Sub

End Module

