<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRM3000
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
        Me.btnRandom60 = New System.Windows.Forms.Button()
        Me.btnSyncTimesBibs = New System.Windows.Forms.Button()
        Me.btnEnterBib = New System.Windows.Forms.Button()
        Me.btnEnterResults = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lstTimeEntry = New System.Windows.Forms.ListBox()
        Me.lstBibs = New System.Windows.Forms.ListBox()
        Me.lstSyncTimeBibs = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.grpCommand.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpCommand
        '
        Me.grpCommand.BackColor = System.Drawing.Color.SteelBlue
        Me.grpCommand.Controls.Add(Me.btnRandom60)
        Me.grpCommand.Controls.Add(Me.btnSyncTimesBibs)
        Me.grpCommand.Controls.Add(Me.btnEnterBib)
        Me.grpCommand.Controls.Add(Me.btnEnterResults)
        Me.grpCommand.Controls.Add(Me.btnExit)
        Me.grpCommand.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCommand.ForeColor = System.Drawing.Color.White
        Me.grpCommand.Location = New System.Drawing.Point(12, 245)
        Me.grpCommand.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpCommand.Name = "grpCommand"
        Me.grpCommand.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpCommand.Size = New System.Drawing.Size(747, 69)
        Me.grpCommand.TabIndex = 2
        Me.grpCommand.TabStop = False
        '
        'btnRandom60
        '
        Me.btnRandom60.ForeColor = System.Drawing.Color.Black
        Me.btnRandom60.Location = New System.Drawing.Point(440, 21)
        Me.btnRandom60.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRandom60.Name = "btnRandom60"
        Me.btnRandom60.Size = New System.Drawing.Size(136, 34)
        Me.btnRandom60.TabIndex = 9
        Me.btnRandom60.Text = "Random 60"
        Me.btnRandom60.UseVisualStyleBackColor = True
        Me.btnRandom60.Visible = False
        '
        'btnSyncTimesBibs
        '
        Me.btnSyncTimesBibs.Enabled = False
        Me.btnSyncTimesBibs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSyncTimesBibs.Location = New System.Drawing.Point(297, 21)
        Me.btnSyncTimesBibs.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSyncTimesBibs.Name = "btnSyncTimesBibs"
        Me.btnSyncTimesBibs.Size = New System.Drawing.Size(136, 34)
        Me.btnSyncTimesBibs.TabIndex = 8
        Me.btnSyncTimesBibs.Text = "Sync Bibs-Times"
        Me.btnSyncTimesBibs.UseVisualStyleBackColor = True
        '
        'btnEnterBib
        '
        Me.btnEnterBib.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnEnterBib.Location = New System.Drawing.Point(163, 21)
        Me.btnEnterBib.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEnterBib.Name = "btnEnterBib"
        Me.btnEnterBib.Size = New System.Drawing.Size(136, 34)
        Me.btnEnterBib.TabIndex = 7
        Me.btnEnterBib.Text = "Enter Bib #s"
        Me.btnEnterBib.UseVisualStyleBackColor = True
        '
        'btnEnterResults
        '
        Me.btnEnterResults.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnEnterResults.Location = New System.Drawing.Point(29, 21)
        Me.btnEnterResults.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEnterResults.Name = "btnEnterResults"
        Me.btnEnterResults.Size = New System.Drawing.Size(136, 34)
        Me.btnEnterResults.TabIndex = 6
        Me.btnEnterResults.Text = "Load Times"
        Me.btnEnterResults.UseVisualStyleBackColor = True
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
        'lstTimeEntry
        '
        Me.lstTimeEntry.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTimeEntry.FormattingEnabled = True
        Me.lstTimeEntry.HorizontalScrollbar = True
        Me.lstTimeEntry.ItemHeight = 17
        Me.lstTimeEntry.Location = New System.Drawing.Point(12, 25)
        Me.lstTimeEntry.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstTimeEntry.Name = "lstTimeEntry"
        Me.lstTimeEntry.Size = New System.Drawing.Size(212, 157)
        Me.lstTimeEntry.TabIndex = 4
        '
        'lstBibs
        '
        Me.lstBibs.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBibs.FormattingEnabled = True
        Me.lstBibs.HorizontalScrollbar = True
        Me.lstBibs.ItemHeight = 17
        Me.lstBibs.Location = New System.Drawing.Point(229, 25)
        Me.lstBibs.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstBibs.Name = "lstBibs"
        Me.lstBibs.Size = New System.Drawing.Size(212, 157)
        Me.lstBibs.TabIndex = 5
        '
        'lstSyncTimeBibs
        '
        Me.lstSyncTimeBibs.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSyncTimeBibs.FormattingEnabled = True
        Me.lstSyncTimeBibs.HorizontalScrollbar = True
        Me.lstSyncTimeBibs.ItemHeight = 17
        Me.lstSyncTimeBibs.Location = New System.Drawing.Point(448, 25)
        Me.lstSyncTimeBibs.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstSyncTimeBibs.Name = "lstSyncTimeBibs"
        Me.lstSyncTimeBibs.Size = New System.Drawing.Size(311, 157)
        Me.lstSyncTimeBibs.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Time Entries"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(227, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "BIB Entries"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(445, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Position | Time | BIB #"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SteelBlue
        Me.GroupBox1.Controls.Add(Me.txtFilePath)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Location = New System.Drawing.Point(452, 194)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(307, 60)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Location - Full Path Location"
        '
        'txtFilePath
        '
        Me.txtFilePath.Location = New System.Drawing.Point(17, 20)
        Me.txtFilePath.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.Size = New System.Drawing.Size(273, 23)
        Me.txtFilePath.TabIndex = 0
        Me.txtFilePath.Text = "timefileshort.txt"
        '
        'frmRM3000
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 322)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstSyncTimeBibs)
        Me.Controls.Add(Me.lstBibs)
        Me.Controls.Add(Me.lstTimeEntry)
        Me.Controls.Add(Me.grpCommand)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmRM3000"
        Me.Text = " Race Mgr-3000-Race Mgnt-Cedric Mulumba"
        Me.grpCommand.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpCommand As System.Windows.Forms.GroupBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnEnterResults As System.Windows.Forms.Button
    Friend WithEvents lstTimeEntry As System.Windows.Forms.ListBox
    Friend WithEvents btnSyncTimesBibs As System.Windows.Forms.Button
    Friend WithEvents btnEnterBib As System.Windows.Forms.Button
    Friend WithEvents lstBibs As System.Windows.Forms.ListBox
    Friend WithEvents lstSyncTimeBibs As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFilePath As System.Windows.Forms.TextBox
    Friend WithEvents btnRandom60 As System.Windows.Forms.Button
End Class
