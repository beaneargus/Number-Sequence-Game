Module Module1
    Dim input As String
    Sub Main()
        ' Random Number Generator thing
        Dim r As Random = New Random
        Dim Answer As Double = 0
        Dim CurrentValue As Double
        Dim StepNumber As Integer

        ' Cube or Sphere
        Console.WriteLine("Random Number Game: input 1 for game mode,input 2 for prompted mode")
        input = Console.ReadLine()

        If input = "1" Then
            ' Set Variables
            Dim StartingNumber As Integer = r.Next(1, 10)
            StepNumber = r.Next(1, 25)
            CurrentValue = StartingNumber
        ElseIf input = "2" Then
            'Add prompted mode here
            Console.WriteLine("coming soon")
        Else
            Console.WriteLine("You did not enter a 1 or 2, the game will exit.")
        End If

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
