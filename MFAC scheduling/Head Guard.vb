﻿Imports System.Runtime.InteropServices.ComTypes

Public Class Head_guard

    Public start As Integer = 0
    Public final As Integer = 1
    Public start2 As Integer = 0
    Public final2 As Integer = 1
    Private Sub Customize_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each value In WorkApp.finalGroup(WorkApp.lstTimeSlots(start) & "-" & WorkApp.lstTimeSlots(final))
            lstbHeadguard.Items.Add(value)
        Next

        lblDisplayTimeSlot.Text = (Deconverter(WorkApp.lstTimeSlots(start)) & "-" & Deconverter(WorkApp.lstTimeSlots(final)))
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
            TopSlides.Visible = True
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
        TopSlides.Visible = True

    End Sub


End Class