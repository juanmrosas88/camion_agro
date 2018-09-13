<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenuPrinc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenuPrinc))
        Me.IngresoDeDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransportistasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DistanciaDelViajeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MuestreoDeEstadisticasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDeTransportistasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CotizaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CotizaciónDelKmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresarUsuariosNuevosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IngresoDeDatosToolStripMenuItem
        '
        Me.IngresoDeDatosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransportistasToolStripMenuItem, Me.DistanciaDelViajeToolStripMenuItem})
        Me.IngresoDeDatosToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IngresoDeDatosToolStripMenuItem.Name = "IngresoDeDatosToolStripMenuItem"
        Me.IngresoDeDatosToolStripMenuItem.Size = New System.Drawing.Size(148, 25)
        Me.IngresoDeDatosToolStripMenuItem.Text = "Ingreso de datos"
        '
        'TransportistasToolStripMenuItem
        '
        Me.TransportistasToolStripMenuItem.Name = "TransportistasToolStripMenuItem"
        Me.TransportistasToolStripMenuItem.Size = New System.Drawing.Size(268, 26)
        Me.TransportistasToolStripMenuItem.Text = "Ingreso de transportistas"
        '
        'DistanciaDelViajeToolStripMenuItem
        '
        Me.DistanciaDelViajeToolStripMenuItem.Name = "DistanciaDelViajeToolStripMenuItem"
        Me.DistanciaDelViajeToolStripMenuItem.Size = New System.Drawing.Size(268, 26)
        Me.DistanciaDelViajeToolStripMenuItem.Text = "Distancia y precio"
        '
        'MuestreoDeEstadisticasToolStripMenuItem
        '
        Me.MuestreoDeEstadisticasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListadoDeTransportistasToolStripMenuItem})
        Me.MuestreoDeEstadisticasToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MuestreoDeEstadisticasToolStripMenuItem.Name = "MuestreoDeEstadisticasToolStripMenuItem"
        Me.MuestreoDeEstadisticasToolStripMenuItem.Size = New System.Drawing.Size(209, 25)
        Me.MuestreoDeEstadisticasToolStripMenuItem.Text = "Muestreo de estadisticas"
        '
        'ListadoDeTransportistasToolStripMenuItem
        '
        Me.ListadoDeTransportistasToolStripMenuItem.Name = "ListadoDeTransportistasToolStripMenuItem"
        Me.ListadoDeTransportistasToolStripMenuItem.Size = New System.Drawing.Size(220, 26)
        Me.ListadoDeTransportistasToolStripMenuItem.Text = "Listados generales"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresoDeDatosToolStripMenuItem, Me.MuestreoDeEstadisticasToolStripMenuItem, Me.CotizaciónToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(925, 29)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CotizaciónToolStripMenuItem
        '
        Me.CotizaciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CotizaciónDelKmToolStripMenuItem, Me.IngresarUsuariosNuevosToolStripMenuItem})
        Me.CotizaciónToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CotizaciónToolStripMenuItem.Name = "CotizaciónToolStripMenuItem"
        Me.CotizaciónToolStripMenuItem.Size = New System.Drawing.Size(253, 25)
        Me.CotizaciónToolStripMenuItem.Text = "Información de Administrador"
        '
        'CotizaciónDelKmToolStripMenuItem
        '
        Me.CotizaciónDelKmToolStripMenuItem.Name = "CotizaciónDelKmToolStripMenuItem"
        Me.CotizaciónDelKmToolStripMenuItem.Size = New System.Drawing.Size(266, 26)
        Me.CotizaciónDelKmToolStripMenuItem.Text = "Cotización del km"
        '
        'IngresarUsuariosNuevosToolStripMenuItem
        '
        Me.IngresarUsuariosNuevosToolStripMenuItem.Name = "IngresarUsuariosNuevosToolStripMenuItem"
        Me.IngresarUsuariosNuevosToolStripMenuItem.Size = New System.Drawing.Size(266, 26)
        Me.IngresarUsuariosNuevosToolStripMenuItem.Text = "Ingresar nuevo usuarios "
        '
        'FrmMenuPrinc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(925, 444)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmMenuPrinc"
        Me.Text = "JC Negocios Agropecuarios"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IngresoDeDatosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransportistasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DistanciaDelViajeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MuestreoDeEstadisticasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ListadoDeTransportistasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CotizaciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CotizaciónDelKmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresarUsuariosNuevosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
