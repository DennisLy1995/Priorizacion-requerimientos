<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Registrar_Contacto
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
        Me.RegistrarCliente = New System.Windows.Forms.Label()
        Me.Txt_correo = New System.Windows.Forms.TextBox()
        Me.Txt_numTelefono = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_nombre = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Panel1.Controls.Add(Me.RegistrarCliente)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(-32, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(768, 54)
        Me.Panel1.TabIndex = 19
        '
        'RegistrarCliente
        '
        Me.RegistrarCliente.AutoSize = True
        Me.RegistrarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegistrarCliente.Location = New System.Drawing.Point(314, 19)
        Me.RegistrarCliente.Name = "RegistrarCliente"
        Me.RegistrarCliente.Size = New System.Drawing.Size(143, 20)
        Me.RegistrarCliente.TabIndex = 0
        Me.RegistrarCliente.Text = "Registrar Contacto"
        Me.RegistrarCliente.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Txt_correo
        '
        Me.Txt_correo.BackColor = System.Drawing.Color.White
        Me.Txt_correo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_correo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Txt_correo.Location = New System.Drawing.Point(95, 268)
        Me.Txt_correo.Name = "Txt_correo"
        Me.Txt_correo.Size = New System.Drawing.Size(157, 26)
        Me.Txt_correo.TabIndex = 18
        '
        'Txt_numTelefono
        '
        Me.Txt_numTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_numTelefono.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Txt_numTelefono.Location = New System.Drawing.Point(95, 201)
        Me.Txt_numTelefono.Name = "Txt_numTelefono"
        Me.Txt_numTelefono.Size = New System.Drawing.Size(157, 26)
        Me.Txt_numTelefono.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(91, 246)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 20)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Correo Electronico"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(91, 179)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Numero de telefono"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(91, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Nombre"
        '
        'Txt_nombre
        '
        Me.Txt_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_nombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Txt_nombre.Location = New System.Drawing.Point(95, 131)
        Me.Txt_nombre.Name = "Txt_nombre"
        Me.Txt_nombre.Size = New System.Drawing.Size(157, 26)
        Me.Txt_nombre.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(267, 348)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(158, 35)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Registrar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 411)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Txt_correo)
        Me.Controls.Add(Me.Txt_numTelefono)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txt_nombre)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Registrar Contacto"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents RegistrarCliente As Label
    Friend WithEvents Txt_correo As TextBox
    Friend WithEvents Txt_numTelefono As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_nombre As TextBox
    Friend WithEvents Button1 As Button
End Class
