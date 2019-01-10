Public Class frmRM0000

    ' Author: Bob Desilets
    ' Project: Race Manager
    ' Form/Class: frmRM0000
    ' Description: Race Manager Menu Form
    ' Date: April 2013

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        grpCommand.Text = TimeOfDay
        frmRM1000.grpCommand.Text = TimeOfDay
        frmRM2000.grpCommand.Text = TimeOfDay
        frmRM3000.grpCommand.Text = TimeOfDay
        frmRM4000.grpCommand.Text = TimeOfDay
        frmRMDataEntry.grpCommand.Text = TimeOfDay
    End Sub

    Private Sub btnTeamMgr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTeamMgr.Click
        frmRM1000.Show()
        'Me.Hide()
        Me.Hide()
    End Sub

    Private Sub btnRunnerMgr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRunnerMgr.Click
        frmRM2000.Show()
        Me.Hide()
    End Sub

    Private Sub btnRaceMgr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRaceMgr.Click
        frmRM3000.Show()
        Me.Hide()
    End Sub

    Private Sub btnResultsMgr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResultsMgr.Click

        frmRM4000.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
