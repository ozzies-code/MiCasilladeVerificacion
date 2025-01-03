Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Form1
    Private Sub chCalculadora_CheckedChanged(sender As Object, e As EventArgs) Handles chCalculadora.CheckedChanged
        If chCalculadora.CheckState = 1 Then
            pbCalculadora.Image = System.Drawing.Image.FromFile _
                ("C:\Users\oswal\Desktop\Archivos de practica\cap03\calcultr.bmp")
            pbCalculadora.Visible = True
        Else
            pbCalculadora.Visible = False
        End If
    End Sub

    Private Sub chCopiadora_CheckedChanged(sender As Object, e As EventArgs) Handles chCopiadora.CheckedChanged
        If chCopiadora.CheckState = 1 Then
            pbCopiadora.Image = System.Drawing.Image.FromFile _
                ("C:\Users\oswal\Desktop\Archivos de practica\cap03\copymach.bmp")
            pbCopiadora.Visible = True
        Else
            pbCopiadora.Visible = False
        End If
    End Sub
End Class
