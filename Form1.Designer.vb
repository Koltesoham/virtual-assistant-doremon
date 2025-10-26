<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        lblResponse = New Label()
        btnExecute = New Button()
        txtCommand = New TextBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' lblResponse
        ' 
        lblResponse.AutoSize = True
        lblResponse.BackColor = SystemColors.ActiveCaptionText
        lblResponse.ForeColor = SystemColors.ButtonFace
        lblResponse.Location = New Point(174, 206)
        lblResponse.Name = "lblResponse"
        lblResponse.Size = New Size(0, 15)
        lblResponse.TabIndex = 0
        ' 
        ' btnExecute
        ' 
        btnExecute.BackColor = Color.Lime
        btnExecute.Location = New Point(561, 344)
        btnExecute.Name = "btnExecute"
        btnExecute.Size = New Size(75, 23)
        btnExecute.TabIndex = 1
        btnExecute.Text = "send"
        btnExecute.UseVisualStyleBackColor = False
        ' 
        ' txtCommand
        ' 
        txtCommand.BackColor = Color.Silver
        txtCommand.Location = New Point(12, 344)
        txtCommand.Multiline = True
        txtCommand.Name = "txtCommand"
        txtCommand.Size = New Size(543, 23)
        txtCommand.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Snap ITC", 36F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Blue
        Label1.Location = New Point(174, 39)
        Label1.MaximumSize = New Size(1000, 1000)
        Label1.Name = "Label1"
        Label1.Size = New Size(349, 63)
        Label1.TabIndex = 3
        Label1.Text = "DOREMON "
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(663, 409)
        Controls.Add(Label1)
        Controls.Add(txtCommand)
        Controls.Add(btnExecute)
        Controls.Add(lblResponse)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        Text = "DOREMON"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblResponse As Label
    Friend WithEvents btnExecute As Button
    Friend WithEvents txtCommand As TextBox
    Friend WithEvents Label1 As Label

End Class
