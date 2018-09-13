<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDistanciayprecio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDistanciayprecio))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblPrecioActual = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.ChkId = New System.Windows.Forms.CheckBox()
        Me.BtnCotizacion = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblprecioxkm = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txtkmhechos = New System.Windows.Forms.TextBox()
        Me.CboTransportista = New System.Windows.Forms.ComboBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.GrlDistanciaMenos = New System.Windows.Forms.DataGridView()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.BtnBorrarTodos = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GrlDistanciaMenos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblPrecioActual)
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.Controls.Add(Me.txtId)
        Me.GroupBox1.Controls.Add(Me.ChkId)
        Me.GroupBox1.Controls.Add(Me.BtnCotizacion)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblprecioxkm)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Txtkmhechos)
        Me.GroupBox1.Controls.Add(Me.CboTransportista)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(286, 147)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingresar distancia recorrida"
        '
        'lblPrecioActual
        '
        Me.lblPrecioActual.AutoSize = True
        Me.lblPrecioActual.Enabled = False
        Me.lblPrecioActual.Location = New System.Drawing.Point(90, 110)
        Me.lblPrecioActual.Name = "lblPrecioActual"
        Me.lblPrecioActual.Size = New System.Drawing.Size(39, 13)
        Me.lblPrecioActual.TabIndex = 24
        Me.lblPrecioActual.Text = "Label1"
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(192, 17)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 23
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(194, 73)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(39, 20)
        Me.txtId.TabIndex = 22
        '
        'ChkId
        '
        Me.ChkId.AutoSize = True
        Me.ChkId.Location = New System.Drawing.Point(9, 75)
        Me.ChkId.Name = "ChkId"
        Me.ChkId.Size = New System.Drawing.Size(170, 17)
        Me.ChkId.TabIndex = 21
        Me.ChkId.Text = "Modificar/Buscar/Borrar por Id"
        Me.ChkId.UseVisualStyleBackColor = True
        '
        'BtnCotizacion
        '
        Me.BtnCotizacion.Location = New System.Drawing.Point(9, 99)
        Me.BtnCotizacion.Name = "BtnCotizacion"
        Me.BtnCotizacion.Size = New System.Drawing.Size(75, 34)
        Me.BtnCotizacion.TabIndex = 20
        Me.BtnCotizacion.Text = "Ir a cotizacion KM"
        Me.BtnCotizacion.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Km hechos:"
        '
        'lblprecioxkm
        '
        Me.lblprecioxkm.AutoSize = True
        Me.lblprecioxkm.Location = New System.Drawing.Point(191, 49)
        Me.lblprecioxkm.Name = "lblprecioxkm"
        Me.lblprecioxkm.Size = New System.Drawing.Size(39, 13)
        Me.lblprecioxkm.TabIndex = 15
        Me.lblprecioxkm.Text = "Label4"
        Me.lblprecioxkm.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Transportistas:"
        '
        'Txtkmhechos
        '
        Me.Txtkmhechos.Location = New System.Drawing.Point(85, 46)
        Me.Txtkmhechos.Name = "Txtkmhechos"
        Me.Txtkmhechos.Size = New System.Drawing.Size(100, 20)
        Me.Txtkmhechos.TabIndex = 14
        '
        'CboTransportista
        '
        Me.CboTransportista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTransportista.FormattingEnabled = True
        Me.CboTransportista.Location = New System.Drawing.Point(85, 19)
        Me.CboTransportista.Name = "CboTransportista"
        Me.CboTransportista.Size = New System.Drawing.Size(100, 21)
        Me.CboTransportista.TabIndex = 12
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Location = New System.Drawing.Point(21, 183)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(286, 35)
        Me.BtnGuardar.TabIndex = 1
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'GrlDistanciaMenos
        '
        Me.GrlDistanciaMenos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.GrlDistanciaMenos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrlDistanciaMenos.Location = New System.Drawing.Point(330, 12)
        Me.GrlDistanciaMenos.Name = "GrlDistanciaMenos"
        Me.GrlDistanciaMenos.Size = New System.Drawing.Size(308, 320)
        Me.GrlDistanciaMenos.TabIndex = 3
        '
        'BtnBorrar
        '
        Me.BtnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBorrar.Location = New System.Drawing.Point(21, 306)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(286, 35)
        Me.BtnBorrar.TabIndex = 4
        Me.BtnBorrar.Text = "Borrar por ID"
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'BtnBorrarTodos
        '
        Me.BtnBorrarTodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBorrarTodos.Location = New System.Drawing.Point(21, 347)
        Me.BtnBorrarTodos.Name = "BtnBorrarTodos"
        Me.BtnBorrarTodos.Size = New System.Drawing.Size(286, 35)
        Me.BtnBorrarTodos.TabIndex = 5
        Me.BtnBorrarTodos.Text = "Borrar todos"
        Me.BtnBorrarTodos.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.Location = New System.Drawing.Point(21, 224)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(286, 35)
        Me.BtnModificar.TabIndex = 6
        Me.BtnModificar.Text = "Modificar por ID"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.Location = New System.Drawing.Point(21, 265)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(286, 35)
        Me.BtnBuscar.TabIndex = 7
        Me.BtnBuscar.Text = "Buscar por ID"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'FrmDistanciayprecio
        '
        Me.AcceptButton = Me.BtnGuardar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(654, 403)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnBorrarTodos)
        Me.Controls.Add(Me.BtnBorrar)
        Me.Controls.Add(Me.GrlDistanciaMenos)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmDistanciayprecio"
        Me.ShowIcon = False
        Me.Text = "Distancia y precio"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GrlDistanciaMenos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblprecioxkm As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Txtkmhechos As System.Windows.Forms.TextBox
    Friend WithEvents CboTransportista As System.Windows.Forms.ComboBox
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GrlDistanciaMenos As System.Windows.Forms.DataGridView
    Friend WithEvents BtnBorrar As System.Windows.Forms.Button
    Friend WithEvents BtnCotizacion As System.Windows.Forms.Button
    Friend WithEvents BtnBorrarTodos As System.Windows.Forms.Button
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents ChkId As System.Windows.Forms.CheckBox
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents BtnModificar As System.Windows.Forms.Button
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents lblPrecioActual As System.Windows.Forms.Label
End Class
