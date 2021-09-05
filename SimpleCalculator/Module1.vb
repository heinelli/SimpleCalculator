'Elliot Heiner
'RCET0265
'Fall 2021
'Simple Calculator
'https://github.com/heinelli/SimpleCalculator.git

Option Strict On
Option Explicit On
Module Module1

    Sub Main()
        Dim num1 As Double  'First number from the user
        Dim num2 As Double  'Second number from the user
        Dim choice As String    'Choice of operation from the user
        Console.WriteLine("This simple program will let you add or multiply two numbers of your choice.")
        Console.WriteLine("Type the first number.")
        num1 = Double.Parse(Console.ReadLine)   'Double.parse is used to convert string format into double format
        Console.WriteLine("Type the second number.")
        num2 = Double.Parse(Console.ReadLine)
        Console.WriteLine("Type + to add or type * to multiply.")
        choice = Console.ReadLine()
        If choice = "+" Then    'If + is typed then the next line of code is triggered
            Console.WriteLine(num1 & " + " & num2 & " = " & num1 + num2)
        ElseIf choice = "*" Then    'If * is typed then the next line of code is triggered
            Console.WriteLine(num1 & " * " & num2 & " = " & num1 * num2)
        Else    'If any character other than + or * is typed then the next line of code is triggered
            Console.WriteLine("Error")
        End If
        Console.ReadLine()  'Provides time for user to see calculation before program ends.
    End Sub

End Module
