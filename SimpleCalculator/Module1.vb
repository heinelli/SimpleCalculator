'Elliot Heiner
'RCET0265
'Fall 2021
'Simple Calculator

Option Strict Off
Option Explicit On
Module Module1

    Sub Main()
        Dim num1 As Double
        Dim num2 As Double
        Console.WriteLine("Choose a number between 0 and 9.")
        num1 = Console.ReadLine()
        Console.WriteLine("Choose a second number between 0 and 9")
        num2 = Console.ReadLine()
        Console.WriteLine(num1 & num2)
        Console.ReadLine()

    End Sub

End Module
