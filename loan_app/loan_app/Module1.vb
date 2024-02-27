Module Module1

    Sub Main()
        Dim loanamount, repaymentamount, monthly_interest, interest, sum2, total_repayment, sum, duration, month As Double
        Console.WriteLine("LOAN APPLICATION")
        Console.WriteLine("..........................................................................")
        Console.WriteLine("ENTER LOAN AMOUNT")
        loanamount = Console.ReadLine()
        Console.WriteLine("..........................................................................")
        Console.WriteLine("FOR HOW MANY MONTHS?")
        duration = Console.ReadLine()
        Console.WriteLine("..........................................................................")

        Console.WriteLine("MONTH" + "       " + "AMOUNT" + "               " + "INTEREST" + "           " + "REPAYMENT" + "           ")
        repaymentamount = loanamount / duration
        sum = 0
        For month = 1 To duration
            monthly_interest = (1.5 / 100) * loanamount
            total_repayment = repaymentamount + monthly_interest
            sum = sum + total_repayment
            sum2 = sum2 + monthly_interest
            loanamount = loanamount - repaymentamount
            interest = monthly_interest

            Console.WriteLine(month.ToString + "           " + repaymentamount.ToString("N2") + "           " + interest.ToString("N2") + "           " + total_repayment.ToString("N2") + "           ")
        Next

        Console.WriteLine("..........................................................................")
        Console.WriteLine("TOTAL REPAYMENT = " + sum.ToString("N2") + "   " + "TOTAL INTEREST = " + sum2.ToString("N2"))




        Console.ReadLine()

    End Sub

End Module
