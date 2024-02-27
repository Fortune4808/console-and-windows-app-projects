Module Module1

    Sub Main()
        Dim SDT101, WAP102, MAP103, NS104, SDA105, AGDT106, DBMS201, UIUX202, AI203, SQT204, AA205, DEVOPS206, TOTALCOURSEUNIT, a, b, c, d, e, f, op, TOTALPOINT, GPA As Double
        Dim action As Char
        Do Until action = "N"


            Console.WriteLine(" AFOOTECH GP CALCULATOR FOR FIRST & SECOND SEMESTER")
            Console.WriteLine(" ...........................................................")
            Console.WriteLine("press 1 TO CALCULATE YOUR GP FOR FIRST SEMESTER")
            Console.WriteLine("press 2 TO CALCULATE YOUR GP FOR SECOND SEMESTER")
            op = Console.ReadLine()
            Console.WriteLine(" ...........................................................")
            If (op = "1") Then

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
                    Console.WriteLine("YOUR GPA = " + GPA.ToString("F2"))

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

            ElseIf (op = "2") Then

                Console.WriteLine(" AFOOTECH GP CALCULATOR FOR SECOND SEMESTER")
                Console.WriteLine(" ...........................................................")
                Console.WriteLine(" ENTER SCORE FOR DATABASE MANAGEMENT SYSTEM(201)")
                DBMS201 = Console.ReadLine()
                Console.WriteLine(" ...........................................................")
                Console.WriteLine(" ENTER SCORE FOR UI & UX DESIGNER(202)")
                UIUX202 = Console.ReadLine()
                Console.WriteLine(" ...........................................................")
                Console.WriteLine(" ENTER SCORE FOR ARTIFICIAL INTELLIGENCE(203)")
                AI203 = Console.ReadLine()
                Console.WriteLine(" ...........................................................")
                Console.WriteLine(" ENTER SCORE FOR SOFTWARE QUALITY TESTING(204)")
                SQT204 = Console.ReadLine()
                Console.WriteLine(" ...........................................................")
                Console.WriteLine(" ENTER SCORE FOR ARGUMENTED ANALYTIC(205)")
                AA205 = Console.ReadLine()
                Console.WriteLine(" ...........................................................")
                Console.WriteLine(" ENTER SCORE FOR SOFTWARE DEVELOPMENT & IT OPERATION(206)")
                DEVOPS206 = Console.ReadLine()
                Console.WriteLine(" ...........................................................")

                If (DBMS201 > 100) Or (UIUX202 > 100) Or (AI203 > 100) Or (SQT204 > 100) Or (AA205 > 100) Or (DEVOPS206 > 100) Then
                    Console.WriteLine("ERROR! Invalid Score")
                    Console.WriteLine(" ...........................................................")
                ElseIf (DBMS201 < 1) Or (UIUX202 < 1) Or (AI203 < 1) Or (SQT204 < 1) Or (AA205 < 1) Or (DEVOPS206 < 1) Then
                    Console.WriteLine("ERROR! Invalid Score")
                    Console.WriteLine(" ...........................................................")

                Else
                    If (DBMS201 >= 80) And (DBMS201 <= 100) Then
                        a = 4.0 * 5
                    ElseIf (DBMS201 >= 60) And (DBMS201 <= 79.9) Then
                        a = 3.5 * 5
                    ElseIf (DBMS201 >= 50) And (DBMS201 <= 69.9) Then
                        a = 3.0 * 5
                    ElseIf (DBMS201 > 40) And (DBMS201 <= 49.9) Then
                        a = 2.5 * 5
                    Else
                        a = 1.5 * 5
                    End If


                    If (UIUX202 >= 80) And (UIUX202 <= 100) Then
                        b = 4.0 * 3
                    ElseIf (UIUX202 >= 60) And (UIUX202 <= 79.9) Then
                        b = 3.5 * 3
                    ElseIf (UIUX202 >= 50) And (UIUX202 <= 69.9) Then
                        b = 3.0 * 3
                    ElseIf (UIUX202 >= 40) And (UIUX202 <= 49.9) Then
                        b = 2.5 * 3
                    Else
                        b = 1.5 * 3
                    End If

                    If (AI203 >= 80) And (AI203 <= 100) Then
                        c = 4.0 * 5
                    ElseIf (AI203 >= 60) And (AI203 <= 79.9) Then
                        c = 3.5 * 5
                    ElseIf (AI203 >= 50) And (AI203 <= 69.9) Then
                        c = 3.0 * 5
                    ElseIf (AI203 >= 40) And (AI203 <= 49.9) Then
                        c = 2.5 * 5
                    Else
                        c = 1.5 * 5
                    End If

                    If (SQT204 >= 80) And (SQT204 <= 100) Then
                        d = 4.0 * 3
                    ElseIf (SQT204 >= 60) And (SQT204 <= 79.9) Then
                        d = 3.5 * 3
                    ElseIf (SQT204 >= 50) And (SQT204 <= 69.9) Then
                        d = 3.0 * 3
                    ElseIf (SQT204 >= 40) And (SQT204 <= 49.9) Then
                        d = 2.5 * 3
                    Else
                        d = 1.5 * 3
                    End If

                    If (AA205 >= 80) And (AA205 <= 100) Then
                        e = 4.0 * 4
                    ElseIf (AA205 >= 60) And (AA205 <= 79.9) Then
                        e = 3.5 * 4
                    ElseIf (AA205 >= 50) And (AA205 <= 69.9) Then
                        e = 3.0 * 4
                    ElseIf (AA205 >= 40) And (AA205 <= 49.9) Then
                        e = 2.5 * 4
                    Else
                        e = 1.5 * 4
                    End If

                    If (DEVOPS206 >= 80) And (DEVOPS206 <= 100) Then
                        f = 4.0 * 4
                    ElseIf (DEVOPS206 >= 60) And (DEVOPS206 <= 79.9) Then
                        f = 3.5 * 4
                    ElseIf (DEVOPS206 >= 50) And (DEVOPS206 <= 69.9) Then
                        f = 3.0 * 4
                    ElseIf (DEVOPS206 >= 40) And (DEVOPS206 <= 49.9) Then
                        f = 2.5 * 4
                    Else
                        f = 1.5 * 4
                    End If

                    TOTALPOINT = a + b + c + d + e + f
                    TOTALCOURSEUNIT = 5 + 3 + 5 + 3 + 4 + 4
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
            Else
                Console.WriteLine("ERORR! Invalid Input")

            End If
            Console.WriteLine(" ...........................................................")

            Console.WriteLine("TO CONTINUE PRESS 'Y'")
            Console.WriteLine("TO STOP PRESS 'N'")
            action = Console.ReadLine()
            Console.WriteLine(" ...........................................................")

        Loop

        Console.ReadLine()
    End Sub

End Module
