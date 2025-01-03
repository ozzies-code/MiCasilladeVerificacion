# MiCasilladeVerificacion

# Descripcion

 Este proyecto consiste en el desarrollo de una aplicacion que emplea
 casillas de verificacion para hacer invisbles las imagenes contenidas
 en objetos Picture Box dependiendo de la activacion o desactivacion de 
 cada casilla.
 
 # Actualizacion: 03/01/2025
 # Hora: 16:58

Detalles técnicos del proyecto:
Idioma: Visual Basic.NET
Versión del framework: 4.7.2

# MyCheckBox

# Description

This project involves the development of an application that uses
checkboxes to make the images contained in Picture Box objects invisible
depending on the activation or deactivation of each box.

# Update: 01/03/2025
# Time: 16:58

Technical details of the project:
Language: Visual Basic.NET
Framework version: 4.7.2

![imagen](https://github.com/user-attachments/assets/d59ea2a3-449e-4f06-afb6-5fbfc21401c6)

Code of the Project:

Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Form1
    Private Sub chCalculadora_CheckedChanged(sender As Object, e As EventArgs) Handles chCalculadora.CheckedChanged

        ' Si el estado del control es 1, se carga la imagen de la calculadora
        ' en el PictureBox pbCalculadora y se hace visible. En caso contrario,
        ' se oculta el PictureBox.
        If chCalculadora.CheckState = 1 Then
            pbCalculadora.Image = System.Drawing.Image.FromFile _
                ("C:\Users\oswal\Desktop\Archivos de practica\cap03\calcultr.bmp")
            pbCalculadora.Visible = True
        Else
            pbCalculadora.Visible = False
        End If
    End Sub

    Private Sub chCopiadora_CheckedChanged(sender As Object, e As EventArgs) Handles chCopiadora.CheckedChanged

        ' Si el estado del control es 1, se carga la imagen de la calculadora
        ' en el PictureBox pbCalculadora y se hace visible. En caso contrario,
        ' se oculta el PictureBox.

        If chCopiadora.CheckState = 1 Then
            pbCopiadora.Image = System.Drawing.Image.FromFile _
                ("C:\Users\oswal\Desktop\Archivos de practica\cap03\copymach.bmp")
            pbCopiadora.Visible = True
        Else
            pbCopiadora.Visible = False
        End If
    End Sub
End Class
