Imports System.Data.OleDb
Public Class FrmDistanciayprecio
    Dim resultado As Integer
    Dim preciototal As String

    Public Sub listar()
        Dim conexion As String
        conexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Juan\Documents\Matrices.accdb"

        Dim DA As New OleDbDataAdapter("select * from viajes", conexion)
        Dim DS As New DataSet
        DA.Fill(DS)
        GrlDistanciaMenos.DataSource = DS.Tables(0)
    End Sub

    Private Sub FrmDistanciayprecio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        listar()
        lblPrecioActual.Text = "El precio actual es de: " & preciokm & "$/KM "

        Dim conexion As String
        conexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Juan\Documents\Matrices.accdb"

        Dim DA As New OleDbDataAdapter("select * from Transportistas", conexion)
        Dim DS As New DataSet
        DA.Fill(DS)

        CboTransportista.DataSource = DS.Tables(0)
        CboTransportista.DisplayMember = DS.Tables(0).Columns(1).Caption
        CboTransportista.ValueMember = DS.Tables(0).Columns(0).Caption

        txtId.Enabled = False

    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        If ChkId.Checked = False Then
            If Txtkmhechos.Text <> Nothing Then
                If IsNumeric(Txtkmhechos.Text) Then

                    Dim nombre As String
                    Dim km As String


                    preciototal = Txtkmhechos.Text * preciokm
                    lblprecioxkm.Text = Txtkmhechos.Text & " km x $ " & preciototal
                    lblprecioxkm.Visible = True

                    nombre = CboTransportista.Text
                    km = Txtkmhechos.Text

                    Dim conexion As String
                    conexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Juan\Documents\Matrices.accdb"
                    Using miconexion As New OleDbConnection(conexion)
                        miconexion.Open()
                        Dim sqlconsulta As String = "Insert into [viajes]( [id_transportista],[km],[preciototal] )values ( @Nombre, @km, @preciototal) "
                        Using cmd As New OleDbCommand(sqlconsulta, miconexion)
                            cmd.Parameters.AddWithValue("@Nombre", nombre)
                            cmd.Parameters.AddWithValue("@km", km)
                            cmd.Parameters.AddWithValue("@preciototal", preciototal)
                            cmd.ExecuteNonQuery() 'ejecuta la consulta 
                        End Using
                    End Using
                    Txtkmhechos.Text = ""
                    listar()
                Else
                    MsgBox("Poner solo numeros")
                End If
            Else
                MsgBox("Poner km")
            End If
            Else
                MsgBox("Desmarcar el chek ID")
        End If
    End Sub

    Private Sub BtnCotizacion_Click(sender As System.Object, e As System.EventArgs) Handles BtnCotizacion.Click
        Dim newMDIChild As New FrmCotizacion
        newMDIChild.MdiParent = FrmMenuPrinc
        newMDIChild.Show()
    End Sub

    Private Sub BtnBorrar_Click(sender As System.Object, e As System.EventArgs) Handles BtnBorrar.Click
        If ChkId.Checked = True Then
            If txtId.Text <> Nothing Then
                If IsNumeric(txtId.Text) Then

                    Dim id As Integer
                    id = txtId.Text
                    Dim conexion As String
                    conexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Juan\Documents\Matrices.accdb "
                    Using miconexion As New OleDbConnection(conexion)
                        miconexion.Open()
                        Dim sqlconsulta As String = "delete * from [viajes] where id = @id"
                        Using cmd As New OleDbCommand(sqlconsulta, miconexion)
                            cmd.Parameters.AddWithValue("@id", id)
                            cmd.ExecuteNonQuery()
                        End Using
                    End Using
                    listar()
                    MsgBox("Los datos han sido borrados correctamente")
                Else
                    MsgBox("Coloque solo numeros")
                End If
            Else
                MsgBox("Debe colocar la posicion que desea borrar en numeros")
            End If
        Else
            MsgBox("Debe estar habilitado el check")
        End If

    End Sub

    Private Sub BtnBorrarTodos_Click(sender As System.Object, e As System.EventArgs) Handles BtnBorrarTodos.Click
        Dim respuestas As String
        respuestas = MsgBox("Desea Borrar todos los nombres? ", vbOKCancel, "Advertencia")

        If respuestas = vbOK Then
            Dim conexion As String
            conexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Juan\Documents\Matrices.accdb "
            Using miconexion As New OleDbConnection(conexion)
                miconexion.Open()
                Dim sqlconsulta As String = "delete * from [viajes] " 'le tuve que borrar el where
                Using cmd As New OleDbCommand(sqlconsulta, miconexion)                  
                    cmd.ExecuteNonQuery()
                End Using
                MsgBox("Los datos han sido borrados correctamente")
            End Using
            listar()
            txtId.Text = ""
            Txtkmhechos.Text = ""
            lblprecioxkm.Text = ""
        Else
            Exit Sub
        End If
    End Sub

    Private Sub ChkId_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ChkId.CheckedChanged
        If ChkId.Checked = True Then
            txtId.Enabled = True
        Else
            txtId.Enabled = False
            txtId.Text = ""
        End If
        lblprecioxkm.Text = Nothing

    End Sub

   
    Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
        Dim newMDIChild As New FrmIngresoTransportistas
        newMDIChild.MdiParent = FrmMenuPrinc
        newMDIChild.Show()
    End Sub

    Private Sub BtnModificar_Click(sender As System.Object, e As System.EventArgs) Handles BtnModificar.Click
        If ChkId.Checked = True Then
            If txtId.Text <> Nothing Then
                If IsNumeric(txtId.Text) Then
                    If Txtkmhechos.Text <> Nothing Then
                        Dim id As Integer
                        Dim nombre, km, respuestas As String
                        respuestas = MsgBox("Desea modificar el viaje con el Id indicado?", vbOKCancel, "Advertencia")
                        If respuestas = vbOK Then
                            'Esto lo repito para calcular el precio total ****************        
                            preciototal = Txtkmhechos.Text * preciokm
                            lblprecioxkm.Text = Txtkmhechos.Text & " km x $ " & preciototal
                            lblprecioxkm.Visible = True
                            '*************************************************************
                            id = txtId.Text
                            nombre = CboTransportista.Text
                            km = Txtkmhechos.Text

                            Dim conexion As String
                            conexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Juan\Documents\Matrices.accdb"
                            Using miconexion As New OleDbConnection(conexion)
                                miconexion.Open()
                                Dim sqlconsulta As String = "update [viajes] set id_transportista = @Nombre , km = @km , preciototal = @preciototal where Id = @id  "
                                Using cmd As New OleDbCommand(sqlconsulta, miconexion)

                                    cmd.Parameters.AddWithValue("@Nombre", nombre)
                                    cmd.Parameters.AddWithValue("@km", km)
                                    cmd.Parameters.AddWithValue("@preciototal", preciototal)
                                    cmd.Parameters.AddWithValue("@id", id)
                                    cmd.ExecuteNonQuery() 'ejecuta la consulta 
                                End Using
                            End Using
                        Else
                            Exit Sub
                        End If
                        listar()

                    Else
                        MsgBox("poner km")
                    End If
                Else
                    MsgBox("deben ser numeros")
                End If

            Else
                MsgBox("poner id que quiere modificar")
            End If

        Else
            MsgBox("Presionar el chek modificar/buscar/borrar para continuar")
        End If


    End Sub

    Private Sub Txtkmhechos_Click(sender As Object, e As System.EventArgs) Handles Txtkmhechos.Click
        lblprecioxkm.Text = Nothing

    End Sub

   
    Private Sub BtnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles BtnBuscar.Click

        If ChkId.Checked = False Then
            MsgBox("Presionar el chek modificar/buscar/borrar para continuar")
        Else
            If txtId.Text = Nothing Then
                MsgBox("Poner el Id que busca")
            Else
                If IsNumeric(txtId.Text) Then
                    Dim conexion As String
                    conexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Juan\Documents\Matrices.accdb"
                    'traigo datos de la db acces
                    Dim DA As New OleDbDataAdapter("select * from [viajes] where Id =" & txtId.Text, conexion) 'Data Adapter
                    Dim DS As New DataSet  'Data set
                    DA.Fill(DS) 'fill = cargar
                    If DS.Tables(0).Rows.Count() <> 0 Then

                        CboTransportista.Text = DS.Tables(0).Rows(0).Item("id_transportista")
                        Txtkmhechos.Text = DS.Tables(0).Rows(0).Item("km")
                    Else
                        MsgBox("no hay nada cargado")
                    End If
                Else
                    MsgBox("Poner NUMERO")
                End If
            End If
        End If
    End Sub

    
    Private Sub GrlDistanciaMenos_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrlDistanciaMenos.CellContentClick

    End Sub

    Private Sub GrlDistanciaMenos_DoubleClick(sender As Object, e As System.EventArgs) Handles GrlDistanciaMenos.DoubleClick
        txtId.Text = GrlDistanciaMenos.Item(0, GrlDistanciaMenos.CurrentRow.Index).Value
        CboTransportista.Text = GrlDistanciaMenos.Item(1, GrlDistanciaMenos.CurrentRow.Index).Value
        Txtkmhechos.Text = GrlDistanciaMenos(2, GrlDistanciaMenos.CurrentRow.Index).Value
        lblprecioxkm.Text = GrlDistanciaMenos(3, GrlDistanciaMenos.CurrentRow.Index).Value & " por km"
        lblprecioxkm.Enabled = True
        lblprecioxkm.Visible = True

    End Sub
End Class