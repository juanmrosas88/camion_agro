<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCargarusuariosnuevos
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
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.Txtnombrenuevo = New System.Windows.Forms.TextBox()
        Me.Txtcontranueva = New System.Windows.Forms.TextBox()
        Me.txtrepetircontra = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(174, 103)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelar.TabIndex = 0
        Me.BtnCancelar.Text = "&Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(40, 103)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAceptar.TabIndex = 1
        Me.BtnAceptar.Text = "&Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'Txtnombrenuevo
        '
        Me.Txtnombrenuevo.Location = New System.Drawing.Point(149, 14)
        Me.Txtnombrenuevo.Name = "Txtnombrenuevo"
        Me.Txtnombrenuevo.Size = New System.Drawing.Size(100, 20)
        Me.Txtnombrenuevo.TabIndex = 2
        '
        'Txtcontranueva
        '
        Me.Txtcontranueva.Location = New System.Drawing.Point(149, 40)
        Me.Txtcontranueva.Name = "Txtcontranueva"
        Me.Txtcontranueva.Size = New System.Drawing.Size(100, 20)
        Me.Txtcontranueva.TabIndex = 3
        '
        'txtrepetircontra
        '
        Me.txtrepetircontra.Location = New System.Drawing.Point(149, 66)
        Me.txtrepetircontra.Name = "txtrepetircontra"
        Me.txtrepetircontra.Size = New System.Drawing.Size(100, 20)
        Me.txtrepetircontra.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nombre del nuevo usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(82, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Contraseña"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Repita contraseña"
        '
        'FrmCargarusuariosnuevos
        '
        Me.AcceptButton = Me.BtnAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 151)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtrepetircontra)
        Me.Controls.Add(Me.Txtcontranueva)
        Me.Controls.Add(Me.Txtnombrenuevo)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Name = "FrmCargarusuariosnuevos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cargar usuarios nuevos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents Txtnombrenuevo As System.Windows.Forms.TextBox
    Friend WithEvents Txtcontranueva As System.Windows.Forms.TextBox
    Friend WithEvents txtrepetircontra As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
