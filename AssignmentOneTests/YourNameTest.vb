Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class YourNameTest

    <TestMethod()> Public Sub YourName()
        Dim yourName As String = "Denis Buhrer Pedroso"

        Assert.AreEqual("Denis Buhrer Pedroso", yourName, "Name incorrect.")

    End Sub

End Class