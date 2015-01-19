Module Module1
    Dim input As String
    Sub Main()
        ' Random Number Generator thing
        Dim r As Random = New Random

        ' Set Variables
        Dim StartingNumber As Integer = r.Next(1, 10)
        Dim StepNumber As Integer = r.Next(1, 25)

        Dim CurrentValue As Double = StartingNumber
        Dim Answer As Double = 0

        ' Instructions
        Console.WriteLine("Read sequence of numbers and guess the next number:")

        ' Output Number Loop
        For value As Integer = 0 To 4
            Console.WriteLine(CurrentValue)
            CurrentValue = CurrentValue + StepNumber
        Next

        Answer = CurrentValue

        While input <> Answer
            Console.WriteLine("What is the next number in the sequence:")
            input = Console.ReadLine()
        End While

        Console.WriteLine("Good Job")

        ' End with Pause
        Console.ReadKey()



    End Sub

End Module
