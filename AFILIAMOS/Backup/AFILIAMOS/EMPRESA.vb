Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Data
Imports System.IO

Public Class EMPRESA
    Dim x As Integer
    Dim ruta As String
    Dim IMAGEN As Byte
    Dim Imag As Byte()
    Private Sub EMPRESA_Layout(sender As Object, e As LayoutEventArgs) Handles Me.Layout
        BUSCAR_EMPRESA()
        BLOQUEAR_BOTONES()
        BLOQUEAR_CAMPOS()
    End Sub

    Private Sub BTM_SALIR_Click(sender As Object, e As EventArgs) Handles BTM_SALIR.Click
        Dispose()
    End Sub

    Sub MODIFICAR()
        Try
            Dim arrFilename() As String = Split(Text, "\")
            Array.Reverse(arrFilename)
            Dim ms As New MemoryStream
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
            Dim arrImage() As Byte = ms.GetBuffer


            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("MODIFICAR_EMPRESA", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@NIT", SqlDbType.VarChar).Value = TB_NIT.Text
            cmd.Parameters.Add("@RAZON_SOCIAL", SqlDbType.VarChar).Value = TB_NOMBRE.Text
            cmd.Parameters.Add("@DIRECCION", SqlDbType.VarChar).Value = TB_DIRECCION.Text
            cmd.Parameters.Add("@TELEFONO", SqlDbType.VarChar).Value = TB_TELEFONO.Text
            cmd.Parameters.Add("@LOGO", SqlDbType.Image).Value = arrImage
            conex.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("INFORMACION DE EMPRESA MODIFICADA CORRECTAMENTE", "SISTEMA")
            conex.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub BLOQUEAR_BOTONES()
        BTM_GUARDAR.Enabled = False
        BTM_MODIFICAR.Enabled = True
    End Sub
    Sub DESBLOQUEAR_BOTONES()
        BTM_GUARDAR.Enabled = True
        BTM_MODIFICAR.Enabled = False
    End Sub
    Sub VALIDACIONES_BLANCO()
        If TB_NIT.Text = "" Then
            MsgBox("EL CAMPO NIT DEBE TENER UN VALOR")
        ElseIf TB_NOMBRE.Text = "" Then
            MsgBox("EL CAMPO RAZON SOIAL NO PUDEDE ESTAR EN BLANCO")
        ElseIf TB_DIRECCION.Text = "" Then
            MsgBox("EL CAMPO DE DIRECCION NO PUEDE ESTAR EN BLANCO")
        ElseIf TB_TELEFONO.Text = "" Then
            MsgBox("EL CAMPO DE TELEFONO NO PUEDE ESTAR EN BLANCO")
        Else
            MODIFICAR()
            BUSCAR_EMPRESA()
            BLOQUEAR_BOTONES()
            BLOQUEAR_CAMPOS()
        End If
    End Sub

    Sub BUSCAR_EMPRESA()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_EMRESA_TODOS", conex)
            cmd.CommandType = CommandType.StoredProcedure
            '  cmd.Parameters.Add("@CAJACODIGO", SqlDbType.VarChar).Value = TB_CODIGO.Text
            Dim dr As SqlDataReader
            conex.Open()
            dr = cmd.ExecuteReader
            If dr.Read Then
                TB_NIT.Text = dr(1)
                TB_NOMBRE.Text = dr(2)
                TB_DIRECCION.Text = dr(3)
                TB_TELEFONO.Text = dr(4)

                Imag = dr(5)
                Me.PictureBox1.Image = Bytes_Imagen(Imag)
                'BLOQUEAR_CAMPOS()
                BTM_GUARDAR.Enabled = False
                conex.Close()
            Else
                conex.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BTM_MODIFICAR_Click(sender As Object, e As EventArgs) Handles BTM_MODIFICAR.Click
        x = 2
        DESBLOQUEAR_BOTONES()
        DESBLOQUEAR_CAMPOS()
        BTM_MODIFICAR.Enabled = False
    End Sub

    Private Sub BTM_GUARDAR_Click(sender As Object, e As EventArgs) Handles BTM_GUARDAR.Click
        If x = 1 Then

        ElseIf x = 2 Then
            VALIDACIONES_BLANCO()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.Filter = "Todos(*.Jpg, *.Png, *.Gif, *.Tiff, *.Jpeg, *.Bmp)|*.Jpg; *.Png; *.Gif; *.Tiff; *.Jpeg; *.Bmp"
        OpenFileDialog1.ShowDialog()
        ruta = OpenFileDialog1.FileName.ToString
        PictureBox1.Image = System.Drawing.Image.FromFile(ruta)
    End Sub

    Private Function Bytes_Imagen(ByVal Imagen As Byte()) As Image
        Try
            'si hay imagen
            If Not Imagen Is Nothing Then
                'caturar array con memorystream hacia Bin
                Dim Bin As New MemoryStream(Imagen)
                'con el método FroStream de Image obtenemos imagen
                Dim Resultado As Image = Image.FromStream(Bin)
                'y la retornamos
                Return Resultado
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Sub BLOQUEAR_CAMPOS()
        TB_NIT.ReadOnly = True
        TB_NOMBRE.ReadOnly = True
        TB_DIRECCION.ReadOnly = True
        TB_TELEFONO.ReadOnly = True
        Button1.Enabled = False
    End Sub

    Sub DESBLOQUEAR_CAMPOS()
        TB_NIT.ReadOnly = True
        TB_NOMBRE.ReadOnly = False
        TB_DIRECCION.ReadOnly = False
        TB_TELEFONO.ReadOnly = False
        Button1.Enabled = True
    End Sub
End Class
