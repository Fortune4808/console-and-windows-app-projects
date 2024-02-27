Module Module1

    Sub Main()
        Dim salary, percentage, a, p, sr As Double
        Console.WriteLine("THIS SOFTWARE DEDUCT PERCENTAGE(%) FROM STAFF'S SALARY")
        Console.WriteLine("---------------------------------------------------------------")
        Console.WriteLine("ENTER THE EMPLOYEE'S SALARY")
        salary = Console.ReadLine()
        Console.WriteLine("---------------------------------------------------------------")
        Console.WriteLine("ENTER PERCENTAGE(%)")
        percentage = Console.ReadLine()
        Console.WriteLine("---------------------------------------------------------------")

        a = percentage * salary
        p = a / 100
        sr = salary - p

        Console.WriteLine("PERCENTAGE(%) DEDUCTED @ N = " + p.ToString("N2"), ("F2"))
        Console.WriteLine("REMAINING EMPLOYEE'S SALARY N = " + sr.ToString("N2"), ("F2"))
        Console.WriteLine("---------------------------------------------------------------")


        Console.ReadLine()


    End Sub

End Module
