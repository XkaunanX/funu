<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Funu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Funu))
        Me.barra = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RadioButtonDerecha = New System.Windows.Forms.RadioButton()
        Me.RadioButtonIzquierda = New System.Windows.Forms.RadioButton()
        Me.RadioButtonCentro = New System.Windows.Forms.RadioButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txt_hora = New System.Windows.Forms.TextBox()
        Me.txt_fecha = New System.Windows.Forms.TextBox()
        Me.txt_sala = New System.Windows.Forms.TextBox()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.elejir = New System.Windows.Forms.FontDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.timer_estado = New System.Windows.Forms.Timer(Me.components)
        Me.estado = New System.Windows.Forms.ToolTip(Me.components)
        Me.cargar = New System.Windows.Forms.PictureBox()
        Me.display = New System.Windows.Forms.PictureBox()
        Me.btn_color_fuente = New System.Windows.Forms.PictureBox()
        Me.btn_fuente = New System.Windows.Forms.PictureBox()
        Me.pedestal = New System.Windows.Forms.PictureBox()
        Me.btn_recurso = New System.Windows.Forms.PictureBox()
        Me.display_estado = New System.Windows.Forms.PictureBox()
        Me.minimizar = New System.Windows.Forms.PictureBox()
        Me.cerrar = New System.Windows.Forms.PictureBox()
        Me.barra.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.cargar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.display, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_color_fuente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_fuente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pedestal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_recurso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.display_estado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'barra
        '
        Me.barra.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.barra.Controls.Add(Me.display_estado)
        Me.barra.Controls.Add(Me.minimizar)
        Me.barra.Controls.Add(Me.cerrar)
        Me.barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.barra.Location = New System.Drawing.Point(0, 0)
        Me.barra.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barra.Name = "barra"
        Me.barra.Size = New System.Drawing.Size(832, 50)
        Me.barra.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel2.Controls.Add(Me.RadioButtonDerecha)
        Me.Panel2.Controls.Add(Me.RadioButtonIzquierda)
        Me.Panel2.Controls.Add(Me.RadioButtonCentro)
        Me.Panel2.Controls.Add(Me.btn_color_fuente)
        Me.Panel2.Controls.Add(Me.btn_fuente)
        Me.Panel2.Controls.Add(Me.pedestal)
        Me.Panel2.Controls.Add(Me.btn_recurso)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 50)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(832, 57)
        Me.Panel2.TabIndex = 1
        '
        'RadioButtonDerecha
        '
        Me.RadioButtonDerecha.AutoSize = True
        Me.RadioButtonDerecha.ForeColor = System.Drawing.Color.White
        Me.RadioButtonDerecha.Location = New System.Drawing.Point(452, 25)
        Me.RadioButtonDerecha.Name = "RadioButtonDerecha"
        Me.RadioButtonDerecha.Size = New System.Drawing.Size(77, 20)
        Me.RadioButtonDerecha.TabIndex = 6
        Me.RadioButtonDerecha.TabStop = True
        Me.RadioButtonDerecha.Text = "DERECHA"
        Me.estado.SetToolTip(Me.RadioButtonDerecha, "Posicion")
        Me.RadioButtonDerecha.UseVisualStyleBackColor = True
        '
        'RadioButtonIzquierda
        '
        Me.RadioButtonIzquierda.AutoSize = True
        Me.RadioButtonIzquierda.ForeColor = System.Drawing.Color.White
        Me.RadioButtonIzquierda.Location = New System.Drawing.Point(260, 25)
        Me.RadioButtonIzquierda.Name = "RadioButtonIzquierda"
        Me.RadioButtonIzquierda.Size = New System.Drawing.Size(84, 20)
        Me.RadioButtonIzquierda.TabIndex = 5
        Me.RadioButtonIzquierda.TabStop = True
        Me.RadioButtonIzquierda.Text = "IZQUIERDA"
        Me.estado.SetToolTip(Me.RadioButtonIzquierda, "Posicion")
        Me.RadioButtonIzquierda.UseVisualStyleBackColor = True
        '
        'RadioButtonCentro
        '
        Me.RadioButtonCentro.AutoSize = True
        Me.RadioButtonCentro.ForeColor = System.Drawing.Color.White
        Me.RadioButtonCentro.Location = New System.Drawing.Point(360, 25)
        Me.RadioButtonCentro.Name = "RadioButtonCentro"
        Me.RadioButtonCentro.Size = New System.Drawing.Size(71, 20)
        Me.RadioButtonCentro.TabIndex = 4
        Me.RadioButtonCentro.TabStop = True
        Me.RadioButtonCentro.Text = "CENTRO"
        Me.estado.SetToolTip(Me.RadioButtonCentro, "Posicion")
        Me.RadioButtonCentro.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Panel3.Controls.Add(Me.txt_hora)
        Me.Panel3.Controls.Add(Me.txt_fecha)
        Me.Panel3.Controls.Add(Me.txt_sala)
        Me.Panel3.Controls.Add(Me.txt_apellido)
        Me.Panel3.Controls.Add(Me.txt_nombre)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Location = New System.Drawing.Point(16, 163)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(218, 256)
        Me.Panel3.TabIndex = 4
        '
        'txt_hora
        '
        Me.txt_hora.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.txt_hora.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txt_hora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_hora.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_hora.ForeColor = System.Drawing.Color.Gray
        Me.txt_hora.Location = New System.Drawing.Point(5, 214)
        Me.txt_hora.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_hora.Name = "txt_hora"
        Me.txt_hora.Size = New System.Drawing.Size(210, 32)
        Me.txt_hora.TabIndex = 4
        Me.txt_hora.TabStop = False
        Me.txt_hora.Text = "Hora"
        '
        'txt_fecha
        '
        Me.txt_fecha.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.txt_fecha.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txt_fecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_fecha.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fecha.ForeColor = System.Drawing.Color.Gray
        Me.txt_fecha.Location = New System.Drawing.Point(5, 164)
        Me.txt_fecha.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(210, 32)
        Me.txt_fecha.TabIndex = 3
        Me.txt_fecha.TabStop = False
        Me.txt_fecha.Text = "Fecha"
        '
        'txt_sala
        '
        Me.txt_sala.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.txt_sala.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txt_sala.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_sala.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sala.ForeColor = System.Drawing.Color.Gray
        Me.txt_sala.Location = New System.Drawing.Point(5, 114)
        Me.txt_sala.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_sala.Name = "txt_sala"
        Me.txt_sala.Size = New System.Drawing.Size(210, 32)
        Me.txt_sala.TabIndex = 2
        Me.txt_sala.TabStop = False
        Me.txt_sala.Text = "Sala"
        '
        'txt_apellido
        '
        Me.txt_apellido.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.txt_apellido.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txt_apellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_apellido.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_apellido.ForeColor = System.Drawing.Color.Gray
        Me.txt_apellido.Location = New System.Drawing.Point(5, 64)
        Me.txt_apellido.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(210, 32)
        Me.txt_apellido.TabIndex = 1
        Me.txt_apellido.TabStop = False
        Me.txt_apellido.Text = "Apellido"
        '
        'txt_nombre
        '
        Me.txt_nombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.txt_nombre.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nombre.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre.ForeColor = System.Drawing.Color.Gray
        Me.txt_nombre.Location = New System.Drawing.Point(5, 16)
        Me.txt_nombre.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(210, 32)
        Me.txt_nombre.TabIndex = 0
        Me.txt_nombre.TabStop = False
        Me.txt_nombre.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(161, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "apellido"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(167, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(183, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "sala"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(173, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "fecha"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(180, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "hora"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 107)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 321)
        Me.Panel4.TabIndex = 7
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(827, 107)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(5, 321)
        Me.Panel5.TabIndex = 8
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(5, 423)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(822, 5)
        Me.Panel6.TabIndex = 9
        '
        'elejir
        '
        Me.elejir.Font = New System.Drawing.Font("Arial", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.elejir.FontMustExist = True
        '
        'ColorDialog1
        '
        Me.ColorDialog1.Color = System.Drawing.Color.White
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'timer_estado
        '
        Me.timer_estado.Interval = 6000
        '
        'cargar
        '
        Me.cargar.Image = Global.Funu.My.Resources.Resources.cargar
        Me.cargar.Location = New System.Drawing.Point(15, 115)
        Me.cargar.Name = "cargar"
        Me.cargar.Size = New System.Drawing.Size(219, 41)
        Me.cargar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cargar.TabIndex = 10
        Me.cargar.TabStop = False
        '
        'display
        '
        Me.display.BackColor = System.Drawing.Color.Black
        Me.display.Image = Global.Funu.My.Resources.Resources._968d6e4af9e2ed7a74605fa46274ce9f
        Me.display.Location = New System.Drawing.Point(260, 115)
        Me.display.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.display.Name = "display"
        Me.display.Size = New System.Drawing.Size(560, 304)
        Me.display.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.display.TabIndex = 5
        Me.display.TabStop = False
        Me.estado.SetToolTip(Me.display, "Clickea para copiar direccion")
        '
        'btn_color_fuente
        '
        Me.btn_color_fuente.Image = Global.Funu.My.Resources.Resources.color_palette
        Me.btn_color_fuente.Location = New System.Drawing.Point(168, 7)
        Me.btn_color_fuente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_color_fuente.Name = "btn_color_fuente"
        Me.btn_color_fuente.Size = New System.Drawing.Size(41, 43)
        Me.btn_color_fuente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_color_fuente.TabIndex = 3
        Me.btn_color_fuente.TabStop = False
        Me.estado.SetToolTip(Me.btn_color_fuente, "Seleccione color de la fuente")
        '
        'btn_fuente
        '
        Me.btn_fuente.Image = Global.Funu.My.Resources.Resources.size
        Me.btn_fuente.Location = New System.Drawing.Point(98, 7)
        Me.btn_fuente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_fuente.Name = "btn_fuente"
        Me.btn_fuente.Size = New System.Drawing.Size(41, 43)
        Me.btn_fuente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_fuente.TabIndex = 2
        Me.btn_fuente.TabStop = False
        Me.estado.SetToolTip(Me.btn_fuente, "Seleccione fuente")
        '
        'pedestal
        '
        Me.pedestal.Image = Global.Funu.My.Resources.Resources.pedestal
        Me.pedestal.Location = New System.Drawing.Point(786, 10)
        Me.pedestal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pedestal.Name = "pedestal"
        Me.pedestal.Size = New System.Drawing.Size(35, 35)
        Me.pedestal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pedestal.TabIndex = 1
        Me.pedestal.TabStop = False
        Me.estado.SetToolTip(Me.pedestal, "Creditos")
        '
        'btn_recurso
        '
        Me.btn_recurso.Image = Global.Funu.My.Resources.Resources.imagen
        Me.btn_recurso.Location = New System.Drawing.Point(32, 7)
        Me.btn_recurso.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_recurso.Name = "btn_recurso"
        Me.btn_recurso.Size = New System.Drawing.Size(41, 43)
        Me.btn_recurso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_recurso.TabIndex = 0
        Me.btn_recurso.TabStop = False
        Me.estado.SetToolTip(Me.btn_recurso, "Ingrese su plantilla")
        '
        'display_estado
        '
        Me.display_estado.Image = Global.Funu.My.Resources.Resources.loader
        Me.display_estado.Location = New System.Drawing.Point(0, 0)
        Me.display_estado.Name = "display_estado"
        Me.display_estado.Size = New System.Drawing.Size(52, 50)
        Me.display_estado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.display_estado.TabIndex = 2
        Me.display_estado.TabStop = False
        Me.estado.SetToolTip(Me.display_estado, "estado")
        '
        'minimizar
        '
        Me.minimizar.Image = Global.Funu.My.Resources.Resources.minimizar1
        Me.minimizar.Location = New System.Drawing.Point(745, 7)
        Me.minimizar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.minimizar.Name = "minimizar"
        Me.minimizar.Size = New System.Drawing.Size(35, 35)
        Me.minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.minimizar.TabIndex = 1
        Me.minimizar.TabStop = False
        '
        'cerrar
        '
        Me.cerrar.Image = Global.Funu.My.Resources.Resources.cerrar1
        Me.cerrar.Location = New System.Drawing.Point(786, 7)
        Me.cerrar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cerrar.Name = "cerrar"
        Me.cerrar.Size = New System.Drawing.Size(35, 35)
        Me.cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.cerrar.TabIndex = 0
        Me.cerrar.TabStop = False
        '
        'Funu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(832, 428)
        Me.Controls.Add(Me.cargar)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.display)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.barra)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Funu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Funu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.barra.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.cargar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.display, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_color_fuente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_fuente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pedestal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_recurso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.display_estado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents barra As Panel
    Friend WithEvents minimizar As PictureBox
    Friend WithEvents cerrar As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents pedestal As PictureBox
    Friend WithEvents btn_recurso As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_hora As TextBox
    Friend WithEvents txt_fecha As TextBox
    Friend WithEvents txt_sala As TextBox
    Friend WithEvents txt_apellido As TextBox
    Friend WithEvents display As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents cargar As PictureBox
    Friend WithEvents btn_color_fuente As PictureBox
    Friend WithEvents btn_fuente As PictureBox
    Friend WithEvents elejir As FontDialog
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents display_estado As PictureBox
    Friend WithEvents timer_estado As Timer
    Friend WithEvents estado As ToolTip
    Friend WithEvents RadioButtonDerecha As RadioButton
    Friend WithEvents RadioButtonIzquierda As RadioButton
    Friend WithEvents RadioButtonCentro As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
