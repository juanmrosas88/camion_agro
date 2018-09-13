Public Class FrmCotizacion

    Private Sub FrmCotizacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LblcotizacionActual.Text = "La cotizacion actual es: " & preciokm & "  $/KM "
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        If Txtcotizacion.Text <> Nothing Then
            If IsNumeric(Txtcotizacion.Text) Then
                preciokm = Txtcotizacion.Text
                Txtcotizacion.Text = ""
                LblcotizacionActual.Text = "La cotizacion actual es: " & preciokm & "  $/KM "
                MsgBox("La actualizacion del precio es correcta " & vbCrLf & "Ahora el precio del km es de: $" & preciokm)
            Else
                MsgBox("Debe ingresar la cotizacion con numeros... chistos@!")
            End If
        Else
            MsgBox("Debe ingresar una cotizacion del km")
        End If
    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()

    End Sub

  
End Class