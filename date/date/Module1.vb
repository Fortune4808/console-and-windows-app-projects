Module Module1

    Sub Main()
        Dim today, tomonth, toyear As Integer

        today = Date.Now.Day
        tomonth = Date.Now.Month
        toyear = Date.Now.Year

        Console.WriteLine("TODAY'S DATE = " + today.ToString + "/" + tomonth.ToString + "/" + toyear.ToString)



        Console.ReadLine()
    End Sub

End Module
