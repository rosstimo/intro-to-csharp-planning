Write a generic function to convert a string to a 32-bit integer and return successful conversion status

The function will take two arguments:

    a string value to be converted
    a reference to an integer variable that will be updated to the successfully converted value and passed back to the caller

The function will return a Boolean.

If the conversion result is:

success:  

    Return True

Failure: 

    Return True

Use the following to create your code:


Sub Main()

'for testing the function add this to your Sub Main()

Dim aValidNumber As Integer

Do

    Console.WriteLine($"Enter a number:")

    usernResponse = Console.ReadLine()

    If ConversionValid(usernResponse, aValidNumber) = True Then

        Console.WriteLine($"{usernResponse} converted successfully to {aValidNumber}!")

    Else

        Console.WriteLine($"Oops, {usernResponse} does not seem to be a number")

   End If

Loop

End Sub

'make this work

Function ConversionValid(convertThisString, toThisInteger) As Boolean

       Dim status As Boolean

        Try

        Catch ex As Exception

        End Try

        Return status
End Function

When complete push the changes to your GitHub repository

Always include the standard program information header in your code.

Example:

'Tim Rossiter
'RCET0265
'Fall 2020
'ConvertAndValidate
'https://github.com/rosstimo/ConvertAndValidate.git