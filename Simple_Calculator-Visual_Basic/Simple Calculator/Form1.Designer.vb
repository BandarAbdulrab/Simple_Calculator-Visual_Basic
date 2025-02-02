<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        txtDisplay = New TextBox()
        btn1 = New Button()
        btn2 = New Button()
        btn3 = New Button()
        btn4 = New Button()
        btn5 = New Button()
        btn6 = New Button()
        btn7 = New Button()
        btn8 = New Button()
        btn9 = New Button()
        btn0 = New Button()
        btnAdd = New Button()
        btnSubtract = New Button()
        btnMultiply = New Button()
        btnDivide = New Button()
        btnEquals = New Button()
        btnClear = New Button()
        btnExit = New Button()
        lstHistory = New ListBox()
        btnBackspace = New Button()
        btnDecimal = New Button()
        SuspendLayout()
        ' 
        ' txtDisplay
        ' 
        txtDisplay.Location = New Point(256, 94)
        txtDisplay.Name = "txtDisplay"
        txtDisplay.ReadOnly = True
        txtDisplay.Size = New Size(200, 39)
        txtDisplay.TabIndex = 0
        ' 
        ' btn1
        ' 
        btn1.Location = New Point(41, 339)
        btn1.Name = "btn1"
        btn1.Size = New Size(150, 46)
        btn1.TabIndex = 1
        btn1.Text = "1"
        btn1.UseVisualStyleBackColor = True
        ' 
        ' btn2
        ' 
        btn2.Location = New Point(197, 339)
        btn2.Name = "btn2"
        btn2.Size = New Size(150, 46)
        btn2.TabIndex = 2
        btn2.Text = "2"
        btn2.UseVisualStyleBackColor = True
        ' 
        ' btn3
        ' 
        btn3.Location = New Point(353, 339)
        btn3.Name = "btn3"
        btn3.Size = New Size(150, 46)
        btn3.TabIndex = 3
        btn3.Text = "3"
        btn3.UseVisualStyleBackColor = True
        ' 
        ' btn4
        ' 
        btn4.Location = New Point(41, 287)
        btn4.Name = "btn4"
        btn4.Size = New Size(150, 46)
        btn4.TabIndex = 4
        btn4.Text = "4"
        btn4.UseVisualStyleBackColor = True
        ' 
        ' btn5
        ' 
        btn5.Location = New Point(197, 287)
        btn5.Name = "btn5"
        btn5.Size = New Size(150, 46)
        btn5.TabIndex = 5
        btn5.Text = "5"
        btn5.UseVisualStyleBackColor = True
        ' 
        ' btn6
        ' 
        btn6.Location = New Point(353, 287)
        btn6.Name = "btn6"
        btn6.Size = New Size(150, 46)
        btn6.TabIndex = 6
        btn6.Text = "6"
        btn6.UseVisualStyleBackColor = True
        ' 
        ' btn7
        ' 
        btn7.Location = New Point(41, 235)
        btn7.Name = "btn7"
        btn7.Size = New Size(150, 46)
        btn7.TabIndex = 7
        btn7.Text = "7"
        btn7.UseVisualStyleBackColor = True
        ' 
        ' btn8
        ' 
        btn8.Location = New Point(197, 235)
        btn8.Name = "btn8"
        btn8.Size = New Size(150, 46)
        btn8.TabIndex = 8
        btn8.Text = "8"
        btn8.UseVisualStyleBackColor = True
        ' 
        ' btn9
        ' 
        btn9.Location = New Point(353, 235)
        btn9.Name = "btn9"
        btn9.Size = New Size(150, 46)
        btn9.TabIndex = 9
        btn9.Text = "9"
        btn9.UseVisualStyleBackColor = True
        ' 
        ' btn0
        ' 
        btn0.Location = New Point(197, 391)
        btn0.Name = "btn0"
        btn0.Size = New Size(150, 46)
        btn0.TabIndex = 10
        btn0.Text = "0"
        btn0.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(509, 339)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(150, 46)
        btnAdd.TabIndex = 11
        btnAdd.Text = "+"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnSubtract
        ' 
        btnSubtract.Location = New Point(509, 287)
        btnSubtract.Name = "btnSubtract"
        btnSubtract.Size = New Size(150, 46)
        btnSubtract.TabIndex = 12
        btnSubtract.Text = "-"
        btnSubtract.UseVisualStyleBackColor = True
        ' 
        ' btnMultiply
        ' 
        btnMultiply.Location = New Point(509, 235)
        btnMultiply.Name = "btnMultiply"
        btnMultiply.Size = New Size(150, 46)
        btnMultiply.TabIndex = 13
        btnMultiply.Text = "*"
        btnMultiply.UseVisualStyleBackColor = True
        ' 
        ' btnDivide
        ' 
        btnDivide.Location = New Point(509, 183)
        btnDivide.Name = "btnDivide"
        btnDivide.Size = New Size(150, 46)
        btnDivide.TabIndex = 14
        btnDivide.Text = "/"
        btnDivide.UseVisualStyleBackColor = True
        ' 
        ' btnEquals
        ' 
        btnEquals.Location = New Point(509, 391)
        btnEquals.Name = "btnEquals"
        btnEquals.Size = New Size(150, 46)
        btnEquals.TabIndex = 15
        btnEquals.Text = "="
        btnEquals.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(353, 391)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(150, 46)
        btnClear.TabIndex = 16
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(41, 183)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(150, 46)
        btnExit.TabIndex = 17
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' lstHistory
        ' 
        lstHistory.FormattingEnabled = True
        lstHistory.Location = New Point(246, 471)
        lstHistory.Name = "lstHistory"
        lstHistory.Size = New Size(240, 164)
        lstHistory.TabIndex = 18
        ' 
        ' btnBackspace
        ' 
        btnBackspace.Location = New Point(41, 391)
        btnBackspace.Name = "btnBackspace"
        btnBackspace.Size = New Size(150, 46)
        btnBackspace.TabIndex = 19
        btnBackspace.Text = "←"
        btnBackspace.UseVisualStyleBackColor = True
        ' 
        ' btnDecimal
        ' 
        btnDecimal.Location = New Point(509, 443)
        btnDecimal.Name = "btnDecimal"
        btnDecimal.Size = New Size(150, 46)
        btnDecimal.TabIndex = 20
        btnDecimal.Text = "."
        btnDecimal.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13.0F, 32.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(729, 701)
        Controls.Add(btnDecimal)
        Controls.Add(btnBackspace)
        Controls.Add(lstHistory)
        Controls.Add(btnExit)
        Controls.Add(btnClear)
        Controls.Add(btnEquals)
        Controls.Add(btnDivide)
        Controls.Add(btnMultiply)
        Controls.Add(btnSubtract)
        Controls.Add(btnAdd)
        Controls.Add(btn0)
        Controls.Add(btn9)
        Controls.Add(btn8)
        Controls.Add(btn7)
        Controls.Add(btn6)
        Controls.Add(btn5)
        Controls.Add(btn4)
        Controls.Add(btn3)
        Controls.Add(btn2)
        Controls.Add(btn1)
        Controls.Add(txtDisplay)
        Name = "Form1"
        Text = "/"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtDisplay As TextBox
    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSubtract As Button
    Friend WithEvents btnMultiply As Button
    Friend WithEvents btnDivide As Button
    Friend WithEvents btnEquals As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lstHistory As ListBox
    Friend WithEvents btnBackspace As Button
    Friend WithEvents btnDecimal As Button

End Class
