Public Class FrmLogin
    Dim Nombre As String = ""
    Dim Contraseña As String = ""
    Dim Veces As Integer = 0
    Dim Nombre1 As String = "admin"
    Dim Contraseña1 As String = "admin"
    Dim Nombre2 As String = "JC"
    Dim Contraseña2 As String = "123"    
    'este vector lo uso en los usuarios nuevo
    Dim usuariotemporal, contraseñatemporal As String

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        Nombre = TxtUsuario.Text
        Contraseña = TxtContraseña.Text
        If TxtUsuario.Text = "" And TxtContraseña.Text = "" Then
            MsgBox("Coloque USUARIO y CONTRASEÑA")
        Else
            If TxtUsuario.Text = "" Then
                MsgBox("Coloque un USUARIO valido")
            Else
                If TxtContraseña.Text = "" Then
                    MsgBox("Coloque contraseña")
                Else
                    If chkusuarionuevo.Checked = True Then
                        For i = 0 To 9
                            If usuariosnuevosmatriz(i, 0) = TxtUsuario.Text And usuariosnuevosmatriz(i, 1) = TxtContraseña.Text Then
                                usuariotemporal = usuariosnuevosmatriz(i, 0)
                                contraseñatemporal = usuariosnuevosmatriz(i, 1)
                                FrmMenuPrinc.Show()
                                Me.Visible = False
                            End If
                        Next
                    Else
                        If Nombre = Nombre1 And Contraseña = Contraseña1 Or Nombre = Nombre2 And Contraseña = Contraseña2 Then
                            TxtUsuario.Text = ""
                            TxtContraseña.Text = ""
                            FrmMenuPrinc.Show()
                            Me.Visible = False
                        Else
                            MsgBox("Los datos son incorrectos")
                            Veces = Veces + 1
                            TxtUsuario.Text = Nothing
                            TxtContraseña.Text = Nothing
                        End If
                        If Veces = 3 Then
                            MsgBox("Has sobrepasado los intentos posibles!", MsgBoxStyle.Critical, "ADVERTENCIA!")
                            TxtUsuario.Enabled = False
                            TxtContraseña.Enabled = False
                            btnok.Enabled = False
                            BtnIngresUsuario.Enabled = False
                        End If
                    End If                   
                End If
            End If
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub FrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnIngresUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIngresUsuario.Click
        FrmCargarusuariosnuevos.Show()
        Me.Hide()


    End Sub
End Class
