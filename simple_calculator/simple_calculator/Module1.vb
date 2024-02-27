Module Module1

    Sub Main()
        Dim op, firstno, secondno, result As Double
        Dim action As Char
        Do Until action = "N"
            Console.WriteLine("THIS SOFTWARE USE FOR SIMPLE CALCULATION")
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>")

            Console.WriteLine("ENTER FIRST NUMBER")
            firstno = Console.ReadLine()

            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>")
            Console.WriteLine("press 1 TO FIND THE SUM OF TWO NUMBERS")
            Console.WriteLine("press 2 TO FIND THE DIFERRENCES BETWEEN TWO NUMBERS")
            Console.WriteLine("press 3 TO FIND THE FRACTION OF TWO NUMBERS")
            Console.WriteLine("press 4 TO FIND THE PRODUCT OF TWO NUMBERS")
            op = Console.ReadLine()

            If (op = "1") Then

                Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>")

                Console.WriteLine("ENTER SECOND NUMBER")
                secondno = Console.ReadLine()

                result = firstno + secondno

                Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>")

                Console.WriteLine("RESULT = " + result.ToString("N0"))

            ElseIf (op = "2") Then
                Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>")

                Console.WriteLine("ENTER SECOND NUMBER")
                secondno = Console.ReadLine()
                Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>")

                result = firstno - secondno
                Console.WriteLine("RESULT = " + result.ToString("N0"))

            ElseIf (op = "3") Then
                Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>")

                Console.WriteLine("ENTER SECOND")
                secondno = Console.ReadLine()
                Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>")

                If (secondno = 0) Then
                    Console.WriteLine("CAN'T BE DIVIDE BY 0")
                Else : result = firstno / secondno
                    Console.WriteLine("RESULT = " + result.ToString("N0"))
                End If

            ElseIf (op = "4") Then

                Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>")

                Console.WriteLine("ENTER SECOND NUMBER")
                secondno = Console.ReadLine()
                Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>")

                result = firstno * secondno
                Console.WriteLine("RESULT = " + result.ToString("N0"))
            Else
                Console.WriteLine(">>> WRONG INPUT")
            End If
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>")

            Console.WriteLine("TO CONTINUE PRESS 'Y'")
            Console.WriteLine("TO STOP PRESS 'N'")
            action = Console.ReadLine()
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>")

        Loop
        Console.ReadLine()

    End Sub

End Module
