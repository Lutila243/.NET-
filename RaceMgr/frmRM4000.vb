Imports System.IO
Public Class frmRM4000

    ' Author: Cedric Mulumba
    ' Project: Race Manager
    ' Form/Class: frmRM4000
    ' Description: Race Manager: Race Results
    ' Date: April 2016


    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        frmRM0000.Show()
        Me.Hide()
    End Sub



    Private Sub btnCalculateResults_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculateResults.Click
        Dim intPosition As Integer = 0
        Dim intPosition2 As Integer = 0
        Dim strLine As String = Space(61)
        Dim strTeamCode As String
        Dim strPlace As String
        Dim strBIB As String
        Dim strTeamList As String = ""
        'Dim strTeamWork As String
        Dim intTotal As Integer
        Dim strTotal As String
        Dim intsub As Integer
        Dim strRunnerWorkLine As String = ""
        Dim strName As String

        lstTeamResults.Items.Clear()
        lstTeamResults.Items.Add("[Points] [Team Code] [P-1] [P-2] [P-3] [P-4] [P-5] [P-6] [P-7]")
        lstTeamResults.Items.Add("  ----    ---------   ---   ---   ---   ---   ---   ---   ---")
        ' populate teams
        For Each item As String In frmRM1000.lstTeam.Items
            strLine = "  0000    ---------   ---   ---   ---   ---   ---   ---   ---"
            strTeamCode = Space(9)
            intPosition = InStr(1, item, "|")

            Mid(strTeamCode, 1) = (Mid(item, 1, intPosition - 1))
            Mid(strLine, 11, 9) = strTeamCode
            lstTeamResults.Items.Add(strLine)
        Next
        ' Step through merged list
        For Each item As String In frmRM3000.lstSyncTimeBibs.Items
            strLine = item
            'find postion
            intPosition = InStr(1, strLine, "-")
            strPlace = Mid(strLine, 1, intPosition - 1).Trim
            ' Pad place to 3 digits
            While strPlace.Length < 3
                strPlace = "0" & strPlace
            End While
            ' find runner BIB #
            ' find ' before BIB #
            intPosition = InStr(intPosition + 1, strLine, "-")
            ' find BIB # after BIB#
            intPosition2 = InStr(intPosition + 1, strLine, "-")
            ' extract the BIB #
            strBIB = Mid(strLine, intPosition + 1, (intPosition2 - intPosition - 1)).Trim
            ' extract the Team Code
            intPosition = intPosition2
            intPosition2 = InStr(intPosition + 1, strLine, "|")
            strTeamCode = Space(9)
            Mid(strTeamCode, 1) = (Mid(strLine, intPosition + 1, (intPosition2 - 1 - intPosition))).Trim
            Debug.Print(frmRM1000.lstTeam.Items.Count - 1)
            'For intSub As Integer = 0 To frmRM1000.lstTeam.Items.Count - 1
            For intsub = 0 To lstTeamResults.Items.Count - 1
                Dim strItems As String
                lstTeamResults.SelectedIndex = intsub
                strItems = lstTeamResults.SelectedItem
                ' find team in merge list for current BIB #
                If strTeamCode = Mid(strItems, 11, 9) Then
                    ' found team now find [placement for team
                    Debug.Print(strItems)
                    intPosition = InStr(20, strItems, "---")
                    If intPosition > 0 Then
                        Mid(strItems, intPosition, 3) = strPlace
                        ' place 5 starts at position 46
                        If intPosition < 49 Then
                            intTotal = CStr(Val(Mid(strItems, 3, 4)))
                            intTotal += Val(strPlace)
                            strTotal = intTotal.ToString
                            While strTotal.Length < 4
                                strTotal = "0" & strTotal
                            End While
                            Mid(strItems, 3, 4) = strTotal
                        End If
                        lstTeamResults.Items.RemoveAt(intsub)
                        lstTeamResults.Items.Add(strItems)
                        Debug.Print(lstTeamResults.SelectedItem)
                        Me.Refresh()
                        Exit For
                    End If

                End If
            Next
        Next
        'intsub = 0
        'For Each item As String In lstTeamResults.Items
        'If Mid(item, 3, 4) = "0000" Then
        'lstTeamResults.Items.RemoveAt(intsub)
        'intsub += 1
        'End If
        'Next
        lstBoxLoad.Items.Clear()
        intsub = 0
        For Each item As String In lstTeamResults.Items
            If intsub > 1 Then
                If Mid(item, 3, 4) <> "0000" Then
                    lstBoxLoad.Items.Add(item)
                End If
            End If
            intsub += 1
        Next

        lstTeamResults.Items.Clear()
        lstTeamResults.Items.Add("[Points] [Team Code] [P-1] [P-2] [P-3] [P-4] [P-5] [P-6] [P-7]")
        For Each item As String In lstBoxLoad.Items
            lstTeamResults.Items.Add(item)
        Next
        lstTeamResults.Items.Add(" ")
        lstTeamResults.Items.Add("         Individual Results")
        lstTeamResults.Items.Add("Pos.     Time      Bib   School        Runner")

        ' Loop thru frmRM3000.lstSyncTimeBib to add runners to the list
        For Each item As String In frmRM3000.lstSyncTimeBibs.Items
            strRunnerWorkLine = ""
            ' 1 - 18:29.17 - 113 - WSHS|FName|LName
            ' find space after Position
            intPosition = InStr(1, item, " ")
            strRunnerWorkLine = Mid(item, 1, intPosition - 1)
            ' Pad Position less than 3 digits with leading "0"s
            Do While intPosition < 4
                strRunnerWorkLine = "0" & strRunnerWorkLine
                intPosition += 1
            Loop
            strRunnerWorkLine &= Space(60)
            ' Find the time
            ' start of time
            intPosition = InStr(1, item, "- ")
            intPosition2 = InStr(intPosition + 2, item, " ")
            Mid(strRunnerWorkLine, 8, 9) = Mid(item, intPosition + 2, intPosition2 - intPosition + 1)
            Mid(strRunnerWorkLine, 6, 1) = "-"

            ' Find Bib Number
            intPosition = InStr(intPosition2, item, "-")
            ' Find End of Bib
            intPosition2 = InStr(intPosition + 1, item, "-")
            Mid(strRunnerWorkLine, 18, 1) = "-"
            Mid(strRunnerWorkLine, 20, (intPosition2 - 3 - intPosition)) = Mid(item, intPosition + 2, (intPosition2 - 3 - intPosition))

            ' 1 - 18:29.17 - 113 - WSHS|FName|LName
            ' Find School/Team Code
            ' School code end
            intPosition = InStr(intPosition2, item, "|")
            Mid(strRunnerWorkLine, 25, 8) = Mid(item, intPosition2 + 1, intPosition - intPosition2 - 1)
            intPosition2 = InStr(intPosition + 1, item, "|")
            strName = Mid(item, intPosition + 1, intPosition2 - intPosition - 1)
            strName &= " " & Mid(item, intPosition2 + 1)
            Mid(strRunnerWorkLine, 35, 20) = strName

            '   lstTeamResults.Items.Add(item)
            lstTeamResults.Items.Add(strRunnerWorkLine)
        Next
    End Sub


    Private Sub btnArchiveReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArchiveReport.Click

        Dim textOut As New StreamWriter( _
            New FileStream("ArchiveReport.txt", FileMode.Create, FileAccess.Write))

        textOut.WriteLine("Cedric Mulumba' Race Manager                             " & Now)
        textOut.WriteLine()
        textOut.WriteLine()
        textOut.WriteLine("                 T E A M       R E S U L T S")
        For Each item As String In lstTeamResults.Items
            textOut.WriteLine(item)
        Next

        'textOut.WriteLine()
        'textOut.WriteLine("====================================================================")
        'textOut.WriteLine("                       Individual Results")
        'textOut.WriteLine("====================================================================")
        'textOut.WriteLine("  1.     Cedric Mulumba            South H.S .          18:23.55")
        'textOut.WriteLine("  2.     --------------------    ------------------   --------")
        textOut.WriteLine()
        textOut.WriteLine()
        textOut.Close()
        MsgBox("Your race results have been archived")
    End Sub

    Private Sub frmRM4000_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class