<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Modificar_Caso_De_Uso
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_Codigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_Nombre = New System.Windows.Forms.TextBox()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.Txt_Descripcion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnGuardarCambiosCU = New System.Windows.Forms.Button()
        Me.BtnCancelarCambiosCU = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(735, 85)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(200, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(329, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Modificar caso de uso"
        '
        'Txt_Codigo
        '
        Me.Txt_Codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Txt_Codigo.Location = New System.Drawing.Point(150, 170)
        Me.Txt_Codigo.Multiline = True
        Me.Txt_Codigo.Name = "Txt_Codigo"
        Me.Txt_Codigo.Size = New System.Drawing.Size(154, 27)
        Me.Txt_Codigo.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Label2.Location = New System.Drawing.Point(146, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 22)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Código"
        '
        'Txt_Nombre
        '
        Me.Txt_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Txt_Nombre.Location = New System.Drawing.Point(430, 170)
        Me.Txt_Nombre.Multiline = True
        Me.Txt_Nombre.Name = "Txt_Nombre"
        Me.Txt_Nombre.Size = New System.Drawing.Size(154, 27)
        Me.Txt_Nombre.TabIndex = 6
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.LabelNombre.Location = New System.Drawing.Point(426, 145)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(73, 22)
        Me.LabelNombre.TabIndex = 7
        Me.LabelNombre.Text = "Nombre"
        '
        'Txt_Descripcion
        '
        Me.Txt_Descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Txt_Descripcion.Location = New System.Drawing.Point(150, 259)
        Me.Txt_Descripcion.Multiline = True
        Me.Txt_Descripcion.Name = "Txt_Descripcion"
        Me.Txt_Descripcion.Size = New System.Drawing.Size(434, 35)
        Me.Txt_Descripcion.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Label3.Location = New System.Drawing.Point(146, 234)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 22)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Descripción"
        '
        'BtnGuardarCambiosCU
        '
        Me.BtnGuardarCambiosCU.BackColor = System.Drawing.Color.White
        Me.BtnGuardarCambiosCU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardarCambiosCU.Location = New System.Drawing.Point(321, 315)
        Me.BtnGuardarCambiosCU.Name = "BtnGuardarCambiosCU"
        Me.BtnGuardarCambiosCU.Size = New System.Drawing.Size(109, 39)
        Me.BtnGuardarCambiosCU.TabIndex = 11
        Me.BtnGuardarCambiosCU.Text = "Guardar cambios"
        Me.BtnGuardarCambiosCU.UseVisualStyleBackColor = False
        '
        'BtnCancelarCambiosCU
        '
        Me.BtnCancelarCambiosCU.BackColor = System.Drawing.Color.White
        Me.BtnCancelarCambiosCU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelarCambiosCU.Location = New System.Drawing.Point(321, 360)
        Me.BtnCancelarCambiosCU.Name = "BtnCancelarCambiosCU"
        Me.BtnCancelarCambiosCU.Size = New System.Drawing.Size(109, 39)
        Me.BtnCancelarCambiosCU.TabIndex = 12
        Me.BtnCancelarCambiosCU.Text = "Cancelar"
        Me.BtnCancelarCambiosCU.UseVisualStyleBackColor = False
        '
        'Frm_Modificar_Caso_De_Uso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(734, 411)
        Me.Controls.Add(Me.BtnCancelarCambiosCU)
        Me.Controls.Add(Me.BtnGuardarCambiosCU)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Txt_Descripcion)
        Me.Controls.Add(Me.LabelNombre)
        Me.Controls.Add(Me.Txt_Nombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txt_Codigo)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_Modificar_Caso_De_Uso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Modificar_Caso_De_Uso"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_Codigo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_Nombre As TextBox
    Friend WithEvents LabelNombre As Label
    Friend WithEvents Txt_Descripcion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnGuardarCambiosCU As Button
    Friend WithEvents BtnCancelarCambiosCU As Button
End Class
