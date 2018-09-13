Imports System.Data.OleDb

Public Class FrmListadoGeneral

    Private Sub BtnListado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnListado.Click
        Dim conexion As String
        conexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Juan\Documents\Matrices.accdb"
        'traigo datos de acces
        Dim DA1 As New OleDbDataAdapter("select * from Transportistas", conexion)
        Dim DS1 As New DataSet
        DA1.Fill(DS1)
        GRLListadoTransportistas.DataSource = DS1.Tables(0)
    End Sub

    Private Sub BtnListarviajes_Click(sender As System.Object, e As System.EventArgs) Handles BtnListarviajes.Click
        Dim conexion As String
        conexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Juan\Documents\Matrices.accdb"
        'traigo datos de acces
        Dim DA1 As New OleDbDataAdapter("select * from viajes", conexion)
        Dim DS1 As New DataSet
        DA1.Fill(DS1)
        GRLListadoTransportistas.DataSource = DS1.Tables(0)
    End Sub

    Private Sub FrmListadoGeneral_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class