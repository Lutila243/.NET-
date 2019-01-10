Imports System.IO
Public Class frmRM3000

    ' Author: Cedric Mulumba
    ' Project: Race Manager
    ' Form/Class: frmRM3000
    ' Description: Race Manager: Race Maintenance
    ' Date: April 2016

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If lstSyncTimeBibs.Items.Count > 0 Then
            frmRM0000.btnResultsMgr.Enabled = True
        Else
            frmRM0000.btnResultsMgr.Enabled = False
        End If
        frmRM0000.Show()
        Me.Hide()

    End Sub

    Private Sub btnSyncTimesBibs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSyncTimesBibs.Click
        ' This button is disabled until both Times and Bibs have been entered.
        ' The associated list box is invisible until this buttom is pressed
        ' This routine merges Position | Time | Bib #

        Dim intPostion As Integer
        Dim subscript As Integer = 0
        Dim intcount As Integer = 0
        ' Dim item2 As String
        Dim strRunner As String = ""
        Dim strSchool As String = ""

        lstSyncTimeBibs.Items.Clear()
        For Each item As String In lstTimeEntry.Items
            strRunner = "Runner Not Found"
            strSchool = "School Not Found"
            ' find selected BIB #

            lstBibs.SelectedIndex = subscript
            intPostion = InStr(lstBibs.SelectedItem, "- ")
            strRunner = Trim(Mid(lstBibs.SelectedItem, intPostion + 2))
            ' Find School by stepping through lstPlayers
            intcount = lstBibs.Items.Count
            ' Debug.Print(intcount)
            ' Step through lstRoster looking for match of runner from lstPlace
            For Each item2 As String In frmRM2000.lstPlayers.Items
                ' Sample row layout -- lstRoster.Items.Add("A-SHS")
                If strRunner = Mid(item2, 1, 3) Then
                    strSchool = Mid(item2, 5)
                End If
            Next
            lstSyncTimeBibs.Items.Add(item & " - " & strRunner & " - " & strSchool)
            subscript += 1
            Me.Refresh()
        Next
    End Sub

    Private Sub btnEnterResults_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnterResults.Click
        Dim strRow As String
        Dim bolFoundCode As Boolean = False
        Dim bolEndCode As Boolean = False
        Dim intCount As Integer = 0
        If txtFilePath.Text.Trim <> "" Then
            Dim textIn As New StreamReader( _
                New FileStream(txtFilePath.Text, FileMode.OpenOrCreate, FileAccess.Read))
            ' Clear Team listbox
            lstTimeEntry.Items.Clear()

            Do While textIn.Peek <> -1 And Not bolEndCode
                Me.Refresh()
                strRow = textIn.ReadLine.Trim
                If Not bolFoundCode Then
                    If "# TIME FILE" = UCase(Mid(strRow, 1, 11)) Then
                        bolFoundCode = True
                    End If
                Else
                    If Mid(strRow, 1, 2) <> "# " Then
                        intCount += 1
                        lstTimeEntry.Items.Add(CStr(intCount) & " - " & strRow)
                    Else
                        bolEndCode = True
                    End If
                End If
            Loop
        Else
            MsgBox("Logic for input box entry goes here")
        End If
        If lstTimeEntry.Items.Count > 0 And lstBibs.Items.Count > 0 Then
            btnSyncTimesBibs.Enabled = True
        Else
            btnSyncTimesBibs.Enabled = False
        End If
    End Sub

    Private Sub txtFilePath_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFilePath.TextChanged
        'If txtFilePath.Text.Length > 0 Then
        ' btnEnterResults.Enabled = True
        ' Else
        ' btnEnterResults.Enabled = False
        ' End If

    End Sub

    Private Sub btnEnterBib_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnterBib.Click
        ' The btnBattingAverage click event accepts and displays up to 9 batting averages
        ' and then calculates and displays the team average.
        ' Declare and initialize variables

        Dim strBIBNumber As String
        Dim decBIBNumber As Decimal
        Dim decTotalOfAllAverages As Decimal = 0D
        Dim strInputBoxMessage As String = "Enter the BIB # for Runner#"
        Dim strInputBoxHeading As String = "BIB Entry"
        Dim strNormalBoxMessage As String = "Enter the BIB # "
        Dim strNonNumericErrorMessage As String = "Error - Enter a BIB # for the Runner"
        Dim strNegativeNumberErrorMessage As String = "Error- Enter a positive number"

        'Declare and initialize loop variables
        Dim intMaximumNumberOfEntries As Integer = lstTimeEntry.Items.Count
        Dim intNumberOfEntries As Integer = 1

        strBIBNumber = InputBox(strInputBoxMessage & intNumberOfEntries, strInputBoxHeading)

        'Do Until intNumberOfEntries > intMaximumNumberOfEntries 
        'Or strBattingAverage is empty (Cancel Button)
        Do Until intNumberOfEntries > intMaximumNumberOfEntries Or strBIBNumber = ""
            'Validates that the Average is a number


            If IsNumeric(strBIBNumber) Then
                decBIBNumber = Convert.ToDecimal(strBIBNumber)


                ' Validates that the value is positive number
                If decBIBNumber > 0 Then
                    lstBibs.Items.Add(CStr(intNumberOfEntries) & " - " & strBIBNumber)
                    intNumberOfEntries += 1
                    strInputBoxMessage = strNormalBoxMessage
                    Me.Refresh()
                Else
                    strInputBoxMessage = strNegativeNumberErrorMessage
                End If
            Else
                strInputBoxMessage = strNonNumericErrorMessage
            End If
            If intNumberOfEntries <= intMaximumNumberOfEntries Then
                strBIBNumber = InputBox(strInputBoxMessage & intNumberOfEntries, strInputBoxHeading)
            End If
        Loop
        If lstTimeEntry.Items.Count > 0 And lstBibs.Items.Count > 0 Then
            btnSyncTimesBibs.Enabled = True
        Else
            btnSyncTimesBibs.Enabled = False
        End If

    End Sub

    Private Sub btnRandom60_Click(sender As System.Object, e As System.EventArgs) Handles btnRandom60.Click
        Dim strNumberList As String = "|"
        Dim RandomNumber As Integer
        Dim strRandomNumber As String
        Dim intPosition As Integer
        Dim icount As Integer = 0
        Dim iTotalTry As Integer = 0
        Randomize()
        Do While icount < 60
            RandomNumber = CInt(Int(60 * Rnd()) + 101)
            strRandomNumber = RandomNumber.ToString.Trim & "|"
            intPosition = InStr(1, strNumberList, strRandomNumber)
            If intPosition = 0 Then
                strNumberList &= strRandomNumber
                icount += 1
            End If
            iTotalTry += 1
        Loop
        Debug.Print(strNumberList)

    End Sub

    Private Sub frmRM3000_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class