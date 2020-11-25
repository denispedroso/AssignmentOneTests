Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class RetirementTest

    <TestMethod()> Public Sub Retirement()
        Dim number1 As Integer = 7
        Dim number2 As Integer = 8
        Dim result As Integer
        result = number1 * number2

        Const retirementAge As Integer = 55

        If result < retirementAge Then
            Debug.Print(String.Format("You have a little more work ahead"))
        Else
            Debug.Print(String.Format("Time to retire"))
        End If

        Assert.AreEqual(56, result, "Result different of 56")


    End Sub

End Class