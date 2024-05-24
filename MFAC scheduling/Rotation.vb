Imports System.Diagnostics.Eventing.Reader
Imports System.Drawing.Printing
Imports System.IO
Imports System.Net.Mime.MediaTypeNames
Imports System.Reflection
Imports Microsoft.VisualBasic.ApplicationServices
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class Rotation
    'Dim remainingValues As New List(Of String)
    'Dim usedValues As New List(Of String)
    'Dim remainingKeys As New List(Of String)
    'Dim keyOrder As New List(Of String)
    'Dim usedKeys As New List(Of String)
    'Public rotation8 As New Dictionary(Of String, String)
    'Public tempDictionary As New Dictionary(Of String, String)
    Public listkeys As List(Of String)
    Dim num As Integer = WorkApp.lstTimeSlots.Count
    Dim listTotal As New List(Of List(Of String))
    Dim listDifference As New List(Of String)
    'Public difference As Integer
    Dim difference As Integer
    Dim newlistKeys As New List(Of String)
    Dim newlistValues As New List(Of String)
    Dim listNewPerson As New List(Of String)
    Dim finalListValues As New List(Of String)
    Dim variable As Integer = 1

    Private Sub DisplaySchedule()
        ' Clear any existing labels

        ' Dimensions
        Dim formWidth As Integer = 800
        Dim formHeight As Integer = 500
        Dim labelHeight As Integer = 30
        Dim verticalSpacing As Integer = 5
        Dim horizontalPadding As Integer = 10
        Dim verticalPadding As Integer = 10

        ' Calculate the maximum number of labels that can fit in the form vertically
        Dim maxLabels As Integer = (formHeight - 2 * verticalPadding) \ (labelHeight + verticalSpacing)

        ' Ensure to avoid overflow
        Dim numLabels As Integer = Math.Min(finalListValues.Count, maxLabels)

        ' Create labels dynamically
        For i As Integer = 0 To numLabels - 1
            Dim lbl As New Label()
            lbl.Text = listkeys(i) & ": " & finalListValues(i)
            lbl.Size = New Size(formWidth - 2 * horizontalPadding, labelHeight)
            lbl.Location = New Point(horizontalPadding, verticalPadding + i * (labelHeight + verticalSpacing))
            lbl.BorderStyle = BorderStyle.FixedSingle
            Me.Controls.Add(lbl)
        Next
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
    Private Sub btnDefault_Click(sender As Object, e As EventArgs) Handles btnDefault.Click
        PictureBox1.Visible = False

        ' Initialize listDifference
        For Each i In WorkApp.finalGroup(WorkApp.lstTimeSlots(0) & "-" & WorkApp.lstTimeSlots(1))
            listDifference.Add(i)
        Next

        ' Initial rotation setup
        Dim listValues As New List(Of String)
        For Each i In WorkApp.finalGroup(WorkApp.lstTimeSlots(0) & "-" & WorkApp.lstTimeSlots(1))
            listValues.Add(i)
        Next

        ' Set initial rotation keys
        If listValues.Count = 8 Then
            listkeys = New List(Of String) From {"L1", "S1", "R1", "Down", "C1", "C2", "C3", "Down2"}
        ElseIf listValues.Count = 9 Then
            listkeys = New List(Of String) From {"L1", "S1", "Down", "R1", "C1", "Down2", "C2", "C3", "Down3"}
        ElseIf listValues.Count = 10 Then
            listkeys = New List(Of String) From {"L1", "S1", "Down", "R1", "R2", "Down2", "C1", "C2", "C3", "Down3"}
        ElseIf listValues.Count = 11 Then
            listkeys = New List(Of String) From {"L1", "S1", "Down", "R1", "R2", "Down2", "C1", "C2", "Down3", "C3", "Down4"}
        ElseIf listValues.Count = 12 Then
            listkeys = New List(Of String) From {"L1", "L2", "Down", "S1", "R1", "Down2", "R2", "C1", "Down3", "C2", "C3", "Down4"}
        ElseIf listValues.Count = 13 Then
            listkeys = New List(Of String) From {"L1", "L2", "Down", "S1", "R1", "Down2", "R2", "C1", "Down3", "C2", "C3", "Down4", "Down5"}
        ElseIf listValues.Count = 14 Then
            listkeys = New List(Of String) From {"L1", "L2", "Down", "S1", "R1", "Down2", "Down3", "R2", "C1", "Down4", "C2", "C3", "Down5", "Down6"}
        ElseIf listValues.Count = 15 Then
            listkeys = New List(Of String) From {"L1", "L2", "Down", "S1", "R1", "Down2", "Down3", "R2", "C1", "Down4", "Down5", "C2", "C3", "Down6", "Down7"}
        ElseIf listValues.Count = 16 Then
            listkeys = New List(Of String) From {"L1", "L2", "Down", "Down2", "S1", "R1", "Down3", "Down4", "R2", "C1", "Down5", "Down6", "C2", "C3", "Down7", "Down8"}
        ElseIf listValues.Count = 17 Then
            listkeys = New List(Of String) From {"L1", "L2", "Down", "Down2", "S1", "R1", "Down3", "Down4", "R2", "R3", "Down5", "C1", "Down6", "C2", "C3", "Down7", "Down8"}
        ElseIf listValues.Count = 18 Then
            listkeys = New List(Of String) From {"L1", "L2", "Down", "Down2", "S1", "R1", "Down3", "Down4", "R2", "R3", "Down5", "C1", "Down6", "C2", "C3", "Down7", "C4", "Down8"}
        ElseIf listValues.Count = 19 Then
            listkeys = New List(Of String) From {"L1", "L2", "Down", "Down2", "S1", "R1", "Down3", "Down4", "R2", "R3", "Down5", "C1", "Down6", "C2", "C3", "Down7", "C4", "Down8", "Down9"}
        ElseIf listValues.Count = 20 Then
            listkeys = New List(Of String) From {"L1", "L2", "Down", "Down2", "S1", "R1", "Down3", "Down4", "R2", "R3", "Down5", "C1", "Down6", "C2", "C3", "Down", "Down7", "C4", "Down8", "Down9"}
        End If

        lblOriginal.Text = Deconverter(WorkApp.lstTimeSlots(0)).ToString & "-" & Deconverter(WorkApp.lstTimeSlots(1)).ToString
        lblOriginal.Text += Environment.NewLine
        ' Print current rotation
        For i As Integer = 0 To listkeys.Count - 1
            Debug.Print(listkeys(i) & ": " & listValues(i))
            lblOriginal.Text += (listkeys(i) & ": " & listValues(i))
            lblOriginal.Text += Environment.NewLine
        Next


        ' Main loop for handling shift changes
        For x As Integer = 0 To WorkApp.lstTimeSlots.Count - 3
            ' If WorkApp.finalGroup(WorkApp.lstTimeSlots(x) & "-" & WorkApp.lstTimeSlots(x + 1)).Count < WorkApp.finalGroup(WorkApp.lstTimeSlots(x + 1) & "-" & WorkApp.lstTimeSlots(x + 2)).Count Then
            newlistKeys = listkeys
            Debug.Print("-------------------------------------------------------")

            ' Calculate difference for rotation
            difference = (WorkApp.lstTimeSlots(x + 1) - WorkApp.lstTimeSlots(x)) * 3

            ' Rotate lifeguards for the current shift
            For i As Integer = 0 To difference - 1
                listValues.Insert(0, listValues(listValues.Count - 1))
                listValues.RemoveAt(listValues.Count - 1)
            Next

            ' Print predicted rotation
            For i As Integer = 0 To listkeys.Count - 1
                Debug.Print("Predicted - " & listkeys(i) & ": " & listValues(i))
            Next

            ' Populate listTotal
            listTotal.Clear()
            For i As Integer = 0 To listkeys.Count - 1
                Dim innerList As New List(Of String)
                innerList.Add(listkeys(i))
                innerList.Add(listValues(i))
                listTotal.Add(innerList)
            Next

            ' Update listDifference
            listDifference.Clear()
            For Each item In WorkApp.finalGroup(WorkApp.lstTimeSlots(x) & "-" & WorkApp.lstTimeSlots(x + 1))
                For Each list In listTotal
                    If list.Contains(item) Then
                        listDifference.Add(item)
                    End If
                Next
            Next

            ' Update newlistValues
            newlistValues.Clear()
            For Each i In WorkApp.finalGroup(WorkApp.lstTimeSlots(x + 1) & "-" & WorkApp.lstTimeSlots(x + 2))
                newlistValues.Add(i)
            Next

            ' Set new rotation keys based on newlistValues
            If newlistValues.Count = 8 Then
                listkeys = New List(Of String) From {"L1", "S1", "R1", "Down", "C1", "C2", "C3", "Down2"}
            ElseIf newlistValues.Count = 9 Then
                listkeys = New List(Of String) From {"L1", "S1", "Down", "R1", "C1", "Down2", "C2", "C3", "Down3"}
            ElseIf newlistValues.Count = 10 Then
                listkeys = New List(Of String) From {"L1", "S1", "Down", "R1", "R2", "Down2", "C1", "C2", "C3", "Down3"}
            ElseIf newlistValues.Count = 11 Then
                listkeys = New List(Of String) From {"L1", "S1", "Down", "R1", "R2", "Down2", "C1", "C2", "Down3", "C3", "Down4"}
            ElseIf newlistValues.Count = 12 Then
                listkeys = New List(Of String) From {"L1", "L2", "Down", "S1", "R1", "Down2", "R2", "C1", "Down3", "C2", "C3", "Down4"}
            ElseIf newlistValues.Count = 13 Then
                listkeys = New List(Of String) From {"L1", "L2", "Down", "S1", "R1", "Down2", "R2", "C1", "Down3", "C2", "C3", "Down4", "Down5"}
            ElseIf newlistValues.Count = 14 Then
                listkeys = New List(Of String) From {"L1", "L2", "Down", "S1", "R1", "Down2", "Down3", "R2", "C1", "Down4", "C2", "C3", "Down5", "Down6"}
            ElseIf newlistValues.Count = 15 Then
                listkeys = New List(Of String) From {"L1", "L2", "Down", "S1", "R1", "Down2", "Down3", "R2", "C1", "Down4", "Down5", "C2", "C3", "Down6", "Down7"}
            ElseIf newlistValues.Count = 16 Then
                listkeys = New List(Of String) From {"L1", "L2", "Down", "Down2", "S1", "R1", "Down3", "Down4", "R2", "C1", "Down5", "Down6", "C2", "C3", "Down7", "Down8"}
            ElseIf newlistValues.Count = 17 Then
                listkeys = New List(Of String) From {"L1", "L2", "Down", "Down2", "S1", "R1", "Down3", "Down4", "R2", "R3", "Down5", "C1", "Down6", "C2", "C3", "Down7", "Down8"}
            ElseIf newlistValues.Count = 18 Then
                listkeys = New List(Of String) From {"L1", "L2", "Down", "Down2", "S1", "R1", "Down3", "Down4", "R2", "R3", "Down5", "C1", "Down6", "C2", "C3", "Down7", "C4", "Down8"}
            ElseIf listValues.Count = 19 Then
                listkeys = New List(Of String) From {"L1", "L2", "Down", "Down2", "S1", "R1", "Down3", "Down4", "R2", "R3", "Down5", "C1", "Down6", "C2", "C3", "Down7", "C4", "Down8", "Down9"}
            ElseIf listValues.Count = 20 Then
                listkeys = New List(Of String) From {"L1", "L2", "Down", "Down2", "S1", "R1", "Down3", "Down4", "R2", "R3", "Down5", "C1", "Down6", "C2", "C3", "Down", "Down7", "C4", "Down8", "Down9"}
            End If

            ' Initialize finalListValues
            finalListValues.Clear()
            For i As Integer = 0 To listkeys.Count - 1
                finalListValues.Add("P")
            Next

            ' Assign lifeguards to new positions
            Dim index As Integer
            For i As Integer = 0 To listValues.Count - 1
                If WorkApp.finalGroup(WorkApp.lstTimeSlots(x + 1) & "-" & WorkApp.lstTimeSlots(x + 2)).Contains(listValues(i)) Then
                    index = listkeys.IndexOf(newlistKeys(i))
                    If index >= 0 AndAlso index < finalListValues.Count Then
                        finalListValues(index) = listValues(i)
                    End If
                End If
            Next
            Dim counter As Integer = 0
            Dim runningCounter As Integer = 0
            For Each y In finalListValues
                If y = "P" Then
                    counter += 1
                End If
            Next

            For i As Integer = 0 To listValues.Count - 1
                Dim currentPerson = listValues(i)
                If WorkApp.finalGroup(WorkApp.lstTimeSlots(x + 1) & "-" & WorkApp.lstTimeSlots(x + 2)).Contains(currentPerson) Then
                    If Not finalListValues.Contains(currentPerson) Then
                        If newlistKeys(i).Contains("Down") Then
                            Dim assigned As Boolean = False
                            For z As Integer = 0 To finalListValues.Count - 1
                                If finalListValues(z) = "P" AndAlso Not listkeys(z).Contains("Down") Then
                                    finalListValues(z) = currentPerson
                                    assigned = True
                                    Exit For
                                End If
                            Next
                            If Not assigned Then
                                ' If not assigned, place them in the first available "Down" slot
                                For z As Integer = 0 To finalListValues.Count - 1
                                    If finalListValues(z) = "P" Then
                                        finalListValues(z) = currentPerson
                                        Exit For
                                    End If
                                Next
                            End If
                        Else
                            ' Handle non-"Down" cases
                            For z As Integer = 0 To finalListValues.Count - 1
                                If finalListValues(z) = "P" Then
                                    finalListValues(z) = currentPerson
                                    Exit For
                                End If
                            Next
                        End If
                    End If
                End If
            Next

            ' Fill any remaining empty "Down" slots
            For i As Integer = 0 To finalListValues.Count - 1
                If finalListValues(i) = "P" Then
                    For Each person In WorkApp.finalGroup(WorkApp.lstTimeSlots(x + 1) & "-" & WorkApp.lstTimeSlots(x + 2))
                        If Not finalListValues.Contains(person) Then
                            finalListValues(i) = person
                            Exit For
                        End If
                    Next
                End If
            Next



            ' Populate listNewPerson
            listNewPerson.Clear()
            For i As Integer = 0 To WorkApp.finalGroup(WorkApp.lstTimeSlots(x + 1) & "-" & WorkApp.lstTimeSlots(x + 2)).Count - 1
                If Not WorkApp.finalGroup(WorkApp.lstTimeSlots(x) & "-" & WorkApp.lstTimeSlots(x + 1)).Contains(WorkApp.finalGroup(WorkApp.lstTimeSlots(x + 1) & "-" & WorkApp.lstTimeSlots(x + 2))(i)) Then
                    listNewPerson.Add(WorkApp.finalGroup(WorkApp.lstTimeSlots(x + 1) & "-" & WorkApp.lstTimeSlots(x + 2))(i))
                End If
            Next

            ' Fill remaining slots
            Dim point As Integer = 0
            For i As Integer = 0 To finalListValues.Count - 1
                If finalListValues(i) = "P" Then
                    If point < listNewPerson.Count Then
                        finalListValues(i) = listNewPerson(point)
                        point += 1
                    Else
                        Exit For
                    End If
                End If
            Next

            ' Remove assigned lifeguards from listNewPerson
            If point > 0 Then
                listNewPerson.RemoveRange(0, point)
            End If
            Dim bla = "lbl"
            For Each i In WorkApp.lstHeadguards
                MsgBox(i)
            Next
            ' Print the final rotation
            Me.Controls(bla & variable.ToString).Text = Deconverter(WorkApp.lstTimeSlots(x + 1)).ToString & "-" & Deconverter(WorkApp.lstTimeSlots(x + 2)).ToString
            Me.Controls(bla & variable.ToString).Text += Environment.NewLine
            For Each i In WorkApp.lstHeadguards
                If WorkApp.finalGroup(WorkApp.lstTimeSlots(x) & "-" & WorkApp.lstTimeSlots(x + 1)).Contains(i) Then
                    Me.Controls(bla & variable.ToString).Text += "HeadGuard: " & i
                    Me.Controls(bla & variable.ToString).Text += Environment.NewLine
                End If
            Next
            For i As Integer = 0 To newlistValues.Count - 1
                Debug.Print(listkeys(i) & ": " & finalListValues(i))
                Me.Controls(bla & variable.ToString).Text += listkeys(i) & ": " & finalListValues(i)
                Me.Controls(bla & variable.ToString).Text += Environment.NewLine
            Next

            ' Prepare for the next shift change
            listValues = finalListValues.ToList()

            variable += 1
            'End If
        Next

        Button1.Enabled = True


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Create a SaveFileDialog to prompt the user for a file path
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        saveFileDialog.Title = "Save Schedule As"
        saveFileDialog.FileName = "Schedule Display.txt"

        ' Show the dialog and check if the user clicked 'Save'
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim pdfPath As String = saveFileDialog.FileName

            ' Write the content to the selected file
            Using writer As New StreamWriter(pdfPath, False)
                writer.WriteLine("MFAC Schedule " & Date.Now)
                writer.WriteLine(Environment.NewLine)
                writer.WriteLine("-----------------------------------------------------")
                writer.WriteLine(lblOriginal.Text)
                writer.WriteLine("-----------------------------------------------------")
                writer.WriteLine(lbl1.Text)
                writer.WriteLine("-----------------------------------------------------")
                If lbl2.Text <> "" Then
                    writer.WriteLine(lbl2.Text)
                    writer.WriteLine("-----------------------------------------------------")
                End If
                If lbl3.Text <> "" Then
                    writer.WriteLine(lbl3.Text)
                    writer.WriteLine("-----------------------------------------------------")
                End If
            End Using

            MessageBox.Show("PDF created successfully at " & pdfPath)
            Process.Start(pdfPath)
        Else
            MessageBox.Show("PDF creation canceled.")
        End If
    End Sub

    Private Sub Rotation_Load(sender As Object, e As EventArgs) Handles Me.Load
        Button1.Enabled = False
    End Sub
End Class