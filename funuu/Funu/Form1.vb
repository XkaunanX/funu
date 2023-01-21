Public Class Funu
    'CONTROLES DE MOVIMIENTO
    Dim valor As Boolean
    Dim moux As Integer
    Dim mouy As Integer
    Dim fuente As Font
    '------------------------
    'CONTROLES DE EVENTOS
    Dim CLICK_NOMBRE As Boolean
    Dim CLICK_APELLIDO As Boolean
    Dim CLICK_SALA As Boolean
    Dim CLICK_FECHA As Boolean
    Dim CLICK_HORA As Boolean
    Dim plantilla_elejida As Boolean
    '-----------------------
    'VALORES DE INICIO
    Dim newFont As New Drawing.Font("Century Gothic", 16, FontStyle.Bold)
    Dim micolor As Color = Color.White
    '------------------------
    'VARIABLES
    Dim ruta As String
    Dim carpeta_imagenes As String
    Dim nombre_archivo
    Dim nombre_imagen As String
    Dim texto_NOMBRE As String
    Dim texto_APELLIDO As String
    Dim texto_SALA As String
    Dim texto_FECHA As String
    Dim texto_HORA As String
    '------------------------
    Dim portapapeles As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load   'CARGAR RUTA DE EJECUCION
        Carga.Show()
        Me.Visible = False

        ruta = Environment.CurrentDirectory
        carpeta_imagenes = My.Computer.FileSystem.SpecialDirectories.MyPictures
        Console.WriteLine(carpeta_imagenes)
        fuente = New Font(elejir.Font, FontStyle.Bold)

        CLICK_NOMBRE = False
        CLICK_APELLIDO = False
        CLICK_SALA = False
        CLICK_FECHA = False
        CLICK_HORA = False

        plantilla_elejida = False

        portapapeles = "aun no cargo nada"
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles cerrar.Click 'CERRAR
        Application.Exit()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles minimizar.Click 'MINIMIZAR
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub barra_MouseDown(sender As Object, e As MouseEventArgs) Handles barra.MouseDown  'MOVIMIENTO PARTE 1
        valor = True
        moux = Cursor.Position.X - Me.Left
        mouy = Cursor.Position.Y - Me.Top

    End Sub

    Private Sub barra_MouseMove(sender As Object, e As MouseEventArgs) Handles barra.MouseMove 'MOVIMIENTO PARTE 2
        If valor = True Then
            Me.Top = Cursor.Position.Y - mouy
            Me.Left = Cursor.Position.X - moux
        End If
    End Sub

    Private Sub barra_MouseUp(sender As Object, e As MouseEventArgs) Handles barra.MouseUp 'MOVIMIENTO PARTE 3
        valor = False
    End Sub

    Private Sub display_estado_MouseDown(sender As Object, e As MouseEventArgs) Handles display_estado.MouseDown 'MOVIMIENTO PARTE 1
        valor = True
        moux = Cursor.Position.X - Me.Left
        mouy = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub display_estado_MouseMove(sender As Object, e As MouseEventArgs) Handles display_estado.MouseMove 'MOVIMIENTO PARTE 2
        If valor = True Then
            Me.Top = Cursor.Position.Y - mouy
            Me.Left = Cursor.Position.X - moux
        End If
    End Sub

    Private Sub display_estado_MouseUp(sender As Object, e As MouseEventArgs) Handles display_estado.MouseUp 'MOVIMIENTO PARTE 3
        valor = False
    End Sub

    Private Sub btn_fuente_Click(sender As Object, e As EventArgs) Handles btn_fuente.Click 'SELECIONAR FUENTE
        If elejir.ShowDialog = Windows.Forms.DialogResult.OK Then
            fuente = New Font(elejir.Font, FontStyle.Bold)
        End If
    End Sub

    Private Sub btn_color_fuente_Click(sender As Object, e As EventArgs) Handles btn_color_fuente.Click 'SELECIONAR COLOR FUENTE
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            micolor = New Color
            micolor = ColorDialog1.Color
        End If
    End Sub

    Private Sub btn_recurso_Click(sender As Object, e As EventArgs) Handles btn_recurso.Click 'COLOCAR PLANTILLA PROPIA
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            display.ImageLocation = OpenFileDialog1.FileName
            plantilla_elejida = True
            display.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub cargar_Click(sender As Object, e As EventArgs) Handles cargar.Click 'ANIMACION DE CARGADO O ERROR
        display.SizeMode = PictureBoxSizeMode.StretchImage
        'SE HIZO ELECCION?
        If plantilla_elejida = False Then
            display.Image = My.Resources.Plantilla_1080
        End If
        '-------------------------------------------------------------------
        'VALORES VARIABLES
        texto_NOMBRE = txt_nombre.Text
        texto_APELLIDO = txt_apellido.Text
        texto_SALA = txt_sala.Text
        texto_FECHA = txt_fecha.Text
        texto_HORA = txt_hora.Text
        '-------------------------------------------------------------------
        'DIBUJAR SOBRE LA IMAGEN
        Try
            Dim POSICION As Point                       'VARIABLES POSICIONAMIENTO
            Dim POSICION_NOMBRE As Point
            Dim POSICION_APELLIDO As Point
            Dim POSICION_SALA As Point
            Dim POSICION_FECHA As Point
            Dim POSICION_HORA As Point

            If RadioButtonCentro.Checked Then
                POSICION = New Point((display.Image.Width / 2) - (texto_NOMBRE.Length * fuente.Size / 2), display.Image.Height / 2) 'PRUEBA "SALA"

                POSICION_NOMBRE = New Point((display.Image.Width / 2) - (texto_NOMBRE.Length * fuente.Size / 2), display.Image.Height / 2 - 210)
                POSICION_APELLIDO = New Point((display.Image.Width / 2) - (texto_NOMBRE.Length * fuente.Size / 2), display.Image.Height / 2 - 110)
                POSICION_SALA = POSICION
                POSICION_FECHA = New Point((display.Image.Width / 2) - (texto_NOMBRE.Length * fuente.Size / 2), display.Image.Height / 2 + 110)
                POSICION_HORA = New Point((display.Image.Width / 2) - (texto_NOMBRE.Length * fuente.Size / 2), display.Image.Height / 2 + 210)

            ElseIf RadioButtonDerecha.Checked Then
                POSICION = New Point((display.Image.Width / 1.3) - (texto_NOMBRE.Length * fuente.Size / 2), display.Image.Height / 2) 'PRUEBA "SALA"

                POSICION_NOMBRE = New Point((display.Image.Width / 1.3) - (texto_NOMBRE.Length * fuente.Size / 2), display.Image.Height / 2 - 210)
                POSICION_APELLIDO = New Point((display.Image.Width / 1.3) - (texto_NOMBRE.Length * fuente.Size / 2), display.Image.Height / 2 - 110)
                POSICION_SALA = POSICION
                POSICION_FECHA = New Point((display.Image.Width / 1.3) - (texto_NOMBRE.Length * fuente.Size / 2), display.Image.Height / 2 + 110)
                POSICION_HORA = New Point((display.Image.Width / 1.3) - (texto_NOMBRE.Length * fuente.Size / 2), display.Image.Height / 2 + 210)

            ElseIf RadioButtonIzquierda.Checked Then
                POSICION = New Point((display.Image.Width / 3.5) - (texto_NOMBRE.Length * fuente.Size / 2), display.Image.Height / 2) 'PRUEBA "SALA"

                POSICION_NOMBRE = New Point((display.Image.Width / 3.5) - (texto_NOMBRE.Length * fuente.Size / 2), display.Image.Height / 2 - 210)
                POSICION_APELLIDO = New Point((display.Image.Width / 3.5) - (texto_NOMBRE.Length * fuente.Size / 2), display.Image.Height / 2 - 110)
                POSICION_SALA = POSICION
                POSICION_FECHA = New Point((display.Image.Width / 3.5) - (texto_NOMBRE.Length * fuente.Size / 2), display.Image.Height / 2 + 110)
                POSICION_HORA = New Point((display.Image.Width / 3.5) - (texto_NOMBRE.Length * fuente.Size / 2), display.Image.Height / 2 + 210)
            End If

            Dim TRAZO As SolidBrush = New SolidBrush(micolor)   'COLOR
            Dim BM As Bitmap = New Bitmap(display.Image)        'BITMAP
            Dim DIBUJO As Graphics = Graphics.FromImage(BM)     'DECLAR GRAFICO

            DIBUJO.DrawString(texto_NOMBRE, fuente, TRAZO, POSICION_NOMBRE)   'COLOCAR EL DIBUJO
            DIBUJO.DrawString(texto_APELLIDO, fuente, TRAZO, POSICION_APELLIDO)   'COLOCAR EL DIBUJO
            DIBUJO.DrawString(texto_SALA, fuente, TRAZO, POSICION_SALA)   'COLOCAR EL DIBUJO
            DIBUJO.DrawString(texto_FECHA, fuente, TRAZO, POSICION_FECHA)   'COLOCAR EL DIBUJO
            DIBUJO.DrawString(texto_HORA, fuente, TRAZO, POSICION_HORA)   'COLOCAR EL DIBUJO

            display.Image = BM                                  'GUARDAR DIBUJO
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'GUARDAR LA IMAGEN CARGADA
        Try
            Dim HORA As String = Now.ToLongTimeString
            HORA = HORA.Replace(":", "_")
            'nombre_archivo = Application.StartupPath & "\IMAGENES\" & "RESULTADO" & "_" & HORA & ".jpg"                              'GUARDAR RUTA
            'display.Image.Save(Application.StartupPath & "\IMAGENES\" & "RESULTADO" & "_" & HORA & ".jpg", Imaging.ImageFormat.Jpeg) 'GUARDAR IMAGEN
            nombre_imagen = "RESULTADO" & "_" & HORA & ".jpg"
            display.Image.Save(carpeta_imagenes & "\" & "RESULTADO" & "_" & HORA & ".jpg", Imaging.ImageFormat.Jpeg)
            'ANIMACION
            display_estado.Image = My.Resources.ok
            timer_estado.Enabled = True
            portapapeles = carpeta_imagenes
            '--------------------------------------------------------------------
        Catch ex As Exception
            MsgBox(ex.Message)
            'ANIMACION
            display_estado.Image = My.Resources.error1
            timer_estado.Enabled = True
            '--------------------------------------------------------------------
            portapapeles = "no generado"
        End Try

    End Sub

    Private Sub timer_estado_Tick(sender As Object, e As EventArgs) Handles timer_estado.Tick 'RESETEO DE LA ANIMACION
        display_estado.Image = My.Resources.loader
        timer_estado.Enabled = False
    End Sub

    Private Sub btn_recurso_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_recurso.MouseDown 'ANIMACION
        btn_recurso.BackColor = Color.FromArgb(60, 60, 60)
        btn_recurso.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub btn_recurso_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_recurso.MouseUp  'ANIMACION
        btn_recurso.BackColor = Color.FromArgb(5, 16, 38)
        btn_recurso.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

    Private Sub btn_fuente_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_fuente.MouseDown    'ANIMACION
        btn_fuente.BackColor = Color.FromArgb(60, 60, 60)
        btn_fuente.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub btn_fuente_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_fuente.MouseUp    'ANIMACION
        btn_fuente.BackColor = Color.FromArgb(5, 16, 38)
        btn_fuente.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

    Private Sub btn_color_fuente_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_color_fuente.MouseDown 'ANIMACION
        btn_color_fuente.BackColor = Color.FromArgb(60, 60, 60)
        btn_color_fuente.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub btn_color_fuente_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_color_fuente.MouseUp 'ANIMACION
        btn_color_fuente.BackColor = Color.FromArgb(5, 16, 38)
        btn_color_fuente.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

    Private Sub txt_nombre_Click(sender As Object, e As EventArgs) Handles txt_nombre.Click
        txt_nombre.Font = newFont
        txt_nombre.ForeColor = Color.Black
        If CLICK_NOMBRE = False Then
            txt_nombre.Text = ""
        End If
        CLICK_NOMBRE = True
    End Sub

    Private Sub txt_apellido_Click(sender As Object, e As EventArgs) Handles txt_apellido.Click
        txt_apellido.Font = newFont
        txt_apellido.ForeColor = Color.Black
        If CLICK_APELLIDO = False Then
            txt_apellido.Text = ""
        End If
        CLICK_APELLIDO = True
    End Sub

    Private Sub txt_fecha_Click(sender As Object, e As EventArgs) Handles txt_fecha.Click
        txt_fecha.Font = newFont
        txt_fecha.ForeColor = Color.Black
        If CLICK_FECHA = False Then
            txt_fecha.Text = " / /"
        End If
        CLICK_FECHA = True
    End Sub

    Private Sub txt_hora_Click(sender As Object, e As EventArgs) Handles txt_hora.Click
        txt_hora.Font = newFont
        txt_hora.ForeColor = Color.Black
        If CLICK_HORA = False Then
            txt_hora.Text = " : "
        End If
        CLICK_HORA = True
    End Sub

    Private Sub txt_sala_Click(sender As Object, e As EventArgs) Handles txt_sala.Click
        txt_sala.Font = newFont
        txt_sala.ForeColor = Color.Black
    End Sub

    Private Sub display_Click(sender As Object, e As EventArgs) Handles display.Click
        My.Computer.Clipboard.SetText(portapapeles)
    End Sub

    Private Sub pedestal_Click(sender As Object, e As EventArgs) Handles pedestal.Click
        Form2.Visible = True
    End Sub
End Class
