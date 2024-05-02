Public Class Head_guard
    Private Sub Customize_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each i In WorkApp.nameList
            lstbHeadguard.Items.Add(i.name)
        Next
    End Sub

    Private Sub btnConfrimHeadguard_Click(sender As Object, e As EventArgs) Handles btnConfrimHeadguard.Click
        lblHeadguard.Text += Environment.NewLine + lstbHeadguard.SelectedItem.ToString
        For Each i In WorkApp.nameList
            If lstbHeadguard.SelectedItem.ToString = i.name Then

                WorkApp.removeList.Add(i)
                WorkApp.nameList.Remove(i)

                Debug.Print(i.name)
                Exit For

            End If
        Next
        lstbHeadguard.Items.Clear()
        For Each i In WorkApp.nameList
            lstbHeadguard.Items.Add(i.name)
        Next
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Me.Visible = False
        Slides.Visible = True

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
            WorkApp.nameList.Add(i)
        Next

        WorkApp.removeList.Clear()
        lstbHeadguard.Items.Clear()
        For Each i In WorkApp.nameList
            lstbHeadguard.Items.Add(i.name)
        Next
        lblHeadguard.Text = "Selcted Headguard"
    End Sub
End Class