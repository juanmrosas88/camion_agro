<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIngresoTransportistas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmIngresoTransportistas))
        Me.TxtIngreseNombre = New System.Windows.Forms.TextBox()
        Me.BtnGuardarMostrar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Btnborrartodos = New System.Windows.Forms.Button()
        Me.Btncargarkm = New System.Windows.Forms.Button()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.GrlGrillaTransportistas = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GrlGrillaTransportistas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtIngreseNombre
        '
        Me.TxtIngreseNombre.Location = New System.Drawing.Point(134, 23)
        Me.TxtIngreseNombre.Name = "TxtIngreseNombre"
        Me.TxtIngreseNombre.Size = New System.Drawing.Size(117, 20)
        Me.TxtIngreseNombre.TabIndex = 1
        '
        'BtnGuardarMostrar
        '
        Me.BtnGuardarMostrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardarMostrar.Location = New System.Drawing.Point(133, 89)
        Me.BtnGuardarMostrar.Name = "BtnGuardarMostrar"
        Me.BtnGuardarMostrar.Size = New System.Drawing.Size(121, 46)
        Me.BtnGuardarMostrar.TabIndex = 3
        Me.BtnGuardarMostrar.Text = "Guardar y mostrar"
        Me.BtnGuardarMostrar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Ingrese nombre:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDNI)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Btnborrartodos)
        Me.GroupBox1.Controls.Add(Me.Btncargarkm)
        Me.GroupBox1.Controls.Add(Me.BtnBorrar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.BtnGuardarMostrar)
        Me.GroupBox1.Controls.Add(Me.TxtIngreseNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(271, 218)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese datos del transportista"
        '
        'Btnborrartodos
        '
        Me.Btnborrartodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnborrartodos.Location = New System.Drawing.Point(7, 141)
        Me.Btnborrartodos.Name = "Btnborrartodos"
        Me.Btnborrartodos.Size = New System.Drawing.Size(121, 46)
        Me.Btnborrartodos.TabIndex = 14
        Me.Btnborrartodos.Text = "Borrar TODOS"
        Me.Btnborrartodos.UseVisualStyleBackColor = True
        '
        'Btncargarkm
        '
        Me.Btncargarkm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btncargarkm.Location = New System.Drawing.Point(7, 89)
        Me.Btncargarkm.Name = "Btncargarkm"
        Me.Btncargarkm.Size = New System.Drawing.Size(121, 46)
        Me.Btncargarkm.TabIndex = 13
        Me.Btncargarkm.Text = "Ir a: Distancia y precio"
        Me.Btncargarkm.UseVisualStyleBackColor = True
        '
        'BtnBorrar
        '
        Me.BtnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBorrar.Location = New System.Drawing.Point(133, 141)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(121, 46)
        Me.BtnBorrar.TabIndex = 12
        Me.BtnBorrar.Text = "Borrar transportista"
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'GrlGrillaTransportistas
        '
        Me.GrlGrillaTransportistas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.GrlGrillaTransportistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrlGrillaTransportistas.Location = New System.Drawing.Point(305, 12)
        Me.GrlGrillaTransportistas.Name = "GrlGrillaTransportistas"
        Me.GrlGrillaTransportistas.Size = New System.Drawing.Size(301, 218)
        Me.GrlGrillaTransportistas.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 16)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Ingrese DNI:"
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(133, 49)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(117, 20)
        Me.txtDNI.TabIndex = 16
        '
        'FrmIngresoTransportistas
        '
        Me.AcceptButton = Me.BtnGuardarMostrar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(622, 258)
        Me.Controls.Add(Me.GrlGrillaTransportistas)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmIngresoTransportistas"
        Me.ShowIcon = False
        Me.Text = "Ingreso Transportistas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GrlGrillaTransportistas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxtIngreseNombre As System.Windows.Forms.TextBox
    Friend WithEvents BtnGuardarMostrar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnBorrar As System.Windows.Forms.Button
    Friend WithEvents Btncargarkm As System.Windows.Forms.Button
    Friend WithEvents Btnborrartodos As System.Windows.Forms.Button
    Friend WithEvents GrlGrillaTransportistas As System.Windows.Forms.DataGridView
    Friend WithEvents txtDNI As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
