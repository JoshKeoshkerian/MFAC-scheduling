
Imports System.Threading
Imports System.IO
Imports System.Net
Imports HtmlAgilityPack





Public Class WorkApp
    Public lstHeadguards As New List(Of String)
    Dim totalName As String
    Dim totalTimeIn As Integer
    Dim totalTimeOut As Integer
    Public nameList As List(Of person)
    Public removeList As List(Of String)
    Public slideList As List(Of person)
    'Public timeInList As New Dictionary(Of String, List(Of String)) From {{"11", New List(Of String)({})}, {"12", New List(Of String)({})}, {"1", New List(Of String)({})}, {"2", New List(Of String)({})}, {"3", New List(Of String)({})}, {"4", New List(Of String)({})}, {"5", New List(Of String)({})}, {"6", New List(Of String)({})}, {"7", New List(Of String)({})}, {"8", New List(Of String)({})}}
    Public timeInList As List(Of List(Of String))
    Public finalGroup As New Dictionary(Of String, List(Of String))
    Public lstTimeSlots As New List(Of Integer)
    Public groupsOut As New Dictionary(Of Integer, List(Of String))()
    Public groupsIn As New Dictionary(Of Integer, List(Of String))()


    Dim screenWidth As Integer = My.Computer.Screen.Bounds.Width
    Dim screenHeight As Integer = My.Computer.Screen.Bounds.Height

    Dim listData As IList(Of String)
    Public Sub getData()
        'copies data off of the website
        ' Thread.Sleep(3000)
        AppActivate("google chrome")
        Thread.Sleep(300)
        My.Computer.Keyboard.SendKeys("^u", True)
        Thread.Sleep(1000)
        My.Computer.Keyboard.SendKeys("^a", True)
        Thread.Sleep(300)
        My.Computer.Keyboard.SendKeys("^c", True)
        Thread.Sleep(300)
        My.Computer.Keyboard.SendKeys("^w", True)

        Dim data As String = My.Computer.Clipboard.GetText()


        listData = New List(Of String)(data.Split(New Char() {vbCrLf, vbCr, vbLf}, StringSplitOptions.RemoveEmptyEntries))

        AppActivate("WorkApp")
    End Sub

    Public Sub parceData()
        Dim lifeguardflag As Boolean = False


        For Each i As String In listData
            If i.Length > 10 Then
                If i.Substring(0, 11) = "<script>php" Then
                    Dim tempStr As String() = i.Split($"{Chr(34)}")
                    If tempStr(5) = "Lifeguard-MFAC" Then
                        lifeguardflag = True
                        Dim color As String = i.Split("(")(4)
                        Debug.Print(color)
                        i = i.Split(",")(10)

                        If i(1) Like "[A-Z]" Then
                            If color.Substring(0, 1) = "9" Then
                                lstHeadguards.Add(nameConverter(i))
                            End If
                            storeData(i)

                        End If

                        Continue For
                    End If
                End If

                If lifeguardflag = True Then
                    If i.Substring(0, 11) = "<script>hdr" Then
                        Dim strLifeguard As String = i.Split(",")(7)

                        If strLifeguard(1) Like "[A-Z]" Then
                            storeData(strLifeguard)
                            Dim color As String = i.Split("(")(3)
                            Debug.Print(color)
                            If color.Substring(0, 1) = "9" Then
                                lstHeadguards.Add(nameConverter(strLifeguard))
                            End If
                        End If
                    Else
                        lifeguardflag = False
                    End If
                End If
            End If
        Next





        For Each i In lstHeadguards
                Debug.Print(i)
            Next
    End Sub

    Public Sub storeData(ByVal i As String)
        Dim newName As String = nameConverter(i)
        ' Debug.Print(name)
        Dim timeIn As String = GetTimeIn(i)
        timeIn = inTimeConverter(timeIn)
        Dim timeOut As String = GetTimeOut(i)
        timeOut = outTimeConverter(timeOut)
        'Debug.Print(timeOut)

        Dim current As person = New person
        current.name = newName
        current.timeIn = timeIn
        current.timeOut = timeOut

        nameList.Add(current)



        'For Each a In nameList
        'Debug.Print(a.name)
        'Debug.Print(a.timeIn)
        'Debug.Print(a.timeOut)
        'Next
    End Sub

    Public Function outTimeConverter(ByVal i As String)
        'converts "8:30pm" to "8"
        Dim key As Integer
        Dim newI As Integer
        If i.Contains(":") Then
            key = i.IndexOf(":")
            i.Remove(key, 3)
            newI = Val(i)
        End If
        If i.Contains("12") Then
            Return 12
        End If
        If i.Contains("a") Then
            key = i.IndexOf("a")
            i.Substring(0, key)
            newI = Val(i)
        ElseIf i.Contains("p") Then

            key = i.IndexOf("p")
            i.Substring(0, key)
            newI = Val(i) + 12
        End If

        Return newI

    End Function

    Function GetTimeOut(ByVal i As String)
        Dim firstNum As Integer
        Dim endNum As Integer
        For Each x As Char In i
            If x Like "#" Then
                firstNum = i.IndexOf(x)
                Exit For
            End If
        Next
        Dim newString As String = i.Substring(firstNum, ((i.Length - 1) - firstNum))
        For Each n As Char In newString
            If n Like "m" Then
                endNum = newString.IndexOf(n) + 2
                Exit For
            End If
        Next
        Return newString.Substring(endNum, (newString.Length - 1 - endNum))
    End Function

    Function GetTimeIn(ByVal inputString As String) As String
        'substrings josh keoshkerian 12-8pm to "12"
        Dim firstNum As Integer
        Dim endNum As Integer
        Dim newString As String
        For Each i As Char In inputString
            If i Like "#" Then
                firstNum = inputString.IndexOf(i)
                newString = inputString.Substring(firstNum, ((inputString.Length - 1) - firstNum))
                Exit For
            End If
        Next
        For Each i As Char In newString
            If i Like "[a-z]" Then
                endNum = newString.IndexOf(i)
                Exit For
            End If
        Next
        'Debug.Print(newString.Substring(0, (endNum + 1)))

        Return newString.Substring(0, (endNum + 1))
    End Function
    Public Function inTimeConverter(ByVal i As String)
        'converts "12:30pm" to "1"
        Dim key As Integer
        Dim newI As Integer
        Dim colon As Integer = 0
        If i.Contains(":") Then
            key = i.IndexOf(":")
            i.Remove(key, 3)
            colon = 1
        End If
        If i.Contains("12") Then
            Return 12
        End If
        If i.Contains("a") Then
            key = i.IndexOf("a")
            i.Substring(0, key)
            newI = Val(i)
        ElseIf i.Contains("p") Then

            key = i.IndexOf("p")
            i.Substring(0, key)
            newI = Val(i) + 12
        End If
        If colon = 1 Then
            newI += 1
        End If
        Return newI

    End Function

    Function nameConverter(ByVal i As String)
        Dim num As Integer

        For Each x As Char In i
            If x Like "#" Then
                num = i.IndexOf(x)
                Exit For

            End If
        Next

        Return i.Substring(1, (num - 1))
        'Return (i.Split(" ")(0) + " " + i.Split(" ")(1)).Remove(0, 1)
    End Function

    Private Sub btnExtract_Click(sender As Object, e As EventArgs) Handles btnExtract.Click


        nameList.Clear()

        getData()
        parceData()


        For Each entry In nameList
            If Not groupsIn.ContainsKey(entry.timeIn) Then
                groupsIn.Add(entry.timeIn, New List(Of String))
            End If
            groupsIn(entry.timeIn).Add(entry.name)
        Next


        For Each entry In nameList
            If Not groupsOut.ContainsKey(entry.timeOut) Then
                groupsOut.Add(entry.timeOut, New List(Of String))
            End If
            groupsOut(entry.timeOut).Add(entry.name)
        Next

        For Each i In nameList
            If Not lstTimeSlots.Contains(i.timeIn) Then
                lstTimeSlots.Add(i.timeIn)
            End If

        Next
        For Each i In nameList
            If Not lstTimeSlots.Contains(i.timeOut) Then
                lstTimeSlots.Add(i.timeOut)
            End If
        Next

        lstTimeSlots.Sort()


        For Each i In lstTimeSlots
            If (lstTimeSlots.IndexOf(i) < (lstTimeSlots.Count - 1)) Then
                finalGroup.Add(i & "-" & (lstTimeSlots(lstTimeSlots.IndexOf(i) + 1)), New List(Of String))
            End If
        Next

        For Each i In nameList
            For Each key In finalGroup.Keys
                If key.Substring(0, 2) >= i.timeIn Then
                    finalGroup(key).Add(i.name)
                End If
                If key.Substring(3, 2) = i.timeOut Then
                    Exit For
                End If
            Next
        Next

        'For Each kvp As KeyValuePair(Of String, List(Of String)) In finalGroup
        '    Debug.Print("Key: " & kvp.Key)

        '    ' Iterate through the list of strings and print them
        '    For Each value As String In kvp.Value
        '        Debug.Print("Value: " & value)
        '    Next
        'Next

        'For Each kvp In finalGroup
        '    Debug.Print(kvp.Key.ToString)
        'Next


        'For Each kvp In groupsOut
        '    Debug.Print("Time: " & kvp.Key.ToString())
        '    Debug.Print("Names: " & String.Join(", ", kvp.Value))
        'Next

        If (nameList.Count < 3) Then
            picError.Visible = True
            lblError.Visible = True
            btnReset.Visible = True
        Else
            Me.Visible = False
            SuggestedHeadguard.Visible = True
        End If
    End Sub

    Public Sub within(timeIn As Integer, timeOut As Integer)

    End Sub

    Private Sub WorkApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nameList = New List(Of person)
        removeList = New List(Of String)
        slideList = New List(Of person)
        lblError.Visible = False
        btnReset.Visible = False

        Me.BackgroundImageLayout = ImageLayout.Stretch

    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        lblError.Visible = False
        nameList.Clear()
        btnReset.Visible = False
    End Sub
End Class

Public Class person
    Public Property name As String
    Public Property timeIn As Integer
    Public Property timeOut As Integer
End Class