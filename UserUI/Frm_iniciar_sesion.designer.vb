<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_iniciar_sesion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Link_registrarse = New System.Windows.Forms.LinkLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_iniciar = New System.Windows.Forms.Button()
        Me.Txt_clave = New System.Windows.Forms.TextBox()
        Me.Txt_nom_usuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(734, 411)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Link_registrarse)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Btn_iniciar)
        Me.Panel2.Controls.Add(Me.Txt_clave)
        Me.Panel2.Controls.Add(Me.Txt_nom_usuario)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(159, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(417, 411)
        Me.Panel2.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(105, 250)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(200, 3)
        Me.Panel5.TabIndex = 8
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(105, 169)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(200, 3)
        Me.Panel4.TabIndex = 8
        '
        'Link_registrarse
        '
        Me.Link_registrarse.AutoSize = True
        Me.Link_registrarse.LinkColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Link_registrarse.Location = New System.Drawing.Point(66, 371)
        Me.Link_registrarse.Name = "Link_registrarse"
        Me.Link_registrarse.Size = New System.Drawing.Size(290, 19)
        Me.Link_registrarse.TabIndex = 8
        Me.Link_registrarse.TabStop = True
        Me.Link_registrarse.Text = "¿No  tienes cuenta? Registrese una aquí"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(105, 79)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 3)
        Me.Panel3.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(101, 210)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Contraseña"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(101, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nombre de usuario"
        '
        'Btn_iniciar
        '
        Me.Btn_iniciar.BackColor = System.Drawing.Color.White
        Me.Btn_iniciar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btn_iniciar.Location = New System.Drawing.Point(136, 297)
        Me.Btn_iniciar.Name = "Btn_iniciar"
        Me.Btn_iniciar.Size = New System.Drawing.Size(126, 39)
        Me.Btn_iniciar.TabIndex = 4
        Me.Btn_iniciar.Text = "Iniciar sesión"
        Me.Btn_iniciar.UseVisualStyleBackColor = False
        '
        'Txt_clave
        '
        Me.Txt_clave.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Txt_clave.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_clave.Font = New System.Drawing.Font("Roboto", 13.0!)
        Me.Txt_clave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Txt_clave.Location = New System.Drawing.Point(105, 232)
        Me.Txt_clave.Name = "Txt_clave"
        Me.Txt_clave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_clave.Size = New System.Drawing.Size(200, 21)
        Me.Txt_clave.TabIndex = 3
        '
        'Txt_nom_usuario
        '
        Me.Txt_nom_usuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Txt_nom_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_nom_usuario.Font = New System.Drawing.Font("Roboto", 13.0!)
        Me.Txt_nom_usuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Txt_nom_usuario.Location = New System.Drawing.Point(105, 151)
        Me.Txt_nom_usuario.Name = "Txt_nom_usuario"
        Me.Txt_nom_usuario.Size = New System.Drawing.Size(200, 21)
        Me.Txt_nom_usuario.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(116, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Iniciar sesión"
        '
        'Frm_iniciar_sesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(734, 411)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_iniciar_sesion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Link_registrarse As LinkLabel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Btn_iniciar As Button
    Friend WithEvents Txt_clave As TextBox
    Friend WithEvents Txt_nom_usuario As TextBox
    Friend WithEvents Label1 As Label
End Class
