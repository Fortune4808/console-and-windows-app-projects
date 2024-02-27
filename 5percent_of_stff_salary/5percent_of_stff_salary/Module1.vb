Module Module1

    Sub Main()
        Dim salary, percentage, remainingsalary, percentageresult, remainingsalaryresult, e As Double
            Console.WriteLine("THIS SOFTWARE DEDUCT 5% OF STAFF SALARY")
            Console.WriteLine("............................................")
            Console.WriteLine("ENTER THE EMPLOYEE'S SALARY")
            salary = Console.ReadLine()
            Console.WriteLine("............................................")

            e = 5 * salary
            percentage = e / 100
            remainingsalary = salary - percentage
            percentageresult = e / 100
            remainingsalaryresult = salary - percentage

            Console.WriteLine("PERCENTAGE(%) DEDUCTED @ 5% N = " + percentageresult.ToString("N2"), ("F2"))

            Console.WriteLine("TOTAL EMPLOYEE'S SALARY  N = " + remainingsalaryresult.ToString("N2"), ("F2"))
            Console.WriteLine("............................................")

       
        Console.ReadLine()

    End Sub

End Module

