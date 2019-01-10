Imports System.IO
Public Class frmRM2000

    ' Author: Cedric Mulumba
    ' Project: Race Manager
    ' Form/Class: frmRM2000
    ' Description: Race Manager Runner Maintenance
    ' Date: April 2016

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If frmRM1000.lstTeam.Items.Count > 0 And lstPlayers.Items.Count > 0 Then
            frmRM0000.btnRaceMgr.Enabled = True
        Else
            frmRM0000.btnRaceMgr.Enabled = False
        End If
        frmRM0000.Show()
        Me.Hide()
    End Sub

    Private Sub btnLoadRunners_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadRunners.Click
        ' This routine loads the lstRunner box from an ASCII .txt file

        Dim strRow As String
        Dim bolFoundCode As Boolean = False
        Dim bolEndCode As Boolean = False
        Dim textIn As New StreamReader( _
            New FileStream(txtFilePath.Text, FileMode.OpenOrCreate, FileAccess.Read))
        ' Clear Team listbox
        lstPlayers.Items.Clear()

        Do While textIn.Peek <> -1 And Not bolEndCode
            Me.Refresh()
            strRow = textIn.ReadLine.Trim
            If Not bolFoundCode Then
                If "# ROSTER " = UCase(Mid(strRow, 1, 9)) Then
                    bolFoundCode = True
                End If
            Else
                If Mid(strRow, 1, 2) <> "# " Then
                    lstPlayers.Items.Add(strRow)
                Else
                    bolEndCode = True
                End If
            End If
        Loop


    End Sub

    Private Sub btnAddRunners_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddRunners.Click
        ' This routine loops through a msg box prompting the user for Bib # | School Code | Name
        ' You must scan the existing runner's Bib #s for duplicates... Force the user 
        ' to enter a new number
        frmRMDataEntry.FromForm = Me
        Me.Enabled = False
        frmRMDataEntry.Show()
    End Sub

    Private Sub btnDeleteRunner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteRunner.Click
        'This routine removes a runner from the list based on the entered Bib #... Perform typical validation...
        MsgBox("This routine removes a runner from the list based on the entered Bib #... Perform typical validation...Make sure to ask Are You Sure?")

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lstPlayers.Items.Add("Player-1")
        lstPlayers.Items.Add("Player-2")

    End Sub

    Private Sub frmRM2000_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If txtFilePath.Text.Trim = "" Then
            txtFilePath.Text = frmRM0000.txtFilePath.Text
        End If
    End Sub

    Private Sub frmRM2000_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        If txtFilePath.Text.Trim = "" Then
            txtFilePath.Text = frmRM0000.txtFilePath.Text
        End If
    End Sub
End Class