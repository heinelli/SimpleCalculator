'Elliot Heiner
'RCET0265
'Fall 2021
'Simple Calculator

Option Strict Off
Option Explicit Off
Module Module1

    Sub Main()
        Dim num1 As Double
        Dim num2 As Double
        Dim choice As String
        Console.WriteLine("This simple program will let you add or multiply two numbers of your choice. Type the first number.")
        num1 = Console.ReadLine()
        Console.WriteLine("Type the second number.")
        num2 = Console.ReadLine()
        Console.WriteLine("Type + to add or type * to multiply.")
        choice = Console.ReadLine()
        If choice = "+" Then
            Console.WriteLine(num1 & "+" & num2 & "=" & num1 + num2)
        ElseIf choice = "*" Then
            Console.WriteLine(num1 & "*" & num2 & "=" & num1 * num2)
        Else
            Console.WriteLine("Error")
        End If
        Console.ReadLine()



    End Sub

End Module
