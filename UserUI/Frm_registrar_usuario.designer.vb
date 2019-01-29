<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_registrar_usuario
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_identificacion = New System.Windows.Forms.TextBox()
        Me.txt_correo = New System.Windows.Forms.TextBox()
        Me.Txt_nomUsuario = New System.Windows.Forms.TextBox()
        Me.Txt_nombre1 = New System.Windows.Forms.TextBox()
        Me.Txt_apellido1 = New System.Windows.Forms.TextBox()
        Me.Txt_clave = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Btn_registrar = New System.Windows.Forms.Button()
        Me.Btn_cancelar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 48)
        Me.Panel1.MaximumSize = New System.Drawing.Size(735, 64)
        Me.Panel1.MinimumSize = New System.Drawing.Size(735, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(735, 64)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(257, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registrar usuario"
        '
        'Txt_identificacion
        '
        Me.Txt_identificacion.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.Txt_identificacion.Location = New System.Drawing.Point(184, 149)
        Me.Txt_identificacion.Name = "Txt_identificacion"
        Me.Txt_identificacion.Size = New System.Drawing.Size(154, 27)
        Me.Txt_identificacion.TabIndex = 1
        '
        'txt_correo
        '
        Me.txt_correo.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.txt_correo.Location = New System.Drawing.Point(416, 149)
        Me.txt_correo.Name = "txt_correo"
        Me.txt_correo.Size = New System.Drawing.Size(154, 27)
        Me.txt_correo.TabIndex = 2
        '
        'Txt_nomUsuario
        '
        Me.Txt_nomUsuario.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.Txt_nomUsuario.Location = New System.Drawing.Point(184, 287)
        Me.Txt_nomUsuario.Name = "Txt_nomUsuario"
        Me.Txt_nomUsuario.Size = New System.Drawing.Size(154, 27)
        Me.Txt_nomUsuario.TabIndex = 3
        '
        'Txt_nombre1
        '
        Me.Txt_nombre1.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.Txt_nombre1.Location = New System.Drawing.Point(184, 218)
        Me.Txt_nombre1.Name = "Txt_nombre1"
        Me.Txt_nombre1.Size = New System.Drawing.Size(154, 27)
        Me.Txt_nombre1.TabIndex = 3
        '
        'Txt_apellido1
        '
        Me.Txt_apellido1.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.Txt_apellido1.Location = New System.Drawing.Point(416, 218)
        Me.Txt_apellido1.Name = "Txt_apellido1"
        Me.Txt_apellido1.Size = New System.Drawing.Size(154, 27)
        Me.Txt_apellido1.TabIndex = 4
        '
        'Txt_clave
        '
        Me.Txt_clave.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.Txt_clave.Location = New System.Drawing.Point(416, 287)
        Me.Txt_clave.Name = "Txt_clave"
        Me.Txt_clave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_clave.Size = New System.Drawing.Size(154, 27)
        Me.Txt_clave.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(180, 196)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Primer nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(180, 265)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nombre de usuario"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(180, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Identificación"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(412, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Correo electrónico"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(412, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 19)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Primer apellido"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(412, 265)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 19)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Clave"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(152, 338)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(449, 3)
        Me.Panel3.TabIndex = 12
        '
        'Btn_registrar
        '
        Me.Btn_registrar.ForeColor = System.Drawing.Color.Black
        Me.Btn_registrar.Location = New System.Drawing.Point(404, 360)
        Me.Btn_registrar.Name = "Btn_registrar"
        Me.Btn_registrar.Size = New System.Drawing.Size(123, 39)
        Me.Btn_registrar.TabIndex = 13
        Me.Btn_registrar.Text = "Registrarse"
        Me.Btn_registrar.UseVisualStyleBackColor = True
        '
        'Btn_cancelar
        '
        Me.Btn_cancelar.ForeColor = System.Drawing.Color.Black
        Me.Btn_cancelar.Location = New System.Drawing.Point(240, 360)
        Me.Btn_cancelar.Name = "Btn_cancelar"
        Me.Btn_cancelar.Size = New System.Drawing.Size(123, 39)
        Me.Btn_cancelar.TabIndex = 14
        Me.Btn_cancelar.Text = "Cancelar"
        Me.Btn_cancelar.UseVisualStyleBackColor = True
        '
        'Frm_registrar_usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(734, 411)
        Me.Controls.Add(Me.Btn_cancelar)
        Me.Controls.Add(Me.Btn_registrar)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txt_clave)
        Me.Controls.Add(Me.Txt_apellido1)
        Me.Controls.Add(Me.Txt_nombre1)
        Me.Controls.Add(Me.Txt_nomUsuario)
        Me.Controls.Add(Me.txt_correo)
        Me.Controls.Add(Me.Txt_identificacion)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_registrar_usuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrarse"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_identificacion As TextBox
    Friend WithEvents txt_correo As TextBox
    Friend WithEvents Txt_nomUsuario As TextBox
    Friend WithEvents Txt_nombre1 As TextBox
    Friend WithEvents Txt_apellido1 As TextBox
    Friend WithEvents Txt_clave As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Btn_registrar As Button
    Friend WithEvents Btn_cancelar As Button
End Class
