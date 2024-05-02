Public Class Slides
    Private Sub rdbSlideNo_CheckedChanged(sender As Object, e As EventArgs) Handles rdbSlideNo.CheckedChanged
        btnNext.Visible = True

        If rdbSlideNo.Checked = True Then

            btnConfrimNumOfSlides.Visible = False
            lstbLifeguards.Visible = False
            lblSelectedSlide.Visible = False
            btnGoBack.Visible = False

        End If

        If rdbSlideYes.Checked = True Then

            btnConfrimNumOfSlides.Visible = True
            lstbLifeguards.Visible = True
            lblSelectedSlide.Visible = True
            btnGoBack.Visible = True
        End If
    End Sub

    Private Sub Slides_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnNext.Visible = False
        For Each i In WorkApp.nameList
            lstbLifeguards.Items.Add(i.name)
        Next
    End Sub

    Private Sub btnConfrimNumOfSlides_Click(sender As Object, e As EventArgs) Handles btnConfrimNumOfSlides.Click
        lblSelectedSlide.Text += Environment.NewLine + lstbLifeguards.SelectedItem.ToString
        For Each i In WorkApp.nameList
            If lstbLifeguards.SelectedItem.ToString = i.name Then

                WorkApp.slideList.Add(i)
                WorkApp.nameList.Remove(i)

                Debug.Print(i.name)
                Exit For

            End If
        Next
        lstbLifeguards.Items.Clear()
        For Each i In WorkApp.nameList
            lstbLifeguards.Items.Add(i.name)
        Next
    End Sub

    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        For Each i In WorkApp.slideList
            WorkApp.nameList.Add(i)
        Next

        WorkApp.slideList.Clear()
        lstbLifeguards.Items.Clear()
        For Each i In WorkApp.nameList
            lstbLifeguards.Items.Add(i.name)
        Next
        lblSelectedSlide.Text = "Selcted Lifeguards"
    End Sub
End Class