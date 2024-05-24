Imports System.Windows.Forms.AxHost

Public Class TopSlides

    Public start As Integer = 0
    Public final As Integer = 1
    Private Sub rdbSlideNo_CheckedChanged(sender As Object, e As EventArgs) Handles rdbSlideNo.CheckedChanged

        btnContinue.Visible = True

        If rdbSlideNo.Checked = True Then

            btnConfrimHeadguard.Visible = False
            btnGoBack.Visible = False
            btnNextTimeSlot.Visible = False
            lblDisplayTimeSlot.Visible = False
            lblHeadguard.Visible = False
            lstbHeadguard.Visible = False

        End If

        If rdbSlideYes.Checked = True Then

            btnConfrimHeadguard.Visible = True
            btnGoBack.Visible = True
            btnNextTimeSlot.Visible = True
            lblDisplayTimeSlot.Visible = True
            lblHeadguard.Visible = True
            lstbHeadguard.Visible = True

        End If


    End Sub

    Public Function Deconverter(i As Integer)
        If i = 7 Then
            Return "7am"
        End If
        If i = 8 Then
            Return "8am"
        End If
        If i = 9 Then
            Return "9am"
        End If
        If i = 10 Then
            Return "10am"
        End If
        If i = 11 Then
            Return "11am"
        End If
        If i = 12 Then
            Return "12pm"
        End If
        If i = 13 Then
            Return "1pm"
        End If
        If i = 14 Then
            Return "2pm"
        End If
        If i = 15 Then
            Return "3pm"
        End If
        If i = 16 Then
            Return "4pm"
        End If
        If i = 17 Then
            Return "5pm"
        End If
        If i = 18 Then
            Return "6pm"
        End If
        If i = 19 Then
            Return "7pm"
        End If
        If i = 20 Then
            Return "8pm"
        End If
        If i = 21 Then
            Return "9pm"
        End If
        If i = 22 Then
            Return "10pm"
        End If

    End Function

    Private Sub btnConfrimHeadguard_Click(sender As Object, e As EventArgs) Handles btnConfrimHeadguard.Click
        lblHeadguard.Text += Environment.NewLine + lstbHeadguard.SelectedItem.ToString
        For Each i In WorkApp.finalGroup(WorkApp.lstTimeSlots(start) & "-" & WorkApp.lstTimeSlots(final))
            If lstbHeadguard.SelectedItem.ToString = i Then

                WorkApp.finalGroup(WorkApp.lstTimeSlots(start) & "-" & WorkApp.lstTimeSlots(final)).Remove(i)
                WorkApp.removeList.Add(i)
                Debug.Print(i)
                Exit For

            End If
        Next
        lstbHeadguard.Items.Clear()
        For Each i In WorkApp.finalGroup(WorkApp.lstTimeSlots(start) & "-" & WorkApp.lstTimeSlots(final))
            lstbHeadguard.Items.Add(i)
        Next
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNextTimeSlot.Click
        start += 1
        final += 1
        lstbHeadguard.Items.Clear()

        If WorkApp.finalGroup.Keys.Count > start Then
            For Each value In WorkApp.finalGroup(WorkApp.lstTimeSlots(start) & "-" & WorkApp.lstTimeSlots(final))
                lstbHeadguard.Items.Add(value)
            Next
            lblDisplayTimeSlot.Text = Deconverter((WorkApp.lstTimeSlots(start))) & "-" & Deconverter(WorkApp.lstTimeSlots(final))

        Else
            Me.Visible = False
            Rotation.visible = True
        End If

        lblHeadguard.Text = "Selected Headguard"

        WorkApp.removeList.Clear()

    End Sub

    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click



        'For Each i In WorkApp.nameList
        '    If lstbHeadguard.SelectedItem.ToString = i.name Then
        '        WorkApp.removeList.Add(i)
        '        WorkApp.nameList.Remove(i)

        '        Debug.Print(i.name)
        '        Exit For

        '    End If
        'Next

        For Each i In WorkApp.removeList
            WorkApp.finalGroup(WorkApp.lstTimeSlots(start) & "-" & WorkApp.lstTimeSlots(final)).Add(i)
        Next

        WorkApp.removeList.Clear()
        lstbHeadguard.Items.Clear()
        For Each value In WorkApp.finalGroup(WorkApp.lstTimeSlots(start) & "-" & WorkApp.lstTimeSlots(final))
            lstbHeadguard.Items.Add(value)
        Next
        lblHeadguard.Text = "Selected Headguard"
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        Me.Visible = False
        Rotation.Visible = True

    End Sub

    Private Sub TopSlides_Load(sender As Object, e As EventArgs) Handles Me.Load
        For Each kvp As KeyValuePair(Of String, List(Of String)) In WorkApp.finalGroup
            Debug.Print("Key: " & kvp.Key)

            ' Iterate through the list of strings and print them
            For Each value As String In kvp.Value
                Debug.Print("Value: " & value)
            Next
        Next

        For Each value In WorkApp.finalGroup(WorkApp.lstTimeSlots(start) & "-" & WorkApp.lstTimeSlots(final))
            lstbHeadguard.Items.Add(value)
        Next

        lblDisplayTimeSlot.Text = (Deconverter(WorkApp.lstTimeSlots(start)) & "-" & Deconverter(WorkApp.lstTimeSlots(final)))
    End Sub
End Class