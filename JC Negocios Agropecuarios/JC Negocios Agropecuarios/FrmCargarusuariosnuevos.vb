Imports System.Data.OleDb

Public Class FrmCargarusuariosnuevos
    Dim resultado As Integer

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        If Txtcontranueva.Text = "" Or Txtnombrenuevo.Text = "" Or txtrepetircontra.Text = "" Then
            MsgBox("Rellene los campos")
        Else
            If Txtcontranueva.Text <> txtrepetircontra.Text Then
                MsgBox("Deben coincidir las contraseñas ingresadas")
            Else

                Dim nombre As String
                Dim Contraseña As String

                ' If Txtnombrenuevo.Text <> Nothing Then
                nombre = Txtnombrenuevo.Text
                Contraseña = Txtcontranueva.Text

                Dim conexion As String
                conexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Juan\Documents\Matrices.accdb"

                Using miconexion As New OleDbConnection(conexion)
                    miconexion.Open()

                    Dim sqlconsulta As String = "Insert into [UsuariosNuevos]( [Contraseña],[Nombre] )values ( @Contraseña, @Nombre) "
                    Using cmd As New OleDbCommand(sqlconsulta, miconexion)
                        cmd.Parameters.AddWithValue("@Contraseña", Contraseña)
                        cmd.Parameters.AddWithValue("@Nombre", nombre)
                        cmd.ExecuteNonQuery() 'ejecuta la consulta 
                    End Using
                    MsgBox("Los datos fueron cargados con exito")

                    resultado = MsgBox("Su nuevo usuario es: " & Txtnombrenuevo.Text & vbCrLf & "Y su contraseña es: " & Txtcontranueva.Text, MsgBoxStyle.Information, "Nuevo Usuario ACEPTADO!")

                End Using
                'End If
            End If
        End If

    End Sub

    Private Sub FrmCargarusuariosnuevos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Txtnombrenuevo.Focus()

    End Sub
End Class