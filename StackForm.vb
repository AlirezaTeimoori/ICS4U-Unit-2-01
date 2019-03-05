Option Strict On
Option Explicit On
'Created on: Sept-2009
'Created by: Mr. Coxall
'Created for: ICS4U
'This program uses the MrCoxallStack class

Public Class StackForm

    ' this is the declaration of my stack
    Dim aStack As MrCoxallStack

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        ' place a value on the stack
        Dim aNumber As Integer

        aNumber = CInt(Me.txtNumber.Text)

        aStack.Push(aNumber)
    End Sub

    Private Sub StackForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' instantiat the stack
        aStack = New MrCoxallStack
    End Sub

End Class
