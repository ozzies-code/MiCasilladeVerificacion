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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.chCalculadora = New System.Windows.Forms.CheckBox()
        Me.chCopiadora = New System.Windows.Forms.CheckBox()
        Me.pbCalculadora = New System.Windows.Forms.PictureBox()
        Me.pbCopiadora = New System.Windows.Forms.PictureBox()
        CType(Me.pbCalculadora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCopiadora, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chCalculadora
        '
        Me.chCalculadora.AutoSize = True
        Me.chCalculadora.Checked = True
        Me.chCalculadora.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chCalculadora.Font = New System.Drawing.Font("Cascadia Code", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chCalculadora.Location = New System.Drawing.Point(12, 12)
        Me.chCalculadora.Name = "chCalculadora"
        Me.chCalculadora.Size = New System.Drawing.Size(128, 25)
        Me.chCalculadora.TabIndex = 0
        Me.chCalculadora.Text = "Calculadora"
        Me.chCalculadora.UseVisualStyleBackColor = True
        '
        'chCopiadora
        '
        Me.chCopiadora.AutoSize = True
        Me.chCopiadora.Font = New System.Drawing.Font("Cascadia Code", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chCopiadora.Location = New System.Drawing.Point(12, 52)
        Me.chCopiadora.Name = "chCopiadora"
        Me.chCopiadora.Size = New System.Drawing.Size(110, 25)
        Me.chCopiadora.TabIndex = 1
        Me.chCopiadora.Text = "Copiadora"
        Me.chCopiadora.UseVisualStyleBackColor = True
        '
        'pbCalculadora
        '
        Me.pbCalculadora.Image = CType(resources.GetObject("pbCalculadora.Image"), System.Drawing.Image)
        Me.pbCalculadora.Location = New System.Drawing.Point(12, 96)
        Me.pbCalculadora.Name = "pbCalculadora"
        Me.pbCalculadora.Size = New System.Drawing.Size(110, 131)
        Me.pbCalculadora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCalculadora.TabIndex = 2
        Me.pbCalculadora.TabStop = False
        '
        'pbCopiadora
        '
        Me.pbCopiadora.Location = New System.Drawing.Point(168, 96)
        Me.pbCopiadora.Name = "pbCopiadora"
        Me.pbCopiadora.Size = New System.Drawing.Size(100, 131)
        Me.pbCopiadora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCopiadora.TabIndex = 3
        Me.pbCopiadora.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(284, 244)
        Me.Controls.Add(Me.pbCopiadora)
        Me.Controls.Add(Me.pbCalculadora)
        Me.Controls.Add(Me.chCopiadora)
        Me.Controls.Add(Me.chCalculadora)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Form1"
        Me.Text = "Casilla de Verificacion"
        CType(Me.pbCalculadora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCopiadora, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chCalculadora As CheckBox
    Friend WithEvents chCopiadora As CheckBox
    Friend WithEvents pbCalculadora As PictureBox
    Friend WithEvents pbCopiadora As PictureBox
End Class
