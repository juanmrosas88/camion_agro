<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListadoGeneral
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
        Me.BtnListado = New System.Windows.Forms.Button()
        Me.GRLListadoTransportistas = New System.Windows.Forms.DataGridView()
        Me.BtnListarviajes = New System.Windows.Forms.Button()
        CType(Me.GRLListadoTransportistas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnListado
        '
        Me.BtnListado.Location = New System.Drawing.Point(12, 179)
        Me.BtnListado.Name = "BtnListado"
        Me.BtnListado.Size = New System.Drawing.Size(99, 49)
        Me.BtnListado.TabIndex = 0
        Me.BtnListado.Text = "Listar todos los transportistas"
        Me.BtnListado.UseVisualStyleBackColor = True
        '
        'GRLListadoTransportistas
        '
        Me.GRLListadoTransportistas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.GRLListadoTransportistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GRLListadoTransportistas.Location = New System.Drawing.Point(12, 12)
        Me.GRLListadoTransportistas.Name = "GRLListadoTransportistas"
        Me.GRLListadoTransportistas.Size = New System.Drawing.Size(301, 161)
        Me.GRLListadoTransportistas.TabIndex = 1
        '
        'BtnListarviajes
        '
        Me.BtnListarviajes.Location = New System.Drawing.Point(117, 179)
        Me.BtnListarviajes.Name = "BtnListarviajes"
        Me.BtnListarviajes.Size = New System.Drawing.Size(99, 49)
        Me.BtnListarviajes.TabIndex = 2
        Me.BtnListarviajes.Text = "Listar todos los viajes"
        Me.BtnListarviajes.UseVisualStyleBackColor = True
        '
        'FrmListadoGeneral
        '
        Me.AcceptButton = Me.BtnListado
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 248)
        Me.Controls.Add(Me.BtnListarviajes)
        Me.Controls.Add(Me.GRLListadoTransportistas)
        Me.Controls.Add(Me.BtnListado)
        Me.Name = "FrmListadoGeneral"
        Me.Text = "Listados Generales"
        CType(Me.GRLListadoTransportistas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnListado As System.Windows.Forms.Button
    Friend WithEvents GRLListadoTransportistas As System.Windows.Forms.DataGridView
    Friend WithEvents BtnListarviajes As System.Windows.Forms.Button
End Class
