Module Module1

    Sub Main()
        Dim SDT101, WAP102, MAP103, NS104, SDA105, AGDT106, TOTALCOURSEUNIT, a, b, c, d, e, f, TOTALPOINT, GPA As Double
      
            Console.WriteLine(" AFOOTECH GP CALCULATOR FOR FIRST SEMESTER")
            Console.WriteLine(" ...........................................................")
            Console.WriteLine(" ENTER SCORE FOR SOFTWARE DEVELOPMENT TRAINING(SDT 101)")
            SDT101 = Console.ReadLine()
            Console.WriteLine(" ...........................................................")
            Console.WriteLine(" ENTER SCORE FOR WEBSITE & APP DEVELOPMENT(WAP 102)")
            WAP102 = Console.ReadLine()
            Console.WriteLine(" ...........................................................")
            Console.WriteLine(" ENTER SCORE FOR MOBILE APPLICATION DEVELOPMENT(MAP 103)")
            MAP103 = Console.ReadLine()
            Console.WriteLine(" ...........................................................")
            Console.WriteLine(" ENTER SCORE FOR NETWORK & SECURITY(NS 104)")
            NS104 = Console.ReadLine()
            Console.WriteLine(" ...........................................................")
            Console.WriteLine(" ENTER SCORE FOR SYSTEM & DATA ANALYSIS(SDA 105)")
            SDA105 = Console.ReadLine()
            Console.WriteLine(" ...........................................................")
            Console.WriteLine(" ENTER SCORE FOR ADVANCED GRAPHICS DESIGN TRAINING(AGDT 106)")
            AGDT106 = Console.ReadLine()
            Console.WriteLine(" ...........................................................")


            If (SDT101 > 100) Or (WAP102 > 100) Or (MAP103 > 100) Or (NS104 > 100) Or (SDA105 > 100) Or (AGDT106 > 100) Then
                Console.WriteLine("ERROR! Invalid Score")
                Console.WriteLine(" ...........................................................")

            ElseIf (SDT101 < 1) Or (WAP102 < 1) Or (MAP103 < 1) Or (NS104 < 1) Or (SDA105 < 1) Or (AGDT106 < 1) Then
                Console.WriteLine("ERROR! Invalid Score")
                Console.WriteLine(" ...........................................................")

            Else

                If (SDT101 >= 80) And (SDT101 <= 100) Then
                    a = 4.0 * 3

                ElseIf (SDT101 >= 60) And (SDT101 <= 79.9) Then
                    a = 3.5 * 3
                ElseIf (SDT101 >= 50) And (SDT101 <= 69.9) Then
                    a = 3.0 * 3
                ElseIf (SDT101 >= 40) And (SDT101 <= 49.9) Then
                    a = 2.5 * 3
                Else
                    a = 1.5 * 3
                End If


                If (WAP102 >= 80) And (WAP102 <= 100) Then
                    b = 4.0 * 4
                ElseIf (WAP102 >= 60) And (WAP102 <= 79.9) Then
                    b = 3.5 * 4
                ElseIf (WAP102 >= 50) And (WAP102 <= 69.9) Then
                    b = 3.0 * 4
                ElseIf (WAP102 >= 40) And (WAP102 <= 49.9) Then
                    b = 2.5 * 4
                Else
                    b = 1.5 * 4
                End If

                If (MAP103 >= 80) And (MAP103 <= 100) Then
                    c = 4.0 * 4
                ElseIf (MAP103 >= 60) And (MAP103 <= 79.9) Then
                    c = 3.5 * 4
                ElseIf (MAP103 >= 50) And (MAP103 <= 69.9) Then
                    c = 3.0 * 4
                ElseIf (MAP103 >= 40) And (MAP103 <= 49.9) Then
                    c = 2.5 * 4
                Else
                    c = 1.5 * 4
                End If

                If (NS104 >= 80) And (NS104 <= 100) Then
                    d = 4.0 * 3
                ElseIf (NS104 >= 60) And (NS104 <= 79.9) Then
                    d = 3.5 * 3
                ElseIf (NS104 >= 50) And (NS104 <= 69.9) Then
                    d = 3.0 * 3
                ElseIf (NS104 >= 40) And (NS104 <= 49.9) Then
                    d = 2.5 * 3
                Else
                    d = 1.5 * 3
                End If

                If (SDA105 >= 80) And (SDA105 <= 100) Then
                    e = 4.0 * 3
                ElseIf (SDA105 >= 60) And (SDA105 <= 79.9) Then
                    e = 3.5 * 3
                ElseIf (SDA105 >= 50) And (SDA105 <= 69.9) Then
                    e = 3.0 * 3
                ElseIf (SDA105 >= 40) And (SDA105 <= 49.9) Then
                    e = 2.5 * 3
                Else
                    e = 1.5 * 3
                End If

                If (AGDT106 >= 80) And (AGDT106 <= 100) Then
                    f = 4.0 * 3
                ElseIf (AGDT106 >= 60) And (AGDT106 <= 79.9) Then
                    f = 3.5 * 3
                ElseIf (AGDT106 >= 50) And (AGDT106 <= 69.9) Then
                    f = 3.0 * 3
                ElseIf (AGDT106 >= 40) And (AGDT106 <= 49.9) Then
                    f = 2.5 * 3
                Else
                    f = 1.5 * 3
                End If


                TOTALPOINT = a + b + c + d + e + f
                TOTALCOURSEUNIT = 3 + 4 + 4 + 3 + 3 + 3
                GPA = TOTALPOINT / TOTALCOURSEUNIT
                Console.WriteLine("YOUR GPA IS = " + GPA.ToString("F2"))

                If (GPA >= 3.5) And (GPA <= 4.0) Then
                    Console.WriteLine("CLASS CATEGORY = DISTINCTION")
                ElseIf (GPA >= 3.0) And (GPA <= 3.49) Then
                    Console.WriteLine("CLASS CATEGORY = UPPER CLASS")
                ElseIf (GPA >= 2.5) And (GPA <= 2.99) Then
                    Console.WriteLine("CLASS CATEGORY = LOWER CLASS")
                ElseIf (GPA >= 2.0) And (GPA <= 2.49) Then
                    Console.WriteLine("CLASS CATEGORY = PASS")
                Else
                    Console.WriteLine("CLASS CATEGORY = CARRY OVER")
                    Console.WriteLine(" ...........................................................")
                End If

            End If

           

        Console.ReadLine()

    End Sub

End Module
