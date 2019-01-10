<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRM4000
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grpCommand = New System.Windows.Forms.GroupBox()
        Me.btnCalculateResults = New System.Windows.Forms.Button()
        Me.btnArchiveReport = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lstTeamResults = New System.Windows.Forms.ListBox()
        Me.lstBoxLoad = New System.Windows.Forms.ListBox()
        Me.grpCommand.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpCommand
        '
        Me.grpCommand.BackColor = System.Drawing.Color.SteelBlue
        Me.grpCommand.Controls.Add(Me.btnCalculateResults)
        Me.grpCommand.Controls.Add(Me.btnArchiveReport)
        Me.grpCommand.Controls.Add(Me.btnExit)
        Me.grpCommand.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCommand.ForeColor = System.Drawing.Color.White
        Me.grpCommand.Location = New System.Drawing.Point(11, 242)
        Me.grpCommand.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpCommand.Name = "grpCommand"
        Me.grpCommand.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpCommand.Size = New System.Drawing.Size(747, 69)
        Me.grpCommand.TabIndex = 2
        Me.grpCommand.TabStop = False
        '
        'btnCalculateResults
        '
        Me.btnCalculateResults.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCalculateResults.Location = New System.Drawing.Point(21, 21)
        Me.btnCalculateResults.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCalculateResults.Name = "btnCalculateResults"
        Me.btnCalculateResults.Size = New System.Drawing.Size(136, 34)
        Me.btnCalculateResults.TabIndex = 6
        Me.btnCalculateResults.Text = "&Calculate Res."
        Me.btnCalculateResults.UseVisualStyleBackColor = True
        '
        'btnArchiveReport
        '
        Me.btnArchiveReport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnArchiveReport.Location = New System.Drawing.Point(155, 21)
        Me.btnArchiveReport.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnArchiveReport.Name = "btnArchiveReport"
        Me.btnArchiveReport.Size = New System.Drawing.Size(136, 34)
        Me.btnArchiveReport.TabIndex = 5
        Me.btnArchiveReport.Text = "&Archive Files"
        Me.btnArchiveReport.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnExit.Location = New System.Drawing.Point(585, 21)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(136, 34)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "&Return"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lstTeamResults
        '
        Me.lstTeamResults.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTeamResults.FormattingEnabled = True
        Me.lstTeamResults.HorizontalScrollbar = True
        Me.lstTeamResults.ItemHeight = 17
        Me.lstTeamResults.Location = New System.Drawing.Point(19, 15)
        Me.lstTeamResults.Margin = New System.Windows.Forms.Padding(4)
        Me.lstTeamResults.Name = "lstTeamResults"
        Me.lstTeamResults.Size = New System.Drawing.Size(711, 191)
        Me.lstTeamResults.TabIndex = 3
        '
        'lstBoxLoad
        '
        Me.lstBoxLoad.FormattingEnabled = True
        Me.lstBoxLoad.ItemHeight = 16
        Me.lstBoxLoad.Location = New System.Drawing.Point(739, 133)
        Me.lstBoxLoad.Margin = New System.Windows.Forms.Padding(4)
        Me.lstBoxLoad.Name = "lstBoxLoad"
        Me.lstBoxLoad.Size = New System.Drawing.Size(16, 36)
        Me.lstBoxLoad.Sorted = True
        Me.lstBoxLoad.TabIndex = 4
        Me.lstBoxLoad.Visible = False
        '
        'frmRM4000
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 322)
        Me.Controls.Add(Me.lstBoxLoad)
        Me.Controls.Add(Me.lstTeamResults)
        Me.Controls.Add(Me.grpCommand)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmRM4000"
        Me.Text = "Race Mgr-4000-Results Mgr-Cedric Mulumba"
        Me.grpCommand.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpCommand As System.Windows.Forms.GroupBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnArchiveReport As System.Windows.Forms.Button
    Friend WithEvents btnCalculateResults As System.Windows.Forms.Button
    Friend WithEvents lstTeamResults As System.Windows.Forms.ListBox
    Friend WithEvents lstBoxLoad As System.Windows.Forms.ListBox
End Class
