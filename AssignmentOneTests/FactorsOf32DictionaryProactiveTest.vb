Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class FactorsOf32DictionaryProactiveTest

    <TestMethod()> Public Sub FactorsOf32DictionaryProactive()
        Dim factorsOf32Dictionary As Dictionary(Of Integer, Integer)

        factorsOf32Dictionary = New Dictionary(Of Integer, Integer)

        factorsOf32Dictionary.Add(32, 1)
        factorsOf32Dictionary.Add(16, 2)
        factorsOf32Dictionary.Add(8, 4)
        factorsOf32Dictionary.Add(4, 8)
        factorsOf32Dictionary.Add(2, 16)
        factorsOf32Dictionary.Add(1, 32)

        Dim index As Integer = 1

        Do While index <= 32

            If factorsOf32Dictionary.ContainsKey(index) Then
                Dim currentValue = factorsOf32Dictionary(index)
                Dim result As Integer

                result = currentValue * index

                Assert.AreEqual(32, result, "Result not equal 32")
            End If

            index += 1
        Loop

    End Sub

End Class