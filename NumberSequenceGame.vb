Module Module1
    Sub Main()
        ' Random Number Generator thing
        Dim r As Random = New Random
        Dim Answer As Double = 0
        Dim CurrentValue As Double
        Dim StepNumber As Integer
        Dim input As Integer
        Dim StartingNumber As Integer

        While input < 1
            Try
                ' Number Game
                Console.WriteLine("Random Number Game: input 1 for game mode,input 2 for prompted mode")
                input = Console.ReadLine()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                If input > 2 Then
                    input = 0
                End If
            End Try
        End While

        If input = "1" Then
            ' Set Variables
            StartingNumber = r.Next(1, 10)
            StepNumber = r.Next(1, 25)
        ElseIf input = "2" Then

            While StartingNumber < 1
                Try
                    Console.WriteLine("Enter starting number(whole number 10 or less)")
                    StartingNumber = Console.ReadLine()
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    If StartingNumber > 10 Then
                        StartingNumber = 0
                    End If
                End Try
            End While

            While StepNumber < 1
                Try
                    Console.WriteLine("Enter length of step (whole number 25 or less)")
                    StepNumber = Console.ReadLine()
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    If StepNumber > 25 Then
                        StepNumber = 0
                    End If
                End Try

            End While

        Else
            Console.WriteLine("You did not enter a 1 or 2, the game will exit.")
            ' End with Pause
            Console.ReadKey()
            Exit Sub
        End If

        ' Instructions
        Console.WriteLine("Read sequence of numbers and guess the next number:")

        ' Output Number Loop
        CurrentValue = StartingNumber
        For value As Integer = 0 To 4
            Console.WriteLine(CurrentValue)
            CurrentValue = CurrentValue + StepNumber
        Next

        Answer = CurrentValue

        While input <> Answer
            Console.WriteLine("What is the next number in the sequence:")
            Try
                input = Console.ReadLine()
            Catch ex As Exception
                Console.WriteLine("Please enter a valid answer. (A whole number, greater than 0)")
            End Try
        End While

        Console.WriteLine("Good Job")

        ' End with Pause
        Console.ReadKey()



    End Sub

End Module
