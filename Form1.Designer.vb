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
        Me.Txt_Input = New System.Windows.Forms.TextBox()
        Me.Txt_Res = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Txt_Input
        '
        Me.Txt_Input.Location = New System.Drawing.Point(33, 28)
        Me.Txt_Input.Multiline = True
        Me.Txt_Input.Name = "Txt_Input"
        Me.Txt_Input.Size = New System.Drawing.Size(731, 124)
        Me.Txt_Input.TabIndex = 1
        '
        'Txt_Res
        '
        Me.Txt_Res.AutoSize = True
        Me.Txt_Res.Location = New System.Drawing.Point(723, 196)
        Me.Txt_Res.Name = "Txt_Res"
        Me.Txt_Res.Size = New System.Drawing.Size(41, 15)
        Me.Txt_Res.TabIndex = 2
        Me.Txt_Res.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Txt_Res)
        Me.Controls.Add(Me.Txt_Input)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txt_Input As TextBox
    Friend WithEvents Txt_Res As Label
End Class
