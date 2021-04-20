<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.Btn3 = New System.Windows.Forms.Button()
        Me.Btn4 = New System.Windows.Forms.Button()
        Me.TxtBox1 = New System.Windows.Forms.TextBox()
        Me.TxtBox2 = New System.Windows.Forms.TextBox()
        Me.Lbl1 = New System.Windows.Forms.Label()
        Me.Lbl2 = New System.Windows.Forms.Label()
        Me.Lbl3 = New System.Windows.Forms.Label()
        Me.Lbl4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Btn1
        '
        Me.Btn1.Location = New System.Drawing.Point(59, 48)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(75, 23)
        Me.Btn1.TabIndex = 0
        Me.Btn1.Text = "Button1"
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'Btn2
        '
        Me.Btn2.Location = New System.Drawing.Point(59, 114)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(75, 23)
        Me.Btn2.TabIndex = 1
        Me.Btn2.Text = "Button2"
        Me.Btn2.UseVisualStyleBackColor = True
        '
        'Btn3
        '
        Me.Btn3.Location = New System.Drawing.Point(59, 171)
        Me.Btn3.Name = "Btn3"
        Me.Btn3.Size = New System.Drawing.Size(75, 23)
        Me.Btn3.TabIndex = 2
        Me.Btn3.Text = "Button3"
        Me.Btn3.UseVisualStyleBackColor = True
        '
        'Btn4
        '
        Me.Btn4.Location = New System.Drawing.Point(59, 236)
        Me.Btn4.Name = "Btn4"
        Me.Btn4.Size = New System.Drawing.Size(75, 23)
        Me.Btn4.TabIndex = 3
        Me.Btn4.Text = "Button4"
        Me.Btn4.UseVisualStyleBackColor = True
        '
        'TxtBox1
        '
        Me.TxtBox1.Location = New System.Drawing.Point(304, 115)
        Me.TxtBox1.Name = "TxtBox1"
        Me.TxtBox1.Size = New System.Drawing.Size(100, 22)
        Me.TxtBox1.TabIndex = 4
        '
        'TxtBox2
        '
        Me.TxtBox2.Location = New System.Drawing.Point(304, 234)
        Me.TxtBox2.Name = "TxtBox2"
        Me.TxtBox2.Size = New System.Drawing.Size(100, 22)
        Me.TxtBox2.TabIndex = 5
        '
        'Lbl1
        '
        Me.Lbl1.AutoSize = True
        Me.Lbl1.Location = New System.Drawing.Point(197, 48)
        Me.Lbl1.Name = "Lbl1"
        Me.Lbl1.Size = New System.Drawing.Size(51, 17)
        Me.Lbl1.TabIndex = 6
        Me.Lbl1.Text = "Label1"
        '
        'Lbl2
        '
        Me.Lbl2.AutoSize = True
        Me.Lbl2.Location = New System.Drawing.Point(197, 114)
        Me.Lbl2.Name = "Lbl2"
        Me.Lbl2.Size = New System.Drawing.Size(51, 17)
        Me.Lbl2.TabIndex = 7
        Me.Lbl2.Text = "Label2"
        '
        'Lbl3
        '
        Me.Lbl3.AutoSize = True
        Me.Lbl3.Location = New System.Drawing.Point(197, 177)
        Me.Lbl3.Name = "Lbl3"
        Me.Lbl3.Size = New System.Drawing.Size(51, 17)
        Me.Lbl3.TabIndex = 8
        Me.Lbl3.Text = "Label3"
        '
        'Lbl4
        '
        Me.Lbl4.AutoSize = True
        Me.Lbl4.Location = New System.Drawing.Point(197, 239)
        Me.Lbl4.Name = "Lbl4"
        Me.Lbl4.Size = New System.Drawing.Size(51, 17)
        Me.Lbl4.TabIndex = 9
        Me.Lbl4.Text = "Label4"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Lbl4)
        Me.Controls.Add(Me.Lbl3)
        Me.Controls.Add(Me.Lbl2)
        Me.Controls.Add(Me.Lbl1)
        Me.Controls.Add(Me.TxtBox2)
        Me.Controls.Add(Me.TxtBox1)
        Me.Controls.Add(Me.Btn4)
        Me.Controls.Add(Me.Btn3)
        Me.Controls.Add(Me.Btn2)
        Me.Controls.Add(Me.Btn1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn1 As Button
    Friend WithEvents Btn2 As Button
    Friend WithEvents Btn3 As Button
    Friend WithEvents Btn4 As Button
    Friend WithEvents TxtBox1 As TextBox
    Friend WithEvents TxtBox2 As TextBox
    Friend WithEvents Lbl1 As Label
    Friend WithEvents Lbl2 As Label
    Friend WithEvents Lbl3 As Label
    Friend WithEvents Lbl4 As Label
End Class
