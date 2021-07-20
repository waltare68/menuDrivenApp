Imports System.Math
Module Module1
    Dim myMenu As Integer
    Dim dec As Integer
    Dim a, b, c, dert, x, y, z, k As Integer
    Dim root1, root2 As Double
    Dim fvalue As Integer
    Dim flag As Integer = 1
    Dim no, primeNo, i As Integer
    Function menu() As String

        Console.WriteLine("WELCOME TO MATHPLUS,select any option" + vbCrLf + "1:ACCURACY OPTION" + vbCrLf + "2:Quadratic Equation" + vbCrLf + "3:Fibonacci Sequence" + vbCrLf + "4:Prime or NOT Prime" + vbCrLf + "5:Exit the application")
        Return Nothing
    End Function
    Function setDec(ByVal dec As Integer) As Integer
        Console.WriteLine("you have selectd an option to set accuracy")
        Console.WriteLine("how many decimals for the quad solution")

        dec = Console.ReadLine()
        If dec > 5 Then
            Console.WriteLine("enter a value 1-5")
            dec = Console.ReadLine()
        End If
        Return dec
    End Function
    Function calculateQuad(ByVal a As Integer, b As Integer, c As Integer) As Integer
        Console.WriteLine("you have selected an option to calculate a quad equation")
        Console.WriteLine("enter the value of a")
        a = Console.ReadLine()
        Console.WriteLine("enter the value of b")
        b = Console.ReadLine()
        Console.WriteLine("enter the value of c")
        c = Console.ReadLine()

        dert = (b ^ 2) - (4 * a * c)
        If dert > 0 Then
            root1 = (-b + Sqrt(dert)) / (2 * a)
            root2 = (-b - Sqrt(dert)) / (2 * a)
            Console.WriteLine("These are the roots")
            Console.WriteLine(root1)
            Console.WriteLine(root2)

        ElseIf dert = 0 Then
            root1 = (-b) / 2 * a
            Console.WriteLine(Round(root1, dec))

        End If

        Console.WriteLine("Those are the roots")
        Return Nothing

    End Function
    Function PrimeNumber(ByVal primeNo As Integer) As Integer
        Console.WriteLine("Enter any number")
        primeNo = Console.ReadLine()
        'iterate from number to sqrt of number
        For i = 2 To Sqrt(primeNo)
            If primeNo Mod i = 0 Then
                flag = 0
            End If

        Next

        If primeNo <= 1 Then
            flag = 0
        End If
        If flag = 1 Then
            Console.WriteLine("Prime number")
        Else
            Console.WriteLine("Not Prime number")
        End If

        Return Nothing
    End Function
    Function Fibonacci(ByVal fvalue As Integer) As Integer
        'check for quad
        Console.WriteLine("fibonaci Series")
        Console.WriteLine("Enter the n values of the sequence")
        fvalue = Console.ReadLine()
        Console.WriteLine("Enter the first values of the sequence")
        x = Console.ReadLine()
        Console.WriteLine("Enter the second values of the sequence")
        y = Console.ReadLine()
        If fvalue < 1 Then
            Console.WriteLine("Enter a positive value")
        End If
        If x < 0 Then
            Console.WriteLine("Enter a positive value")
        End If
        If y < 1 Then
            Console.WriteLine("Enter a positive value")
        End If
       
        For k = 2 To fvalue
            z = x + y
            Console.WriteLine(z)
            y = x
            x = z

        Next


    End Function





    Sub Main()
        Dim selection As Integer
        menu()

        
        While selection <> 5
            Console.WriteLine("Choose an option from the menu")
            selection = Console.ReadLine()
            Select Case selection
                Case 1
                    setDec(dec)
                    Console.WriteLine("the Decimal points is set")
                Case 2
                    Console.WriteLine("Quadratic Calculator")
                    calculateQuad(a, b, c)



                Case 3
                    Console.WriteLine("Fibonacci Calculator")
                    Fibonacci(fvalue)

                Case 4
                    Console.WriteLine("Prime Number Checker")
                    PrimeNumber(primeNo)


                Case Else
                    Console.WriteLine("Invalid number")
            End Select


        End While

        




        ' menu()
        ' MyFunc(1, 20, 3)



    End Sub

End Module
