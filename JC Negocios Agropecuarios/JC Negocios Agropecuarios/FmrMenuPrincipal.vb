Public Class FrmMenuPrinc
    Private Sub DistanciaDelViajeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DistanciaDelViajeToolStripMenuItem.Click
        Dim newMDIChild As New FrmDistanciayprecio
        newMDIChild.MdiParent = Me
        newMDIChild.Show()
    End Sub
   
    Private Sub TransportistasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransportistasToolStripMenuItem.Click
        Dim newMDIChild As New FrmIngresoTransportistas
        newMDIChild.MdiParent = Me
        newMDIChild.Show()
    End Sub


    Private Sub FrmMenuPrinc_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        FrmLogin.Close()
    End Sub
    
    Private Sub ListadoDeTransportistasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoDeTransportistasToolStripMenuItem.Click
        Dim newMDIChild As New FrmListadoGeneral
        newMDIChild.MdiParent = Me
        newMDIChild.Show()
    End Sub

    Private Sub CotizaciónDelKmToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CotizaciónDelKmToolStripMenuItem.Click
        Dim newMDIChild As New FrmCotizacion
        newMDIChild.MdiParent = Me
        newMDIChild.Show()
    End Sub

    Private Sub IngresarUsuariosNuevosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngresarUsuariosNuevosToolStripMenuItem.Click
        Dim newMDIChild As New FrmCargarusuariosnuevos
        newMDIChild.MdiParent = Me
        newMDIChild.Show()
    End Sub

    Private Sub FrmMenuPrinc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
