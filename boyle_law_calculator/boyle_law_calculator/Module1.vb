Module Module1

    Sub Main()
        Dim firstpressure, secondpressure, firstvolume, secondvolume, op, result, a As Double
        Console.WriteLine("THIS SOFTWARE CALCULATE BOYLE'S LAW")
        Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>")
        Console.WriteLine("press 1 TO FIND INITIAL PRESSURE(P1)")
        Console.WriteLine("press 2 TO FIND FINAL PRESSURE(P2)")
        Console.WriteLine("press 3 TO FIND INITIAL VOLUME(V1)")
        Console.WriteLine("press 4 TO FIND FINAL VOLUME(V2)")
        op = Console.ReadLine()

        If (op = "1") Then
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>")
            Console.WriteLine("ENTER FINAL PRESSURE(P2)")
            secondpressure = Console.ReadLine()
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>")
            Console.WriteLine("ENTER FINAL VOLUME(V2)")
            secondvolume = Console.ReadLine()
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>")
            Console.WriteLine("ENTER INITIAL VOLUME(V1)")
            firstvolume = Console.ReadLine()
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>")

            a = secondpressure * secondvolume
            result = a / firstvolume
            Console.WriteLine("RESULT IS = " + result.ToString)

        ElseIf (op = "2") Then
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>")
            Console.WriteLine("ENTER INITAIL PRESSURE(P1)")
            firstpressure = Console.ReadLine()
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>")
            Console.WriteLine("ENTER INITIAL VOLUME(V1)")
            firstvolume = Console.ReadLine()
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>")
            Console.WriteLine("ENTER FINAL VOLUME(V2)")
            secondvolume = Console.ReadLine()
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>")

            a = firstpressure * firstvolume
            result = a / secondvolume
            Console.WriteLine("RESULT IS = " + result.ToString)

        ElseIf (op = "3") Then
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>")
            Console.WriteLine("ENTER FINAL PRESSURE(P2)")
            secondpressure = Console.ReadLine()
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>")
            Console.WriteLine("ENTER FINAL VOLUME(V2)")
            secondvolume = Console.ReadLine()
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>")
            Console.WriteLine("ENTER INITIAL PRESSURE(P1)")
            firstpressure = Console.ReadLine()
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>")

            a = secondpressure * secondvolume
            result = a / firstpressure
            Console.WriteLine("RESULT IS = " + result.ToString)

        ElseIf (op = "4") Then
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>")
            Console.WriteLine("ENTER INITIAL PRESSURE(P1)")
            firstpressure = Console.ReadLine()
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>")
            Console.WriteLine("ENTER INITIAL VOLUME(V1)")
            firstvolume = Console.ReadLine()
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>")
            Console.WriteLine("ENTER FINAL PRESSURE(P2)")
            secondpressure = Console.ReadLine()
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>")

            a = firstpressure * firstvolume
            result = a / secondpressure
            Console.WriteLine("RESULT IS = " + result.ToString)
        Else
            Console.WriteLine(">>>INVALID INPUT")


        End If

        If (result = a / 0) Then
            Console.WriteLine(">>>ERROR")
        End If


        Console.ReadLine()

    End Sub

End Module
