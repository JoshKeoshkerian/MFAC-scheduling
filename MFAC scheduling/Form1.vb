Imports System.Threading
Imports System.IO
Imports System.Net
Imports HtmlAgilityPack
Public Class WorkApp

    Public Class person
        Public Property name As String
        Public Property timeIn As Integer
        Public Property timeOut As Integer
    End Class
    Dim listData As IList(Of String)
    Public Sub getData()

        Thread.Sleep(3000)
        AppActivate("google chrome")
        Thread.Sleep(300)
        My.Computer.Keyboard.SendKeys("^u", True)
        Thread.Sleep(300)
        My.Computer.Keyboard.SendKeys("^a", True)
        Thread.Sleep(300)
        My.Computer.Keyboard.SendKeys("^c", True)
        Thread.Sleep(300)
        My.Computer.Keyboard.SendKeys("^w", True)

        Dim data As String = My.Computer.Clipboard.GetText()


        listData = New List(Of String)(data.Split(New Char() {vbCrLf, vbCr, vbLf}, StringSplitOptions.RemoveEmptyEntries))

        AppActivate("WorkApp")
    End Sub

    Function GetTimeIn(ByVal inputString As String) As String
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
    Public Function timeConverter(ByVal i As String)
        Dim key As Integer
        Dim newI As Integer
        If i.Contains(":") Then
            key = i.IndexOf(":")
            i.Remove(key, 3)
            newI = Val(i) + 1
        End If
        If i.Contains("12") Then
            Return 12
        End If
        If i.Contains("a") Then
            key = i.IndexOf("a")
            i.Substring(0, key)
            Debug.Print("step: " & i)
            newI = Val(i)
        ElseIf i.Contains("p") Then

            key = i.IndexOf("p")
            i.Substring(0, key)
            newI = Val(i) + 12
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
    Public Sub storeData(ByVal i As String)
        Dim name As String = nameConverter(i)
        Debug.Print(name)
        Dim timeIn As String = GetTimeIn(i)
        timeIn = timeConverter(timeIn)
        Debug.Print(timeIn)



    End Sub

    Public Sub parceData()
            Dim lifeguardflag As Boolean = False


            For Each i As String In listData
                If i.Length > 10 Then
                    If i.Substring(0, 11) = "<script>php" Then
                        Dim tempStr As String() = i.Split($"{Chr(34)}")
                        If tempStr(5) = "Lifeguard-MFAC" Then
                        lifeguardflag = True
                        i = i.Split(",")(10)

                        If i(1) Like "[A-Z]" Then
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
                        End If
                    Else
                        lifeguardflag = False
                    End If
                End If
                End If

            Next
        End Sub

        Private Sub btnExtract_Click(sender As Object, e As EventArgs) Handles btnExtract.Click

        getData()
        parceData()
        End Sub
    End Class
