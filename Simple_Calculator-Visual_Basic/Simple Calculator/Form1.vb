Imports System.Data

Public Class Form1
    ' Handles number and operator button clicks
    Private Sub Button_Click(sender As Object, e As EventArgs)
        Dim button As Button = CType(sender, Button)

        ' Append the clicked button's text to the display
        If txtDisplay.Text = "0" Then
            txtDisplay.Text = button.Text
        Else
            txtDisplay.Text &= button.Text
        End If
    End Sub

    ' Handles the Equals button click
    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles btnEquals.Click
        Try
            ' Evaluate the expression in the display using DataTable.Compute
            Dim result As Double = EvaluateExpression(txtDisplay.Text)
            txtDisplay.Text = result.ToString()

            ' Add the expression and result to the history
            lstHistory.Items.Add($"{txtDisplay.Text} = {result}")
        Catch ex As Exception
            MessageBox.Show("Invalid expression!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDisplay.Text = "0"
        End Try
    End Sub

    ' Evaluate the mathematical expression
    Private Function EvaluateExpression(expression As String) As Double
        Dim table As New DataTable()
        Return Convert.ToDouble(table.Compute(expression, String.Empty))
    End Function

    ' Handles the Clear button click
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDisplay.Text = "0"
    End Sub

    ' Handles the Backspace button click
    Private Sub btnBackspace_Click(sender As Object, e As EventArgs) Handles btnBackspace.Click
        If txtDisplay.Text.Length > 0 Then
            txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1)
        End If
        If txtDisplay.Text = "" Then
            txtDisplay.Text = "0"
        End If
    End Sub

    ' Handles the Exit button click
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    ' Initializes the form and wires up event handlers
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add event handlers for number and operator buttons
        For Each control As Control In Me.Controls
            If TypeOf control Is Button Then
                Dim button As Button = CType(control, Button)

                If IsNumeric(button.Text) OrElse "+-*/.".Contains(button.Text) Then
                    AddHandler button.Click, AddressOf Button_Click
                End If
            End If
        Next
    End Sub
End Class
