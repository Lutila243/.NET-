Public Class frmRMDataEntry
    Friend FromForm As Form
    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        'frmRM1000.Enabled = True
        FromForm.Enabled = True
        Me.Close()
    End Sub

    Private Sub frmRMDataEntry_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Dim Counter As Integer
        Dim labelName As Label
        lblFrom.Text = "[Act " & FromForm.Name & " ]"
        'For Counter = 1 To 6
        'labelName.Name = "lblField" & Counter.ToString.Trim
        'Debug.Print(labelName.Name)

        'lblField2.Text = FromForm.Field2
        'lblField3.Text = FromForm.Field3
        'lblField4.Text = FromForm.Field4
        'lblField5.Text = FromForm.Field5
        'lblField6.Text = FromForm.Field6
        'lblField1.Text = FromForm.Field1
    End Sub

    Private Sub frmRMDataEntry_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim Counter As Integer
        Dim labelName As Label
        lblFrom.Text = "[Load " & FromForm.Name & " ]"
        'For Counter = 1 To 6
        'labelName.Name = "lblField" & Counter.ToString.Trim
        'Debug.Print(labelName.Name)

        'lblField2.Text = FromForm.Field2
        'lblField3.Text = FromForm.Field3
        'lblField4.Text = FromForm.Field4
        'lblField5.Text = FromForm.Field5
        'lblField6.Text = FromForm.Field6
        'lblField1.Text = FromForm.Field1

        'Next
    End Sub


    Private Sub lblField1_Click(sender As System.Object, e As System.EventArgs) Handles lblField1.Click

    End Sub
End Class
