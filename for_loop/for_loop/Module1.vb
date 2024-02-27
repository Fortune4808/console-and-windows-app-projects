Module Module1

    Sub Main()
        Dim i, number, b, c2, c, result, op As Integer
        Dim action As Char
        Do Until action = "N"
            Console.WriteLine("PRESS 1 FOR MULTIPLICATION TABLE")
            Console.WriteLine("PRESS 2 FOR FACTORIAL")
            op = Console.ReadLine()
            Console.WriteLine(".............................................")
            If (op = 1) Then

                Console.WriteLine("MULTIPLICATION TABLE")
                Console.WriteLine(".............................................")
                Console.WriteLine("ENTER NUMBER")
                number = Console.ReadLine()
                Console.WriteLine(".............................................")
                Console.WriteLine("ENTER LENGTH")
                b = Console.ReadLine()
                Console.WriteLine(".............................................")

                For i = 1 To b
                    result = number * i

                    Console.WriteLine(number.ToString + " X " + i.ToString + " = " + result.ToString)

                Next


            ElseIf (op = 2) Then

                Console.WriteLine("FACTORIAL")
                Console.WriteLine(".............................................")
                Console.WriteLine("ENTER NUMBER")
                number = Console.ReadLine()
                Console.WriteLine(".............................................")
                c = 1
                For i = 1 To number
                    c2 = c
                    c = c * i
                    Console.WriteLine(i.ToString + " X " + c2.ToString + " = " + c.ToString)

                Next


            Else
                Console.WriteLine("ERROR! Invalid Input")

            End If
            Console.WriteLine(".............................................")

            Console.WriteLine("TO CONTINUE PRESS 'Y'")
            Console.WriteLine("TO STOP PRESS 'N'")
            action = Console.ReadLine()
            Console.WriteLine(".............................................")

        Loop

        Console.ReadLine()

    End Sub

End Module
