Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class FactorsOf32DictionaryCatchErrorTest

    <TestMethod()> Public Sub FactorsOf32DictionaryCatchError()
        Dim factorsOf32Dictionary As Dictionary(Of Integer, Integer)

        factorsOf32Dictionary = New Dictionary(Of Integer, Integer)

        factorsOf32Dictionary.Add(32, 1)
        factorsOf32Dictionary.Add(16, 2)
        factorsOf32Dictionary.Add(8, 4)
        factorsOf32Dictionary.Add(4, 8)
        factorsOf32Dictionary.Add(2, 16)
        factorsOf32Dictionary.Add(1, 32)

        For loopCounter As Integer = 1 To 32
            Try
                Dim currentValue = factorsOf32Dictionary(loopCounter)
                Dim result As Integer

                result = currentValue * loopCounter

                Assert.AreEqual(32, result, "Result not equal 32")
            Catch ex As Exception
                Debug.Print(String.Format("An valid key was expected but the user entered {0}", loopCounter))
            End Try
        Next
    End Sub

End Class