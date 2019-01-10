<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRM1000
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRM1000))
        Me.grpCommand = New System.Windows.Forms.GroupBox()
        Me.btnDeleteTeam = New System.Windows.Forms.Button()
        Me.btnAddRunners = New System.Windows.Forms.Button()
        Me.btnLoadTeams = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lstTeam = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.groPath = New System.Windows.Forms.GroupBox()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.groAdd = New System.Windows.Forms.GroupBox()
        Me.lblAddTeamMessage = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.txtADLName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtADFName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCoachLName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCoachFName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSchoolName = New System.Windows.Forms.TextBox()
        Me.txtSchoolCode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.grpCommand.SuspendLayout()
        Me.groPath.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groAdd.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpCommand
        '
        Me.grpCommand.BackColor = System.Drawing.Color.SteelBlue
        Me.grpCommand.Controls.Add(Me.btnDeleteTeam)
        Me.grpCommand.Controls.Add(Me.btnAddRunners)
        Me.grpCommand.Controls.Add(Me.btnLoadTeams)
        Me.grpCommand.Controls.Add(Me.btnExit)
        Me.grpCommand.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCommand.ForeColor = System.Drawing.Color.White
        Me.grpCommand.Location = New System.Drawing.Point(12, 370)
        Me.grpCommand.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpCommand.Name = "grpCommand"
        Me.grpCommand.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpCommand.Size = New System.Drawing.Size(747, 69)
        Me.grpCommand.TabIndex = 1
        Me.grpCommand.TabStop = False
        '
        'btnDeleteTeam
        '
        Me.btnDeleteTeam.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDeleteTeam.Location = New System.Drawing.Point(291, 21)
        Me.btnDeleteTeam.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDeleteTeam.Name = "btnDeleteTeam"
        Me.btnDeleteTeam.Size = New System.Drawing.Size(136, 34)
        Me.btnDeleteTeam.TabIndex = 10
        Me.btnDeleteTeam.Text = "Delete Teams"
        Me.btnDeleteTeam.UseVisualStyleBackColor = True
        '
        'btnAddRunners
        '
        Me.btnAddRunners.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAddRunners.Location = New System.Drawing.Point(157, 21)
        Me.btnAddRunners.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddRunners.Name = "btnAddRunners"
        Me.btnAddRunners.Size = New System.Drawing.Size(136, 34)
        Me.btnAddRunners.TabIndex = 9
        Me.btnAddRunners.Text = "Add Teams"
        Me.btnAddRunners.UseVisualStyleBackColor = True
        '
        'btnLoadTeams
        '
        Me.btnLoadTeams.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnLoadTeams.Location = New System.Drawing.Point(23, 21)
        Me.btnLoadTeams.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLoadTeams.Name = "btnLoadTeams"
        Me.btnLoadTeams.Size = New System.Drawing.Size(136, 34)
        Me.btnLoadTeams.TabIndex = 8
        Me.btnLoadTeams.Text = "Load Teams"
        Me.btnLoadTeams.UseVisualStyleBackColor = True
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
        'lstTeam
        '
        Me.lstTeam.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTeam.FormattingEnabled = True
        Me.lstTeam.HorizontalScrollbar = True
        Me.lstTeam.ItemHeight = 17
        Me.lstTeam.Location = New System.Drawing.Point(12, 25)
        Me.lstTeam.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstTeam.Name = "lstTeam"
        Me.lstTeam.Size = New System.Drawing.Size(571, 259)
        Me.lstTeam.Sorted = True
        Me.lstTeam.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(557, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "School Code | School Name | Coach F-Name | Coach L-Name | AD F-Name| AD L-Name"
        '
        'groPath
        '
        Me.groPath.BackColor = System.Drawing.Color.SteelBlue
        Me.groPath.Controls.Add(Me.txtFilePath)
        Me.groPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groPath.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.groPath.Location = New System.Drawing.Point(452, 305)
        Me.groPath.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.groPath.Name = "groPath"
        Me.groPath.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.groPath.Size = New System.Drawing.Size(307, 60)
        Me.groPath.TabIndex = 10
        Me.groPath.TabStop = False
        Me.groPath.Text = "Data Location - Full Path Location"
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
        Me.PictureBox1.Location = New System.Drawing.Point(591, 25)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(165, 143)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'groAdd
        '
        Me.groAdd.BackColor = System.Drawing.Color.SteelBlue
        Me.groAdd.Controls.Add(Me.lblAddTeamMessage)
        Me.groAdd.Controls.Add(Me.btnSave)
        Me.groAdd.Controls.Add(Me.btnRefresh)
        Me.groAdd.Controls.Add(Me.txtADLName)
        Me.groAdd.Controls.Add(Me.Label6)
        Me.groAdd.Controls.Add(Me.txtADFName)
        Me.groAdd.Controls.Add(Me.Label7)
        Me.groAdd.Controls.Add(Me.txtCoachLName)
        Me.groAdd.Controls.Add(Me.Label5)
        Me.groAdd.Controls.Add(Me.txtCoachFName)
        Me.groAdd.Controls.Add(Me.Label4)
        Me.groAdd.Controls.Add(Me.txtSchoolName)
        Me.groAdd.Controls.Add(Me.txtSchoolCode)
        Me.groAdd.Controls.Add(Me.Label3)
        Me.groAdd.Controls.Add(Me.Label2)
        Me.groAdd.Controls.Add(Me.btnCancel)
        Me.groAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groAdd.ForeColor = System.Drawing.Color.White
        Me.groAdd.Location = New System.Drawing.Point(12, 188)
        Me.groAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.groAdd.Name = "groAdd"
        Me.groAdd.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.groAdd.Size = New System.Drawing.Size(747, 177)
        Me.groAdd.TabIndex = 12
        Me.groAdd.TabStop = False
        Me.groAdd.Text = "Add Team Information"
        Me.groAdd.Visible = False
        '
        'lblAddTeamMessage
        '
        Me.lblAddTeamMessage.AutoSize = True
        Me.lblAddTeamMessage.Location = New System.Drawing.Point(25, 139)
        Me.lblAddTeamMessage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAddTeamMessage.Name = "lblAddTeamMessage"
        Me.lblAddTeamMessage.Size = New System.Drawing.Size(0, 17)
        Me.lblAddTeamMessage.TabIndex = 21
        '
        'btnSave
        '
        Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSave.Location = New System.Drawing.Point(319, 129)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(136, 34)
        Me.btnSave.TabIndex = 18
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRefresh.Location = New System.Drawing.Point(452, 129)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(136, 34)
        Me.btnRefresh.TabIndex = 19
        Me.btnRefresh.Text = "re&Fresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'txtADLName
        '
        Me.txtADLName.Location = New System.Drawing.Point(483, 97)
        Me.txtADLName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtADLName.Name = "txtADLName"
        Me.txtADLName.Size = New System.Drawing.Size(237, 22)
        Me.txtADLName.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(355, 97)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 17)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "AD L-Name"
        '
        'txtADFName
        '
        Me.txtADFName.Location = New System.Drawing.Point(172, 94)
        Me.txtADFName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtADFName.Name = "txtADFName"
        Me.txtADFName.Size = New System.Drawing.Size(164, 22)
        Me.txtADFName.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 97)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 17)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "AD F-Name"
        '
        'txtCoachLName
        '
        Me.txtCoachLName.Location = New System.Drawing.Point(483, 64)
        Me.txtCoachLName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCoachLName.Name = "txtCoachLName"
        Me.txtCoachLName.Size = New System.Drawing.Size(237, 22)
        Me.txtCoachLName.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(355, 68)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Coach L-Name"
        '
        'txtCoachFName
        '
        Me.txtCoachFName.Location = New System.Drawing.Point(172, 60)
        Me.txtCoachFName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCoachFName.Name = "txtCoachFName"
        Me.txtCoachFName.Size = New System.Drawing.Size(164, 22)
        Me.txtCoachFName.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 68)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Coach F-Name"
        '
        'txtSchoolName
        '
        Me.txtSchoolName.Location = New System.Drawing.Point(483, 30)
        Me.txtSchoolName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSchoolName.Name = "txtSchoolName"
        Me.txtSchoolName.Size = New System.Drawing.Size(237, 22)
        Me.txtSchoolName.TabIndex = 9
        '
        'txtSchoolCode
        '
        Me.txtSchoolCode.Location = New System.Drawing.Point(172, 30)
        Me.txtSchoolCode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSchoolCode.Name = "txtSchoolCode"
        Me.txtSchoolCode.Size = New System.Drawing.Size(77, 22)
        Me.txtSchoolCode.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(355, 33)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "School Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 33)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "School Code"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(585, 129)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(136, 34)
        Me.btnCancel.TabIndex = 20
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmRM1000
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 446)
        Me.Controls.Add(Me.grpCommand)
        Me.Controls.Add(Me.groAdd)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.groPath)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstTeam)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmRM1000"
        Me.Text = "Race Mgr-1000-Team Mgnt-Cedric Mulumba"
        Me.grpCommand.ResumeLayout(False)
        Me.groPath.ResumeLayout(False)
        Me.groPath.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groAdd.ResumeLayout(False)
        Me.groAdd.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpCommand As System.Windows.Forms.GroupBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnDeleteTeam As System.Windows.Forms.Button
    Friend WithEvents btnAddRunners As System.Windows.Forms.Button
    Friend WithEvents btnLoadTeams As System.Windows.Forms.Button
    Friend WithEvents lstTeam As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents groPath As System.Windows.Forms.GroupBox
    Friend WithEvents txtFilePath As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents groAdd As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtCoachFName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSchoolName As System.Windows.Forms.TextBox
    Friend WithEvents txtSchoolCode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtADLName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtADFName As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCoachLName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblAddTeamMessage As System.Windows.Forms.Label
End Class
