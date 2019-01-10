<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRM2000
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRM2000))
        Me.grpCommand = New System.Windows.Forms.GroupBox()
        Me.btnDeleteRunner = New System.Windows.Forms.Button()
        Me.btnAddRunners = New System.Windows.Forms.Button()
        Me.btnLoadRunners = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lstPlayers = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grpCommand.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpCommand
        '
        Me.grpCommand.BackColor = System.Drawing.Color.SteelBlue
        Me.grpCommand.Controls.Add(Me.btnDeleteRunner)
        Me.grpCommand.Controls.Add(Me.btnAddRunners)
        Me.grpCommand.Controls.Add(Me.btnLoadRunners)
        Me.grpCommand.Controls.Add(Me.btnExit)
        Me.grpCommand.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCommand.ForeColor = System.Drawing.Color.White
        Me.grpCommand.Location = New System.Drawing.Point(13, 240)
        Me.grpCommand.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpCommand.Name = "grpCommand"
        Me.grpCommand.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpCommand.Size = New System.Drawing.Size(747, 69)
        Me.grpCommand.TabIndex = 2
        Me.grpCommand.TabStop = False
        '
        'btnDeleteRunner
        '
        Me.btnDeleteRunner.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDeleteRunner.Location = New System.Drawing.Point(285, 21)
        Me.btnDeleteRunner.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDeleteRunner.Name = "btnDeleteRunner"
        Me.btnDeleteRunner.Size = New System.Drawing.Size(136, 34)
        Me.btnDeleteRunner.TabIndex = 7
        Me.btnDeleteRunner.Text = "Del. Runners"
        Me.btnDeleteRunner.UseVisualStyleBackColor = True
        '
        'btnAddRunners
        '
        Me.btnAddRunners.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAddRunners.Location = New System.Drawing.Point(152, 21)
        Me.btnAddRunners.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddRunners.Name = "btnAddRunners"
        Me.btnAddRunners.Size = New System.Drawing.Size(136, 34)
        Me.btnAddRunners.TabIndex = 6
        Me.btnAddRunners.Text = "Add Runners"
        Me.btnAddRunners.UseVisualStyleBackColor = True
        '
        'btnLoadRunners
        '
        Me.btnLoadRunners.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnLoadRunners.Location = New System.Drawing.Point(19, 21)
        Me.btnLoadRunners.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLoadRunners.Name = "btnLoadRunners"
        Me.btnLoadRunners.Size = New System.Drawing.Size(136, 34)
        Me.btnLoadRunners.TabIndex = 5
        Me.btnLoadRunners.Text = "Load Runners"
        Me.btnLoadRunners.UseVisualStyleBackColor = True
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
        'lstPlayers
        '
        Me.lstPlayers.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPlayers.FormattingEnabled = True
        Me.lstPlayers.HorizontalScrollbar = True
        Me.lstPlayers.ItemHeight = 17
        Me.lstPlayers.Location = New System.Drawing.Point(15, 25)
        Me.lstPlayers.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstPlayers.Name = "lstPlayers"
        Me.lstPlayers.Size = New System.Drawing.Size(461, 174)
        Me.lstPlayers.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(356, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "School Code | BIB # | Runner F-Name | Runner L-Name"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SteelBlue
        Me.GroupBox1.Controls.Add(Me.txtFilePath)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Location = New System.Drawing.Point(453, 190)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(307, 60)
        Me.GroupBox1.TabIndex = 8
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
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(595, 25)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(165, 143)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'frmRM2000
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 322)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstPlayers)
        Me.Controls.Add(Me.grpCommand)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmRM2000"
        Me.Text = "Race Mgr-2000-Runner Mgnt-Cedric Mulumba"
        Me.grpCommand.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpCommand As System.Windows.Forms.GroupBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnAddRunners As System.Windows.Forms.Button
    Friend WithEvents btnLoadRunners As System.Windows.Forms.Button
    Friend WithEvents lstPlayers As System.Windows.Forms.ListBox
    Friend WithEvents btnDeleteRunner As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFilePath As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
