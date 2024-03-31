' Book.vb
Imports System.Reflection

Public Class Car
    Public Property Make As String
    Public Property Model As String
    Public Property Year As Integer

    Public Sub New(ByVal make As String, ByVal model As String, ByVal year As Integer)
        Me.Make = make
        Me.Model = model
        Me.Year = year
    End Sub

    Public Function GetDetails() As String
        Return $"Make: {Make}, Model: {Model}, Year: {Year}"
    End Function

    Public Sub UpdateYear(newYear As Integer)
        Me.Year = newYear
    End Sub
End Class

