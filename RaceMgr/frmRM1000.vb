Imports System.IO
Public Class frmRM1000

    ' Author: Cedric Mulumba
    ' Project: Race Manager
    ' Form/Class: frmRM1000
    ' Description: Race Manager Team/School Maintenance
    ' Date: April 2016

    Friend Field1 As String = "School Code"
    Friend Field2 As String = "School Name"
    Friend Field3 As String = "Coach F-Name"
    Friend Field4 As String = "Coach L-Name"
    Friend Field5 As String = "AD F-Name"
    Friend Field6 As String = "AD L-Name"
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If lstTeam.Items.Count > 0 And frmRM2000.lstPlayers.Items.Count > 0 Then
            frmRM0000.btnRaceMgr.Enabled = True
        Else
            frmRM0000.btnRaceMgr.Enabled = False
        End If
        frmRM0000.Show()
        Me.Hide()
    End Sub

    Private Sub btnLoadTeams_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadTeams.Click
        ' This routine loads the lstTeam box from an ASCII .txt file
        ' # School [School Code | Name | Coach F-Name| Coach L-Name | AD F-Name | AD L-Name]

        Dim strRow As String
        Dim bolFoundCode As Boolean = False
        Dim bolEndCode As Boolean = False
        Dim textIn As New StreamReader( _
            New FileStream(txtFilePath.Text, FileMode.OpenOrCreate, FileAccess.Read))
        ' Clear Team listbox
        lstTeam.Items.Clear()

        Do While textIn.Peek <> -1 And Not bolEndCode
            Me.Refresh()
            strRow = textIn.ReadLine.Trim
            If Not bolFoundCode Then
                If "# SCHOOL " = UCase(Mid(strRow, 1, 9)) Then
                    bolFoundCode = True
                End If
            Else
                If Mid(strRow, 1, 2) <> "# " Then
                    lstTeam.Items.Add(strRow)
                Else
                    bolEndCode = True
                End If
            End If
        Loop

    End Sub

    Private Sub btnDeleteTeam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteTeam.Click
        'This routine removes a Team from the list based on the entered Team Code.. Perform typical validation...
        'MsgBox("This routine removes a Team from the list based on the entered Team Code... Perform typical validation...Make sure to ask Are You Sure?")

        ' Have we selected an item|Team to be deleted?
        If lstTeam.SelectedItem = "" Then
            ' No then tell the user
            MsgBox("You have not selected a team for deletion")
        Else
            ' Yes Then check to see if they REALLY want to detelet the team
            If MsgBox("Are you sure you want to delete: " & lstTeam.SelectedItem, MsgBoxStyle.OkCancel) = vbOK Then
                ' Yes... The user wants to delete the team then remove it from the list
                lstTeam.Items.Remove(lstTeam.SelectedItem)
            End If
        End If

    End Sub


    Private Sub frmRM1000_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If txtFilePath.Text.Trim = "" Then
            txtFilePath.Text = frmRM0000.txtFilePath.Text
        End If
    End Sub

    Private Sub frmRM1000_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        If txtFilePath.Text.Trim = "" Then
            txtFilePath.Text = frmRM0000.txtFilePath.Text
        End If
    End Sub

    Private Sub btnAddRunners_Click(sender As System.Object, e As System.EventArgs) Handles btnAddRunners.Click
        'frmRMDataEntry.FromForm = Me
        'frmRMDataEntry.lblField1.Text = Field1
        'frmRMDataEntry.lblField2.Text = Field2
        'frmRMDataEntry.lblField3.Text = Field3
        'frmRMDataEntry.lblField4.Text = Field4
        'frmRMDataEntry.lblField5.Text = Field5
        'frmRMDataEntry.lblField6.Text = Field6
        'Me.Enabled = False
        'frmRMDataEntry.Show()
        grpCommand.Enabled = False
        groAdd.Visible = True
        txtSchoolCode.Focus()
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        grpCommand.Enabled = True
        groAdd.Visible = False
    End Sub


    Private Sub btnRefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnRefresh.Click
        RefreshAddTeam()

    End Sub
    Private Sub RefreshAddTeam()
        txtADFName.Clear()
        txtADLName.Clear()
        txtCoachFName.Clear()
        txtCoachLName.Clear()
        txtSchoolCode.Clear()
        txtSchoolName.Clear()

        txtSchoolCode.Focus()
    End Sub

    Private Sub txtSchoolCode_GotFocus(sender As Object, e As System.EventArgs) Handles txtSchoolCode.GotFocus
        AddSchoolDataVerification()

    End Sub


    Private Sub AddSchoolDataVerification()
        '''' add search for duplicate school  code here

        '''' add search for duplicate school  code here
        If txtADFName.Text.Trim <> "" And
        txtADLName.Text.Trim <> "" And
        txtCoachFName.Text.Trim <> "" And
        txtCoachLName.Text.Trim <> "" And
        txtSchoolCode.Text.Trim <> "" And
        txtSchoolName.Text.Trim <> "" Then
            btnSave.Enabled = True
        Else
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub txtCoachFName_lostfocus(sender As Object, e As System.EventArgs) Handles txtCoachFName.MarginChanged
        AddSchoolDataVerification()
    End Sub

    Private Sub txtCoachFName_GotFocus(sender As System.Object, e As System.EventArgs) Handles txtCoachFName.TextChanged
        AddSchoolDataVerification()
    End Sub

    Private Sub txtCoachLName_LostFocus(sender As Object, e As System.EventArgs) Handles txtCoachLName.LostFocus
        AddSchoolDataVerification()
    End Sub

    Private Sub txtCoachLName_GotFocus(sender As System.Object, e As System.EventArgs) Handles txtCoachLName.TextChanged
        AddSchoolDataVerification()
    End Sub

    Private Sub txtADFName_LostFocus(sender As Object, e As System.EventArgs) Handles txtADFName.LostFocus
        AddSchoolDataVerification()
    End Sub

    Private Sub txtADFName_GotFocus(sender As System.Object, e As System.EventArgs) Handles txtADFName.TextChanged
        AddSchoolDataVerification()
    End Sub

    Private Sub txtADLName_LostFocus(sender As Object, e As System.EventArgs) Handles txtADLName.LostFocus
        AddSchoolDataVerification()
    End Sub

    Private Sub txtADLName_GotFocus(sender As System.Object, e As System.EventArgs) Handles txtADLName.TextChanged
        AddSchoolDataVerification()
    End Sub


    Private Sub txtSchoolCode_LostFocus(sender As System.Object, e As System.EventArgs) Handles txtSchoolCode.TextChanged
        AddSchoolDataVerification()
    End Sub

    Private Sub txtSchoolName_LostFocus(sender As System.Object, e As System.EventArgs) Handles txtSchoolName.TextChanged
        AddSchoolDataVerification()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Dim intPosition As Integer
        Dim strLine As String = ""
        Dim strSchoolCode As String
        Dim DupSchool As Boolean = False

        Dim Subscript As Integer = 0
        ' Loop through The Team list to locate a duplicate school code
        For Each item As String In lstTeam.Items
            'lstTeam.SelectedIndex = Subscript
            strLine = item
            intPosition = InStr(1, strLine, "|")
            strSchoolCode = Trim(Mid(strLine, 1, intPosition - 1))
            If strSchoolCode.ToUpper = Trim(txtSchoolCode.Text.ToUpper) Then
                DupSchool = True
                ' we do not need to check any more... Let's byepass the remainder of the list
                Exit For

            End If
            'Subscript += 1
        Next

        If DupSchool Then
            lblAddTeamMessage.Text = "Duplicate school code found"
        Else
            strLine = ""
            strLine &= txtSchoolCode.Text.ToUpper & "|"
            strLine &= txtSchoolName.Text & "|"
            strLine &= txtCoachFName.Text & "|"
            strLine &= txtCoachLName.Text & "|"
            strLine &= txtADFName.Text & "|"
            strLine &= txtADLName.Text
            lstTeam.Items.Add(strLine)
            RefreshAddTeam()
            lblAddTeamMessage.Text = "School code added to list"
        End If

    End Sub
End Class