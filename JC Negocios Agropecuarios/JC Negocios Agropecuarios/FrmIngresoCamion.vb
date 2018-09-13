Imports System.Data.OleDb

Public Class FrmIngresoTransportistas

    Public Sub listar()
        Dim conexion As String
        conexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Juan\Documents\Matrices.accdb"
        'traigo datos de acces
        Dim DA As New OleDbDataAdapter("select * from Transportistas", conexion) 'Data Adapter
        Dim DS As New DataSet  'Data set
        DA.Fill(DS) 'fill = cargar
        GrlGrillaTransportistas.DataSource = DS.Tables(0) ' traigo la tabla 0
    End Sub

    Private Sub FrmIngresoCamion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim conexion As String
        'conexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Juan\Documents\Matrices.accdb"

        'Dim DA As New OleDbDataAdapter("select [Nombre_transportistas] from Transportistas", conexion)
        'Dim DS As New DataSet
        'DA.Fill(DS)
        TxtIngreseNombre.Focus()
        listar()

    End Sub

    Private Sub BtnGuardarMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardarMostrar.Click
        If txtDNI.Text <> Nothing Or TxtIngreseNombre.Text <> Nothing Then
            If TxtIngreseNombre.Text <> Nothing Then
                If txtDNI.Text <> Nothing Then
                    If IsNumeric(txtDNI.Text) Then

                        Dim nombre As String
                        Dim DNI As String
                        DNI = txtDNI.Text
                        nombre = TxtIngreseNombre.Text
                        Dim conexion As String
                        conexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Juan\Documents\Matrices.accdb"
                        Using miconexion As New OleDbConnection(conexion)
                            miconexion.Open()
                            Dim sqlconsulta As String = "Insert into [Transportistas]( [Nombre_transportistas],[DNI])values ( @Nombre, @DNI) "
                            Using cmd As New OleDbCommand(sqlconsulta, miconexion)
                                cmd.Parameters.AddWithValue("@Nombre", nombre)
                                cmd.Parameters.AddWithValue("@DNI", DNI)
                                cmd.ExecuteNonQuery() 'ejecuta la consulta 
                            End Using
                        End Using

                        TxtIngreseNombre.Text = ""
                        txtDNI.Text = ""
                    Else
                        MsgBox("DNI va con numeros")
                    End If
                Else
                    MsgBox("Poner DNI")
                End If
            Else
                MsgBox("Agregar nombre del transportista")
            End If
        Else
            MsgBox("Poner Nombre transportista y DNI")

        End If

        listar()

    End Sub
    Private Sub Rbmas100km_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtIngreseNombre.Focus()
    End Sub

    Private Sub rbmenos100km_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtIngreseNombre.Focus()
    End Sub

    Private Sub Btncargarkm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btncargarkm.Click
        Dim newMDIChild As New FrmDistanciayprecio
        newMDIChild.MdiParent = FrmMenuPrinc
        newMDIChild.Show()
    End Sub

    Private Sub Btnborrartodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnborrartodos.Click
        Dim respuestas As String
        respuestas = MsgBox("Desea Borrar todos los nombres? ", vbOKCancel, "Advertencia")

        If respuestas = vbOK Then
            Dim conexion As String
            conexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Juan\Documents\Matrices.accdb "
            Using miconexion As New OleDbConnection(conexion)
                miconexion.Open()
                Dim sqlconsulta As String = "delete * from [Transportistas] " 'le tuve que borrar el where
                Using cmd As New OleDbCommand(sqlconsulta, miconexion)
                    ' cmd.Parameters.AddWithValue("@*", id)
                    cmd.ExecuteNonQuery()
                End Using
                MsgBox("Los datos han sido borrados correctamente")
                TxtIngreseNombre.Text = ""
            End Using
            listar()
        Else
            Exit Sub

        End If
    End Sub

    Private Sub BtnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBorrar.Click
        If TxtIngreseNombre.Text <> Nothing Then
            If IsNumeric(TxtIngreseNombre.Text) = True Then
                Dim id As Integer
                id = TxtIngreseNombre.Text
                Dim conexion As String
                conexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Juan\Documents\Matrices.accdb "
                Using miconexion As New OleDbConnection(conexion)
                    miconexion.Open()
                    Dim sqlconsulta As String = "delete * from [Transportistas] where id = @id"
                    Using cmd As New OleDbCommand(sqlconsulta, miconexion)
                        cmd.Parameters.AddWithValue("@id", id)
                        cmd.ExecuteNonQuery()
                    End Using
                   
                    MsgBox("Los datos han sido borrados correctamente")

                End Using
                listar()
            Else
                MsgBox("debe colocar la posicion que desea borrar en numeros")

            End If
        Else
            MsgBox("debe rellenar la caja de 'ingresar nombre' con la posición que desea borrar")

        End If


    End Sub
End Class