﻿Module Module1
    
    Sub Main()
        Dim ivalue As Object
        Dim oprand As Integer
        Dim action1 As Char
        Do Until action1 = "N"
            Console.WriteLine("MULTIFUCTION SOFTWARE")
            Console.WriteLine("..........................................................................................................")
            Console.WriteLine("PRESS 1 FOR AFOOTECH GP FOR FIRST & SECOND SEMESTER CALCULATOR")
            Console.WriteLine("PRESS 2 FOR GAPOSA COMPUTER ENGINEERING STUDENTS GP CALCULATOR")
            Console.WriteLine("PRESS 3 FOR QUADRATIC EQUATION CALCULATOR")
            Console.WriteLine("PRESS 4 FOR AGE CALCULATOR")
            Console.WriteLine("PRESS 5 FOR SIMPLE CALCULATOR")
            Console.WriteLine("PRESS 6 TO CALCULATE THE AREA OF A CIRCLE")
            Console.WriteLine("PRESS 7 TO CALCULATE THE CIRCUMFERENCE OF A CIRCLE")
            Console.WriteLine("PRESS 8 TO CALCULATE BOYLE'S LAW")
            Console.WriteLine("PRESS 9 FOR VELOCITY CALCULATOR")
            Console.WriteLine("PRESS 10 TO FIND THE HIGHEST OF TWO NUMBERS")
            Console.WriteLine("PRESS 11 TO FIND THE HIGHEST OF THREE NUMBERS")
            Console.WriteLine("PRESS 12 TO FIND THE HIGHEST OF FOUR NUMBERS")
            Console.WriteLine("PRESS 13 FOR LOAN APPLICATION")
            Console.WriteLine("PRESS 14 TO DEDUCT 5% OF STAFF SALARY")
            Console.WriteLine("PRESS 15 TO DEDUCT % OF STAFF SALARY")
            oprand = Console.ReadLine()

            If (oprand = "1") Then
                ivalue = afootechgpcalculator()
            ElseIf (oprand = "2") Then
                ivalue = gaposacomputerengineeringgpcalculator()
            ElseIf (oprand = "3") Then
                ivalue = quadraticequationcalculator()
            ElseIf (oprand = "4") Then
                ivalue = agecalculator()
            ElseIf (oprand = "5") Then
                ivalue = simplecalculator()
            ElseIf (oprand = "6") Then
                ivalue = areaofcircle()
            ElseIf (oprand = "7") Then
                ivalue = circumferenceofcircle()
            ElseIf (oprand = "8") Then
                ivalue = boylelaw()
            ElseIf (oprand = "9") Then
                ivalue = velocitycalculator()
            ElseIf (oprand = "10") Then
                ivalue = highestoftwonumbers()
            ElseIf (oprand = "11") Then
                ivalue = highestofthreenumbers()
            ElseIf (oprand = "12") Then
                ivalue = highestoffournumbers()
            ElseIf (oprand = "13") Then
                ivalue = loanapp()
            ElseIf (oprand = "14") Then
                ivalue = fivepercentofstaffsalary()
            ElseIf (oprand = "15") Then
                ivalue = percentageofstaffsalary()
            Else
                Console.WriteLine("ERROR! Invalid Input")
            End If

            Console.WriteLine("..........................................................................................................")

            Console.WriteLine("TO CONTINUE PRESS 'Y'")
            Console.WriteLine("TO STOP PRESS 'N'")
            action1 = Console.ReadLine()
            Console.WriteLine("..........................................................................................................")

        Loop


        Console.ReadLine()
    End Sub

    Function afootechgpcalculator()

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


    End Function

    Function gaposacomputerengineeringgpcalculator()
        Dim COM111, CTE111, CTE112, CTE113, EEC116, EEC118, GNS111, GNS112, GNS118, ICT115, MEC111, MEC112, MEC113, MTH113, STA111, op, a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, BAM124, COM122, COM129, CTE121, EEC124, EEC126, EEC127, GNS122, ICT121, ICT125, MEC121, MEC122, MTH121, COM218, CTE213, CTE214, CTE216, EEC210, EEC214, EEC215, EEC217, GNS211, ICT211, ICT215, MTH212, SWE211, COM228, CTE221, CTE222, CTE223, CTE224, CTE229, EEC220, EEC224, EED226, GNS221, ICT225, MTH222, TOTALPOINT, TOTALCOURSEUNIT, GPA As Double
        Dim action As Char
        Do Until action = "N"
            Console.WriteLine("GAPOSA COMPUTER ENGINEERING STUDENTS GP CALCULATOR")
            Console.WriteLine("....................................................................")
            Console.WriteLine("press 1 TO CALCULATE YOUR GP FOR ND1 FIRST SEMESTER")
            Console.WriteLine("press 2 TO CALCULATE YOUR GP FOR ND1 SECOND SEMESTER")
            Console.WriteLine("press 3 TO CALCULATE YOUR GP FOR ND2 FIRST SEMESTER")
            Console.WriteLine("press 4 TO CALCULATE YOUR GP FOR ND2 SECOND SEMESTER")
            op = Console.ReadLine()
            Console.WriteLine("....................................................................")
            If (op = 1) Then
                Console.WriteLine("GAPOSA COMPUTER ENGINEERING STUDENTS GP CALCULATOR FOR ND1 FIRST SEMESTER")
                Console.WriteLine("....................................................................")
                Console.WriteLine("ENTER SCORE FOR INTRODUCTION TO COMPUTER(COM111)")
                COM111 = Console.ReadLine()
                Console.WriteLine("....................................................................")
                Console.WriteLine("ENTER SCORE FOR MICRO COMPUTER FUNDAMENTALS(CTE111)")
                CTE111 = Console.ReadLine()
                Console.WriteLine("....................................................................")
                Console.WriteLine("ENTER SCORE FOR COMPUTER WORKSHOP PRACTICE 1(CTE112)")
                CTE112 = Console.ReadLine()
                Console.WriteLine("....................................................................")
                Console.WriteLine("ENTER SCORE FOR RUDIMENT OF CIRCUIT DESIGN AND CONSTRUCTION(PRACTICALS)(CTE113)")
                CTE113 = Console.ReadLine()
                Console.WriteLine("....................................................................")
                Console.WriteLine("ENTER SCORE FOR ELECTRICAL WORKSHOP PRACTICE 1(EEC116)")
                EEC116 = Console.ReadLine()
                Console.WriteLine("....................................................................")
                Console.WriteLine("ENTER SCORE FOR ELECTRICAL ENGINEERING SCIENCE(EEC118)")
                EEC118 = Console.ReadLine()
                Console.WriteLine("....................................................................")
                Console.WriteLine("ENTER SCORE FOR CITIZENSHIP EDUCATION(GNS111)")
                GNS111 = Console.ReadLine()
                Console.WriteLine("....................................................................")
                Console.WriteLine("ENTER SCORE FOR USE OF ENGLISH 1(GNS112)")
                GNS112 = Console.ReadLine()
                Console.WriteLine("....................................................................")
                Console.WriteLine("ENTER SCORE FOR USE OF LIBRARY(GNS118)")
                GNS118 = Console.ReadLine()
                Console.WriteLine("....................................................................")
                Console.WriteLine("ENTER SCORE FOR NETWORK FUNDAMENTAL (CCNA)(ICT115)")
                ICT115 = Console.ReadLine()
                Console.WriteLine("....................................................................")
                Console.WriteLine("ENTER SCORE FOR MECHANICAL ENGINEERING SCIENCE(MEC111)")
                MEC111 = Console.ReadLine()
                Console.WriteLine("....................................................................")
                Console.WriteLine("ENTER SCORE FOR TECHNICAL DRAWING(MEC112)")
                MEC112 = Console.ReadLine()
                Console.WriteLine("....................................................................")
                Console.WriteLine("ENTER SCORE FOR MECHANICAL WORKSHOP TECHNIQUE AND PRACTICE 1(MEC113)")
                MEC113 = Console.ReadLine()
                Console.WriteLine("....................................................................")
                Console.WriteLine("ENTER SCORE FOR FUNCTIONS AND GEOMETRY(MTH113)")
                MTH113 = Console.ReadLine()
                Console.WriteLine("....................................................................")
                Console.WriteLine("ENTER SCORE FOR INTRODUCTION TO STATISTICS(STA111)")
                STA111 = Console.ReadLine()
                Console.WriteLine("....................................................................")

                If (COM111 > 100) Or (CTE111 > 100) Or (CTE112 > 100) Or (CTE113 > 100) Or (EEC116 > 100) Or (EEC118 > 100) Or (GNS111 > 100) Or (GNS112 > 100) Or (GNS118 > 100) Or (ICT115 > 100) Or (MEC111 > 100) Or (MEC112 > 100) Or (MEC113 > 100) Or (MTH113 > 100) Or (STA111 > 100) Then
                    Console.WriteLine("ERROR! Invalid Score")
                    Console.WriteLine("....................................................................")
                ElseIf (COM111 < 0) Or (CTE111 < 0) Or (CTE112 < 0) Or (CTE113 < 0) Or (EEC116 < 0) Or (EEC118 < 0) Or (GNS111 < 0) Or (GNS112 < 0) Or (GNS118 < 0) Or (ICT115 < 0) Or (MEC111 < 0) Or (MEC112 < 0) Or (MEC113 < 0) Or (MTH113 < 0) Or (STA111 < 0) Then
                    Console.WriteLine("ERROR! Invalid Score")
                    Console.WriteLine("....................................................................")

                Else
                    If (COM111 >= 80) And (COM111 <= 100) Then
                        a = 4.0 * 2
                    ElseIf (COM111 >= 75) And (COM111 <= 79) Then
                        a = 3.75 * 2
                    ElseIf (COM111 >= 70) And (COM111 <= 74) Then
                        a = 3.5 * 2
                    ElseIf (COM111 >= 65) And (COM111 <= 69) Then
                        a = 3.25 * 2
                    ElseIf (COM111 >= 60) And (COM111 <= 64) Then
                        a = 3.0 * 2
                    ElseIf (COM111 >= 55) And (COM111 <= 59) Then
                        a = 2.75 * 2
                    ElseIf (COM111 >= 50) And (COM111 <= 54) Then
                        a = 2.5 * 2
                    ElseIf (COM111 >= 45) And (COM111 <= 49) Then
                        a = 2.25 * 2
                    ElseIf (COM111 >= 40) And (COM111 <= 44) Then
                        a = 2.0 * 2
                    Else
                        a = 1.99 * 2
                    End If



                    If (CTE111 >= 80) And (CTE111 <= 100) Then
                        b = 4.0 * 2
                    ElseIf (CTE111 >= 75) And (CTE111 <= 79) Then
                        b = 3.75 * 2
                    ElseIf (CTE111 >= 70) And (CTE111 <= 74) Then
                        b = 3.5 * 2
                    ElseIf (CTE111 >= 65) And (CTE111 <= 69) Then
                        b = 3.25 * 2
                    ElseIf (CTE111 >= 60) And (CTE111 <= 64) Then
                        b = 3.0 * 2
                    ElseIf (CTE111 >= 55) And (CTE111 <= 59) Then
                        b = 2.75 * 2
                    ElseIf (CTE111 >= 50) And (CTE111 <= 54) Then
                        b = 2.5 * 2
                    ElseIf (CTE111 >= 45) And (CTE111 <= 49) Then
                        b = 2.25 * 2
                    ElseIf (CTE111 >= 40) And (CTE111 <= 44) Then
                        b = 2.0 * 2
                    Else
                        b = 1.99 * 2
                    End If


                    If (CTE112 >= 80) And (CTE112 <= 100) Then
                        c = 4.0 * 1
                    ElseIf (CTE112 >= 75) And (CTE112 <= 79) Then
                        c = 3.75 * 1
                    ElseIf (CTE112 >= 70) And (CTE112 <= 74) Then
                        c = 3.5 * 1
                    ElseIf (CTE112 >= 65) And (CTE112 <= 69) Then
                        c = 3.25 * 1
                    ElseIf (CTE112 >= 60) And (CTE112 <= 64) Then
                        c = 3.0 * 1
                    ElseIf (CTE112 >= 55) And (CTE112 <= 59) Then
                        c = 2.75 * 1
                    ElseIf (CTE112 >= 50) And (CTE112 <= 54) Then
                        c = 2.5 * 1
                    ElseIf (CTE112 >= 45) And (CTE112 <= 49) Then
                        c = 2.25 * 1
                    ElseIf (CTE112 >= 40) And (CTE112 <= 44) Then
                        c = 2.0 * 1
                    Else
                        c = 1.99 * 1
                    End If


                    If (CTE113 >= 80) And (CTE113 <= 100) Then
                        d = 4.0 * 1
                    ElseIf (CTE113 >= 75) And (CTE113 <= 79) Then
                        d = 3.75 * 1
                    ElseIf (CTE113 >= 70) And (CTE113 <= 74) Then
                        d = 3.5 * 1
                    ElseIf (CTE113 >= 65) And (CTE113 <= 69) Then
                        d = 3.25 * 1
                    ElseIf (CTE113 >= 60) And (CTE113 <= 64) Then
                        d = 3.0 * 1
                    ElseIf (CTE113 >= 55) And (CTE113 <= 59) Then
                        d = 2.75 * 1
                    ElseIf (CTE113 >= 50) And (CTE113 <= 54) Then
                        d = 2.5 * 1
                    ElseIf (CTE113 >= 45) And (CTE113 <= 49) Then
                        d = 2.25 * 1
                    ElseIf (CTE113 >= 40) And (CTE113 <= 44) Then
                        d = 2.0 * 1
                    Else
                        d = 1.99 * 1
                    End If



                    If (EEC116 >= 80) And (EEC116 <= 100) Then
                        e = 4.0 * 2
                    ElseIf (EEC116 >= 75) And (EEC116 <= 79) Then
                        e = 3.75 * 2
                    ElseIf (EEC116 >= 70) And (EEC116 <= 74) Then
                        e = 3.5 * 2
                    ElseIf (EEC116 >= 65) And (EEC116 <= 69) Then
                        e = 3.25 * 2
                    ElseIf (EEC116 >= 60) And (EEC116 <= 64) Then
                        e = 3.0 * 2
                    ElseIf (EEC116 >= 55) And (EEC116 <= 59) Then
                        e = 2.75 * 2
                    ElseIf (EEC116 >= 50) And (EEC116 <= 54) Then
                        e = 2.5 * 2
                    ElseIf (EEC116 >= 45) And (EEC116 <= 49) Then
                        e = 2.25 * 2
                    ElseIf (EEC116 >= 40) And (EEC116 <= 44) Then
                        e = 2.0 * 2
                    Else
                        e = 1.99 * 2
                    End If


                    If (EEC118 >= 80) And (EEC118 <= 100) Then
                        f = 4.0 * 3
                    ElseIf (EEC118 >= 75) And (EEC118 <= 79) Then
                        f = 3.75 * 3
                    ElseIf (EEC118 >= 70) And (EEC118 <= 74) Then
                        f = 3.5 * 3
                    ElseIf (EEC118 >= 65) And (EEC118 <= 69) Then
                        f = 3.25 * 3
                    ElseIf (EEC118 >= 60) And (EEC118 <= 64) Then
                        f = 3.0 * 3
                    ElseIf (EEC118 >= 55) And (EEC118 <= 59) Then
                        f = 2.75 * 3
                    ElseIf (EEC118 >= 50) And (EEC118 <= 54) Then
                        f = 2.5 * 3
                    ElseIf (EEC118 >= 45) And (EEC118 <= 49) Then
                        f = 2.25 * 3
                    ElseIf (EEC118 >= 40) And (EEC118 <= 44) Then
                        f = 2.0 * 3
                    Else
                        f = 1.99 * 3
                    End If


                    If (GNS111 >= 80) And (GNS111 <= 100) Then
                        g = 4.0 * 2
                    ElseIf (GNS111 >= 75) And (GNS111 <= 79) Then
                        g = 3.75 * 2
                    ElseIf (GNS111 >= 70) And (GNS111 <= 74) Then
                        g = 3.5 * 2
                    ElseIf (GNS111 >= 65) And (GNS111 <= 69) Then
                        g = 3.25 * 2
                    ElseIf (GNS111 >= 60) And (GNS111 <= 64) Then
                        g = 3.0 * 2
                    ElseIf (GNS111 >= 55) And (GNS111 <= 59) Then
                        g = 2.75 * 2
                    ElseIf (GNS111 >= 50) And (GNS111 <= 54) Then
                        g = 2.5 * 2
                    ElseIf (GNS111 >= 45) And (GNS111 <= 49) Then
                        g = 2.25 * 2
                    ElseIf (GNS111 >= 40) And (GNS111 <= 44) Then
                        g = 2.0 * 2
                    Else
                        g = 1.99 * 2
                    End If


                    If (GNS112 >= 80) And (GNS112 <= 100) Then
                        h = 4.0 * 2
                    ElseIf (GNS112 >= 75) And (GNS112 <= 79) Then
                        h = 3.75 * 2
                    ElseIf (GNS112 >= 70) And (GNS112 <= 74) Then
                        h = 3.5 * 2
                    ElseIf (GNS112 >= 65) And (GNS112 <= 69) Then
                        h = 3.25 * 2
                    ElseIf (GNS112 >= 60) And (GNS112 <= 64) Then
                        h = 3.0 * 2
                    ElseIf (GNS112 >= 55) And (GNS112 <= 59) Then
                        h = 2.75 * 2
                    ElseIf (GNS112 >= 50) And (GNS112 <= 54) Then
                        h = 2.5 * 2
                    ElseIf (GNS112 >= 45) And (GNS112 <= 49) Then
                        h = 2.25 * 2
                    ElseIf (GNS112 >= 40) And (GNS112 <= 44) Then
                        h = 2.0 * 2
                    Else
                        h = 1.99 * 2
                    End If


                    If (GNS118 >= 80) And (GNS118 <= 100) Then
                        i = 4.0 * 1
                    ElseIf (GNS118 >= 75) And (GNS118 <= 79) Then
                        i = 3.75 * 1
                    ElseIf (GNS118 >= 70) And (GNS118 <= 74) Then
                        i = 3.5 * 1
                    ElseIf (GNS118 >= 65) And (GNS118 <= 69) Then
                        i = 3.25 * 1
                    ElseIf (GNS118 >= 60) And (GNS118 <= 64) Then
                        i = 3.0 * 1
                    ElseIf (GNS118 >= 55) And (GNS118 <= 59) Then
                        i = 2.75 * 1
                    ElseIf (GNS118 >= 50) And (GNS118 <= 54) Then
                        i = 2.5 * 1
                    ElseIf (GNS118 >= 45) And (GNS118 <= 49) Then
                        i = 2.25 * 1
                    ElseIf (GNS118 >= 40) And (GNS118 <= 44) Then
                        i = 2.0 * 1
                    Else
                        i = 1.99 * 1
                    End If



                    If (ICT115 >= 80) And (ICT115 <= 100) Then
                        j = 4.0 * 2
                    ElseIf (ICT115 >= 75) And (ICT115 <= 79) Then
                        j = 3.75 * 2
                    ElseIf (ICT115 >= 70) And (ICT115 <= 74) Then
                        j = 3.5 * 2
                    ElseIf (ICT115 >= 65) And (ICT115 <= 69) Then
                        j = 3.25 * 2
                    ElseIf (ICT115 >= 60) And (ICT115 <= 64) Then
                        j = 3.0 * 2
                    ElseIf (ICT115 >= 55) And (ICT115 <= 59) Then
                        j = 2.75 * 2
                    ElseIf (ICT115 >= 50) And (ICT115 <= 54) Then
                        j = 2.5 * 2
                    ElseIf (ICT115 >= 45) And (ICT115 <= 49) Then
                        j = 2.25 * 2
                    ElseIf (ICT115 >= 40) And (ICT115 <= 44) Then
                        j = 2.0 * 2
                    Else
                        j = 1.99 * 2
                    End If


                    If (MEC111 >= 80) And (MEC111 <= 100) Then
                        k = 4.0 * 3
                    ElseIf (MEC111 >= 75) And (MEC111 <= 79) Then
                        k = 3.75 * 3
                    ElseIf (MEC111 >= 70) And (MEC111 <= 74) Then
                        k = 3.5 * 3
                    ElseIf (MEC111 >= 65) And (MEC111 <= 69) Then
                        k = 3.25 * 3
                    ElseIf (MEC111 >= 60) And (MEC111 <= 64) Then
                        k = 3.0 * 3
                    ElseIf (MEC111 >= 55) And (MEC111 <= 59) Then
                        k = 2.75 * 3
                    ElseIf (MEC111 >= 50) And (MEC111 <= 54) Then
                        k = 2.5 * 3
                    ElseIf (MEC111 >= 45) And (MEC111 <= 49) Then
                        k = 2.25 * 3
                    ElseIf (MEC111 >= 40) And (MEC111 <= 44) Then
                        k = 2.0 * 3
                    Else
                        k = 1.99 * 3
                    End If



                    If (MEC112 >= 80) And (MEC112 <= 100) Then
                        l = 4.0 * 2
                    ElseIf (MEC112 >= 75) And (MEC112 <= 79) Then
                        l = 3.75 * 2
                    ElseIf (MEC112 >= 70) And (MEC112 <= 74) Then
                        l = 3.5 * 2
                    ElseIf (MEC112 >= 65) And (MEC112 <= 69) Then
                        l = 3.25 * 2
                    ElseIf (MEC112 >= 60) And (MEC112 <= 64) Then
                        l = 3.0 * 2
                    ElseIf (MEC112 >= 55) And (MEC112 <= 59) Then
                        l = 2.75 * 2
                    ElseIf (MEC112 >= 50) And (MEC112 <= 54) Then
                        l = 2.5 * 2
                    ElseIf (MEC112 >= 45) And (MEC112 <= 49) Then
                        l = 2.25 * 2
                    ElseIf (MEC112 >= 40) And (MEC112 <= 44) Then
                        l = 2.0 * 2
                    Else
                        l = 1.99 * 2
                    End If


                    If (MEC113 >= 80) And (MEC113 <= 100) Then
                        m = 4.0 * 2
                    ElseIf (MEC113 >= 75) And (MEC113 <= 79) Then
                        m = 3.75 * 2
                    ElseIf (MEC113 >= 70) And (MEC113 <= 74) Then
                        m = 3.5 * 2
                    ElseIf (MEC113 >= 65) And (MEC113 <= 69) Then
                        m = 3.25 * 2
                    ElseIf (MEC113 >= 60) And (MEC113 <= 64) Then
                        m = 3.0 * 2
                    ElseIf (MEC113 >= 55) And (MEC113 <= 59) Then
                        m = 2.75 * 2
                    ElseIf (MEC113 >= 50) And (MEC113 <= 54) Then
                        m = 2.5 * 2
                    ElseIf (MEC113 >= 45) And (MEC113 <= 49) Then
                        m = 2.25 * 2
                    ElseIf (MEC113 >= 40) And (MEC113 <= 44) Then
                        m = 2.0 * 2
                    Else
                        m = 1.99 * 2
                    End If



                    If (MTH113 >= 80) And (MTH113 <= 100) Then
                        n = 4.0 * 2
                    ElseIf (MTH113 >= 75) And (MTH113 <= 79) Then
                        n = 3.75 * 2
                    ElseIf (MTH113 >= 70) And (MTH113 <= 74) Then
                        n = 3.5 * 2
                    ElseIf (MTH113 >= 65) And (MTH113 <= 69) Then
                        n = 3.25 * 2
                    ElseIf (MTH113 >= 60) And (MTH113 <= 64) Then
                        n = 3.0 * 2
                    ElseIf (MTH113 >= 55) And (MTH113 <= 59) Then
                        n = 2.75 * 2
                    ElseIf (MTH113 >= 50) And (MTH113 <= 54) Then
                        n = 2.5 * 2
                    ElseIf (MTH113 >= 45) And (MTH113 <= 49) Then
                        n = 2.25 * 2
                    ElseIf (MTH113 >= 40) And (MTH113 <= 44) Then
                        n = 2.0 * 2
                    Else
                        n = 1.99 * 2
                    End If


                    If (STA111 >= 80) And (STA111 <= 100) Then
                        o = 4.0 * 2
                    ElseIf (STA111 >= 75) And (STA111 <= 79) Then
                        o = 3.75 * 2
                    ElseIf (STA111 >= 70) And (STA111 <= 74) Then
                        o = 3.5 * 2
                    ElseIf (STA111 >= 65) And (STA111 <= 69) Then
                        o = 3.25 * 2
                    ElseIf (STA111 >= 60) And (STA111 <= 64) Then
                        o = 3.0 * 2
                    ElseIf (STA111 >= 55) And (STA111 <= 59) Then
                        o = 2.75 * 2
                    ElseIf (STA111 >= 50) And (STA111 <= 54) Then
                        o = 2.5 * 2
                    ElseIf (STA111 >= 45) And (STA111 <= 49) Then
                        o = 2.25 * 2
                    ElseIf (STA111 >= 40) And (STA111 <= 44) Then
                        o = 2.0 * 2
                    Else
                        o = 1.99 * 2
                    End If

                    TOTALPOINT = a + b + c + d + e + f + g + h + i + j + k + l + m + n + o
                    TOTALCOURSEUNIT = 2 + 2 + 1 + 1 + 2 + 3 + 2 + 2 + 1 + 2 + 3 + 2 + 2 + 2 + 2
                    GPA = TOTALPOINT / TOTALCOURSEUNIT
                    Console.WriteLine("YOUR GPA = " + GPA.ToString("F2"))

                    If (GPA >= 3.5) And (GPA <= 4.0) Then
                        Console.WriteLine("CLASS CATEGORY = DISTINCTION")
                    ElseIf (GPA >= 3.0) And (GPA <= 3.49) Then
                        Console.WriteLine("CLASS CATEGORY = UPPER CREDIT")
                    ElseIf (GPA >= 2.5) And (GPA <= 2.99) Then
                        Console.WriteLine("CLASS CATEGORY = LOWER CREDIT")
                    ElseIf (GPA >= 2.0) And (GPA <= 2.49) Then
                        Console.WriteLine("CLASS CATEGORY = PASS")
                    Else
                        Console.WriteLine("CLASS CATEGORY = CARRY OVER")

                    End If
                End If

            ElseIf (op = "2") Then

                Console.WriteLine("GAPOSA COMPUTER ENGINEERING STUDENTS GP CALCULATOR FOR ND1 SECOND SEMESTER")
                Console.WriteLine("....................................................................")
                Console.WriteLine("ENTER SCORE FOR ECONOMICS(BAM124)")
                BAM124 = Console.ReadLine()
                Console.WriteLine("....................................................................")
                Console.WriteLine("ENTER SCORE FOR MICRO COMPUTER OPERATIONS(COM122)")
                COM122 = Console.ReadLine()
                Console.WriteLine("....................................................................")
                Console.WriteLine("ENTER SCORE FOR COMPUTER PROGRAMMING(FORTRAN)(COM129)")
                COM129 = Console.ReadLine()
                Console.WriteLine("....................................................................")
                Console.WriteLine("ENTER SCORE FOR DIGITAL COMPUTER FUNDAMENTALS 1(CTE121)")
                CTE121 = Console.ReadLine()
                Console.WriteLine("....................................................................")
                Console.WriteLine("ENTER SCORE FOR ELECTRONICS 1(EEC124)")
                EEC124 = Console.ReadLine()
                Console.WriteLine("....................................................................")
                Console.WriteLine("ENTER SCORE FOR ELECTRICAL MEASUREMENT AND INSTRUMENTATION(EEC126)")
                EEC126 = Console.ReadLine()
                Console.WriteLine("....................................................................")
                Console.WriteLine("ENTER SCORE FOR ELECTRICAL WORKSHOP PRACTICE 2(EEC127)")
                EEC127 = Console.ReadLine()
                Console.WriteLine("....................................................................")
                Console.WriteLine("ENTER SCORE FOR COMMUNICATION IN ENGLISH 1(GNS122)")
                GNS122 = Console.ReadLine()
                Console.WriteLine("....................................................................")
                Console.WriteLine("ENTER SCORE FOR INFORMATION TECHNOLOGY ESSENTIALS 1(ICT121)")
                ICT121 = Console.ReadLine()
                Console.WriteLine("....................................................................")
                Console.WriteLine("ENTER SCORE FOR ROUTING PROTOCOL(CCNA)(ICT125)")
                ICT125 = Console.ReadLine()
                Console.WriteLine("....................................................................")
                Console.WriteLine("ENTER SCORE FOR DESCRIPTIVE GEOMETRY(MEC121)")
                MEC121 = Console.ReadLine()
                Console.WriteLine("....................................................................")
                Console.WriteLine("ENTER SCORE FOR INTRODUCTION TO THERMODYNAMICS(MEC122)")
                MEC122 = Console.ReadLine()
                Console.WriteLine("....................................................................")
                Console.WriteLine("ENTER SCORE FOR CALCULUS(MTH121)")
                MTH121 = Console.ReadLine()
                Console.WriteLine("....................................................................")

                If (BAM124 > 100) Or (COM122 > 100) Or (COM129 > 100) Or (CTE121 > 100) Or (EEC124 > 100) Or (EEC126 > 100) Or (EEC127 > 100) Or (GNS122 > 100) Or (ICT121 > 100) Or (ICT125 > 100) Or (MEC121 > 100) Or (MEC122 > 100) Or (MTH121 > 100) Then
                    Console.WriteLine("ERROR! Invalid Score")
                    Console.WriteLine("....................................................................")
                ElseIf (BAM124 < 0) Or (COM122 < 0) Or (COM129 < 0) Or (CTE121 < 0) Or (EEC124 < 0) Or (EEC126 < 0) Or (EEC127 < 0) Or (GNS122 < 0) Or (ICT121 < 0) Or (ICT125 < 0) Or (MEC121 < 0) Or (MEC122 < 0) Or (MTH121 < 0) Then
                    Console.WriteLine("ERROR! Invalid Score")
                    Console.WriteLine("....................................................................")

                Else
                    If (BAM124 >= 80) And (BAM124 <= 100) Then
                        a = 4.0 * 2
                    ElseIf (BAM124 >= 75) And (BAM124 <= 79) Then
                        a = 3.75 * 2
                    ElseIf (BAM124 >= 70) And (BAM124 <= 74) Then
                        a = 3.5 * 2
                    ElseIf (BAM124 >= 65) And (BAM124 <= 69) Then
                        a = 3.25 * 2
                    ElseIf (BAM124 >= 60) And (BAM124 <= 64) Then
                        a = 3.0 * 2
                    ElseIf (BAM124 >= 55) And (BAM124 <= 59) Then
                        a = 2.75 * 2
                    ElseIf (BAM124 >= 50) And (BAM124 <= 54) Then
                        a = 2.5 * 2
                    ElseIf (BAM124 >= 45) And (BAM124 <= 49) Then
                        a = 2.25 * 2
                    ElseIf (BAM124 >= 40) And (BAM124 <= 44) Then
                        a = 2.0 * 2
                    Else
                        a = 1.99 * 2
                    End If



                    If (COM122 >= 80) And (COM122 <= 100) Then
                        b = 4.0 * 2
                    ElseIf (COM122 >= 75) And (COM122 <= 79) Then
                        b = 3.75 * 2
                    ElseIf (COM122 >= 70) And (COM122 <= 74) Then
                        b = 3.5 * 2
                    ElseIf (COM122 >= 65) And (COM122 <= 69) Then
                        b = 3.25 * 2
                    ElseIf (COM122 >= 60) And (COM122 <= 64) Then
                        b = 3.0 * 2
                    ElseIf (COM122 >= 55) And (COM122 <= 59) Then
                        b = 2.75 * 2
                    ElseIf (COM122 >= 50) And (COM122 <= 54) Then
                        b = 2.5 * 2
                    ElseIf (COM122 >= 45) And (COM122 <= 49) Then
                        b = 2.25 * 2
                    ElseIf (COM122 >= 40) And (COM122 <= 44) Then
                        b = 2.0 * 2
                    Else
                        b = 1.99 * 2
                    End If


                    If (COM129 >= 80) And (COM129 <= 100) Then
                        c = 4.0 * 3
                    ElseIf (COM129 >= 75) And (COM129 <= 79) Then
                        c = 3.75 * 3
                    ElseIf (COM129 >= 70) And (COM129 <= 74) Then
                        c = 3.5 * 3
                    ElseIf (COM129 >= 65) And (COM129 <= 69) Then
                        c = 3.25 * 3
                    ElseIf (COM129 >= 60) And (COM129 <= 64) Then
                        c = 3.0 * 3
                    ElseIf (COM129 >= 55) And (COM129 <= 59) Then
                        c = 2.75 * 3
                    ElseIf (COM129 >= 50) And (COM129 <= 54) Then
                        c = 2.5 * 3
                    ElseIf (COM129 >= 45) And (COM129 <= 49) Then
                        c = 2.25 * 3
                    ElseIf (COM129 >= 40) And (COM129 <= 44) Then
                        c = 2.0 * 3
                    Else
                        c = 1.99 * 3
                    End If


                    If (CTE121 >= 80) And (CTE121 <= 100) Then
                        d = 4.0 * 2
                    ElseIf (CTE121 >= 75) And (CTE121 <= 79) Then
                        d = 3.75 * 2
                    ElseIf (CTE121 >= 70) And (CTE121 <= 74) Then
                        d = 3.5 * 2
                    ElseIf (CTE121 >= 65) And (CTE121 <= 69) Then
                        d = 3.25 * 2
                    ElseIf (CTE121 >= 60) And (CTE121 <= 64) Then
                        d = 3.0 * 2
                    ElseIf (CTE121 >= 55) And (CTE121 <= 59) Then
                        d = 2.75 * 2
                    ElseIf (CTE121 >= 50) And (CTE121 <= 54) Then
                        d = 2.5 * 2
                    ElseIf (CTE121 >= 45) And (CTE121 <= 49) Then
                        d = 2.25 * 2
                    ElseIf (CTE121 >= 40) And (CTE121 <= 44) Then
                        d = 2.0 * 2
                    Else
                        d = 1.99 * 2
                    End If


                    If (EEC124 >= 80) And (EEC124 <= 100) Then
                        e = 4.0 * 3
                    ElseIf (EEC124 >= 75) And (EEC124 <= 7) Then
                        e = 3.75 * 3
                    ElseIf (EEC124 >= 70) And (EEC124 <= 74) Then
                        e = 3.5 * 3
                    ElseIf (EEC124 >= 65) And (EEC124 <= 69) Then
                        e = 3.25 * 3
                    ElseIf (EEC124 >= 60) And (EEC124 <= 64) Then
                        e = 3.0 * 3
                    ElseIf (EEC124 >= 55) And (EEC124 <= 59) Then
                        e = 2.75 * 3
                    ElseIf (EEC124 >= 50) And (EEC124 <= 54) Then
                        e = 2.5 * 3
                    ElseIf (EEC124 >= 45) And (EEC124 <= 49) Then
                        e = 2.25 * 3
                    ElseIf (EEC124 >= 40) And (EEC124 <= 44) Then
                        e = 2.0 * 3
                    Else
                        e = 1.99 * 3
                    End If


                    If (EEC126 >= 80) And (EEC126 <= 100) Then
                        f = 4.0 * 3
                    ElseIf (EEC126 >= 75) And (EEC126 <= 79) Then
                        f = 3.75 * 3
                    ElseIf (EEC126 >= 70) And (EEC126 <= 74) Then
                        f = 3.5 * 3
                    ElseIf (EEC126 >= 65) And (EEC126 <= 69) Then
                        f = 3.25 * 3
                    ElseIf (EEC126 >= 60) And (EEC126 <= 64) Then
                        f = 3.0 * 3
                    ElseIf (EEC126 >= 55) And (EEC126 <= 59) Then
                        f = 2.75 * 3
                    ElseIf (EEC126 >= 50) And (EEC126 <= 54) Then
                        f = 2.5 * 3
                    ElseIf (EEC126 >= 45) And (EEC126 <= 49) Then
                        f = 2.25 * 3
                    ElseIf (EEC126 >= 40) And (EEC126 <= 44) Then
                        f = 2.0 * 3
                    Else
                        f = 1.99 * 3
                    End If


                    If (EEC127 >= 80) And (EEC127 <= 100) Then
                        g = 4.0 * 1
                    ElseIf (EEC127 >= 75) And (EEC127 <= 79) Then
                        g = 3.75 * 1
                    ElseIf (EEC127 >= 70) And (EEC127 <= 74) Then
                        g = 3.5 * 1
                    ElseIf (EEC127 >= 65) And (EEC127 <= 69) Then
                        g = 3.25 * 1
                    ElseIf (EEC127 >= 60) And (EEC127 <= 64) Then
                        g = 3.0 * 1
                    ElseIf (EEC127 >= 55) And (EEC127 <= 59) Then
                        g = 2.75 * 1
                    ElseIf (EEC127 >= 50) And (EEC127 <= 54) Then
                        g = 2.5 * 1
                    ElseIf (EEC127 >= 45) And (EEC127 <= 49) Then
                        g = 2.25 * 1
                    ElseIf (EEC127 >= 40) And (EEC127 <= 44) Then
                        g = 2.0 * 1
                    Else
                        g = 1.99 * 1
                    End If


                    If (GNS122 >= 80) And (GNS122 <= 100) Then
                        h = 4.0 * 2
                    ElseIf (GNS122 >= 75) And (GNS122 <= 79) Then
                        h = 3.75 * 2
                    ElseIf (GNS122 >= 70) And (GNS122 <= 74) Then
                        h = 3.5 * 2
                    ElseIf (GNS122 >= 65) And (GNS122 <= 69) Then
                        h = 3.25 * 2
                    ElseIf (GNS122 >= 60) And (GNS122 <= 64) Then
                        h = 3.0 * 2
                    ElseIf (GNS122 >= 55) And (GNS122 <= 59) Then
                        h = 2.75 * 2
                    ElseIf (GNS122 >= 50) And (GNS122 <= 54) Then
                        h = 2.5 * 2
                    ElseIf (GNS122 >= 45) And (GNS122 <= 49) Then
                        h = 2.25 * 2
                    ElseIf (GNS122 >= 40) And (GNS122 <= 44) Then
                        h = 2.0 * 2
                    Else
                        h = 1.99 * 2
                    End If


                    If (ICT121 >= 80) And (ICT121 <= 100) Then
                        i = 4.0 * 3
                    ElseIf (ICT121 >= 75) And (ICT121 <= 79) Then
                        i = 3.75 * 3
                    ElseIf (ICT121 >= 70) And (ICT121 <= 74) Then
                        i = 3.5 * 3
                    ElseIf (ICT121 >= 65) And (ICT121 <= 69) Then
                        i = 3.25 * 3
                    ElseIf (ICT121 >= 60) And (ICT121 <= 64) Then
                        i = 3.0 * 3
                    ElseIf (ICT121 >= 55) And (ICT121 <= 59) Then
                        i = 2.75 * 3
                    ElseIf (ICT121 >= 50) And (ICT121 <= 54) Then
                        i = 2.5 * 3
                    ElseIf (ICT121 >= 45) And (ICT121 <= 49) Then
                        i = 2.25 * 3
                    ElseIf (ICT121 >= 40) And (ICT121 <= 44) Then
                        i = 2.0 * 3
                    Else
                        i = 1.99 * 3
                    End If


                    If (ICT125 >= 80) And (ICT125 <= 100) Then
                        j = 4.0 * 2
                    ElseIf (ICT125 >= 75) And (ICT125 <= 79) Then
                        j = 3.75 * 2
                    ElseIf (ICT125 >= 70) And (ICT125 <= 74) Then
                        j = 3.5 * 2
                    ElseIf (ICT125 >= 65) And (ICT125 <= 69) Then
                        j = 3.25 * 2
                    ElseIf (ICT125 >= 60) And (ICT125 <= 64) Then
                        j = 3.0 * 2
                    ElseIf (ICT125 >= 55) And (ICT125 <= 59) Then
                        j = 2.75 * 2
                    ElseIf (ICT125 >= 50) And (ICT125 <= 54) Then
                        j = 2.5 * 2
                    ElseIf (ICT125 >= 45) And (ICT125 <= 49) Then
                        j = 2.25 * 2
                    ElseIf (ICT125 >= 40) And (ICT125 <= 44) Then
                        j = 2.0 * 2
                    Else
                        j = 1.99 * 2
                    End If


                    If (MEC121 >= 80) And (MEC121 <= 100) Then
                        k = 4.0 * 2
                    ElseIf (MEC121 >= 75) And (MEC121 <= 79) Then
                        k = 3.75 * 2
                    ElseIf (MEC121 >= 70) And (MEC121 <= 74) Then
                        k = 3.5 * 2
                    ElseIf (MEC121 >= 65) And (MEC121 <= 69) Then
                        k = 3.25 * 2
                    ElseIf (MEC121 >= 60) And (MEC121 <= 64) Then
                        k = 3.0 * 2
                    ElseIf (MEC121 >= 55) And (MEC121 <= 59) Then
                        k = 2.75 * 2
                    ElseIf (MEC121 >= 50) And (MEC121 <= 54) Then
                        k = 2.5 * 2
                    ElseIf (MEC121 >= 45) And (MEC121 <= 49) Then
                        k = 2.25 * 2
                    ElseIf (MEC121 >= 40) And (MEC121 <= 44) Then
                        k = 2.0 * 2
                    Else
                        k = 1.99 * 2
                    End If


                    If (MEC122 >= 80) And (MEC122 <= 100) Then
                        l = 4.0 * 2
                    ElseIf (MEC122 >= 75) And (MEC122 <= 79) Then
                        l = 3.75 * 2
                    ElseIf (MEC122 >= 70) And (MEC122 <= 74) Then
                        l = 3.5 * 2
                    ElseIf (MEC122 >= 65) And (MEC122 <= 69) Then
                        l = 3.25 * 2
                    ElseIf (MEC122 >= 60) And (MEC122 <= 64) Then
                        l = 3.0 * 2
                    ElseIf (MEC122 >= 55) And (MEC122 <= 59) Then
                        l = 2.75 * 2
                    ElseIf (MEC122 >= 50) And (MEC122 <= 54) Then
                        l = 2.5 * 2
                    ElseIf (MEC122 >= 45) And (MEC122 <= 49) Then
                        l = 2.25 * 2
                    ElseIf (MEC122 >= 40) And (MEC122 <= 44) Then
                        l = 2.0 * 2
                    Else
                        l = 1.99 * 2
                    End If


                    If (MTH121 >= 80) And (MTH121 <= 100) Then
                        m = 4.0 * 2
                    ElseIf (MTH121 >= 75) And (MTH121 <= 79) Then
                        m = 3.75 * 2
                    ElseIf (MTH121 >= 70) And (MTH121 <= 74) Then
                        m = 3.5 * 2
                    ElseIf (MTH121 >= 65) And (MTH121 <= 69) Then
                        m = 3.25 * 2
                    ElseIf (MTH121 >= 60) And (MTH121 <= 64) Then
                        m = 3.0 * 2
                    ElseIf (MTH121 >= 55) And (MTH121 <= 59) Then
                        m = 2.75 * 2
                    ElseIf (MTH121 >= 50) And (MTH121 <= 54) Then
                        m = 2.5 * 2
                    ElseIf (MTH121 >= 45) And (MTH121 <= 49) Then
                        m = 2.25 * 2
                    ElseIf (MTH121 >= 40) And (MTH121 <= 44) Then
                        m = 2.0 * 2
                    Else
                        m = 1.99 * 2
                    End If



                    TOTALPOINT = a + b + c + d + e + f + g + h + i + j + k + l + m
                    TOTALCOURSEUNIT = 2 + 2 + 3 + 2 + 3 + 3 + 1 + 2 + 3 + 2 + 2 + 2 + 2
                    GPA = TOTALPOINT / TOTALCOURSEUNIT
                    Console.WriteLine("YOUR GPA = " + GPA.ToString("F2"))

                    If (GPA >= 3.5) And (GPA <= 4.0) Then
                        Console.WriteLine("CLASS CATEGORY = DISTINCTION")
                    ElseIf (GPA >= 3.0) And (GPA <= 3.49) Then
                        Console.WriteLine("CLASS CATEGORY = UPPER CREDIT")
                    ElseIf (GPA >= 2.5) And (GPA <= 2.99) Then
                        Console.WriteLine("CLASS CATEGORY = LOWER CREDIT")
                    ElseIf (GPA >= 2.0) And (GPA <= 2.49) Then
                        Console.WriteLine("CLASS CATEGORY = PASS")
                    Else
                        Console.WriteLine("CLASS CATEGORY = CARRY OVER")

                    End If
                End If

            ElseIf (op = "3") Then
                Console.WriteLine("GAPOSA COMPUTER ENGINEERING STUDENTS GP CALCULATOR FOR ND2 FIRST SEMESTER")
                Console.WriteLine("....................................................................")
                Console.WriteLine("ENTER SCORE FOR COMPUTER PROGRAMMING USING C++(COM218)")
                COM218 = Console.ReadLine()
                Console.WriteLine("....................................................................")
                Console.WriteLine("ENTER SCORE FOR DIGITAL COMPUTER FUNDAMENTALS 2(CTE213)")
                CTE213 = Console.ReadLine()
                Console.WriteLine("....................................................................")
                Console.WriteLine("ENTER SCORE FOR COMPUTER ARCHITECTURE(CTE214)")
                CTE214 = Console.ReadLine()
                Console.WriteLine("....................................................................")
                Console.WriteLine("ENTER SCORE FOR SEMILAR(CTE216)")
                CTE216 = Console.ReadLine()
                Console.WriteLine("....................................................................")
                Console.WriteLine("ENTER SCORE FOR ELECTRICAL CIRCUIT THEORY 1(EEC210)")
                EEC210 = Console.ReadLine()
                Console.WriteLine("....................................................................")
                Console.WriteLine("ENTER SCORE FOR ELECTRONICS 2(EEC214)")
                EEC214 = Console.ReadLine()
                Console.WriteLine("....................................................................")
                Console.WriteLine("ENTER SCORE FOR ELECTRICAL MEASUREMENT AND INSTRUMENTATION 2(EEC215)")
                EEC215 = Console.ReadLine()
                Console.WriteLine("....................................................................")
                Console.WriteLine("ENTER SCORE FOR ELECTRICAL/ELECTRONIC MAINTENANCE AND REPAIR(EEC217)")
                EEC217 = Console.ReadLine()
                Console.WriteLine("....................................................................")
                Console.WriteLine("ENTER SCORE FOR USE OF ENGLISH 2(GNS211)")
                GNS211 = Console.ReadLine()
                Console.WriteLine("....................................................................")
                Console.WriteLine("ENTER SCORE FOR INFORMATION TECHNOLOGY ESSENTIALS 2(ICT211)")
                ICT211 = Console.ReadLine()
                Console.WriteLine("....................................................................")
                Console.WriteLine("ENTER SCORE FOR SWITCHING AND WIRELESS (CCNA)(ICT215)")
                ICT215 = Console.ReadLine()
                Console.WriteLine("....................................................................")
                Console.WriteLine("ENTER SCORE FOR LOGIC AND LINEAR ALGEBRA(MTH212)")
                MTH212 = Console.ReadLine()
                Console.WriteLine("....................................................................")
                Console.WriteLine("ENTER SCORE FOR STUDENTS INDUSTRIAL WORK EXPERIENCE SCHEME(SWE211)")
                SWE211 = Console.ReadLine()
                Console.WriteLine("....................................................................")

                If (COM218 > 100) Or (CTE213 > 100) Or (CTE214 > 100) Or (CTE216 > 100) Or (EEC210 > 100) Or (EEC214 > 100) Or (EEC215 > 100) Or (EEC217 > 100) Or (GNS211 > 100) Or (ICT211 > 100) Or (ICT215 > 100) Or (MTH212 > 100) Or (SWE211 > 100) Then
                    Console.WriteLine("ERROR! Invalid Score")
                    Console.WriteLine("....................................................................")
                ElseIf (COM218 < 0) Or (CTE213 < 0) Or (CTE214 < 0) Or (CTE216 < 0) Or (EEC210 < 0) Or (EEC214 < 0) Or (EEC215 < 0) Or (EEC217 < 0) Or (GNS211 < 0) Or (ICT211 < 0) Or (ICT215 < 0) Or (MTH212 < 0) Or (SWE211 < 0) Then
                    Console.WriteLine("ERROR! Invalid Score")
                    Console.WriteLine("....................................................................")

                Else
                    If (COM218 >= 80) And (COM218 <= 100) Then
                        a = 4.0 * 2
                    ElseIf (COM218 >= 75) And (COM218 <= 79) Then
                        a = 3.75 * 2
                    ElseIf (COM218 >= 70) And (COM218 <= 74) Then
                        a = 3.5 * 2
                    ElseIf (COM218 >= 65) And (COM218 <= 69) Then
                        a = 3.25 * 2
                    ElseIf (COM218 >= 60) And (COM218 <= 64) Then
                        a = 3.0 * 2
                    ElseIf (COM218 >= 55) And (COM218 <= 59) Then
                        a = 2.75 * 2
                    ElseIf (COM218 >= 50) And (COM218 <= 54) Then
                        a = 2.5 * 2
                    ElseIf (COM218 >= 45) And (COM218 <= 49) Then
                        a = 2.25 * 2
                    ElseIf (COM218 >= 40) And (COM218 <= 44) Then
                        a = 2.0 * 2
                    Else
                        a = 1.99 * 2
                    End If



                    If (CTE213 >= 80) And (CTE213 <= 100) Then
                        b = 4.0 * 3
                    ElseIf (CTE213 >= 75) And (CTE213 <= 79) Then
                        b = 3.75 * 3
                    ElseIf (CTE213 >= 70) And (CTE213 <= 74) Then
                        b = 3.5 * 3
                    ElseIf (CTE213 >= 65) And (CTE213 <= 69) Then
                        b = 3.25 * 3
                    ElseIf (CTE213 >= 60) And (CTE213 <= 64) Then
                        b = 3.0 * 3
                    ElseIf (CTE213 >= 55) And (CTE213 <= 59) Then
                        b = 2.75 * 3
                    ElseIf (CTE213 >= 50) And (CTE213 <= 54) Then
                        b = 2.5 * 3
                    ElseIf (CTE213 >= 45) And (CTE213 <= 49) Then
                        b = 2.25 * 3
                    ElseIf (CTE213 >= 40) And (CTE213 <= 44) Then
                        b = 2.0 * 3
                    Else
                        b = 1.99 * 3
                    End If


                    If (CTE214 >= 80) And (CTE214 <= 100) Then
                        c = 4.0 * 1
                    ElseIf (CTE214 >= 75) And (CTE214 <= 79) Then
                        c = 3.75 * 1
                    ElseIf (CTE214 >= 70) And (CTE214 <= 74) Then
                        c = 3.5 * 1
                    ElseIf (CTE214 >= 65) And (CTE214 <= 69) Then
                        c = 3.25 * 1
                    ElseIf (CTE214 >= 60) And (CTE214 <= 64) Then
                        c = 3.0 * 1
                    ElseIf (CTE214 >= 55) And (CTE214 <= 59) Then
                        c = 2.75 * 1
                    ElseIf (CTE214 >= 50) And (CTE214 <= 54) Then
                        c = 2.5 * 1
                    ElseIf (CTE214 >= 45) And (CTE214 <= 49) Then
                        c = 2.25 * 1
                    ElseIf (CTE214 >= 40) And (CTE214 <= 44) Then
                        c = 2.0 * 1
                    Else
                        c = 1.99 * 1
                    End If


                    If (CTE216 >= 80) And (CTE216 <= 100) Then
                        d = 4.0 * 2
                    ElseIf (CTE216 >= 75) And (CTE216 <= 79) Then
                        d = 3.75 * 2
                    ElseIf (CTE216 >= 70) And (CTE216 <= 74) Then
                        d = 3.5 * 2
                    ElseIf (CTE216 >= 65) And (CTE216 <= 69) Then
                        d = 3.25 * 2
                    ElseIf (CTE216 >= 60) And (CTE216 <= 64) Then
                        d = 3.0 * 2
                    ElseIf (CTE216 >= 55) And (CTE216 <= 59) Then
                        d = 2.75 * 2
                    ElseIf (CTE216 >= 50) And (CTE216 <= 54) Then
                        d = 2.5 * 2
                    ElseIf (CTE216 >= 45) And (CTE216 <= 49) Then
                        d = 2.25 * 2
                    ElseIf (CTE216 >= 40) And (CTE216 <= 44) Then
                        d = 2.0 * 2
                    Else
                        d = 1.99 * 2
                    End If


                    If (EEC210 >= 80) And (EEC210 <= 100) Then
                        e = 4.0 * 2
                    ElseIf (EEC210 >= 75) And (EEC210 <= 7) Then
                        e = 3.75 * 2
                    ElseIf (EEC210 >= 70) And (EEC210 <= 74) Then
                        e = 3.5 * 2
                    ElseIf (EEC210 >= 65) And (EEC210 <= 69) Then
                        e = 3.25 * 2
                    ElseIf (EEC210 >= 60) And (EEC210 <= 64) Then
                        e = 3.0 * 2
                    ElseIf (EEC210 >= 55) And (EEC210 <= 59) Then
                        e = 2.75 * 2
                    ElseIf (EEC210 >= 50) And (EEC210 <= 54) Then
                        e = 2.5 * 2
                    ElseIf (EEC210 >= 45) And (EEC210 <= 49) Then
                        e = 2.25 * 2
                    ElseIf (EEC210 >= 40) And (EEC210 <= 44) Then
                        e = 2.0 * 2
                    Else
                        e = 1.99 * 2
                    End If


                    If (EEC214 >= 80) And (EEC214 <= 100) Then
                        f = 4.0 * 3
                    ElseIf (EEC214 >= 75) And (EEC214 <= 79) Then
                        f = 3.75 * 3
                    ElseIf (EEC214 >= 70) And (EEC214 <= 74) Then
                        f = 3.5 * 3
                    ElseIf (EEC214 >= 65) And (EEC214 <= 69) Then
                        f = 3.25 * 3
                    ElseIf (EEC214 >= 60) And (EEC214 <= 64) Then
                        f = 3.0 * 3
                    ElseIf (EEC214 >= 55) And (EEC214 <= 59) Then
                        f = 2.75 * 3
                    ElseIf (EEC214 >= 50) And (EEC214 <= 54) Then
                        f = 2.5 * 3
                    ElseIf (EEC214 >= 45) And (EEC214 <= 49) Then
                        f = 2.25 * 3
                    ElseIf (EEC214 >= 40) And (EEC214 <= 44) Then
                        f = 2.0 * 3
                    Else
                        f = 1.99 * 3
                    End If


                    If (EEC215 >= 80) And (EEC215 <= 100) Then
                        g = 4.0 * 2
                    ElseIf (EEC215 >= 75) And (EEC215 <= 79) Then
                        g = 3.75 * 2
                    ElseIf (EEC215 >= 70) And (EEC215 <= 74) Then
                        g = 3.5 * 2
                    ElseIf (EEC215 >= 65) And (EEC215 <= 69) Then
                        g = 3.25 * 2
                    ElseIf (EEC215 >= 60) And (EEC215 <= 64) Then
                        g = 3.0 * 2
                    ElseIf (EEC215 >= 55) And (EEC215 <= 59) Then
                        g = 2.75 * 2
                    ElseIf (EEC215 >= 50) And (EEC215 <= 54) Then
                        g = 2.5 * 2
                    ElseIf (EEC215 >= 45) And (EEC215 <= 49) Then
                        g = 2.25 * 2
                    ElseIf (EEC215 >= 40) And (EEC215 <= 44) Then
                        g = 2.0 * 2
                    Else
                        g = 1.99 * 2
                    End If


                    If (EEC217 >= 80) And (EEC217 <= 100) Then
                        h = 4.0 * 2
                    ElseIf (EEC217 >= 75) And (EEC217 <= 79) Then
                        h = 3.75 * 2
                    ElseIf (EEC217 >= 70) And (EEC217 <= 74) Then
                        h = 3.5 * 2
                    ElseIf (EEC217 >= 65) And (EEC217 <= 69) Then
                        h = 3.25 * 2
                    ElseIf (EEC217 >= 60) And (EEC217 <= 64) Then
                        h = 3.0 * 2
                    ElseIf (EEC217 >= 55) And (EEC217 <= 59) Then
                        h = 2.75 * 2
                    ElseIf (EEC217 >= 50) And (EEC217 <= 54) Then
                        h = 2.5 * 2
                    ElseIf (EEC217 >= 45) And (EEC217 <= 49) Then
                        h = 2.25 * 2
                    ElseIf (EEC217 >= 40) And (EEC217 <= 44) Then
                        h = 2.0 * 2
                    Else
                        h = 1.99 * 2
                    End If


                    If (GNS211 >= 80) And (GNS211 <= 100) Then
                        i = 4.0 * 2
                    ElseIf (GNS211 >= 75) And (GNS211 <= 79) Then
                        i = 3.75 * 2
                    ElseIf (GNS211 >= 70) And (GNS211 <= 74) Then
                        i = 3.5 * 2
                    ElseIf (GNS211 >= 65) And (GNS211 <= 69) Then
                        i = 3.25 * 2
                    ElseIf (GNS211 >= 60) And (GNS211 <= 64) Then
                        i = 3.0 * 2
                    ElseIf (GNS211 >= 55) And (GNS211 <= 59) Then
                        i = 2.75 * 2
                    ElseIf (GNS211 >= 50) And (GNS211 <= 54) Then
                        i = 2.5 * 2
                    ElseIf (GNS211 >= 45) And (GNS211 <= 49) Then
                        i = 2.25 * 2
                    ElseIf (GNS211 >= 40) And (GNS211 <= 44) Then
                        i = 2.0 * 2
                    Else
                        i = 1.99 * 2
                    End If


                    If (ICT211 >= 80) And (ICT211 <= 100) Then
                        j = 4.0 * 3
                    ElseIf (ICT211 >= 75) And (ICT211 <= 79) Then
                        j = 3.75 * 3
                    ElseIf (ICT211 >= 70) And (ICT211 <= 74) Then
                        j = 3.5 * 3
                    ElseIf (ICT211 >= 65) And (ICT211 <= 69) Then
                        j = 3.25 * 3
                    ElseIf (ICT211 >= 60) And (ICT211 <= 64) Then
                        j = 3.0 * 3
                    ElseIf (ICT211 >= 55) And (ICT211 <= 59) Then
                        j = 2.75 * 3
                    ElseIf (ICT211 >= 50) And (ICT211 <= 54) Then
                        j = 2.5 * 3
                    ElseIf (ICT211 >= 45) And (ICT211 <= 49) Then
                        j = 2.25 * 3
                    ElseIf (ICT211 >= 40) And (ICT211 <= 44) Then
                        j = 2.0 * 3
                    Else
                        j = 1.99 * 3
                    End If


                    If (ICT215 >= 80) And (ICT215 <= 100) Then
                        k = 4.0 * 2
                    ElseIf (ICT215 >= 75) And (ICT215 <= 79) Then
                        k = 3.75 * 2
                    ElseIf (ICT215 >= 70) And (ICT215 <= 74) Then
                        k = 3.5 * 2
                    ElseIf (ICT215 >= 65) And (ICT215 <= 69) Then
                        k = 3.25 * 2
                    ElseIf (ICT215 >= 60) And (ICT215 <= 64) Then
                        k = 3.0 * 2
                    ElseIf (ICT215 >= 55) And (ICT215 <= 59) Then
                        k = 2.75 * 2
                    ElseIf (ICT215 >= 50) And (ICT215 <= 54) Then
                        k = 2.5 * 2
                    ElseIf (ICT215 >= 45) And (ICT215 <= 49) Then
                        k = 2.25 * 2
                    ElseIf (ICT215 >= 40) And (ICT215 <= 44) Then
                        k = 2.0 * 2
                    Else
                        k = 1.99 * 2
                    End If


                    If (MTH212 >= 80) And (MTH212 <= 100) Then
                        l = 4.0 * 2
                    ElseIf (MTH212 >= 75) And (MTH212 <= 79) Then
                        l = 3.75 * 2
                    ElseIf (MTH212 >= 70) And (MTH212 <= 74) Then
                        l = 3.5 * 2
                    ElseIf (MTH212 >= 65) And (MTH212 <= 69) Then
                        l = 3.25 * 2
                    ElseIf (MTH212 >= 60) And (MTH212 <= 64) Then
                        l = 3.0 * 2
                    ElseIf (MTH212 >= 55) And (MTH212 <= 59) Then
                        l = 2.75 * 2
                    ElseIf (MTH212 >= 50) And (MTH212 <= 54) Then
                        l = 2.5 * 2
                    ElseIf (MTH212 >= 45) And (MTH212 <= 49) Then
                        l = 2.25 * 2
                    ElseIf (MTH212 >= 40) And (MTH212 <= 44) Then
                        l = 2.0 * 2
                    Else
                        l = 1.99 * 2
                    End If


                    If (SWE211 >= 80) And (SWE211 <= 100) Then
                        m = 4.0 * 2
                    ElseIf (SWE211 >= 75) And (SWE211 <= 79) Then
                        m = 3.75 * 2
                    ElseIf (SWE211 >= 70) And (SWE211 <= 74) Then
                        m = 3.5 * 2
                    ElseIf (SWE211 >= 65) And (SWE211 <= 69) Then
                        m = 3.25 * 2
                    ElseIf (SWE211 >= 60) And (SWE211 <= 64) Then
                        m = 3.0 * 2
                    ElseIf (SWE211 >= 55) And (SWE211 <= 59) Then
                        m = 2.75 * 2
                    ElseIf (SWE211 >= 50) And (SWE211 <= 54) Then
                        m = 2.5 * 2
                    ElseIf (SWE211 >= 45) And (SWE211 <= 49) Then
                        m = 2.25 * 2
                    ElseIf (SWE211 >= 40) And (SWE211 <= 44) Then
                        m = 2.0 * 2
                    Else
                        m = 1.99 * 2
                    End If



                    TOTALPOINT = a + b + c + d + e + f + g + h + i + j + k + l + m
                    TOTALCOURSEUNIT = 2 + 3 + 1 + 2 + 2 + 3 + 2 + 2 + 2 + 3 + 2 + 2 + 2
                    GPA = TOTALPOINT / TOTALCOURSEUNIT
                    Console.WriteLine("YOUR GPA = " + GPA.ToString("F2"))

                    If (GPA >= 3.5) And (GPA <= 4.0) Then
                        Console.WriteLine("CLASS CATEGORY = DISTINCTION")
                    ElseIf (GPA >= 3.0) And (GPA <= 3.49) Then
                        Console.WriteLine("CLASS CATEGORY = UPPER CREDIT")
                    ElseIf (GPA >= 2.5) And (GPA <= 2.99) Then
                        Console.WriteLine("CLASS CATEGORY = LOWER CREDIT")
                    ElseIf (GPA >= 2.0) And (GPA <= 2.49) Then
                        Console.WriteLine("CLASS CATEGORY = PASS")
                    Else
                        Console.WriteLine("CLASS CATEGORY = CARRY OVER")

                    End If
                End If


            ElseIf (op = "4") Then
                Console.WriteLine("GAPOSA COMPUTER ENGINEERING STUDENTS GP CALCULATOR FOR ND2 SECOND SEMESTER")
                Console.WriteLine("....................................................................")
                Console.WriteLine("ENTER SCORE FOR COMPUTER PROGRAMMING USING JAVA(COM228)")
                COM228 = Console.ReadLine()
                Console.WriteLine("....................................................................")
                Console.WriteLine("ENTER SCORE FOR COMPUTER PROGRAMMING(ASSEMBLY LANGUAGE)(CTE221)")
                CTE221 = Console.ReadLine()
                Console.WriteLine("....................................................................")
                Console.WriteLine("ENTER SCORE FOR COMPUTER WORKSHOP PRACTICE 2(CTE222)")
                CTE222 = Console.ReadLine()
                Console.WriteLine("....................................................................")
                Console.WriteLine("ENTER SCORE FOR OPERATING SYSTEM(CTE223)")
                CTE223 = Console.ReadLine()
                Console.WriteLine("....................................................................")
                Console.WriteLine("ENTER SCORE FOR COMPUTER POWER SYSTEMS(CTE224)")
                CTE224 = Console.ReadLine()
                Console.WriteLine("....................................................................")
                Console.WriteLine("ENTER SCORE FOR PROJECT(CTE229)")
                CTE229 = Console.ReadLine()
                Console.WriteLine("....................................................................")
                Console.WriteLine("ENTER SCORE FOR ELECTRICAL CIRCUIT THEORY 2(EEC220)")
                EEC220 = Console.ReadLine()
                Console.WriteLine("....................................................................")
                Console.WriteLine("ENTER SCORE FOR TELECOMMUNICATIONS ENGINEERING(EEC224)")
                EEC224 = Console.ReadLine()
                Console.WriteLine("....................................................................")
                Console.WriteLine("ENTER SCORE INTRODUCTION TO ENTREPRENEURSHIP(EED226)")
                EED226 = Console.ReadLine()
                Console.WriteLine("....................................................................")
                Console.WriteLine("ENTER SCORE FOR COMMUNICATION IN ENGLISH 2(GNS221)")
                GNS221 = Console.ReadLine()
                Console.WriteLine("....................................................................")
                Console.WriteLine("ENTER SCORE FOR WIRELESS AREA NETWORK(CCNA)(ICT225)")
                ICT225 = Console.ReadLine()
                Console.WriteLine("....................................................................")
                Console.WriteLine("ENTER SCORE FOR TRIGONOMETRY AND ANALYTICAL GEOMETRY(MTH222)")
                MTH222 = Console.ReadLine()
                Console.WriteLine("....................................................................")


                If (COM228 > 100) Or (CTE221 > 100) Or (CTE222 > 100) Or (CTE223 > 100) Or (CTE224 > 100) Or (CTE229 > 100) Or (EEC220 > 100) Or (EEC224 > 100) Or (EED226 > 100) Or (GNS221 > 100) Or (ICT225 > 100) Or (MTH222 > 100) Then
                    Console.WriteLine("ERROR! Invalid Score")
                    Console.WriteLine("....................................................................")
                ElseIf (COM228 < 0) Or (CTE221 < 0) Or (CTE222 < 0) Or (CTE223 < 0) Or (CTE224 < 0) Or (CTE229 < 0) Or (EEC220 < 0) Or (EEC224 < 0) Or (EED226 < 0) Or (GNS221 < 0) Or (ICT225 < 0) Or (MTH222 < 0) Then
                    Console.WriteLine("ERROR! Invalid Score")
                    Console.WriteLine("....................................................................")

                Else
                    If (COM228 >= 80) And (COM228 <= 100) Then
                        a = 4.0 * 2
                    ElseIf (COM228 >= 75) And (COM228 <= 79) Then
                        a = 3.75 * 2
                    ElseIf (COM228 >= 70) And (COM228 <= 74) Then
                        a = 3.5 * 2
                    ElseIf (COM228 >= 65) And (COM228 <= 69) Then
                        a = 3.25 * 2
                    ElseIf (COM228 >= 60) And (COM228 <= 64) Then
                        a = 3.0 * 2
                    ElseIf (COM228 >= 55) And (COM228 <= 59) Then
                        a = 2.75 * 2
                    ElseIf (COM228 >= 50) And (COM228 <= 54) Then
                        a = 2.5 * 2
                    ElseIf (COM228 >= 45) And (COM228 <= 49) Then
                        a = 2.25 * 2
                    ElseIf (COM228 >= 40) And (COM228 <= 44) Then
                        a = 2.0 * 2
                    Else
                        a = 1.99 * 2
                    End If



                    If (CTE221 >= 80) And (CTE221 <= 100) Then
                        b = 4.0 * 2
                    ElseIf (CTE221 >= 75) And (CTE221 <= 79) Then
                        b = 3.75 * 2
                    ElseIf (CTE221 >= 70) And (CTE221 <= 74) Then
                        b = 3.5 * 2
                    ElseIf (CTE221 >= 65) And (CTE221 <= 69) Then
                        b = 3.25 * 2
                    ElseIf (CTE221 >= 60) And (CTE221 <= 64) Then
                        b = 3.0 * 2
                    ElseIf (CTE221 >= 55) And (CTE221 <= 59) Then
                        b = 2.75 * 2
                    ElseIf (CTE221 >= 50) And (CTE221 <= 54) Then
                        b = 2.5 * 2
                    ElseIf (CTE221 >= 45) And (CTE221 <= 49) Then
                        b = 2.25 * 2
                    ElseIf (CTE221 >= 40) And (CTE221 <= 44) Then
                        b = 2.0 * 2
                    Else
                        b = 1.99 * 2
                    End If


                    If (CTE222 >= 80) And (CTE222 <= 100) Then
                        c = 4.0 * 1
                    ElseIf (CTE222 >= 75) And (CTE222 <= 79) Then
                        c = 3.75 * 1
                    ElseIf (CTE222 >= 70) And (CTE222 <= 74) Then
                        c = 3.5 * 1
                    ElseIf (CTE222 >= 65) And (CTE222 <= 69) Then
                        c = 3.25 * 1
                    ElseIf (CTE222 >= 60) And (CTE222 <= 64) Then
                        c = 3.0 * 1
                    ElseIf (CTE222 >= 55) And (CTE222 <= 59) Then
                        c = 2.75 * 1
                    ElseIf (CTE222 >= 50) And (CTE222 <= 54) Then
                        c = 2.5 * 1
                    ElseIf (CTE222 >= 45) And (CTE222 <= 49) Then
                        c = 2.25 * 1
                    ElseIf (CTE222 >= 40) And (CTE222 <= 44) Then
                        c = 2.0 * 1
                    Else
                        c = 1.99 * 1
                    End If


                    If (CTE223 >= 80) And (CTE223 <= 100) Then
                        d = 4.0 * 2
                    ElseIf (CTE223 >= 75) And (CTE223 <= 79) Then
                        d = 3.75 * 2
                    ElseIf (CTE223 >= 70) And (CTE223 <= 74) Then
                        d = 3.5 * 2
                    ElseIf (CTE223 >= 65) And (CTE223 <= 69) Then
                        d = 3.25 * 2
                    ElseIf (CTE223 >= 60) And (CTE223 <= 64) Then
                        d = 3.0 * 2
                    ElseIf (CTE223 >= 55) And (CTE223 <= 59) Then
                        d = 2.75 * 2
                    ElseIf (CTE223 >= 50) And (CTE223 <= 54) Then
                        d = 2.5 * 2
                    ElseIf (CTE223 >= 45) And (CTE223 <= 49) Then
                        d = 2.25 * 2
                    ElseIf (CTE223 >= 40) And (CTE223 <= 44) Then
                        d = 2.0 * 2
                    Else
                        d = 1.99 * 2
                    End If


                    If (CTE224 >= 80) And (CTE224 <= 100) Then
                        e = 4.0 * 2
                    ElseIf (CTE224 >= 75) And (CTE224 <= 7) Then
                        e = 3.75 * 2
                    ElseIf (CTE224 >= 70) And (CTE224 <= 74) Then
                        e = 3.5 * 2
                    ElseIf (CTE224 >= 65) And (CTE224 <= 69) Then
                        e = 3.25 * 2
                    ElseIf (CTE224 >= 60) And (CTE224 <= 64) Then
                        e = 3.0 * 2
                    ElseIf (CTE224 >= 55) And (CTE224 <= 59) Then
                        e = 2.75 * 2
                    ElseIf (CTE224 >= 50) And (CTE224 <= 54) Then
                        e = 2.5 * 2
                    ElseIf (CTE224 >= 45) And (CTE224 <= 49) Then
                        e = 2.25 * 2
                    ElseIf (CTE224 >= 40) And (CTE224 <= 44) Then
                        e = 2.0 * 2
                    Else
                        e = 1.99 * 2
                    End If


                    If (CTE229 >= 80) And (CTE229 <= 100) Then
                        f = 4.0 * 4
                    ElseIf (CTE229 >= 75) And (CTE229 <= 79) Then
                        f = 3.75 * 4
                    ElseIf (CTE229 >= 70) And (CTE229 <= 74) Then
                        f = 3.5 * 4
                    ElseIf (CTE229 >= 65) And (CTE229 <= 69) Then
                        f = 3.25 * 4
                    ElseIf (CTE229 >= 60) And (CTE229 <= 64) Then
                        f = 3.0 * 4
                    ElseIf (CTE229 >= 55) And (CTE229 <= 59) Then
                        f = 2.75 * 4
                    ElseIf (CTE229 >= 50) And (CTE229 <= 54) Then
                        f = 2.5 * 4
                    ElseIf (CTE229 >= 45) And (CTE229 <= 49) Then
                        f = 2.25 * 4
                    ElseIf (CTE229 >= 40) And (CTE229 <= 44) Then
                        f = 2.0 * 4
                    Else
                        f = 1.99 * 4
                    End If


                    If (EEC220 >= 80) And (EEC220 <= 100) Then
                        g = 4.0 * 2
                    ElseIf (EEC220 >= 75) And (EEC220 <= 79) Then
                        g = 3.75 * 2
                    ElseIf (EEC220 >= 70) And (EEC220 <= 74) Then
                        g = 3.5 * 2
                    ElseIf (EEC220 >= 65) And (EEC220 <= 69) Then
                        g = 3.25 * 2
                    ElseIf (EEC220 >= 60) And (EEC220 <= 64) Then
                        g = 3.0 * 2
                    ElseIf (EEC220 >= 55) And (EEC220 <= 59) Then
                        g = 2.75 * 2
                    ElseIf (EEC220 >= 50) And (EEC220 <= 54) Then
                        g = 2.5 * 2
                    ElseIf (EEC220 >= 45) And (EEC220 <= 49) Then
                        g = 2.25 * 2
                    ElseIf (EEC220 >= 40) And (EEC220 <= 44) Then
                        g = 2.0 * 2
                    Else
                        g = 1.99 * 2
                    End If


                    If (EEC224 >= 80) And (EEC224 <= 100) Then
                        h = 4.0 * 2
                    ElseIf (EEC224 >= 75) And (EEC224 <= 79) Then
                        h = 3.75 * 2
                    ElseIf (EEC224 >= 70) And (EEC224 <= 74) Then
                        h = 3.5 * 2
                    ElseIf (EEC224 >= 65) And (EEC224 <= 69) Then
                        h = 3.25 * 2
                    ElseIf (EEC224 >= 60) And (EEC224 <= 64) Then
                        h = 3.0 * 2
                    ElseIf (EEC224 >= 55) And (EEC224 <= 59) Then
                        h = 2.75 * 2
                    ElseIf (EEC224 >= 50) And (EEC224 <= 54) Then
                        h = 2.5 * 2
                    ElseIf (EEC224 >= 45) And (EEC224 <= 49) Then
                        h = 2.25 * 2
                    ElseIf (EEC224 >= 40) And (EEC224 <= 44) Then
                        h = 2.0 * 2
                    Else
                        h = 1.99 * 2
                    End If


                    If (EED226 >= 80) And (EED226 <= 100) Then
                        i = 4.0 * 2
                    ElseIf (EED226 >= 75) And (EED226 <= 79) Then
                        i = 3.75 * 2
                    ElseIf (EED226 >= 70) And (EED226 <= 74) Then
                        i = 3.5 * 2
                    ElseIf (EED226 >= 65) And (EED226 <= 69) Then
                        i = 3.25 * 2
                    ElseIf (EED226 >= 60) And (EED226 <= 64) Then
                        i = 3.0 * 2
                    ElseIf (EED226 >= 55) And (EED226 <= 59) Then
                        i = 2.75 * 2
                    ElseIf (EED226 >= 50) And (EED226 <= 54) Then
                        i = 2.5 * 2
                    ElseIf (EED226 >= 45) And (EED226 <= 49) Then
                        i = 2.25 * 2
                    ElseIf (EED226 >= 40) And (EED226 <= 44) Then
                        i = 2.0 * 2
                    Else
                        i = 1.99 * 2
                    End If


                    If (GNS221 >= 80) And (GNS221 <= 100) Then
                        j = 4.0 * 2
                    ElseIf (GNS221 >= 75) And (GNS221 <= 79) Then
                        j = 3.75 * 2
                    ElseIf (GNS221 >= 70) And (GNS221 <= 74) Then
                        j = 3.5 * 2
                    ElseIf (GNS221 >= 65) And (GNS221 <= 69) Then
                        j = 3.25 * 2
                    ElseIf (GNS221 >= 60) And (GNS221 <= 64) Then
                        j = 3.0 * 2
                    ElseIf (GNS221 >= 55) And (GNS221 <= 59) Then
                        j = 2.75 * 2
                    ElseIf (GNS221 >= 50) And (GNS221 <= 54) Then
                        j = 2.5 * 2
                    ElseIf (GNS221 >= 45) And (GNS221 <= 49) Then
                        j = 2.25 * 2
                    ElseIf (GNS221 >= 40) And (GNS221 <= 44) Then
                        j = 2.0 * 2
                    Else
                        j = 1.99 * 2
                    End If


                    If (ICT225 >= 80) And (ICT225 <= 100) Then
                        k = 4.0 * 2
                    ElseIf (ICT225 >= 75) And (ICT225 <= 79) Then
                        k = 3.75 * 2
                    ElseIf (ICT225 >= 70) And (ICT225 <= 74) Then
                        k = 3.5 * 2
                    ElseIf (ICT225 >= 65) And (ICT225 <= 69) Then
                        k = 3.25 * 2
                    ElseIf (ICT225 >= 60) And (ICT225 <= 64) Then
                        k = 3.0 * 2
                    ElseIf (ICT225 >= 55) And (ICT225 <= 59) Then
                        k = 2.75 * 2
                    ElseIf (ICT225 >= 50) And (ICT225 <= 54) Then
                        k = 2.5 * 2
                    ElseIf (ICT225 >= 45) And (ICT225 <= 49) Then
                        k = 2.25 * 2
                    ElseIf (ICT225 >= 40) And (ICT225 <= 44) Then
                        k = 2.0 * 2
                    Else
                        k = 1.99 * 2
                    End If


                    If (MTH222 >= 80) And (MTH222 <= 100) Then
                        l = 4.0 * 2
                    ElseIf (MTH222 >= 75) And (MTH222 <= 79) Then
                        l = 3.75 * 2
                    ElseIf (MTH222 >= 70) And (MTH222 <= 74) Then
                        l = 3.5 * 2
                    ElseIf (MTH222 >= 65) And (MTH222 <= 69) Then
                        l = 3.25 * 2
                    ElseIf (MTH222 >= 60) And (MTH222 <= 64) Then
                        l = 3.0 * 2
                    ElseIf (MTH222 >= 55) And (MTH222 <= 59) Then
                        l = 2.75 * 2
                    ElseIf (MTH222 >= 50) And (MTH222 <= 54) Then
                        l = 2.5 * 2
                    ElseIf (MTH222 >= 45) And (MTH222 <= 49) Then
                        l = 2.25 * 2
                    ElseIf (MTH222 >= 40) And (MTH222 <= 44) Then
                        l = 2.0 * 2
                    Else
                        l = 1.99 * 2
                    End If

                    TOTALPOINT = a + b + c + d + e + f + g + h + i + j + k + l
                    TOTALCOURSEUNIT = 2 + 2 + 1 + 2 + 2 + 4 + 2 + 2 + 2 + 2 + 2 + 2
                    GPA = TOTALPOINT / TOTALCOURSEUNIT
                    Console.WriteLine("YOUR GPA = " + GPA.ToString("F2"))

                    If (GPA >= 3.5) And (GPA <= 4.0) Then
                        Console.WriteLine("CLASS CATEGORY = DISTINCTION")
                    ElseIf (GPA >= 3.0) And (GPA <= 3.49) Then
                        Console.WriteLine("CLASS CATEGORY = UPPER CREDIT")
                    ElseIf (GPA >= 2.5) And (GPA <= 2.99) Then
                        Console.WriteLine("CLASS CATEGORY = LOWER CREDIT")
                    ElseIf (GPA >= 2.0) And (GPA <= 2.49) Then
                        Console.WriteLine("CLASS CATEGORY = PASS")
                    Else
                        Console.WriteLine("CLASS CATEGORY = CARRY OVER")

                    End If
                End If
            Else
                Console.WriteLine("ERORR! Invalid Input")
            End If
            Console.WriteLine("....................................................................")

            Console.WriteLine("TO CONTINUE PRESS 'Y'")
            Console.WriteLine("TO STOP PRESS 'N'")
            action = Console.ReadLine()
            Console.WriteLine("....................................................................")

        Loop
    End Function

    Function quadraticequationcalculator()
        Dim a, b, c, d, e, f, g, h, x1, x2 As Double
        Console.WriteLine("THIS SOFTWARE SOLVE QUADRATIC EQUATION")
        Console.WriteLine("---------------------------------------------")
        Console.WriteLine("INPUT COEFFICIENT a")
        a = Console.ReadLine()
        Console.WriteLine("---------------------------------------------")
        Console.WriteLine("INPUT COEFFICIENT b")
        b = Console.ReadLine()
        Console.WriteLine("---------------------------------------------")
        Console.WriteLine("INPUT COEFFICIENT c")
        c = Console.ReadLine()
        Console.WriteLine("---------------------------------------------")

        d = b * b
        e = 4 * a * c
        f = d - e
        g = Math.Sqrt(f)
        h = 2 * a
        x1 = (-b + g) / h
        x2 = (-b - g) / h

        Console.WriteLine("x1 = " + x1.ToString)

        Console.WriteLine("x2 = " + x2.ToString)

    End Function

    Function agecalculator()
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
            ElseIf (birthyear = toyear) And (birthday > today) Then
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
                    resultday = DaysInMonth - birthday + today
                ElseIf (birthday > today) And (birthmonth = tomonth) Then
                    resultday = DaysInMonth - birthday + today + 1
                ElseIf (birthday > today) And (birthmonth > tomonth) Then
                    resultday = DaysInMonth - birthday + today
                ElseIf (birthday > today) Then
                    resultday = birthday - today
                Else : resultday = today - birthday
                End If

                Console.WriteLine("YOUR BIRTHDAY IS = " + resultyear.ToString + "Years" + ", " + resultmonth.ToString + "Months" + ", " + resultday.ToString + "Days")


            End If
        End If
    End Function

    Function simplecalculator()
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
    End Function

    Function areaofcircle()
        Dim radius, a, b, c As Double
        Console.WriteLine("THIS SOFTWARE CALCULATE THE AREA OF A CIRCLE")
        Console.WriteLine("------------------------------------------------")
        Console.WriteLine("ENTER RADIUS")
        radius = Console.ReadLine()
        Console.WriteLine("------------------------------------------------")
        a = 22 / 7
        b = radius * radius
        c = 22 / 7 * b
        Console.WriteLine("THE RESULT IS = " + c.ToString)
    End Function

    Function circumferenceofcircle()
        Dim radius, a, b As Double
        Console.WriteLine("THIS SOFTWARE CALCULATE THE CIRCUMFERENCE OF A CIRCLE")
        Console.WriteLine("******************************************************")
        Console.WriteLine("ENTER RADIUS")
        radius = Console.ReadLine()
        Console.WriteLine("******************************************************")
        a = 2 * 22 / 7
        b = a * radius
        Console.WriteLine("THE RESULT IS = " + b.ToString)
    End Function

    Function boylelaw()
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
    End Function

    Function velocitycalculator()
        Dim u, a, t, b, c As Double
        Console.WriteLine("THIS SOFTWARE CALCULATE VELOCITY")
        Console.WriteLine("**************************************")
        Console.WriteLine("ENTER COEFFICIENT u")
        u = Console.ReadLine()
        Console.WriteLine("**************************************")
        Console.WriteLine("ENTER COEFFICIENT a")
        a = Console.ReadLine()
        Console.WriteLine("**************************************")
        Console.WriteLine("ENTER COEFFICIENT t")
        t = Console.ReadLine()
        Console.WriteLine("**************************************")
        b = a * t
        c = u + b
        Console.WriteLine("THE RESULT IS = " + c.ToString)
    End Function

    Function highestoftwonumbers()
        Dim firstNo, SecondNo As Integer
        Console.WriteLine("THIS SOFTWARE CHECK HIGHEST OF TWO NUMBERS")
        Console.WriteLine("............................................")
        Console.WriteLine("ENTER FIRST NUMBER")
        firstNo = Console.ReadLine()
        Console.WriteLine("............................................")

        Console.WriteLine("ENTER SECOND NUMBER")
        SecondNo = Console.ReadLine()
        Console.WriteLine("............................................")

        If (firstNo > SecondNo) Then
            Console.WriteLine(firstNo.ToString + " IS THE HIGHEST NUMBER")
        Else
            Console.WriteLine(SecondNo.ToString + " IS THE HIGHEST NUMBER")
        End If
    End Function

    Function highestofthreenumbers()
        Dim a, b, c As Integer
        Console.WriteLine("THIS SOFTWARE FIND THE HIGHEST NUMBER BETWEEN THREE NUMBERS")
        Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>")
        Console.WriteLine("ENTER FIRST NUMBER")
        a = Console.ReadLine()
        Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>")
        Console.WriteLine("ENTER SECOND NUMBER")
        b = Console.ReadLine()
        Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>")
        Console.WriteLine("ENTER THIRD NUMBER")
        c = Console.ReadLine()
        Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>")
        If (a > b) Then
            Console.WriteLine(a.ToString + " IS THE BIGGEST NUMBER")
        ElseIf (b > c) Then
            Console.WriteLine(b.ToString + " IS THE BIGGEST NUMBER")
        Else
            Console.WriteLine(c.ToString + " IS THE BIGGEST NUMBER")

        End If
    End Function

    Function highestoffournumbers()
        Dim a, b, c, d As Integer
        Console.WriteLine("THIS SOFTWARE FIND THE HIGHEST NUMBER BETWEEN FOUR NUMBERS")
        Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>")
        Console.WriteLine("ENTER FIRST NUMBER")
        a = Console.ReadLine()
        Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>")
        Console.WriteLine("ENTER SECOND NUMBER")
        b = Console.ReadLine()
        Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>")
        Console.WriteLine("ENTER THIRD NUMBER")
        c = Console.ReadLine()
        Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>")
        Console.WriteLine("ENTER FOURTH NUMBER")
        d = Console.ReadLine()
        Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>")
        If (a > b) Then
            Console.WriteLine(a.ToString + " IS THE BIGGEST NUMBER")
        ElseIf (b > c) Then
            Console.WriteLine(b.ToString + " IS THE BIGGEST NUMBER")
        ElseIf (c > d) Then
            Console.WriteLine(c.ToString + " IS THE BIGGEST NUMBER")
        Else
            Console.WriteLine(d.ToString + " IS THE BIGGEST NUMBER")

        End If
    End Function

    Function loanapp()
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


        Console.WriteLine("TOTAL REPAYMENT = " + sum.ToString("N2") + "   " + "TOTAL INTEREST = " + sum2.ToString("N2"))

    End Function

    Function fivepercentofstaffsalary()

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


    End Function

    Function percentageofstaffsalary()
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

    End Function





End Module
