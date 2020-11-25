Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class FactorsOf32ArrayTest

    <TestMethod()> Public Sub FactorsOf32Array()
        Dim factorsOf32Array = New Integer() {1, 2, 4, 8, 16, 32}
        Dim factorsOf32Array2 = New Integer() {32, 16, 8, 4, 2, 1}

        Dim result As Integer

        Dim loopCounter As Integer
        loopCounter = 0

        While loopCounter <= 5
            Dim currentValue1 = FactorsOf32Array(loopCounter)
            Dim currentValue2 = factorsOf32Array2(loopCounter)

            result = currentValue1 * currentValue2

            Assert.AreEqual(32, result, "Value in first array times the value in the second array different of 32")

            loopCounter = loopCounter + 1
        End While

    End Sub

End Class