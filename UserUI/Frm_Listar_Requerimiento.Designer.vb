<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Listar_Requerimiento
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridRequerimientos = New System.Windows.Forms.DataGridView()
        Me.BtnAgregarRequerimiento = New System.Windows.Forms.Button()
        Me.Txt_Buscar = New System.Windows.Forms.TextBox()
        Me.Btn_Buscar = New System.Windows.Forms.Button()
        Me.LblUpdate = New System.Windows.Forms.Label()
        Me.LabelMensaje = New System.Windows.Forms.Label()
        Me.Jp_menu_lateral = New System.Windows.Forms.Panel()
        Me.Btn_cliente = New System.Windows.Forms.Panel()
        Me.img_cliente = New System.Windows.Forms.PictureBox()
        Me.Jb_cliente = New System.Windows.Forms.Label()
        Me.Btn_cu = New System.Windows.Forms.Panel()
        Me.img_cu = New System.Windows.Forms.PictureBox()
        Me.Jb_cu = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Btn_salir = New System.Windows.Forms.Panel()
        Me.img_salir = New System.Windows.Forms.PictureBox()
        Me.Jb_salir = New System.Windows.Forms.Label()
        Me.Btn_perfil = New System.Windows.Forms.Panel()
        Me.img_perfil = New System.Windows.Forms.PictureBox()
        Me.Jb_perfil = New System.Windows.Forms.Label()
        Me.Btn_req = New System.Windows.Forms.Panel()
        Me.img_req = New System.Windows.Forms.PictureBox()
        Me.Lb_req = New System.Windows.Forms.Label()
        Me.Btn_proyecto = New System.Windows.Forms.Panel()
        Me.img_pro = New System.Windows.Forms.PictureBox()
        Me.Jb_proyecto = New System.Windows.Forms.Label()
        Me.Btn_Listar = New System.Windows.Forms.Button()
        Me.ButtonPriorizar = New System.Windows.Forms.Button()
        CType(Me.DataGridRequerimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Jp_menu_lateral.SuspendLayout()
        Me.Btn_cliente.SuspendLayout()
        CType(Me.img_cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Btn_cu.SuspendLayout()
        CType(Me.img_cu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Btn_salir.SuspendLayout()
        CType(Me.img_salir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Btn_perfil.SuspendLayout()
        CType(Me.img_perfil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Btn_req.SuspendLayout()
        CType(Me.img_req, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Btn_proyecto.SuspendLayout()
        CType(Me.img_pro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.Label1.Location = New System.Drawing.Point(26, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Requerimientos"
        '
        'DataGridRequerimientos
        '
        Me.DataGridRequerimientos.AllowUserToAddRows = False
        Me.DataGridRequerimientos.AllowUserToDeleteRows = False
        Me.DataGridRequerimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridRequerimientos.Location = New System.Drawing.Point(33, 104)
        Me.DataGridRequerimientos.Name = "DataGridRequerimientos"
        Me.DataGridRequerimientos.ReadOnly = True
        Me.DataGridRequerimientos.Size = New System.Drawing.Size(509, 234)
        Me.DataGridRequerimientos.TabIndex = 1
        '
        'BtnAgregarRequerimiento
        '
        Me.BtnAgregarRequerimiento.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnAgregarRequerimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.BtnAgregarRequerimiento.Location = New System.Drawing.Point(271, 38)
        Me.BtnAgregarRequerimiento.Name = "BtnAgregarRequerimiento"
        Me.BtnAgregarRequerimiento.Size = New System.Drawing.Size(118, 31)
        Me.BtnAgregarRequerimiento.TabIndex = 2
        Me.BtnAgregarRequerimiento.Text = "+ Agregar"
        Me.BtnAgregarRequerimiento.UseVisualStyleBackColor = True
        '
        'Txt_Buscar
        '
        Me.Txt_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Txt_Buscar.Location = New System.Drawing.Point(245, 361)
        Me.Txt_Buscar.Multiline = True
        Me.Txt_Buscar.Name = "Txt_Buscar"
        Me.Txt_Buscar.Size = New System.Drawing.Size(154, 27)
        Me.Txt_Buscar.TabIndex = 5
        '
        'Btn_Buscar
        '
        Me.Btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Btn_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Btn_Buscar.Location = New System.Drawing.Point(424, 361)
        Me.Btn_Buscar.Name = "Btn_Buscar"
        Me.Btn_Buscar.Size = New System.Drawing.Size(118, 27)
        Me.Btn_Buscar.TabIndex = 6
        Me.Btn_Buscar.Text = "Buscar"
        Me.Btn_Buscar.UseVisualStyleBackColor = True
        '
        'LblUpdate
        '
        Me.LblUpdate.AutoSize = True
        Me.LblUpdate.Location = New System.Drawing.Point(253, 88)
        Me.LblUpdate.Name = "LblUpdate"
        Me.LblUpdate.Size = New System.Drawing.Size(62, 13)
        Me.LblUpdate.TabIndex = 7
        Me.LblUpdate.Text = "Cargando..."
        '
        'LabelMensaje
        '
        Me.LabelMensaje.AutoSize = True
        Me.LabelMensaje.Location = New System.Drawing.Point(13, 374)
        Me.LabelMensaje.Name = "LabelMensaje"
        Me.LabelMensaje.Size = New System.Drawing.Size(0, 13)
        Me.LabelMensaje.TabIndex = 8
        '
        'Jp_menu_lateral
        '
        Me.Jp_menu_lateral.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Jp_menu_lateral.Controls.Add(Me.Btn_cliente)
        Me.Jp_menu_lateral.Controls.Add(Me.Btn_cu)
        Me.Jp_menu_lateral.Controls.Add(Me.PictureBox1)
        Me.Jp_menu_lateral.Controls.Add(Me.Panel7)
        Me.Jp_menu_lateral.Controls.Add(Me.Btn_salir)
        Me.Jp_menu_lateral.Controls.Add(Me.Btn_perfil)
        Me.Jp_menu_lateral.Controls.Add(Me.Btn_req)
        Me.Jp_menu_lateral.Controls.Add(Me.Btn_proyecto)
        Me.Jp_menu_lateral.Location = New System.Drawing.Point(563, 0)
        Me.Jp_menu_lateral.Name = "Jp_menu_lateral"
        Me.Jp_menu_lateral.Size = New System.Drawing.Size(172, 415)
        Me.Jp_menu_lateral.TabIndex = 9
        '
        'Btn_cliente
        '
        Me.Btn_cliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Btn_cliente.Controls.Add(Me.img_cliente)
        Me.Btn_cliente.Controls.Add(Me.Jb_cliente)
        Me.Btn_cliente.Location = New System.Drawing.Point(0, 256)
        Me.Btn_cliente.Name = "Btn_cliente"
        Me.Btn_cliente.Size = New System.Drawing.Size(172, 20)
        Me.Btn_cliente.TabIndex = 3
        '
        'img_cliente
        '
        Me.img_cliente.Image = Global.Frm_Registrar_Caso_De_Uso.My.Resources.Resources.usuarios_multiples_en_silueta
        Me.img_cliente.Location = New System.Drawing.Point(24, 2)
        Me.img_cliente.Name = "img_cliente"
        Me.img_cliente.Size = New System.Drawing.Size(16, 16)
        Me.img_cliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.img_cliente.TabIndex = 1
        Me.img_cliente.TabStop = False
        '
        'Jb_cliente
        '
        Me.Jb_cliente.AutoSize = True
        Me.Jb_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Jb_cliente.ForeColor = System.Drawing.Color.White
        Me.Jb_cliente.Location = New System.Drawing.Point(46, 2)
        Me.Jb_cliente.Name = "Jb_cliente"
        Me.Jb_cliente.Size = New System.Drawing.Size(61, 18)
        Me.Jb_cliente.TabIndex = 0
        Me.Jb_cliente.Text = "Clientes"
        '
        'Btn_cu
        '
        Me.Btn_cu.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Btn_cu.Controls.Add(Me.img_cu)
        Me.Btn_cu.Controls.Add(Me.Jb_cu)
        Me.Btn_cu.Location = New System.Drawing.Point(0, 216)
        Me.Btn_cu.Name = "Btn_cu"
        Me.Btn_cu.Size = New System.Drawing.Size(172, 20)
        Me.Btn_cu.TabIndex = 2
        '
        'img_cu
        '
        Me.img_cu.Image = Global.Frm_Registrar_Caso_De_Uso.My.Resources.Resources.lista_de_tareas
        Me.img_cu.Location = New System.Drawing.Point(24, 2)
        Me.img_cu.Name = "img_cu"
        Me.img_cu.Size = New System.Drawing.Size(16, 16)
        Me.img_cu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.img_cu.TabIndex = 1
        Me.img_cu.TabStop = False
        '
        'Jb_cu
        '
        Me.Jb_cu.AutoSize = True
        Me.Jb_cu.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Jb_cu.ForeColor = System.Drawing.Color.White
        Me.Jb_cu.Location = New System.Drawing.Point(46, 2)
        Me.Jb_cu.Name = "Jb_cu"
        Me.Jb_cu.Size = New System.Drawing.Size(101, 18)
        Me.Jb_cu.TabIndex = 0
        Me.Jb_cu.Text = "Casos de uso"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(33, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 65)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Panel7.Location = New System.Drawing.Point(8, 123)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(154, 3)
        Me.Panel7.TabIndex = 4
        '
        'Btn_salir
        '
        Me.Btn_salir.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Btn_salir.Controls.Add(Me.img_salir)
        Me.Btn_salir.Controls.Add(Me.Jb_salir)
        Me.Btn_salir.Location = New System.Drawing.Point(0, 379)
        Me.Btn_salir.Name = "Btn_salir"
        Me.Btn_salir.Size = New System.Drawing.Size(172, 20)
        Me.Btn_salir.TabIndex = 5
        '
        'img_salir
        '
        Me.img_salir.Image = Global.Frm_Registrar_Caso_De_Uso.My.Resources.Resources.boton_salir_a_aplicacion
        Me.img_salir.Location = New System.Drawing.Point(24, 2)
        Me.img_salir.Name = "img_salir"
        Me.img_salir.Size = New System.Drawing.Size(16, 16)
        Me.img_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.img_salir.TabIndex = 1
        Me.img_salir.TabStop = False
        '
        'Jb_salir
        '
        Me.Jb_salir.AutoSize = True
        Me.Jb_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Jb_salir.ForeColor = System.Drawing.Color.White
        Me.Jb_salir.Location = New System.Drawing.Point(46, 2)
        Me.Jb_salir.Name = "Jb_salir"
        Me.Jb_salir.Size = New System.Drawing.Size(37, 18)
        Me.Jb_salir.TabIndex = 0
        Me.Jb_salir.Text = "Salir"
        '
        'Btn_perfil
        '
        Me.Btn_perfil.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Btn_perfil.Controls.Add(Me.img_perfil)
        Me.Btn_perfil.Controls.Add(Me.Jb_perfil)
        Me.Btn_perfil.Location = New System.Drawing.Point(0, 339)
        Me.Btn_perfil.Name = "Btn_perfil"
        Me.Btn_perfil.Size = New System.Drawing.Size(172, 20)
        Me.Btn_perfil.TabIndex = 4
        '
        'img_perfil
        '
        Me.img_perfil.Image = Global.Frm_Registrar_Caso_De_Uso.My.Resources.Resources.usuario_hombre
        Me.img_perfil.Location = New System.Drawing.Point(24, 2)
        Me.img_perfil.Name = "img_perfil"
        Me.img_perfil.Size = New System.Drawing.Size(16, 16)
        Me.img_perfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.img_perfil.TabIndex = 1
        Me.img_perfil.TabStop = False
        '
        'Jb_perfil
        '
        Me.Jb_perfil.AutoSize = True
        Me.Jb_perfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Jb_perfil.ForeColor = System.Drawing.Color.White
        Me.Jb_perfil.Location = New System.Drawing.Point(46, 2)
        Me.Jb_perfil.Name = "Jb_perfil"
        Me.Jb_perfil.Size = New System.Drawing.Size(41, 18)
        Me.Jb_perfil.TabIndex = 0
        Me.Jb_perfil.Text = "Perfil"
        '
        'Btn_req
        '
        Me.Btn_req.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Btn_req.Controls.Add(Me.img_req)
        Me.Btn_req.Controls.Add(Me.Lb_req)
        Me.Btn_req.Location = New System.Drawing.Point(0, 177)
        Me.Btn_req.Name = "Btn_req"
        Me.Btn_req.Size = New System.Drawing.Size(172, 20)
        Me.Btn_req.TabIndex = 1
        '
        'img_req
        '
        Me.img_req.Image = Global.Frm_Registrar_Caso_De_Uso.My.Resources.Resources.listado_con_puntos
        Me.img_req.Location = New System.Drawing.Point(24, 2)
        Me.img_req.Name = "img_req"
        Me.img_req.Size = New System.Drawing.Size(16, 16)
        Me.img_req.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.img_req.TabIndex = 1
        Me.img_req.TabStop = False
        '
        'Lb_req
        '
        Me.Lb_req.AutoSize = True
        Me.Lb_req.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Lb_req.ForeColor = System.Drawing.Color.White
        Me.Lb_req.Location = New System.Drawing.Point(46, 2)
        Me.Lb_req.Name = "Lb_req"
        Me.Lb_req.Size = New System.Drawing.Size(112, 18)
        Me.Lb_req.TabIndex = 0
        Me.Lb_req.Text = "Requerimientos"
        '
        'Btn_proyecto
        '
        Me.Btn_proyecto.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Btn_proyecto.Controls.Add(Me.img_pro)
        Me.Btn_proyecto.Controls.Add(Me.Jb_proyecto)
        Me.Btn_proyecto.Location = New System.Drawing.Point(0, 139)
        Me.Btn_proyecto.Name = "Btn_proyecto"
        Me.Btn_proyecto.Size = New System.Drawing.Size(172, 20)
        Me.Btn_proyecto.TabIndex = 0
        '
        'img_pro
        '
        Me.img_pro.Image = Global.Frm_Registrar_Caso_De_Uso.My.Resources.Resources.cartera
        Me.img_pro.Location = New System.Drawing.Point(24, 2)
        Me.img_pro.Name = "img_pro"
        Me.img_pro.Size = New System.Drawing.Size(16, 16)
        Me.img_pro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.img_pro.TabIndex = 1
        Me.img_pro.TabStop = False
        '
        'Jb_proyecto
        '
        Me.Jb_proyecto.AutoSize = True
        Me.Jb_proyecto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Jb_proyecto.ForeColor = System.Drawing.Color.White
        Me.Jb_proyecto.Location = New System.Drawing.Point(46, 2)
        Me.Jb_proyecto.Name = "Jb_proyecto"
        Me.Jb_proyecto.Size = New System.Drawing.Size(68, 18)
        Me.Jb_proyecto.TabIndex = 0
        Me.Jb_proyecto.Text = "Proyecto"
        '
        'Btn_Listar
        '
        Me.Btn_Listar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Btn_Listar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Btn_Listar.Location = New System.Drawing.Point(424, 360)
        Me.Btn_Listar.Name = "Btn_Listar"
        Me.Btn_Listar.Size = New System.Drawing.Size(118, 27)
        Me.Btn_Listar.TabIndex = 9
        Me.Btn_Listar.Text = "Listar"
        Me.Btn_Listar.UseVisualStyleBackColor = True
        Me.Btn_Listar.Visible = False
        '
        'ButtonPriorizar
        '
        Me.ButtonPriorizar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ButtonPriorizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.ButtonPriorizar.Location = New System.Drawing.Point(409, 38)
        Me.ButtonPriorizar.Name = "ButtonPriorizar"
        Me.ButtonPriorizar.Size = New System.Drawing.Size(118, 31)
        Me.ButtonPriorizar.TabIndex = 10
        Me.ButtonPriorizar.Text = "Priorizar"
        Me.ButtonPriorizar.UseVisualStyleBackColor = True
        '
        'Frm_Listar_Requerimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(735, 411)
        Me.Controls.Add(Me.ButtonPriorizar)
        Me.Controls.Add(Me.Jp_menu_lateral)
        Me.Controls.Add(Me.Btn_Listar)
        Me.Controls.Add(Me.LabelMensaje)
        Me.Controls.Add(Me.LblUpdate)
        Me.Controls.Add(Me.Btn_Buscar)
        Me.Controls.Add(Me.Txt_Buscar)
        Me.Controls.Add(Me.BtnAgregarRequerimiento)
        Me.Controls.Add(Me.DataGridRequerimientos)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_Listar_Requerimiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Listar_Casos_De_Uso"
        CType(Me.DataGridRequerimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Jp_menu_lateral.ResumeLayout(False)
        Me.Btn_cliente.ResumeLayout(False)
        Me.Btn_cliente.PerformLayout()
        CType(Me.img_cliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Btn_cu.ResumeLayout(False)
        Me.Btn_cu.PerformLayout()
        CType(Me.img_cu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Btn_salir.ResumeLayout(False)
        Me.Btn_salir.PerformLayout()
        CType(Me.img_salir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Btn_perfil.ResumeLayout(False)
        Me.Btn_perfil.PerformLayout()
        CType(Me.img_perfil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Btn_req.ResumeLayout(False)
        Me.Btn_req.PerformLayout()
        CType(Me.img_req, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Btn_proyecto.ResumeLayout(False)
        Me.Btn_proyecto.PerformLayout()
        CType(Me.img_pro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridRequerimientos As DataGridView
    Friend WithEvents BtnAgregarRequerimiento As Button
    Friend WithEvents Txt_Buscar As TextBox
    Friend WithEvents Btn_Buscar As Button
    Friend WithEvents LblUpdate As Label
    Friend WithEvents LabelMensaje As Label
    Friend WithEvents Jp_menu_lateral As Panel
    Friend WithEvents Btn_cliente As Panel
    Friend WithEvents img_cliente As PictureBox
    Friend WithEvents Jb_cliente As Label
    Friend WithEvents Btn_cu As Panel
    Friend WithEvents img_cu As PictureBox
    Friend WithEvents Jb_cu As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Btn_salir As Panel
    Friend WithEvents img_salir As PictureBox
    Friend WithEvents Jb_salir As Label
    Friend WithEvents Btn_perfil As Panel
    Friend WithEvents img_perfil As PictureBox
    Friend WithEvents Jb_perfil As Label
    Friend WithEvents Btn_req As Panel
    Friend WithEvents img_req As PictureBox
    Friend WithEvents Lb_req As Label
    Friend WithEvents Btn_proyecto As Panel
    Friend WithEvents img_pro As PictureBox
    Friend WithEvents Jb_proyecto As Label
    Friend WithEvents Btn_Listar As Button
    Friend WithEvents ButtonPriorizar As Button
End Class
