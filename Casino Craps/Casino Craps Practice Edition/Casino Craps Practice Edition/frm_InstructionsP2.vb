﻿'Assignment 5 - Casino Craps
'By: Maor Gornik (ICS3U)
'Date: 26 of April, 2018

Public Class frm_InstructionsP2
    Private Sub btn_Next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Next.Click
        'Hides the current form and opens the third part of the instructions
        Me.Refresh()
        Me.Hide()
        frm_InstructionsP3.Visible = True
    End Sub

    Private Sub btn_Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Back.Click
        'Hides the current form and goes one step back
        Me.Refresh()
        Me.Hide()
        frm_Instructions.Visible = True
    End Sub
End Class