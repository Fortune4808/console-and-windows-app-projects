Module Module1

    Sub Main()
        Dim today, tomonth, toyear As Integer
        Dim birthday, birthmonth, birthyear As Integer
        Dim resultday, resultmonth, resultyear, DaysInMonth As Integer
            Console.WriteLine("AGE CALCULATOR")
            Console.WriteLine("........................................")

            today = Date.Now.Day
            tomonth = Date.Now.Month
            toyear = Date.Now.Year



            Console.WriteLine("TODAY'S DATE = " + today.ToString + "/" + tomonth.ToString + "/" + toyear.ToString)
            Console.WriteLine("........................................")

            Console.WriteLine("ENTER BIRTHDAY")
            birthday = Console.ReadLine()
            Console.WriteLine("........................................")
            Console.WriteLine("ENTER BIRTHMONTH")
            birthmonth = Console.ReadLine()
            Console.WriteLine("........................................")
            Console.WriteLine("ENTER BIRTHYEAR")
            birthyear = Console.ReadLine()
            Console.WriteLine("........................................")


        DaysInMonth = System.DateTime.DaysInMonth(birthyear, birthmonth)

        If (birthmonth = 1 Or 2 Or 3 Or 4 Or 5 Or 6 Or 7 Or 8 Or 9 Or 10 Or 11 Or 12) And (birthday > DaysInMonth Or birthday <= 0) Then
            Console.WriteLine("Error! Invalid Date, Kindly Select Another Date to Continue")

        Else

            If (birthmonth > 12) Or (birthmonth <= 0) Then
                Console.WriteLine("Error! Invalid Date, Kindly Select Another Date to Continue")
            ElseIf (birthyear > toyear) Or (birthyear <= 0) Then
                Console.WriteLine("Error! Invalid Date, Kindly Select Another Date to Continue")
            ElseIf (birthyear = toyear) And (birthmonth > tomonth) Then
                Console.WriteLine("Error! Invalid Date, Kindly Select Another Date to Continue")
            ElseIf (birthyear = toyear) And (birthday > today) And (birthmonth = tomonth) Then
                Console.WriteLine("Error! Invalid Date, Kindly Select Another Date to Continue")
            

            Else

                If (birthmonth = tomonth) And (birthday > today) Then
                    resultyear = toyear - birthyear - 1
                ElseIf (birthmonth > tomonth) And (birthday < today) Then
                    resultyear = toyear - birthyear - 1
                ElseIf (birthmonth > tomonth) And (birthday > today) Then
                    resultyear = toyear - birthyear - 1
                ElseIf (birthday = today) And (birthmonth > tomonth) Then
                    resultyear = toyear - birthyear - 1
                Else : resultyear = toyear - birthyear
                End If

                If (tomonth > birthmonth) And (birthday > today) Then
                    resultmonth = tomonth - birthmonth - 1
                ElseIf (birthday > today) And (tomonth = birthmonth) Then
                    resultmonth = 12 - 1
                ElseIf (birthday < today) And (birthmonth > tomonth) Then
                    resultmonth = tomonth + 12 - birthmonth
                ElseIf (birthmonth > tomonth) And (birthday > today) Then
                    resultmonth = tomonth + 12 - birthmonth - 1
                ElseIf (birthday = today) And (birthmonth > tomonth) Then
                    resultmonth = tomonth + 12 - birthmonth
                Else : resultmonth = tomonth - birthmonth
                End If


                If (birthday < today) And (birthmonth > tomonth) Then
                    resultday = today - birthday
                ElseIf (birthday > today) And (birthmonth < tomonth) Then
                    resultday = DaysInMonth - birthday + today - 1
                ElseIf (birthday > today) And (birthmonth = tomonth) Then
                    resultday = DaysInMonth - birthday + today - 1
                ElseIf (birthday > today) And (birthmonth > tomonth) Then
                    resultday = DaysInMonth - birthday + today - 1
                ElseIf (birthday > today) Then
                    resultday = birthday - today
                Else : resultday = today - birthday
                End If

                Console.WriteLine("YOUR BIRTHDAY IS = " + resultyear.ToString + "Years" + ", " + resultmonth.ToString + "Months" + ", " + resultday.ToString + "Days")


            End If
        End If


        Console.ReadLine()
    End Sub

End Module
