

Public Class SuggestedHeadguard
    Public listHeadguard As New List(Of String)

    Private Sub SuggestedHeadguard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim itemsInList As String
        Dim result As Integer

        lblSuggestedHeadguards.Text += Environment.NewLine
        For Each i In WorkApp.lstHeadguards
            itemsInList += i & " " & Environment.NewLine
        Next

        lblSuggestedHeadguards.Text += itemsInList

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCorrect.Click
        For Each i In WorkApp.lstHeadguards
            For Each kvp As KeyValuePair(Of String, List(Of String)) In WorkApp.finalGroup

                If kvp.Value.Contains(i) Then
                    kvp.Value.Remove(i)
                End If

            Next
        Next


        Me.Visible = False
        TopSlides.Visible = True
    End Sub

    Private Sub btnManual_Click(sender As Object, e As EventArgs) Handles btnManual.Click
        Me.Visible = False
        Head_guard.Visible = True
    End Sub
End Class